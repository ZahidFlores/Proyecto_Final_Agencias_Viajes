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
    public partial class FrmOpiniones : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmOpiniones(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmOpiniones_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdcomentario.Text = IDConsecu();
        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Comentario,Comentario,Calificacion, u.Nombre_Usuario as Edicion_Tabla,Fk_Id_Viaje,Fk_Id_Cliente from OPINIONES o, USUARIO u\r\nwhere o.Fk_Id_Usuario = u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvOpiniones.DataSource = dataTable;
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
            string query = "select Id_Comentario from OPINIONES";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Comentario"].ToString();
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
            txtIdcomentario.Text = IDConsecu();
            txtComentario.Text = "";
            txtCalificacion.Text = "";
            txtIdViaje.Text = "";
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

        private void dgvOpiniones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOpiniones.Rows[e.RowIndex];
                txtIdcomentario.Text = row.Cells["Id_Comentario"].Value.ToString();
                txtComentario.Text = row.Cells["Comentario"].Value.ToString();
                txtCalificacion.Text = row.Cells["Calificacion"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Viaje"].Value.ToString();
                txtIdCliente.Text = row.Cells["Fk_Id_Cliente"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_opinion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Comentario", IDConsecu());
            cmd.Parameters.AddWithValue("@Comentario", txtComentario.Text);
            cmd.Parameters.AddWithValue("@Calificacion", txtCalificacion.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario()); 
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", txtIdViaje.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Opinion agregada correctamente");
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
            int idcomentario, idviaje, idcliente;
            idcomentario = int.Parse(txtIdcomentario.Text);
            idviaje = int.Parse(txtIdViaje.Text);
            idcliente=int.Parse(txtIdCliente.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_opinion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Comentario", idcomentario);
            cmd.Parameters.AddWithValue("@Comentario", txtComentario.Text);
            cmd.Parameters.AddWithValue("@Calificacion", txtCalificacion.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", idviaje);
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", idcliente);
            try
            {
                MessageBox.Show("Opinion actualizada correctamente");
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
            int idcomentario;
            idcomentario = int.Parse(txtIdcomentario.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_opinion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Comentario", idcomentario);
            try
            {
                MessageBox.Show("Opinion eliminada correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\\\Tabla Opiniones.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
