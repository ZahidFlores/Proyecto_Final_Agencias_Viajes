Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmActividad
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub FrmActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarGrid()
        txtUsuario.Text = usuario
        txtIdActividad.Text = IDConsecu()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM ACTIVIDAD;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvActividad.DataSource = ds.Tables("tabla")
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
        Dim query As String = "select Id_Actividad from ACTIVIDAD;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Actividad")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdActividad.Text = IDConsecu()
        txtDescripcion.Text = ""
        txtIdDestino.Text = ""
        txtNombreact.Text = ""
        txtPrecio.text = ""
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

    Private Sub dgvActividad_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActividad.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvActividad.Rows(e.RowIndex)
            txtIdActividad.Text = row.Cells("Id_Actividad").Value.ToString()
            txtDescripcion.Text = row.Cells("Descripcion").Value.ToString()
            txtPrecio.Text = row.Cells("Precio").Value.ToString()
            txtIdDestino.Text = row.Cells("Id_Destino").Value.ToString()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim precio, iddestino As Integer
        'iddestino = Integer.Parse(txtIdDestino.Text)
        precio = Integer.Parse(txtPrecio.Text)
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_actividad", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Actividad", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombreact.Text)
                cmd.Parameters.AddWithValue("@p_Descripcion", txtDescripcion.Text)
                cmd.Parameters.AddWithValue("@p_Precio", precio)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Destino", txtIdDestino.Text)

                Try
                    MessageBox.Show("Actividad agregada correctamente")
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
        Dim iddestino, actividad As Integer
        actividad = Integer.Parse(txtIdActividad.Text)
        iddestino = Integer.Parse(txtIdDestino.Text)
        Dim precio As Decimal
        Decimal.TryParse(txtPrecio.Text, precio)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_actividad", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Actividad", actividad)
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombreact.Text)
                cmd.Parameters.AddWithValue("@p_Descripcion", txtDescripcion.Text)
                cmd.Parameters.AddWithValue("@p_Precio", precio)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Destino", iddestino)

                Try
                    MessageBox.Show("Actividad actualizado correctamente")
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
            MessageBox.Show("Error al actualizar actividad: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim actividad As Integer
                actividad = Integer.Parse(txtIdActividad.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_actividad", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Actividad", actividad)

                Try
                    MessageBox.Show("Actividad eliminada correctamente")
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
            MessageBox.Show("Error al eliminar actividad: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Actividades.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub
End Class