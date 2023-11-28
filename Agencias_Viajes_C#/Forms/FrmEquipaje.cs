using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencias_Viajes_C_.Forms
{
    public partial class FrmEquipaje : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmEquipaje(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmEquipaje_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdequipaje.Text = IDConsecu();
        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Equipaje,Tipo_Equipaje,Peso,u.Nombre_Usuario as Edicion_Tabla, Fk_Id_Cliente from EQUIPAJE e, USUARIO u\r\nwhere e.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvEquipaje.DataSource = dataTable;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAgencia frmAgencia = new FrmAgencia(usuario);
            frmAgencia.Show();
        }
        private string IDConsecu()
        {
            conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Id_Equipaje from EQUIPAJE";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Equipaje"].ToString();
            }
            nex = int.Parse(a);
            nex = nex + 1;
            a = nex.ToString();
            sqlread.Close();
            cmd.Dispose();
            conectar.Close();
            return a;
        }
        public void limpiar()
        {
            txtIdequipaje.Text = IDConsecu();
            txtTipoequipaje.Text = "";
            txtpeso.Text = "";
            txtIdCliente.Text = "";
            CargarGrid();
        }
        private int IdUsuario()
        {
            conectar.Close();
            conectar.Open();
            string query = "select Id_Usuario from USUARIO where Nombre_Usuario=@usuario";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            object resultado = cmd.ExecuteScalar();
            int id;
            id = Convert.ToInt32(resultado);
            return id;
        }

        private void dgvEquipaje_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEquipaje.Rows[e.RowIndex];
                txtIdequipaje.Text = row.Cells["Id_Equipaje"].Value.ToString();
                txtTipoequipaje.Text = row.Cells["Tipo_Equipaje"].Value.ToString();
                txtpeso.Text = row.Cells["Peso"].Value.ToString();
                txtIdCliente.Text = row.Cells["Fk_Id_Cliente"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_equipaje", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Equipaje", IDConsecu());
            cmd.Parameters.AddWithValue("@Tipo_Equipaje", txtTipoequipaje.Text);
            cmd.Parameters.AddWithValue("@Peso", txtpeso.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Equipaje agregado correctamente");
                modificartabla();
                conectar.Close();
                conectar.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            conectar.Close();
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_actualizar_equipaje", conectar);
            int idequipaje;
            idequipaje=int.Parse(txtIdequipaje.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Equipaje", idequipaje);
            cmd.Parameters.AddWithValue("@Tipo_Equipaje", txtTipoequipaje.Text);
            cmd.Parameters.AddWithValue("@Peso", txtpeso.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Equipaje actualizado correctamente");
                modificartabla();
                conectar.Close();
                conectar.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            conectar.Close();
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_eliminar_equipaje", conectar);
            int idequipaje;
            idequipaje = int.Parse(txtIdequipaje.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Equipaje", idequipaje);
            try
            {
                MessageBox.Show("Equipaje eliminado correctamente");
                modificartabla();
                conectar.Close();
                conectar.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            conectar.Close();
            limpiar();
        }
        public void modificartabla()
        {
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Equipaje.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
