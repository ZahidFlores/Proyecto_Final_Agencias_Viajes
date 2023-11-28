Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FrmAgregarUsuario
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)

    Private Function Consecu() As String
        conectar.Close()
        Dim a As String
        Dim nex As Integer
        conectar.Open()
        Dim query As String = "select ID_Usuario from Usuario;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Usuario".ToString())
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()
        conectar.Close()

        Return a
    End Function

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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If txtUsuario.Text.Length > 0 AndAlso txtContrasenia.Text.Length > 0 Then
            Dim password As String = txtContrasenia.Text
            Dim hashedpassword As String = HashPassword(password)
            Try
                Using conectar As New MySqlConnection(server)
                    conectar.Open()
                    Dim cmd As New MySqlCommand("sp_agregar_usuario", conectar)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@p_Id_Usuario", Consecu())
                    cmd.Parameters.AddWithValue("@p_Nombre_Usuario", txtUsuario.Text)
                    cmd.Parameters.AddWithValue("@p_Contrasena", hashedpassword)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Usuario agregado correctamente")
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try
            Me.Close()
            Dim frmLogin As New FrmLogin()
            frmLogin.Show()
        Else
            MessageBox.Show("Favor de llenar todos los campos")
        End If
    End Sub
End Class