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
    public partial class FrmHoteles : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmHoteles(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdHotel.Text = IDConsecu();
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Hotel,Nombre,Tipo_Habitacion,Precio_Noche,u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Destino from HOTEL h, USUARIO u\r\nwhere h.Fk_Id_Usuario =u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvHoteles.DataSource = dataTable;
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
            string query = "select Id_Hotel from HOTEL";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Hotel"].ToString();
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
            txtIdHotel.Text = IDConsecu();
            txtNombreHotel.Text = "";
            txtTipohabitacion.Text = "";
            txtPrecioNoche.Text = "";
            txtIdViaje.Text = "";
            CargarGrid();
        }

        private void dgvHoteles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoteles.Rows[e.RowIndex];
                txtIdHotel.Text = row.Cells["Id_Hotel"].Value.ToString();
                txtNombreHotel.Text = row.Cells["Nombre"].Value.ToString();
                txtTipohabitacion.Text = row.Cells["Tipo_Habitacion"].Value.ToString();
                txtPrecioNoche.Text = row.Cells["Precio_Noche"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Destino"].Value.ToString();
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_hotel", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Hotel", IDConsecu());
            cmd.Parameters.AddWithValue("@Nombre", txtNombreHotel.Text);
            cmd.Parameters.AddWithValue("@Tipo_Habitacion", txtTipohabitacion.Text);
            cmd.Parameters.AddWithValue("@Precio_Noche", txtPrecioNoche.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Destino", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Hotel agregado correctamente");
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
            int idhotel, idviaje;
            idhotel=int.Parse(txtIdHotel.Text);
            idviaje=int.Parse(txtIdViaje.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_hotel", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Hotel", idhotel);
            cmd.Parameters.AddWithValue("@Nombre", txtNombreHotel.Text);
            cmd.Parameters.AddWithValue("@Tipo_Habitacion", txtTipohabitacion.Text);
            cmd.Parameters.AddWithValue("@Precio_Noche", txtPrecioNoche.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Destino", idviaje);
            try
            {
                MessageBox.Show("Hotel actualizado correctamente");
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
            int idhotel;
            idhotel = int.Parse(txtIdHotel.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_hotel", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Hotel", idhotel);
            try
            {
                MessageBox.Show("Hotel eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Hoteles.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
