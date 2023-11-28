Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmPromociones
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub
    Private Sub FrmPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarGrid()
        txtUsuario.Text = usuario
        txtIdPromocion.Text = IDConsecu()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM PROMOCIONES;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvPromociones.DataSource = ds.Tables("tabla")
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
        Dim query As String = "select Id_Promo from PROMOCIONES;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Promo")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdPromocion.Text = IDConsecu()
        txtNombreprom.Text = ""
        txtdescripcion.Text = ""
        txtPorcentaje.Text = ""
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

    Private Sub dgvPromociones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromociones.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPromociones.Rows(e.RowIndex)
            txtIdPromocion.Text = row.Cells("Id_Promo").Value.ToString()
            txtNombreprom.Text = row.Cells("Nombre").Value.ToString()
            txtdescripcion.Text = row.Cells("Descripcion").Value.ToString()
            txtPorcentaje.Text = row.Cells("Porcentaje").Value.ToString()
            txtIdViaje.Text = row.Cells("Id_Viaje").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim porc, iddestino As Integer
        'iddestino = Integer.Parse(txtIdDestino.Text)
        porc = Integer.Parse(txtPorcentaje.Text)
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_promo", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Promo", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombreprom.Text)
                cmd.Parameters.AddWithValue("@p_Descripcion", txtdescripcion.Text)
                cmd.Parameters.AddWithValue("@p_Porcentaje", porc)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", txtIdViaje.Text)

                Try
                    MessageBox.Show("Promo agregada correctamente")
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
        Dim idviaje, promo As Integer
        promo = Integer.Parse(txtIdPromocion.Text)
        idviaje = Integer.Parse(txtIdViaje.Text)
        Dim porc As Decimal
        Decimal.TryParse(txtPorcentaje.Text, porc)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_promo", conectar)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@p_Id_Promo", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombreprom.Text)
                cmd.Parameters.AddWithValue("@p_Descripcion", txtdescripcion.Text)
                cmd.Parameters.AddWithValue("@p_Porcentaje", porc)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Viaje", idviaje)

                Try
                    MessageBox.Show("Promo actualizado correctamente")
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
            MessageBox.Show("Error al actualizar Promo: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim promo As Integer
                promo = Integer.Parse(txtIdPromocion.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_promo", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Promo", promo)

                Try
                    MessageBox.Show("promo eliminada correctamente")
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
            MessageBox.Show("Error al eliminar promo: " & ex.Message)
        End Try
    End Sub

    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Promociones.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub
End Class