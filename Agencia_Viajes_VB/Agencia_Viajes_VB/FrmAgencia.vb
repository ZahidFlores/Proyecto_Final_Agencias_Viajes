Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmAgencia
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub
    Private Sub FrmAgencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = usuario
        CargarGrid()
        txtId.Text = IDViajeConsecu()
        MessageBox.Show(IdUsuario().ToString())
    End Sub

    Private Function IDViajeConsecu() As String
        conectar.Close()
        Dim a As String
        Dim nex As Integer
        conectar.Open()
        Dim query As String = "select Id_Viaje from VIAJE;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Viaje")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

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


    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM VIAJE;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvViajes.DataSource = ds.Tables("tabla")
        conectar.Close()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        Dim FrmLogin As New FrmLogin()
        FrmLogin.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Me.Close()
        Dim frmCliente As New FrmClientes(usuario)
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnReserva_Click(sender As Object, e As EventArgs) Handles btnReserva.Click
        Me.Close()
        Dim frmReserva As New FrmReservas(usuario)
        frmReserva.ShowDialog()
    End Sub

    Private Sub btnPaqueteviaje_Click(sender As Object, e As EventArgs) Handles btnPaqueteviaje.Click
        Me.Close()
        Dim frmPaquete As New FrmPaquete_Viaje(usuario)
        frmPaquete.ShowDialog()
    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click
        Me.Close()
        Dim frmDestino As New FrmDestinos(usuario)
        frmDestino.ShowDialog()
    End Sub

    Private Sub btnTransporte_Click(sender As Object, e As EventArgs) Handles btnTransporte.Click
        Me.Close()
        Dim frmTransporte As New FrmTransporte(usuario)
        frmTransporte.ShowDialog()
    End Sub

    Private Sub btnSeguros_Click(sender As Object, e As EventArgs) Handles btnSeguros.Click
        Me.Close()
        Dim frmSeguros As New FrmSeguros_Viaje(usuario)
        frmSeguros.ShowDialog()
    End Sub

    Private Sub btnPromociones_Click(sender As Object, e As EventArgs) Handles btnPromociones.Click
        Me.Close()
        Dim frmPromociones As New FrmPromociones(usuario)
        frmPromociones.ShowDialog()
    End Sub

    Private Sub btnOpiniones_Click(sender As Object, e As EventArgs) Handles btnOpiniones.Click
        Me.Close()
        Dim frmOpiniones As New FrmOpiniones(usuario)
        frmOpiniones.ShowDialog()
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click
        Me.Close()
        Dim frmAgenda As New FrmAgenda(usuario)
        frmAgenda.ShowDialog()
    End Sub

    Private Sub btnHoteles_Click(sender As Object, e As EventArgs) Handles btnHoteles.Click
        Me.Close()
        Dim frmHoteles As New FrmHoteles(usuario)
        frmHoteles.ShowDialog()
    End Sub

    Private Sub btnGuias_Click(sender As Object, e As EventArgs) Handles btnGuias.Click
        Me.Close()
        Dim frmGuias As New FrmGuias(usuario)
        frmGuias.ShowDialog()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        Dim frmFacturas As New FrmFacturas(usuario)
        frmFacturas.ShowDialog()
    End Sub

    Private Sub btnEquipaje_Click(sender As Object, e As EventArgs) Handles btnEquipaje.Click
        Me.Close()
        Dim frmEquipaje As New FrmEquipaje(usuario)
        frmEquipaje.ShowDialog()
    End Sub

    Private Sub btnDocViaje_Click(sender As Object, e As EventArgs) Handles btnDocViaje.Click
        Me.Close()
        Dim frmDocViaje As New FrmDocViaje(usuario)
        frmDocViaje.ShowDialog()
    End Sub

    Private Sub btnVisados_Click(sender As Object, e As EventArgs) Handles btnVisados.Click
        Me.Close()
        Dim frmVisados As New FrmVisados(usuario)
        frmVisados.ShowDialog()
    End Sub

    Private Sub btnVehicAlquiler_Click(sender As Object, e As EventArgs) Handles btnVehicAlquiler.Click
        Me.Close()
        Dim frmVehiculo As New FrmVehiculo_Alquiler(usuario)
        frmVehiculo.ShowDialog()
    End Sub

    Private Sub btnTarjetas_Click(sender As Object, e As EventArgs) Handles btnTarjetas.Click
        Me.Close()
        Dim frmTarjetas As New FrmTarjetas(usuario)
        frmTarjetas.ShowDialog()
    End Sub

    Private Sub btnActividad_Click(sender As Object, e As EventArgs) Handles btnActividad.Click
        Me.Close()
        Dim frmActividad As New FrmActividad(usuario)
        frmActividad.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cupos, precio As Integer
        cupos = Integer.Parse(txtCupos.Text)
        precio = Integer.Parse(txtPrecio.Text)

        If txtDescripcion.Text.Length > 0 AndAlso txtCupos.Text.Length > 0 AndAlso txtPrecio.Text.Length > 0 Then
            Try
                Using conectar As New MySqlConnection(server)
                    conectar.Open()

                    Dim cmd As New MySqlCommand("sp_agregar_viaje", conectar)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@p_Id_Viaje", IDViajeConsecu())
                    cmd.Parameters.AddWithValue("@p_Fecha_Salida", dtpFechaSalida.Value)
                    cmd.Parameters.AddWithValue("@p_Fecha_Regreso", dtpFechaRegreso.Value)
                    cmd.Parameters.AddWithValue("@p_Precio", precio)
                    cmd.Parameters.AddWithValue("@p_Descripcion", txtDescripcion.Text)
                    cmd.Parameters.AddWithValue("@p_Cupos_disp", cupos)
                    cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())

                    Try
                        MessageBox.Show("Viaje agregado correctamente")
                        conectar.Close()
                        conectar.Open()
                        cmd.ExecuteNonQuery()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.ToString())
                        Throw
                    End Try

                    conectar.Close()
                    limpiar()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Favor de llenar todos los campos")
        End If
    End Sub

    Public Sub Limpiar()
        txtId.Text = IDViajeConsecu()
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtCupos.Text = ""
        CargarGrid()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cupos, viaje As Integer
        cupos = Integer.Parse(txtCupos.Text)
        Dim precio As Decimal
        Decimal.TryParse(txtPrecio.Text, precio)
        viaje = Integer.Parse(txtId.Text)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_viaje", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Viaje", viaje)
                cmd.Parameters.AddWithValue("@p_Fecha_Salida", dtpFechaSalida.Value)
                cmd.Parameters.AddWithValue("@p_Fecha_Regreso", dtpFechaRegreso.Value)
                cmd.Parameters.AddWithValue("@p_Precio", precio)
                cmd.Parameters.AddWithValue("p_Descripcion", txtDescripcion.Text)
                cmd.Parameters.AddWithValue("@p_Cupos_disp", cupos)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())

                Try
                    MessageBox.Show("Viaje actualizado correctamente")
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
            MessageBox.Show("Error al actualizar el viaje: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvViajes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViajes.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvViajes.Rows(e.RowIndex)
            txtId.Text = row.Cells("Id_Viaje").Value.ToString()
            txtPrecio.Text = row.Cells("Precio").Value.ToString()
            txtDescripcion.Text = row.Cells("Descripcion").Value.ToString()
            txtCupos.Text = row.Cells("Cupos_disp").Value.ToString()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim viaje As Integer
                viaje = Integer.Parse(txtId.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_viaje", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Viaje", viaje)

                Try
                    MessageBox.Show("Viaje eliminado correctamente")
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
            MessageBox.Show("Error al eliminar el viaje: " & ex.Message)
        End Try
    End Sub
End Class
