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
    public partial class FrmSeguros_Viaje : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmSeguros_Viaje(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
        }

        private void FrmSeguros_Viaje_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdSeguro.Text =IDConsecu();
        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Seguro,Tipo_Seguro,Cobertura,Precio,u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Viaje from SEGUROS_VIAJE s, USUARIO u\r\nwhere s.Fk_Id_Usuario = u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSeguros.DataSource = dataTable;
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
            string query = "select Id_Seguro from SEGUROS_VIAJE";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Seguro"].ToString();
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
            txtIdSeguro.Text = IDConsecu();
            txtTiposeguro.Text = "";
            txtCobertura.Text = "";
            txtPrecio.Text = "";
            txtIdViaje.Text = "";
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

        private void dgvSeguros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSeguros.Rows[e.RowIndex];
                txtIdSeguro.Text = row.Cells["Id_Seguro"].Value.ToString();
                txtTiposeguro.Text = row.Cells["Tipo_Seguro"].Value.ToString();
                txtCobertura.Text = row.Cells["Cobertura"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Viaje"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int precio;
            precio=int.Parse(txtPrecio.Text);
            SqlCommand cmd = new SqlCommand("sp_agregar_seguros", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Seguro", IDConsecu());
            cmd.Parameters.AddWithValue("@Tipo_Seguro", txtTiposeguro.Text);
            cmd.Parameters.AddWithValue("@Cobertura", txtCobertura.Text);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Seguro de viaje agregado correctamente");
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
            int precio,idseguro,idviaje;
            idseguro=int.Parse(txtIdSeguro.Text);
            idviaje=int.Parse(txtIdViaje.Text);
            precio = int.Parse(txtPrecio.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_seguro", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Seguro", idseguro);
            cmd.Parameters.AddWithValue("@Tipo_Seguro", txtTiposeguro.Text);
            cmd.Parameters.AddWithValue("@Cobertura", txtCobertura.Text);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", idviaje);
            try
            {
                MessageBox.Show("Seguro de viaje actualizado correctamente");
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
            int idseguro;
            idseguro = int.Parse(txtIdSeguro.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_seguro", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Seguro", idseguro);
            try
            {
                MessageBox.Show("Seguro de viaje eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Seguros de Viaje.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
