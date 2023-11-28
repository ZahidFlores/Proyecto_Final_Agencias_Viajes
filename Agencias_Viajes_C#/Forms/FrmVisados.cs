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
    public partial class FrmVisados : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmVisados(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmVisados_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdVisado.Text = IDConsecu();
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Visado,Tipo_Visado,Requisitos,Precio,Pais_Emision,u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Cliente from VISADOS v, USUARIO u\r\nwhere v.Fk_Id_Usuario = u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVisados.DataSource = dataTable;
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
            string query = "select Id_Visado from VISADOS";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Visado"].ToString();
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
            txtIdVisado.Text = IDConsecu();
            txtTipoVisado.Text = "";
            txtRequisitos.Text = "";
            txtPrecio.Text = "";
            txtPaisEmision.Text = "";
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

        private void dgvVisados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVisados.Rows[e.RowIndex];
                txtIdVisado.Text = row.Cells["Id_Visado"].Value.ToString();
                txtTipoVisado.Text = row.Cells["Tipo_Visado"].Value.ToString();
                txtRequisitos.Text = row.Cells["Requisitos"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtPaisEmision.Text = row.Cells["Pais_Emision"].Value.ToString();
                txtIdCliente.Text = row.Cells["Fk_Id_Cliente"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int precio;
            precio = int.Parse(txtPrecio.Text);
            SqlCommand cmd = new SqlCommand("sp_agregar_visado", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Visado", IDConsecu());
            cmd.Parameters.AddWithValue("@Tipo_Visado", txtTipoVisado.Text);
            cmd.Parameters.AddWithValue("@Requisitos", txtRequisitos.Text);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Pais_Emision", txtPaisEmision.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Visado agregado correctamente");
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
            int precio, idvisado,idcliente;
            precio = int.Parse(txtPrecio.Text);
            idvisado=int.Parse(txtIdVisado.Text);
            idcliente=int.Parse(txtIdCliente.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_visado", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Visado", idvisado);
            cmd.Parameters.AddWithValue("@Tipo_Visado", txtTipoVisado.Text);
            cmd.Parameters.AddWithValue("@Requisitos", txtRequisitos.Text);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Pais_Emision", txtPaisEmision.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", idcliente);
            try
            {
                MessageBox.Show("Visado actualizado correctamente");
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
            int idvisado;
            idvisado = int.Parse(txtIdVisado.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_visado", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Visado", idvisado);
            try
            {
                MessageBox.Show("Visado eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Visados.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
