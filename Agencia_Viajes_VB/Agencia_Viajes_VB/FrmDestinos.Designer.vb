<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDestinos
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
        Me.txtIdViaje = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtNombreDestino = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDestinos = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdDestino = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(124, 350)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 70
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtIdViaje
        '
        Me.txtIdViaje.Location = New System.Drawing.Point(18, 314)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.Size = New System.Drawing.Size(100, 20)
        Me.txtIdViaje.TabIndex = 69
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(17, 298)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(58, 13)
        Me.label7.TabIndex = 68
        Me.label7.Text = "Id del viaje"
        '
        'txtNombreDestino
        '
        Me.txtNombreDestino.Location = New System.Drawing.Point(18, 120)
        Me.txtNombreDestino.Name = "txtNombreDestino"
        Me.txtNombreDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreDestino.TabIndex = 67
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(616, 350)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 66
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(523, 350)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 65
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(429, 350)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 64
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDestinos
        '
        Me.dgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDestinos.Location = New System.Drawing.Point(124, 69)
        Me.dgvDestinos.Name = "dgvDestinos"
        Me.dgvDestinos.Size = New System.Drawing.Size(567, 265)
        Me.dgvDestinos.TabIndex = 63
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(697, 69)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 62
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(18, 270)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudad.TabIndex = 61
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(18, 223)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(100, 20)
        Me.txtPais.TabIndex = 60
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(18, 170)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 59
        '
        'txtIdDestino
        '
        Me.txtIdDestino.Location = New System.Drawing.Point(18, 69)
        Me.txtIdDestino.Name = "txtIdDestino"
        Me.txtIdDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDestino.TabIndex = 58
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(17, 254)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 13)
        Me.label6.TabIndex = 57
        Me.label6.Text = "Ciudad"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(17, 207)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(29, 13)
        Me.label5.TabIndex = 56
        Me.label5.Text = "País"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(716, 52)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 55
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 154)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 13)
        Me.label3.TabIndex = 54
        Me.label3.Text = "Descripcion"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 104)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(98, 13)
        Me.label2.TabIndex = 53
        Me.label2.Text = "Nombre del destino"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 53)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 13)
        Me.label1.TabIndex = 52
        Me.label1.Text = "Id del destino"
        '
        'FrmDestinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtIdViaje)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtNombreDestino)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvDestinos)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdDestino)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmDestinos"
        Me.Text = "FrmDestinos"
        CType(Me.dgvDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents txtIdViaje As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtNombreDestino As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvDestinos As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtCiudad As TextBox
    Private WithEvents txtPais As TextBox
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents txtIdDestino As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
