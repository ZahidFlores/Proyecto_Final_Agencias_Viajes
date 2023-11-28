Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class FrmOpiniones
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub FrmOpiniones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        txtUsuario.Text = usuario
        txtIdcomentario.Text = IDConsecu()
    End Sub
    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM OPINIONES;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvOpiniones.DataSource = ds.Tables("tabla")
        conectar.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Dim frmAgencia As New FrmAgencia(usuario)
        frmAgencia.Show()
    End Sub


    Private Function IDConsecu() As String
        conectar.Close()
        Dim a As String
        Dim nex As Integer
        conectar.Open()
        Dim query As String = "select Id_Comentario from OPINIONES;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Comentario")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdcomentario.Text = IDConsecu()
        txtComentario.Text = ""
        txtCalificacion.Text = ""
        txtIdViaje.Text = ""
        txtIdCliente.Text = ""
        CargarGrid()
    End Sub

    Private Function IdUsuario() As Integer
        conectar.Close()
        conectar.Open()
        Dim query As String = "select Id_Usuario from USUARIO where Nombre_Usuario=@usuario;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        Dim resultado As Object = cmd.ExecuteScalar()
        Dim id As Integer
        id = Convert.ToInt32(resultado)
        Return id
    End Function

    Private Sub dgvOpiniones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOpiniones.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvOpiniones.Rows(e.RowIndex)
            txtIdcomentario.Text = row.Cells("Id_Comentario").Value.ToString()
            txtComentario.Text = row.Cells("Comentario").Value.ToString()
            txtCalificacion.Text = Row.Cells("Calificacion").Value.ToString()
            txtIdViaje.Text = row.Cells("Id_Viaje").Value.ToString()
            txtIdCliente.Text = row.Cells("Id_Cliente").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim calif, iddestino As Integer
        'iddestino = Integer.Parse(txtIdDestino.Text)
        calif = Integer.Parse(txtCalificacion.Text)
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_opinion", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Comentario", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Comentario", txtComentario.Text)
                cmd.Parameters.AddWithValue("@p_Calificacion", calif)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", txtIdViaje.Text)
                cmd.Parameters.AddWithValue("@p_Id_Cliente", txtIdCliente.Text)


                Try
                    MessageBox.Show("Comentario agregado correctamente")
                    ModificarTabla()
                    conectar.Close()
                    conectar.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As MySqlException
                    MessageBox.Show(ex.ToString())
                    Throw
                End Try

                conectar.Close()
                Limpiar()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim idviaje, opinion, idcliente, calif As Integer
        idviaje = Integer.Parse(txtIdViaje.Text)
        idcliente = Integer.Parse(txtIdViaje.Text)
        calif = Integer.Parse(txtCalificacion.Text)
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_opinion", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Comentario", opinion)
                cmd.Parameters.AddWithValue("@p_Comentario", txtComentario.Text)
                cmd.Parameters.AddWithValue("@p_Calificacion", calif)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", idviaje)
                cmd.Parameters.AddWithValue("@p_Id_Cliente", idcliente)
                Try
                    MessageBox.Show("Comentario actualizada correctamente")
                    ModificarTabla()
                    conectar.Close()
                    conectar.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As MySqlException
                    MessageBox.Show(ex.ToString())
                    Throw
                End Try
            End Using

            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar Comentario: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim coment As Integer
                coment = Integer.Parse(txtIdcomentario.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_opinion", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Comentario", coment)

                Try
                    MessageBox.Show("comentario eliminada correctamente")
                    ModificarTabla()
                    conectar.Close()
                    conectar.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As MySqlException
                    MessageBox.Show(ex.ToString())
                    Throw
                End Try

                Limpiar()

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar comentario: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Opiniones.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub
End Class
