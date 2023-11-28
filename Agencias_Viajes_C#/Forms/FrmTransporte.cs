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
    public partial class FrmTransporte : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmTransporte(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmTransporte_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdTransporte.Text = IDConsecu();
        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Transporte,Compania,Tipo_Transporte,Precio_Boleto,u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Viaje from TRANSPORTE t, USUARIO u\r\nwhere t.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTransporte.DataSource = dataTable;
            }
        }
        private string IDConsecu()
        {
            conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Id_Transporte from TRANSPORTE";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Transporte"].ToString();
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
            txtIdTransporte.Text = IDConsecu();
            txtCompania.Text = "";
            txtIdViaje.Text = "";
            txtPrecioBoleto.Text = "";
            txtTipoTransporte.Text = "";
            CargarGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAgencia frmAgencia = new FrmAgencia(usuario);
            frmAgencia.Show();
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
   
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_transporte", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Transporte", IDConsecu());
            cmd.Parameters.AddWithValue("@Compania", txtCompania.Text);
            cmd.Parameters.AddWithValue("@Tipo_Transporte", txtTipoTransporte.Text);
            cmd.Parameters.AddWithValue("@Precio_Boleto", txtPrecioBoleto.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Transporte agregado correctamente");
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
            int idtransporte, idviaje;
            idtransporte = int.Parse(txtIdTransporte.Text);
            idviaje = int.Parse(txtIdViaje.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_transporte", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Transporte", idtransporte);
            cmd.Parameters.AddWithValue("@Compania", txtCompania.Text);
            cmd.Parameters.AddWithValue("@Tipo_Transporte", txtTipoTransporte.Text);
            cmd.Parameters.AddWithValue("@Precio_Boleto", txtPrecioBoleto.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", idviaje);
            try
            {
                MessageBox.Show("Transporte actualizado correctamente");
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
            int idTransporte;
            idTransporte = int.Parse(txtIdTransporte.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_transporte", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Transporte", idTransporte);
            try
            {
                MessageBox.Show("Transporte eliminado correctamente");
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
            string rutaArchivo = " C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Transporte.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
        private void dgvTransporte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransporte.Rows[e.RowIndex];
                txtIdTransporte.Text = row.Cells["Id_Transporte"].Value.ToString();
                txtCompania.Text = row.Cells["Compania"].Value.ToString();
                txtTipoTransporte.Text = row.Cells["Tipo_Transporte"].Value.ToString();
                txtPrecioBoleto.Text = row.Cells["Precio_Boleto"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Viaje"].Value.ToString();
            }
        }
    }
}
