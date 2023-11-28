<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocViaje
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
        Me.dtpEmision = New System.Windows.Forms.DateTimePicker()
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDocViajes = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdcliente = New System.Windows.Forms.TextBox()
        Me.txtIdDocumento = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDocViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(121, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 133
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(14, 212)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(101, 20)
        Me.dtpVencimiento.TabIndex = 132
        '
        'dtpEmision
        '
        Me.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmision.Location = New System.Drawing.Point(15, 159)
        Me.dtpEmision.Name = "dtpEmision"
        Me.dtpEmision.Size = New System.Drawing.Size(101, 20)
        Me.dtpEmision.TabIndex = 131
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(15, 109)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDocumento.TabIndex = 130
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(613, 304)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 129
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(520, 304)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 128
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(426, 304)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 127
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDocViajes
        '
        Me.dgvDocViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocViajes.Location = New System.Drawing.Point(121, 58)
        Me.dgvDocViajes.Name = "dgvDocViajes"
        Me.dgvDocViajes.Size = New System.Drawing.Size(567, 221)
        Me.dgvDocViajes.TabIndex = 126
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(694, 58)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 125
        '
        'txtIdcliente
        '
        Me.txtIdcliente.Location = New System.Drawing.Point(15, 259)
        Me.txtIdcliente.Name = "txtIdcliente"
        Me.txtIdcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdcliente.TabIndex = 124
        '
        'txtIdDocumento
        '
        Me.txtIdDocumento.Location = New System.Drawing.Point(15, 58)
        Me.txtIdDocumento.Name = "txtIdDocumento"
        Me.txtIdDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDocumento.TabIndex = 123
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(14, 243)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 13)
        Me.label6.TabIndex = 122
        Me.label6.Text = "Id del cliente"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(11, 196)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(113, 13)
        Me.label5.TabIndex = 121
        Me.label5.Text = "Fecha de Vencimiento"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(713, 41)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 120
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 143)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(91, 13)
        Me.label3.TabIndex = 119
        Me.label3.Text = "Fecha de Emision"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 13)
        Me.label2.TabIndex = 118
        Me.label2.Text = "Tipo de documento"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 13)
        Me.label1.TabIndex = 117
        Me.label1.Text = "Numero del documento"
        '
        'FrmDocViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 382)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dtpVencimiento)
        Me.Controls.Add(Me.dtpEmision)
        Me.Controls.Add(Me.txtTipoDocumento)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvDocViajes)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIdcliente)
        Me.Controls.Add(Me.txtIdDocumento)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmDocViaje"
        Me.Text = "FrmDocViaje"
        CType(Me.dgvDocViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents dtpVencimiento As DateTimePicker
    Private WithEvents dtpEmision As DateTimePicker
    Private WithEvents txtTipoDocumento As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvDocViajes As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtIdcliente As TextBox
    Private WithEvents txtIdDocumento As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
