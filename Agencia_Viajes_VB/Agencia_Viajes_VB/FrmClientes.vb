Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmClientes
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Dim frmAgencia As New FrmAgencia(usuario)
        frmAgencia.ShowDialog()
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        txtusuario.Text = usuario
        txtIdCliente.Text = IDConsecu()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM CLIENTE;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvClientes.DataSource = ds.Tables("tabla")
        conectar.Close()
    End Sub

    Private Function IDConsecu() As String
        conectar.Close()
        Dim a As String
        Dim nex As Integer
        conectar.Open()
        Dim query As String = "select Id_Cliente from CLIENTE;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Cliente")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdCliente.Text = IDConsecu()
        txtNombre.Text = ""
        txtApPaterno.Text = ""
        txtApMaterno.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        CargarGrid()
    End Sub

    Private Function IdUsuario() As Integer
        conectar.Close()
        conectar.Open()
        Dim query As String = "select Id_Usuario from USUARIO where Nombre_Usuario=@usuario;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text)
        Dim resultado As Object = cmd.ExecuteScalar()
        Dim id As Integer
        id = Convert.ToInt32(resultado)
        Return id
    End Function

    Private Sub dgvClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
            txtIdCliente.Text = row.Cells("Id_Cliente").Value.ToString()
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtApPaterno.Text = row.Cells("ApPaterno").Value.ToString()
            txtApMaterno.Text = row.Cells("ApMaterno").Value.ToString()
            txtDireccion.Text = row.Cells("Direccion").Value.ToString()
            txtCorreo.Text = row.Cells("Correo").Value.ToString()
            txtTelefono.Text = row.Cells("Telefono").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_cliente", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Cliente", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@p_ApPaterno", txtApPaterno.Text)
                cmd.Parameters.AddWithValue("@p_ApMaterno", txtApMaterno.Text)
                cmd.Parameters.AddWithValue("@p_Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@p_Correo", txtCorreo.Text)
                cmd.Parameters.AddWithValue("@p_Telefono", txtTelefono.Text)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())

                Try
                    MessageBox.Show("Cliente agregado correctamente")
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


    'pendiente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim idcliente As Integer
        idcliente = Integer.Parse(txtIdCliente.Text)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_cliente", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Cliente", idcliente)
                cmd.Parameters.AddWithValue("@p_Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@p_ApPaterno", txtApPaterno.Text)
                cmd.Parameters.AddWithValue("@p_ApMaterno", txtApMaterno.Text)
                cmd.Parameters.AddWithValue("@p_Direccion", txtDireccion.Text)
                cmd.Parameters.AddWithValue("@p_Correo", txtCorreo.Text)
                cmd.Parameters.AddWithValue("@p_Telefono", txtTelefono.Text)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                Try
                    MessageBox.Show("Cliente actualizado cliente")
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
            MessageBox.Show("Error al actualizar cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cliente As Integer
                cliente = Integer.Parse(txtIdCliente.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_cliente", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Cliente", cliente)

                Try
                    MessageBox.Show("Cliente eliminado correctamente")
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
            MessageBox.Show("Error al eliminar cliente: " & ex.Message)
        End Try

    End Sub

    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Clientes.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub

End Class