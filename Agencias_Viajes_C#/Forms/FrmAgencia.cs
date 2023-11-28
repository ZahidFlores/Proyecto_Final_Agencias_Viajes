using Agencias_Viajes_C_.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agencias_Viajes_C_
{
    public partial class FrmAgencia : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        public FrmAgencia(string usuario)
        {
            InitializeComponent();
            this.usuario=usuario;
        }

        private void FrmAgencia_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuario;
            CargarGrid();
            txtId.Text = IDViajeConsecu();
        }
        private string IDViajeConsecu()
        {
            conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Id_Viaje from VIAJE";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Viaje"].ToString();
            }
            nex = int.Parse(a);
            nex = nex + 1;
            a = nex.ToString();
            sqlread.Close();
            cmd.Dispose();
            conectar.Close();
            return a;
        }

        private int IdUsuario()
        {
            conectar.Close ();
            conectar.Open();
            string query = "select Id_Usuario from USUARIO where Nombre_Usuario=@usuario";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            object resultado=cmd.ExecuteScalar();
            int id;
            id = Convert.ToInt32(resultado);
            return id;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrid()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                string query = "select Id_Viaje,Fecha_Regreso,Fecha_Regreso,Precio,Descripcion,Cupos_disp,u.Nombre_Usuario as Edicion_Tabla from VIAJE v,USUARIO u\r\nwhere v.Fk_Id_Usuario=u.Id_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvViajes.DataSource = dataTable;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmClientes frmClientes = new FrmClientes(usuario);
            frmClientes.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReservas frmReservas = new FrmReservas(usuario);
            frmReservas.Show();
        }

        private void btnPaqueteviaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaquete_Viaje frmPaquete_Viaje=new FrmPaquete_Viaje(usuario);
            frmPaquete_Viaje.Show();
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDestinos frmDestinos = new FrmDestinos(usuario);
            frmDestinos.Show();

        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransporte frmtransporte = new FrmTransporte(usuario);
            frmtransporte.Show();

        }

        private void btnSeguros_Click(object sender, EventArgs e)
        {   
            this.Hide();
            FrmSeguros_Viaje frmSeg = new FrmSeguros_Viaje(usuario);
            frmSeg.Show();
        }

        private void btnOpiniones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOpiniones frmOpiniones = new FrmOpiniones(usuario);
            frmOpiniones.Show();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPromociones frmProm = new FrmPromociones(usuario);
            frmProm.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAgenda frmAgenda = new FrmAgenda(usuario);
            frmAgenda.Show();
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHoteles frmHoteles = new FrmHoteles(usuario);
            frmHoteles.Show();
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEquipaje frmEquipaje = new FrmEquipaje(usuario);
            frmEquipaje.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFacturas frmFacturas = new FrmFacturas(usuario);
            frmFacturas.Show();
        }

        private void btnGuias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGuias frmGuias = new FrmGuias(usuario);
            frmGuias.Show();
        }

        private void btnDocViaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDocViaje frmDocViaje = new FrmDocViaje(usuario);
            frmDocViaje.Show();
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmActividad frmActividad = new FrmActividad(usuario);
            frmActividad.Show();
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTarjetas frmTarjetas = new FrmTarjetas(usuario);
            frmTarjetas.Show();
        }

        private void btnVehicAlquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVehiculoAlquiler frmVehiculoAlquiler = new FrmVehiculoAlquiler(usuario);
            frmVehiculoAlquiler.Show();
        }

        private void btnVisados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVisados frmVisados = new FrmVisados(usuario);
            frmVisados.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cupos, precio;
            cupos= int.Parse(txtCupos.Text);
            precio = int.Parse(txtPrecio.Text);
            if (txtDescripcion.Text.Length>0 && txtCupos.Text.Length>0 && txtPrecio.Text.Length>0)
            {
                conectar.Close();
                conectar.ConnectionString = server;
                conectar.Open();
                SqlCommand cmd = new SqlCommand("sp_agregar_viaje", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Viaje", IDViajeConsecu());
                cmd.Parameters.AddWithValue("@Fecha_Salida", dtpFechaSalida.Value);
                cmd.Parameters.AddWithValue("@Fecha_Regreso", dtpFechaRegreso.Value);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Cupos_disp", cupos);
                cmd.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
                try
                {
                    MessageBox.Show("Viaje agregado correctamente");
                    modificartabla();
                    conectar.Close() ;
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

        public void limpiar()
        {
            txtId.Text=IDViajeConsecu();
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCupos.Text = "";
            CargarGrid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int cupos, precio,viaje;
            cupos = int.Parse(txtCupos.Text);
            precio = int.Parse(txtPrecio.Text);
            viaje = int.Parse(txtId.Text);
            SqlCommand cmd1 = new SqlCommand("sp_actualizar_viaje", conectar);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Id_Viaje", viaje);
            cmd1.Parameters.AddWithValue("@Fecha_Salida", dtpFechaSalida.Value);
            cmd1.Parameters.AddWithValue("@Fecha_Regreso", dtpFechaRegreso.Value);
            cmd1.Parameters.AddWithValue("@Precio", precio);
            cmd1.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            cmd1.Parameters.AddWithValue("@Cupos_disp", cupos);
            cmd1.Parameters.AddWithValue("@FK_Id_Usuario", IdUsuario());
            try
            {
                MessageBox.Show("Viaje Actualizado correctamente");
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


        private void dgvViajes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvViajes.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Viaje"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtCupos.Text = row.Cells["Cupos_disp"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conectar.Close();
            conectar.ConnectionString = server;
            conectar.Open();
            int viaje;
   
            viaje = int.Parse(txtId.Text);
            SqlCommand cmd1 = new SqlCommand("sp_eliminar_viaje", conectar);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Id_Viaje", viaje);
            try
            {
                MessageBox.Show("Viaje eliminado correctamente");
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
            string rutaArchivo = "C:\\Users\\pauli\\source\\repos\\Agencias_Viajes_C#\\Agencias_Viajes_C#\\bin\\Debug\\Tabla Viajes.txt";
            string contenido = "Tabla modificada por " + usuario + " a las " + DateTime.Now;
            using (StreamWriter escritor = File.AppendText(rutaArchivo))
            {

                escritor.WriteLine(contenido);
            }
        }
    }
}

