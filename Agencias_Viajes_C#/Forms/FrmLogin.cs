using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string server = "Data Source = LAPTOP-HAO3D8QC\\SQLEXPRESS; Initial Catalog= BD_Agencia_Viajes; Integrated Security = True ";
        SqlConnection conectar = new SqlConnection();
        string usuario;
        private void btnAgregarUs_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarUsuario = new FrmAgregarUsuario();
            this.Hide();
            agregarUsuario.Show();
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la contraseña en un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string password = txtContrasenia.Text;
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "select Contrasena from USUARIO where Nombre_Usuario=@usuario";
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            object resultado = cmd.ExecuteScalar();
            string hashedpassword = HashPassword(password);
            bool soniguales = string.Equals(resultado, hashedpassword);
            if (soniguales)
            {
                usuario = txtUsuario.Text;
                MessageBox.Show("Login exitoso");
                FrmAgencia formag = new FrmAgencia(usuario);
                formag.Show();
                this.Hide();
                conectar.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
            conectar.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
