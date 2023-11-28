Imports MySql.Data.MySqlClient

Public Class FrmFacturas
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
        frmAgencia.Show()
    End Sub

    Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CargarGrid()
    '    txtUsuario.Text = usuario
    '    txtNumFactura.Text = IDConsecu()
    'End Sub


End Class