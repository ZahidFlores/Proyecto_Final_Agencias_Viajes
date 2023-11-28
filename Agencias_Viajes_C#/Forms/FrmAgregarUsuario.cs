using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencias_Viajes_C_
{
    public partial class FrmAgregarUsuario : Form
    {
        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private string Consecu()
        {
           conectar.Close();
            string a = "";
            int nex;
            conectar.ConnectionString=server; 
            conectar.Open();
            string query = "select ID_Usuario from Usuario";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlread = cmd.ExecuteReader();
            while (sqlread.Read())
            {
                a = sqlread["Id_Usuario"].ToString();
            }
            nex = int.Parse(a);
            nex=nex+1;
            a = nex.ToString();
            sqlread.Close();
            cmd.Dispose();
            conectar.Close();
            return a;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length>0 && txtContrasenia.Text.Length>0)
            {
                string password = txtContrasenia.Text;
                string hashedpassword = HashPassword(password);
                conectar.ConnectionString = server;
                conectar.Open();
                SqlCommand cmd = new SqlCommand("Agregarusuario", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Usuario", Consecu());
                cmd.Parameters.AddWithValue("@Nombre_Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Contrasena", hashedpassword.ToString());
                try
                {
                    MessageBox.Show("Usuario agregado correctamente");
                    conectar.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                conectar.Close();
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
           
        }
    }
}
