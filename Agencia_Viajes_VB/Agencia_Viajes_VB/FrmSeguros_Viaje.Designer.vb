<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguros_Viaje
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
        Me.txtTiposeguro = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvSeguros = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdViaje = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCobertura = New System.Windows.Forms.TextBox()
        Me.txtIdSeguro = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(122, 299)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 115
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtTiposeguro
        '
        Me.txtTiposeguro.Location = New System.Drawing.Point(16, 104)
        Me.txtTiposeguro.Name = "txtTiposeguro"
        Me.txtTiposeguro.Size = New System.Drawing.Size(100, 20)
        Me.txtTiposeguro.TabIndex = 114
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(614, 299)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 113
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(521, 299)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 112
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(427, 299)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 111
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvSeguros
        '
        Me.dgvSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguros.Location = New System.Drawing.Point(122, 53)
        Me.dgvSeguros.Name = "dgvSeguros"
        Me.dgvSeguros.Size = New System.Drawing.Size(567, 221)
        Me.dgvSeguros.TabIndex = 110
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(695, 53)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 109
        '
        'txtIdViaje
        '
        Me.txtIdViaje.Location = New System.Drawing.Point(16, 254)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.Size = New System.Drawing.Size(100, 20)
        Me.txtIdViaje.TabIndex = 108
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(16, 207)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 107
        '
        'txtCobertura
        '
        Me.txtCobertura.Location = New System.Drawing.Point(16, 154)
        Me.txtCobertura.Name = "txtCobertura"
        Me.txtCobertura.Size = New System.Drawing.Size(100, 20)
        Me.txtCobertura.TabIndex = 106
        '
        'txtIdSeguro
        '
        Me.txtIdSeguro.Location = New System.Drawing.Point(16, 53)
        Me.txtIdSeguro.Name = "txtIdSeguro"
        Me.txtIdSeguro.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSeguro.TabIndex = 105
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(15, 238)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(58, 13)
        Me.label6.TabIndex = 104
        Me.label6.Text = "Id del viaje"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 191)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 103
        Me.label5.Text = "Precio"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(714, 36)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 102
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 138)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(53, 13)
        Me.label3.TabIndex = 101
        Me.label3.Text = "Cobertura"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 13)
        Me.label2.TabIndex = 100
        Me.label2.Text = "Tipo de seguro"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 99
        Me.label1.Text = "Id del seguro"
        '
        'FrmSeguros_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 374)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtTiposeguro)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvSeguros)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIdViaje)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCobertura)
        Me.Controls.Add(Me.txtIdSeguro)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmSeguros_Viaje"
        Me.Text = "FrmSeguros_Viaje"
        CType(Me.dgvSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents txtTiposeguro As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvSeguros As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtIdViaje As TextBox
    Private WithEvents txtPrecio As TextBox
    Private WithEvents txtCobertura As TextBox
    Private WithEvents txtIdSeguro As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
