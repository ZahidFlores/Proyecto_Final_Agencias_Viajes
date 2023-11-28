Imports MySql.Data.MySqlClient

Public Class FrmTarjetas
    Dim server As String = "Server=localhost; user=root; password=soporte; Database=bd_agencia_viajes;"
    Dim conectar As MySqlConnection = New MySqlConnection(server)
    Dim usuario As String

    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub

    Private Sub FrmTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class