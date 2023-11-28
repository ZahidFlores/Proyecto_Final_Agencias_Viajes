<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPromociones
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
        Me.txtNombreprom = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvPromociones = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdPromocion = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtIdViaje = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        CType(Me.dgvPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(123, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 132
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(19, 259)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(98, 20)
        Me.dtpVencimiento.TabIndex = 131
        '
        'txtNombreprom
        '
        Me.txtNombreprom.Location = New System.Drawing.Point(17, 109)
        Me.txtNombreprom.Name = "txtNombreprom"
        Me.txtNombreprom.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreprom.TabIndex = 130
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(615, 304)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 129
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(522, 304)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 128
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(428, 304)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 127
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvPromociones
        '
        Me.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromociones.Location = New System.Drawing.Point(123, 58)
        Me.dgvPromociones.Name = "dgvPromociones"
        Me.dgvPromociones.Size = New System.Drawing.Size(567, 221)
        Me.dgvPromociones.TabIndex = 126
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(696, 58)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 125
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(17, 212)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentaje.TabIndex = 124
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(17, 159)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtdescripcion.TabIndex = 123
        '
        'txtIdPromocion
        '
        Me.txtIdPromocion.Location = New System.Drawing.Point(17, 58)
        Me.txtIdPromocion.Name = "txtIdPromocion"
        Me.txtIdPromocion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPromocion.TabIndex = 122
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 243)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(113, 13)
        Me.label6.TabIndex = 121
        Me.label6.Text = "Fecha de Vencimiento"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(14, 196)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(58, 13)
        Me.label5.TabIndex = 120
        Me.label5.Text = "Porcentaje"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(715, 41)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 119
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 143)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 13)
        Me.label3.TabIndex = 118
        Me.label3.Text = "Descripcion "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 13)
        Me.label2.TabIndex = 117
        Me.label2.Text = "Nombre Promocion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 13)
        Me.label1.TabIndex = 116
        Me.label1.Text = "Id de promocion"
        '
        'txtIdViaje
        '
        Me.txtIdViaje.Location = New System.Drawing.Point(15, 323)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.Size = New System.Drawing.Size(100, 20)
        Me.txtIdViaje.TabIndex = 134
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(14, 307)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(59, 13)
        Me.label7.TabIndex = 133
        Me.label7.Text = "Id del Viaje"
        '
        'FrmPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 379)
        Me.Controls.Add(Me.txtIdViaje)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dtpVencimiento)
        Me.Controls.Add(Me.txtNombreprom)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvPromociones)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtIdPromocion)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmPromociones"
        Me.Text = "FrmPromociones"
        CType(Me.dgvPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents dtpVencimiento As DateTimePicker
    Private WithEvents txtNombreprom As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvPromociones As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtPorcentaje As TextBox
    Private WithEvents txtdescripcion As TextBox
    Private WithEvents txtIdPromocion As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtIdViaje As TextBox
    Private WithEvents label7 As Label
End Class
