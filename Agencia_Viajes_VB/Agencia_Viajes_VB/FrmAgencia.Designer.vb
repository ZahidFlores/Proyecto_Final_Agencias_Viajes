<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnVisados = New System.Windows.Forms.Button()
        Me.btnVehicAlquiler = New System.Windows.Forms.Button()
        Me.btnTarjetas = New System.Windows.Forms.Button()
        Me.btnActividad = New System.Windows.Forms.Button()
        Me.btnHoteles = New System.Windows.Forms.Button()
        Me.btnGuias = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnEquipaje = New System.Windows.Forms.Button()
        Me.btnDocViaje = New System.Windows.Forms.Button()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnPromociones = New System.Windows.Forms.Button()
        Me.btnOpiniones = New System.Windows.Forms.Button()
        Me.btnSeguros = New System.Windows.Forms.Button()
        Me.btnTransporte = New System.Windows.Forms.Button()
        Me.btnDestino = New System.Windows.Forms.Button()
        Me.btnPaqueteviaje = New System.Windows.Forms.Button()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.dtpFechaRegreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvViajes = New System.Windows.Forms.DataGridView()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtCupos = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        CType(Me.dgvViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVisados
        '
        Me.btnVisados.Location = New System.Drawing.Point(517, 602)
        Me.btnVisados.Name = "btnVisados"
        Me.btnVisados.Size = New System.Drawing.Size(111, 23)
        Me.btnVisados.TabIndex = 77
        Me.btnVisados.Text = "Visados"
        Me.btnVisados.UseVisualStyleBackColor = True
        '
        'btnVehicAlquiler
        '
        Me.btnVehicAlquiler.Location = New System.Drawing.Point(384, 602)
        Me.btnVehicAlquiler.Name = "btnVehicAlquiler"
        Me.btnVehicAlquiler.Size = New System.Drawing.Size(111, 23)
        Me.btnVehicAlquiler.TabIndex = 76
        Me.btnVehicAlquiler.Text = "Vehic Alquiler"
        Me.btnVehicAlquiler.UseVisualStyleBackColor = True
        '
        'btnTarjetas
        '
        Me.btnTarjetas.Location = New System.Drawing.Point(245, 602)
        Me.btnTarjetas.Name = "btnTarjetas"
        Me.btnTarjetas.Size = New System.Drawing.Size(111, 23)
        Me.btnTarjetas.TabIndex = 75
        Me.btnTarjetas.Text = "Tarjetas"
        Me.btnTarjetas.UseVisualStyleBackColor = True
        '
        'btnActividad
        '
        Me.btnActividad.Location = New System.Drawing.Point(104, 602)
        Me.btnActividad.Name = "btnActividad"
        Me.btnActividad.Size = New System.Drawing.Size(111, 23)
        Me.btnActividad.TabIndex = 74
        Me.btnActividad.Text = "Actividad"
        Me.btnActividad.UseVisualStyleBackColor = True
        '
        'btnHoteles
        '
        Me.btnHoteles.Location = New System.Drawing.Point(104, 554)
        Me.btnHoteles.Name = "btnHoteles"
        Me.btnHoteles.Size = New System.Drawing.Size(111, 23)
        Me.btnHoteles.TabIndex = 73
        Me.btnHoteles.Text = "Hoteles"
        Me.btnHoteles.UseVisualStyleBackColor = True
        '
        'btnGuias
        '
        Me.btnGuias.Location = New System.Drawing.Point(517, 554)
        Me.btnGuias.Name = "btnGuias"
        Me.btnGuias.Size = New System.Drawing.Size(111, 23)
        Me.btnGuias.TabIndex = 72
        Me.btnGuias.Text = "Guias"
        Me.btnGuias.UseVisualStyleBackColor = True
        '
        'btnFacturas
        '
        Me.btnFacturas.Location = New System.Drawing.Point(384, 554)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(111, 23)
        Me.btnFacturas.TabIndex = 71
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = True
        '
        'btnEquipaje
        '
        Me.btnEquipaje.Location = New System.Drawing.Point(245, 554)
        Me.btnEquipaje.Name = "btnEquipaje"
        Me.btnEquipaje.Size = New System.Drawing.Size(111, 23)
        Me.btnEquipaje.TabIndex = 70
        Me.btnEquipaje.Text = "Equipaje"
        Me.btnEquipaje.UseVisualStyleBackColor = True
        '
        'btnDocViaje
        '
        Me.btnDocViaje.Location = New System.Drawing.Point(651, 554)
        Me.btnDocViaje.Name = "btnDocViaje"
        Me.btnDocViaje.Size = New System.Drawing.Size(135, 23)
        Me.btnDocViaje.TabIndex = 69
        Me.btnDocViaje.Text = "Documentos de Viaje"
        Me.btnDocViaje.UseVisualStyleBackColor = True
        '
        'btnAgenda
        '
        Me.btnAgenda.Location = New System.Drawing.Point(517, 502)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(111, 23)
        Me.btnAgenda.TabIndex = 68
        Me.btnAgenda.Text = "Agenda"
        Me.btnAgenda.UseVisualStyleBackColor = True
        '
        'btnPromociones
        '
        Me.btnPromociones.Location = New System.Drawing.Point(384, 502)
        Me.btnPromociones.Name = "btnPromociones"
        Me.btnPromociones.Size = New System.Drawing.Size(111, 23)
        Me.btnPromociones.TabIndex = 67
        Me.btnPromociones.Text = "Promociones"
        Me.btnPromociones.UseVisualStyleBackColor = True
        '
        'btnOpiniones
        '
        Me.btnOpiniones.Location = New System.Drawing.Point(245, 502)
        Me.btnOpiniones.Name = "btnOpiniones"
        Me.btnOpiniones.Size = New System.Drawing.Size(111, 23)
        Me.btnOpiniones.TabIndex = 66
        Me.btnOpiniones.Text = "Opiniones"
        Me.btnOpiniones.UseVisualStyleBackColor = True
        '
        'btnSeguros
        '
        Me.btnSeguros.Location = New System.Drawing.Point(104, 502)
        Me.btnSeguros.Name = "btnSeguros"
        Me.btnSeguros.Size = New System.Drawing.Size(111, 23)
        Me.btnSeguros.TabIndex = 65
        Me.btnSeguros.Text = "Seguros de viaje"
        Me.btnSeguros.UseVisualStyleBackColor = True
        '
        'btnTransporte
        '
        Me.btnTransporte.Location = New System.Drawing.Point(651, 449)
        Me.btnTransporte.Name = "btnTransporte"
        Me.btnTransporte.Size = New System.Drawing.Size(111, 23)
        Me.btnTransporte.TabIndex = 64
        Me.btnTransporte.Text = "Transportes"
        Me.btnTransporte.UseVisualStyleBackColor = True
        '
        'btnDestino
        '
        Me.btnDestino.Location = New System.Drawing.Point(517, 448)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(111, 23)
        Me.btnDestino.TabIndex = 63
        Me.btnDestino.Text = "Destinos"
        Me.btnDestino.UseVisualStyleBackColor = True
        '
        'btnPaqueteviaje
        '
        Me.btnPaqueteviaje.Location = New System.Drawing.Point(384, 448)
        Me.btnPaqueteviaje.Name = "btnPaqueteviaje"
        Me.btnPaqueteviaje.Size = New System.Drawing.Size(111, 23)
        Me.btnPaqueteviaje.TabIndex = 62
        Me.btnPaqueteviaje.Text = "Paquetes de viaje"
        Me.btnPaqueteviaje.UseVisualStyleBackColor = True
        '
        'btnReserva
        '
        Me.btnReserva.Location = New System.Drawing.Point(245, 449)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(111, 23)
        Me.btnReserva.TabIndex = 61
        Me.btnReserva.Text = "Reservas"
        Me.btnReserva.UseVisualStyleBackColor = True
        '
        'dtpFechaRegreso
        '
        Me.dtpFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRegreso.Location = New System.Drawing.Point(25, 180)
        Me.dtpFechaRegreso.Name = "dtpFechaRegreso"
        Me.dtpFechaRegreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaRegreso.TabIndex = 60
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(25, 134)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaSalida.TabIndex = 59
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(770, 379)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 58
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(671, 379)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 57
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(576, 378)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 56
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvViajes
        '
        Me.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViajes.Location = New System.Drawing.Point(159, 91)
        Me.dgvViajes.Name = "dgvViajes"
        Me.dgvViajes.Size = New System.Drawing.Size(686, 258)
        Me.dgvViajes.TabIndex = 55
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(742, 33)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(43, 13)
        Me.label8.TabIndex = 54
        Me.label8.Text = "Usuario"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(25, 313)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(92, 13)
        Me.label7.TabIndex = 53
        Me.label7.Text = "Cupos disponibles"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(22, 264)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(63, 13)
        Me.label6.TabIndex = 52
        Me.label6.Text = "Descripcion"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(22, 215)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 51
        Me.label5.Text = "Precio"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 164)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(90, 13)
        Me.label4.TabIndex = 50
        Me.label4.Text = "Fecha de regreso"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(22, 117)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(84, 13)
        Me.label3.TabIndex = 49
        Me.label3.Text = "Fecha de Salida"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Codigo Viaje"
        '
        'txtCupos
        '
        Me.txtCupos.Location = New System.Drawing.Point(25, 329)
        Me.txtCupos.Name = "txtCupos"
        Me.txtCupos.Size = New System.Drawing.Size(100, 20)
        Me.txtCupos.TabIndex = 47
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(25, 280)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 46
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(25, 231)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 45
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(25, 91)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 44
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(405, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 24)
        Me.label1.TabIndex = 43
        Me.label1.Text = "Viajes"
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(104, 449)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(111, 23)
        Me.btnCliente.TabIndex = 42
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(159, 378)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(111, 23)
        Me.btnCerrarSesion.TabIndex = 41
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(745, 49)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 40
        '
        'FrmAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 658)
        Me.Controls.Add(Me.btnVisados)
        Me.Controls.Add(Me.btnVehicAlquiler)
        Me.Controls.Add(Me.btnTarjetas)
        Me.Controls.Add(Me.btnActividad)
        Me.Controls.Add(Me.btnHoteles)
        Me.Controls.Add(Me.btnGuias)
        Me.Controls.Add(Me.btnFacturas)
        Me.Controls.Add(Me.btnEquipaje)
        Me.Controls.Add(Me.btnDocViaje)
        Me.Controls.Add(Me.btnAgenda)
        Me.Controls.Add(Me.btnPromociones)
        Me.Controls.Add(Me.btnOpiniones)
        Me.Controls.Add(Me.btnSeguros)
        Me.Controls.Add(Me.btnTransporte)
        Me.Controls.Add(Me.btnDestino)
        Me.Controls.Add(Me.btnPaqueteviaje)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.dtpFechaRegreso)
        Me.Controls.Add(Me.dtpFechaSalida)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvViajes)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtCupos)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "FrmAgencia"
        Me.Text = "FrmAgencia"
        CType(Me.dgvViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnVisados As Button
    Private WithEvents btnVehicAlquiler As Button
    Private WithEvents btnTarjetas As Button
    Private WithEvents btnActividad As Button
    Private WithEvents btnHoteles As Button
    Private WithEvents btnGuias As Button
    Private WithEvents btnFacturas As Button
    Private WithEvents btnEquipaje As Button
    Private WithEvents btnDocViaje As Button
    Private WithEvents btnAgenda As Button
    Private WithEvents btnPromociones As Button
    Private WithEvents btnOpiniones As Button
    Private WithEvents btnSeguros As Button
    Private WithEvents btnTransporte As Button
    Private WithEvents btnDestino As Button
    Private WithEvents btnPaqueteviaje As Button
    Private WithEvents btnReserva As Button
    Private WithEvents dtpFechaRegreso As DateTimePicker
    Private WithEvents dtpFechaSalida As DateTimePicker
    Private WithEvents btnEliminar As Button
    Private WithEvents btnActualizar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvViajes As DataGridView
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtCupos As TextBox
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents txtPrecio As TextBox
    Private WithEvents txtId As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnCliente As Button
    Private WithEvents btnCerrarSesion As Button
    Private WithEvents txtUsuario As TextBox
End Class
