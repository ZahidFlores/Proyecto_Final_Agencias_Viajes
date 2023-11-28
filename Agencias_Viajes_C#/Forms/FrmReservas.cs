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
    public partial class FrmReservas : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmReservas(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private string IDConsecu()
        {
            conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Id_Reserva from RESERVA";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Reserva"].ToString();
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
            txtIdCliente.Text = "";
            txtIdViaje.Text = "";
            txtEstado.Text = "";
            txtIdReserva.Text =IDConsecu();
            CargarGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAgencia frmAgencia = new FrmAgencia(usuario);
            frmAgencia.ShowDialog();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdReserva.Text=IDConsecu();
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Reserva,Fecha_Reserva,Estado,u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Cliente,Fk_Id_Viaje from RESERVA r,USUARIO u\r\nwhere r.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvReservas.DataSource = dataTable;
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
            SqlCommand cmd = new SqlCommand("sp_agregar_reserva", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Reserva", IDConsecu());
            cmd.Parameters.AddWithValue("@Fecha_Reserva",dtpFechaReserva.Value );
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            cmd.Parameters.AddWithValue("@FK_Id_Viaje", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Reserva agregada correctamente");
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
            int idcliente, idviaje, idreserva;
            idreserva = int.Parse(txtIdReserva.Text);
            idcliente=int.Parse(txtIdCliente.Text);
            idviaje=int.Parse(txtIdViaje.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_reserva", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Reserva", idreserva);
            cmd.Parameters.AddWithValue("@Fecha_Reserva", dtpFechaReserva.Value);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", idcliente);
            cmd.Parameters.AddWithValue("@FK_Id_Viaje", idviaje);
            try
            {
                MessageBox.Show("Reserva agregada correctamente");
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

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                txtIdReserva.Text = row.Cells["Id_Reserva"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
                txtIdCliente.Text = row.Cells["Fk_Id_Cliente"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Viaje"].Value.ToString();
            
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int reserva;

            reserva = int.Parse(txtIdReserva.Text);
            SqlCommand cmd1 = new SqlCommand("sp_eliminar_reserva", conectar);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Id_Reserva", reserva);
            try
            {
                MessageBox.Show("Reservacion eliminado correctamente");
                modificartabla();
                conectar.Close();
                conectar.Open();
                cmd1.ExecuteNonQuery();
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Reservas.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
