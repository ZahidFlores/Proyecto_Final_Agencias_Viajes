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
    public partial class FrmTarjetas : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmTarjetas(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmTarjetas_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Num_Tarjeta,Fecha_Vencimiento,Tipo_Cuenta,Tipo_Tarjeta, u.Nombre_Usuario as Edicion_Tabla, Fk_Id_Cliente from TARJETAS t, USUARIO u\r\nwhere t.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTarjetas.DataSource = dataTable;
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
            string query = "select Num_Tarjeta from TARJETAS";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Num_Tarjeta"].ToString();
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
            txtNumTarjeta.Text = "";
            txtTipoCuenta.Text = "";
            txtTipoTarjeta.Text = "";
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

        private void dgvTarjetas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTarjetas.Rows[e.RowIndex];
                txtNumTarjeta.Text = row.Cells["Num_Tarjeta"].Value.ToString();
                txtTipoCuenta.Text = row.Cells["Tipo_Cuenta"].Value.ToString();
                txtTipoTarjeta.Text = row.Cells["Tipo_Tarjeta"].Value.ToString();
                txtIdCliente.Text = row.Cells["Fk_Id_Cliente"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_tarjeta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Tarjeta", txtNumTarjeta.Text);
            cmd.Parameters.AddWithValue("@Fecha_Vencimiento", dtpVencimiento.Value);
            cmd.Parameters.AddWithValue("@Tipo_Cuenta", txtTipoCuenta.Text);
            cmd.Parameters.AddWithValue("@Tipo_Tarjeta", txtTipoTarjeta.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Tarjeta agregada correctamente");
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
            SqlCommand cmd = new SqlCommand("sp_actualizar_tarjeta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Tarjeta", txtNumTarjeta.Text);
            cmd.Parameters.AddWithValue("@Fecha_Vencimiento", dtpVencimiento.Value);
            cmd.Parameters.AddWithValue("@Tipo_Cuenta", txtTipoCuenta.Text);
            cmd.Parameters.AddWithValue("@Tipo_Tarjeta", txtTipoTarjeta.Text);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Cliente", txtIdCliente.Text);
            try
            {
                MessageBox.Show("Tarjeta actualizada correctamente");
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
            SqlCommand cmd = new SqlCommand("sp_eliminar_tarjeta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Tarjeta", txtNumTarjeta.Text);
            try
            {
                MessageBox.Show("Tarjeta eliminada correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Tarjetas.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
