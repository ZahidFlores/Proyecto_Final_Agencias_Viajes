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
    public partial class FrmGuias : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmGuias(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmGuias_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdGuia.Text = IDConsecu();
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Guia,Nombre,Idiomas,u.Nombre_Usuario as Edicion_Tabla, Fk_Id_Destino from GUIAS_TURISTICOS g, USUARIO u where g.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvGuias.DataSource = dataTable;
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
            string query = "select Id_Guia from GUIAS_TURISTICOS";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Guia"].ToString();
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
            txtIdGuia.Text = IDConsecu();
            txtNombre.Text = "";
            txtidiomas.Text = "";
            txtIdDestino.Text = "";
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

        private void dgvGuias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGuias.Rows[e.RowIndex];
                txtIdGuia.Text = row.Cells["Id_Guia"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtidiomas.Text = row.Cells["Idiomas"].Value.ToString();
                txtIdDestino.Text = row.Cells["Fk_Id_Destino"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_guia", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Guia", IDConsecu());
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Idiomas", txtidiomas.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Destino", txtIdDestino.Text);
            try
            {
                MessageBox.Show("Guia turistico agregado correctamente");
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
            int idguia, iddestino;
            idguia = int.Parse(txtIdGuia.Text);
            iddestino=int.Parse(txtIdDestino.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_guia", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Guia", idguia);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Idiomas", txtidiomas.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Destino", iddestino);
            try
            {
                MessageBox.Show("Guia turistico actualizado correctamente");
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
            int idguia;
            idguia = int.Parse(txtIdGuia.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_guia", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Guia", idguia);
            try
            {
                MessageBox.Show("Guia turistico eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Guias.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
