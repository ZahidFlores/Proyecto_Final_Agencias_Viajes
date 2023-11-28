Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmEquipaje
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub FrmEquipaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        txtUsuario.Text = usuario
        txtIdequipaje.Text = IDConsecu()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim query As String = "SELECT * FROM EQUIPAJE;"
        Dim sqladap As New MySqlDataAdapter(query, conectar)
        ds.Tables.Add("tabla")
        sqladap.Fill(ds.Tables("tabla"))
        dgvEquipaje.DataSource = ds.Tables("tabla")
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
        Dim query As String = "select Id_Equipaje from EQUIPAJE;"
        Dim cmd As New MySqlCommand(query, conectar)
        cmd.ExecuteNonQuery()
        Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
        While sqlread.Read()
            a = sqlread("Id_Equipaje")
        End While
        nex = CInt(a)
        nex = nex + 1
        a = nex.ToString
        sqlread.Close()
        cmd.Dispose()

        Return a
    End Function

    Public Sub Limpiar()
        txtIdequipaje.Text = IDConsecu()
        txtTipoequipaje.Text = ""
        txtpeso.Text = ""
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

    Private Sub dgvEquipaje_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipaje.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEquipaje.Rows(e.RowIndex)
            txtIdequipaje.Text = row.Cells("Id_Equipaje").Value.ToString()
            txtTipoequipaje.Text = row.Cells("Tipo_Equipaje").Value.ToString()
            txtpeso.Text = row.Cells("Peso").Value.ToString()
            txtIdCliente.Text = row.Cells("Id_Cliente").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_agregar_equipaje", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Equipaje", IDConsecu())
                cmd.Parameters.AddWithValue("@p_Tipo_Equipaje", txtTipoequipaje.Text)
                cmd.Parameters.AddWithValue("@p_Peso", txtpeso.Text)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Cliente", txtIdCliente.Text)

                Try
                    MessageBox.Show("Equipaje agregado correctamente")
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
        Dim idcliente, equipaje As Integer
        equipaje = Integer.Parse(txtIdequipaje.Text)
        idcliente = Integer.Parse(txtIdequipaje.Text)

        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim cmd As New MySqlCommand("sp_actualizar_equipaje", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Equipaje", equipaje)
                cmd.Parameters.AddWithValue("@p_Tipo_Equipaje", txtTipoequipaje.Text)
                cmd.Parameters.AddWithValue("@p_Peso", txtpeso.Text)
                cmd.Parameters.AddWithValue("@p_Id_Usuario", IdUsuario())
                cmd.Parameters.AddWithValue("@p_Id_Cliente", idcliente)
                Try
                    MessageBox.Show("equipaje actualizado correctamente")
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
            MessageBox.Show("Error al actualizar equipaje: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Using conectar As New MySqlConnection(server)
                conectar.Open()

                Dim equipaje As Integer
                equipaje = Integer.Parse(txtIdequipaje.Text)

                Dim cmd As New MySqlCommand("sp_eliminar_equipaje", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_Id_Equipaje", equipaje)

                Try
                    MessageBox.Show("Equipaje eliminada correctamente")
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
            MessageBox.Show("Error al eliminar equipaje: " & ex.Message)
        End Try
    End Sub
    Public Sub ModificarTabla()
        Dim rutaArchivo As String = "C:\Users\pauli\source\repos\Agencia_Viajes_VB\Agencia_Viajes_VB\bin\Debug\Tabla Equipaje.txt"
        Dim contenido As String = "Tabla modificada por " & usuario & " a las " & DateTime.Now.ToString()
        Using escritor As StreamWriter = File.AppendText(rutaArchivo)
            escritor.WriteLine(contenido)
        End Using
    End Sub
End Class