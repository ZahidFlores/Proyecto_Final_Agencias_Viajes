Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmSeguros_Viaje
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub FrmSeguros_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        txtUsuario.Text = usuario
        txtIdSeguro.Text = IDConsecu()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM SEGUROS_VIAJE;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvSeguros.DataSource = ds.Tables("tabla")
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
        Dim query As String = "select Id_Seguro from SEGUROS_VIAJE;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Seguro")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdSeguro.Text = IDConsecu()
        txtTiposeguro.Text = ""
        txtCobertura.Text = ""
        txtPrecio.Text = ""
        txtIdViaje.Text = ""
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

    Private Sub dgvSeguros_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSeguros.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSeguros.Rows(e.RowIndex)
            txtIdSeguro.Text = row.Cells("Id_Seguro").Value.ToString()
            txtTiposeguro.Text = row.Cells("Tipo_Seguro").Value.ToString()
            txtCobertura.Text = row.Cells("Cobertura").Value.ToString()
            txtPrecio.Text = row.Cells("Precio").Value.ToString()
            txtIdViaje.Text = row.Cells("Id_Viaje").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim precio, iddestino As Integer
        'iddestino = Integer.Parse(txtIdDestino.Text)
        precio = Integer.Parse(txtPrecio.Text)
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_seguro", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Seguro", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Tipo_Seguro", txtTiposeguro.Text)
                cmd.Parameters.AddWithValue("@p_Cobertura", txtCobertura.Text)
                cmd.Parameters.AddWithValue("@p_Precio", precio)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", txtIdViaje.Text)

                Try
                    MessageBox.Show("Seguro agregada correctamente")
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
        Dim idviaje, s As Integer
        s = Integer.Parse(txtIdSeguro.Text)
        idviaje = Integer.Parse(txtIdViaje.Text)
        Dim precio As Decimal
        Decimal.TryParse(txtPrecio.Text, precio)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_seguro", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Seguro", s)
                cmd.Parameters.AddWithValue("@p_Tipo_Seguro", txtTiposeguro.Text)
                cmd.Parameters.AddWithValue("@p_Cobertura", txtCobertura.Text)
                cmd.Parameters.AddWithValue("@p_Precio", precio)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", idviaje)

                Try
                    MessageBox.Show("seguro actualizado correctamente")
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
            MessageBox.Show("Error al actualizar seguro: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim s As Integer
                s = Integer.Parse(txtIdSeguro.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_seguro", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Seguro", s)

                Try
                    MessageBox.Show("seguro eliminada correctamente")
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
            MessageBox.Show("Error al eliminar seguro: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Seguros de Viaje.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub
End Class