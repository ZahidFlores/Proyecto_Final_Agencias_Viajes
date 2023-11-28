<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarjetas
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
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvTarjetas = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtTipoTarjeta = New System.Windows.Forms.TextBox()
        Me.txtTipoCuenta = New System.Windows.Forms.TextBox()
        Me.txtNumTarjeta = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(121, 311)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 131
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(15, 117)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpVencimiento.TabIndex = 130
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(613, 311)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 129
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(520, 311)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 128
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(426, 311)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 127
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvTarjetas
        '
        Me.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarjetas.Location = New System.Drawing.Point(121, 65)
        Me.dgvTarjetas.Name = "dgvTarjetas"
        Me.dgvTarjetas.Size = New System.Drawing.Size(567, 221)
        Me.dgvTarjetas.TabIndex = 126
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(694, 65)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 125
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(15, 266)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 124
        '
        'txtTipoTarjeta
        '
        Me.txtTipoTarjeta.Location = New System.Drawing.Point(15, 219)
        Me.txtTipoTarjeta.Name = "txtTipoTarjeta"
        Me.txtTipoTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoTarjeta.TabIndex = 123
        '
        'txtTipoCuenta
        '
        Me.txtTipoCuenta.Location = New System.Drawing.Point(15, 166)
        Me.txtTipoCuenta.Name = "txtTipoCuenta"
        Me.txtTipoCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoCuenta.TabIndex = 122
        '
        'txtNumTarjeta
        '
        Me.txtNumTarjeta.Location = New System.Drawing.Point(15, 65)
        Me.txtNumTarjeta.Name = "txtNumTarjeta"
        Me.txtNumTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumTarjeta.TabIndex = 121
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(14, 250)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 13)
        Me.label6.TabIndex = 120
        Me.label6.Text = "Id del cliente"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(14, 203)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 13)
        Me.label5.TabIndex = 119
        Me.label5.Text = "Tipo de tarjeta"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(713, 48)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 118
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 150)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 13)
        Me.label3.TabIndex = 117
        Me.label3.Text = "Tipo de cuenta"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(113, 13)
        Me.label2.TabIndex = 116
        Me.label2.Text = "Fecha de Vencimiento"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 13)
        Me.label1.TabIndex = 115
        Me.label1.Text = "Numero de tarjeta"
        '
        'FrmTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 385)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dtpVencimiento)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvTarjetas)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtTipoTarjeta)
        Me.Controls.Add(Me.txtTipoCuenta)
        Me.Controls.Add(Me.txtNumTarjeta)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmTarjetas"
        Me.Text = "FrmTarjetas"
        CType(Me.dgvTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents dtpVencimiento As DateTimePicker
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvTarjetas As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtIdCliente As TextBox
    Private WithEvents txtTipoTarjeta As TextBox
    Private WithEvents txtTipoCuenta As TextBox
    Private WithEvents txtNumTarjeta As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
