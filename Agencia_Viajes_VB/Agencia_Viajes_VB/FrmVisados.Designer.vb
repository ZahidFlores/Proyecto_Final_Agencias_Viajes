<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisados
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
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtTipoVisado = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvVisados = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPaisEmision = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtRequisitos = New System.Windows.Forms.TextBox()
        Me.txtIdVisado = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvVisados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(155, 311)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 119
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(15, 311)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 118
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(14, 295)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 13)
        Me.label7.TabIndex = 117
        Me.label7.Text = "Id del cliente"
        '
        'txtTipoVisado
        '
        Me.txtTipoVisado.Location = New System.Drawing.Point(15, 116)
        Me.txtTipoVisado.Name = "txtTipoVisado"
        Me.txtTipoVisado.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoVisado.TabIndex = 116
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(613, 311)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 115
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(520, 311)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 114
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(426, 311)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 113
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvVisados
        '
        Me.dgvVisados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisados.Location = New System.Drawing.Point(121, 65)
        Me.dgvVisados.Name = "dgvVisados"
        Me.dgvVisados.Size = New System.Drawing.Size(567, 221)
        Me.dgvVisados.TabIndex = 112
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(694, 65)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 111
        '
        'txtPaisEmision
        '
        Me.txtPaisEmision.Location = New System.Drawing.Point(15, 266)
        Me.txtPaisEmision.Name = "txtPaisEmision"
        Me.txtPaisEmision.Size = New System.Drawing.Size(100, 20)
        Me.txtPaisEmision.TabIndex = 110
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(15, 219)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 109
        '
        'txtRequisitos
        '
        Me.txtRequisitos.Location = New System.Drawing.Point(15, 166)
        Me.txtRequisitos.Name = "txtRequisitos"
        Me.txtRequisitos.Size = New System.Drawing.Size(100, 20)
        Me.txtRequisitos.TabIndex = 108
        '
        'txtIdVisado
        '
        Me.txtIdVisado.Location = New System.Drawing.Point(15, 65)
        Me.txtIdVisado.Name = "txtIdVisado"
        Me.txtIdVisado.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVisado.TabIndex = 107
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(14, 250)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(83, 13)
        Me.label6.TabIndex = 106
        Me.label6.Text = "País de Emision"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(14, 203)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 105
        Me.label5.Text = "Precio"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(713, 48)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 104
        Me.label4.Text = "Usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 150)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 103
        Me.label3.Text = "Requisitos"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 13)
        Me.label2.TabIndex = 102
        Me.label2.Text = "Tipo de visado"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 101
        Me.label1.Text = "Id del visado"
        '
        'FrmVisados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtTipoVisado)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvVisados)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtPaisEmision)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtRequisitos)
        Me.Controls.Add(Me.txtIdVisado)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmVisados"
        Me.Text = "FrmVisados"
        CType(Me.dgvVisados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCerrar As Button
    Private WithEvents txtIdCliente As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtTipoVisado As TextBox
    Private WithEvents btneliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvVisados As DataGridView
    Private WithEvents txtUsuario As TextBox
    Private WithEvents txtPaisEmision As TextBox
    Private WithEvents txtPrecio As TextBox
    Private WithEvents txtRequisitos As TextBox
    Private WithEvents txtIdVisado As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
