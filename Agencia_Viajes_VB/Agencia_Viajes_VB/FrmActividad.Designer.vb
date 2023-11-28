<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividad
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
        Me.txtNombreact = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvActividad = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtIdDestino = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(120, 287)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 113
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtNombreact
        '
        Me.txtNombreact.Location = New System.Drawing.Point(14, 117)
        Me.txtNombreact.Name = "txtNombreact"
        Me.txtNombreact.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreact.TabIndex = 112
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(612, 287)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 111
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(519, 287)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 110
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(425, 287)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 109
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvActividad
        '
        Me.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividad.Location = New System.Drawing.Point(120, 41)
        Me.dgvActividad.Name = "dgvActividad"
        Me.dgvActividad.Size = New System.Drawing.Size(567, 221)
        Me.dgvActividad.TabIndex = 108
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(693, 41)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 107
        '
        'txtIdDestino
        '
        Me.txtIdDestino.Location = New System.Drawing.Point(14, 265)
        Me.txtIdDestino.Name = "txtIdDestino"
        Me.txtIdDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDestino.TabIndex = 106
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(14, 167)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 105
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Location = New System.Drawing.Point(14, 66)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdActividad.TabIndex = 104
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 249)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(72, 13)
        Me.label6.TabIndex = 103
        Me.label6.Text = "Id del Destino"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(712, 24)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 102
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(13, 151)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 13)
        Me.label3.TabIndex = 101
        Me.label3.Text = "Descripcion"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 101)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(116, 13)
        Me.label2.TabIndex = 100
        Me.label2.Text = "Nombre de la actividad"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 50)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 13)
        Me.label1.TabIndex = 99
        Me.label1.Text = "Id de la actividad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(14, 216)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 115
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(13, 200)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 114
        Me.label5.Text = "Precio"
        '
        'FrmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 335)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtNombreact)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvActividad)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIdDestino)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdActividad)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmActividad"
        Me.Text = "FrmActividad"
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents txtNombreact As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvActividad As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtIdDestino As TextBox
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents txtIdActividad As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtPrecio As TextBox
    Private WithEvents label5 As Label
End Class
