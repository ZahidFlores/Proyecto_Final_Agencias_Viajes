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
    public partial class FrmPromociones : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmPromociones(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void FrmPromociones_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtUsuario.Text = usuario;
            txtIdPromocion.Text = IDConsecu();
        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Promo,Nombre,Descripcion,Porcentaje,Fecha_Vigencia,u.Nombre_Usuario as Edicion_Tabla, Fk_Id_Viaje from PROMOCIONES p, USUARIO u\r\nwhere p.Fk_Id_Usuario = u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvPromociones.DataSource = dataTable;
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
            string query = "select Id_Promo from PROMOCIONES";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Promo"].ToString();
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
            txtIdPromocion.Text = IDConsecu();
            txtNombreprom.Text = "";
            txtdescripcion.Text = "";
            txtPorcentaje.Text = "";
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

        private void dgvPromociones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPromociones.Rows[e.RowIndex];
                txtIdPromocion.Text = row.Cells["Id_Promo"].Value.ToString();
                txtNombreprom.Text = row.Cells["Nombre"].Value.ToString();
                txtdescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPorcentaje.Text = row.Cells["Porcentaje"].Value.ToString();
                txtIdViaje.Text = row.Cells["Fk_Id_Viaje"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_agregar_promocion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Promo", IDConsecu());
            cmd.Parameters.AddWithValue("@Nombre", txtNombreprom.Text);
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
            cmd.Parameters.AddWithValue("@Porcentaje", txtPorcentaje.Text);
            cmd.Parameters.AddWithValue("@Fecha_Vigencia", dtpVencimiento.Value);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Promocion agregada correctamente");
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
            int idpromo;
            idpromo=int.Parse(txtIdPromocion.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_promocion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Promo", idpromo);
            cmd.Parameters.AddWithValue("@Nombre", txtNombreprom.Text);
            cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
            cmd.Parameters.AddWithValue("@Porcentaje", txtPorcentaje.Text);
            cmd.Parameters.AddWithValue("@Fecha_Vigencia", dtpVencimiento.Value);
            cmd.Parameters.AddWithValue("@Fk_Id_Usuario", IdUsuario());
            cmd.Parameters.AddWithValue("@Fk_Id_Viaje", txtIdViaje.Text);
            try
            {
                MessageBox.Show("Promocion actualizada correctamente");
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
            int idpromo;
            idpromo = int.Parse(txtIdPromocion.Text);
            SqlCommand cmd = new SqlCommand("sp_eliminar_promocion", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Promo", idpromo);
            try
            {
                MessageBox.Show("Promocion eliminada correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Promociones.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
