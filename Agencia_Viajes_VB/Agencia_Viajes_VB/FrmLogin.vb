Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Private Sub btnAgregarUs_Click(sender As Object, e As EventArgs) Handles btnAgregarUs.Click
        Dim agregarUsuario As New FrmAgregarUsuario()
        agregarUsuario.Show()
        'Me.Close()
    End Sub

    Public Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim password As String = txtContrasenia.Text


        conectar.ConnectionString = server
        conectar.Open()
        Dim query As String = "SELECT Contrasena FROM USUARIO WHERE Nombre_Usuario=@usuario;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        Dim resultado As Object = cmd.ExecuteScalar()
        Dim hashedpassword As String = HashPassword(password)
        Dim sonIguales As Boolean = String.Equals(resultado, hashedpassword)

        If sonIguales Then
            usuario = txtUsuario.Text
            MessageBox.Show("Login exitoso")
            Dim formAg As New FrmAgencia(usuario)
            formAg.Show()
            Me.Hide()
            conectar.Close()
        Else
            MessageBox.Show("Usuario o Contraseña incorrectos")
        End If
        
        conectar.Close()


    End Sub


End Class
