<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHoteles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvHoteles = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdDestino = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtIdHotel = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvHoteles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(123, 302)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 83
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(17, 107)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 82
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(615, 302)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 81
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(522, 302)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 80
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(428, 302)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 79
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvHoteles
        '
        Me.dgvHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoteles.Location = New System.Drawing.Point(123, 56)
        Me.dgvHoteles.Name = "dgvHoteles"
        Me.dgvHoteles.Size = New System.Drawing.Size(567, 221)
        Me.dgvHoteles.TabIndex = 78
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(696, 56)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 77
        '
        'txtIdDestino
        '
        Me.txtIdDestino.Location = New System.Drawing.Point(17, 257)
        Me.txtIdDestino.Name = "txtIdDestino"
        Me.txtIdDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDestino.TabIndex = 76
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(17, 210)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 75
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(17, 157)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 74
        '
        'txtIdHotel
        '
        Me.txtIdHotel.Location = New System.Drawing.Point(17, 56)
        Me.txtIdHotel.Name = "txtIdHotel"
        Me.txtIdHotel.Size = New System.Drawing.Size(100, 20)
        Me.txtIdHotel.TabIndex = 73
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 241)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(70, 13)
        Me.label6.TabIndex = 72
        Me.label6.Text = "Id del destino"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(16, 194)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(88, 13)
        Me.label5.TabIndex = 71
        Me.label5.Text = "Precio por noche"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(715, 39)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 70
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 141)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(95, 13)
        Me.label3.TabIndex = 69
        Me.label3.Text = "Tipo de habitacion"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 13)
        Me.label2.TabIndex = 68
        Me.label2.Text = "Nombre del hotel"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(59, 13)
        Me.label1.TabIndex = 67
        Me.label1.Text = "Id del hotel"
        '
        'FrmHoteles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvHoteles)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIdDestino)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtIdHotel)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmHoteles"
        Me.Text = "FrmHoteles"
        CType(Me.dgvHoteles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents txtNombre As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvHoteles As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtIdDestino As TextBox
    Private WithEvents txtPrecio As TextBox
    Private WithEvents txtTipo As TextBox
    Private WithEvents txtIdHotel As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
