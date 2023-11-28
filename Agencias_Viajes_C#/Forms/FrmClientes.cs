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
    public partial class FrmClientes : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmClientes(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAgencia frmAgencia = new FrmAgencia(usuario);
            frmAgencia.ShowDialog();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
            txtusuario.Text = usuario;
            txtIdCliente.Text = IDConsecu();
        }
        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Cliente as Numero_Cliente, Nombre, ApPaterno as Apellido_Paterno, ApMaterno as Apellido_Materno, Direccion, Correo,Telefono,p.Nombre_Usuario as Edicion_Tabla from CLIENTE c, USUARIO p where c.Fk_Id_Usuario= p.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvClientes.DataSource = dataTable;
            }
        }
        private int IdUsuario()
        {
            conectar.Close();
            conectar.Open();
            string query = "select Id_Usuario from USUARIO where Nombre_Usuario=@usuario";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
            object resultado = cmd.ExecuteScalar();
            int id;
            id = Convert.ToInt32(resultado);
            return id;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && txtApPaterno.Text.Length > 0 && txtApMaterno.Text.Length > 0)
            {
                conectar.Close();
                conectar.ConnectionString = server;
                conectar.Open();
                SqlCommand cmd = new SqlCommand("sp_agregar_cliente", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cliente", IDConsecu());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@ApPaterno", txtApPaterno.Text);
                cmd.Parameters.AddWithValue("@ApMaterno", txtApMaterno.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
                try
                {
                    MessageBox.Show("Cliente agregado correctamente");
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
            else
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
        }
        private string IDConsecu()
        {
            conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Id_Cliente from CLIENTE";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Cliente"].ToString();
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
            txtIdCliente.Text = IDConsecu();
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
           
            CargarGrid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int cliente;
            cliente=int.Parse(txtIdCliente.Text);
            SqlCommand cmd = new SqlCommand("sp_actualizar_cliente", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", cliente);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@ApPaterno", txtApPaterno.Text);
            cmd.Parameters.AddWithValue("@ApMaterno", txtApMaterno.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
            try
            {
                MessageBox.Show("Cliente actualizado correctamente");
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

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                txtIdCliente.Text = row.Cells["Numero_Cliente"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApPaterno.Text = row.Cells["Apellido_Paterno"].Value.ToString();
                txtApMaterno.Text = row.Cells["Apellido_Materno"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int cliente;

            cliente = int.Parse(txtIdCliente.Text);
            SqlCommand cmd1 = new SqlCommand("sp_eliminar_cliente", conectar);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Id_Cliente", cliente);
            try
            {
                MessageBox.Show("Cliente eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Clientes.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}
