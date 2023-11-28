namespace Agencias_Viajes_C_
{
    partial class FrmAgencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCupos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnPaqueteviaje = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.btnSeguros = new System.Windows.Forms.Button();
            this.btnOpiniones = new System.Windows.Forms.Button();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnDocViaje = new System.Windows.Forms.Button();
            this.btnEquipaje = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnGuias = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.btnActividad = new System.Windows.Forms.Button();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btnVehicAlquiler = new System.Windows.Forms.Button();
            this.btnVisados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(739, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(153, 355);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(98, 426);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(111, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Viajes";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(19, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(19, 208);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(19, 257);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtCupos
            // 
            this.txtCupos.Location = new System.Drawing.Point(19, 306);
            this.txtCupos.Name = "txtCupos";
            this.txtCupos.Size = new System.Drawing.Size(100, 20);
            this.txtCupos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de regreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cupos disponibles";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(736, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Usuario";
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(153, 68);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(686, 258);
            this.dgvViajes.TabIndex = 17;
            this.dgvViajes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(570, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(665, 356);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(764, 356);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(19, 111);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaSalida.TabIndex = 21;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegreso.Location = new System.Drawing.Point(19, 157);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaRegreso.TabIndex = 22;
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(239, 426);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(111, 23);
            this.btnReserva.TabIndex = 23;
            this.btnReserva.Text = "Reservas";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnPaqueteviaje
            // 
            this.btnPaqueteviaje.Location = new System.Drawing.Point(378, 425);
            this.btnPaqueteviaje.Name = "btnPaqueteviaje";
            this.btnPaqueteviaje.Size = new System.Drawing.Size(111, 23);
            this.btnPaqueteviaje.TabIndex = 24;
            this.btnPaqueteviaje.Text = "Paquetes de viaje";
            this.btnPaqueteviaje.UseVisualStyleBackColor = true;
            this.btnPaqueteviaje.Click += new System.EventHandler(this.btnPaqueteviaje_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(511, 425);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(111, 23);
            this.btnDestino.TabIndex = 25;
            this.btnDestino.Text = "Destinos";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnTransporte
            // 
            this.btnTransporte.Location = new System.Drawing.Point(645, 426);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(111, 23);
            this.btnTransporte.TabIndex = 26;
            this.btnTransporte.Text = "Transportes";
            this.btnTransporte.UseVisualStyleBackColor = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // btnSeguros
            // 
            this.btnSeguros.Location = new System.Drawing.Point(98, 479);
            this.btnSeguros.Name = "btnSeguros";
            this.btnSeguros.Size = new System.Drawing.Size(111, 23);
            this.btnSeguros.TabIndex = 27;
            this.btnSeguros.Text = "Seguros de viaje";
            this.btnSeguros.UseVisualStyleBackColor = true;
            this.btnSeguros.Click += new System.EventHandler(this.btnSeguros_Click);
            // 
            // btnOpiniones
            // 
            this.btnOpiniones.Location = new System.Drawing.Point(239, 479);
            this.btnOpiniones.Name = "btnOpiniones";
            this.btnOpiniones.Size = new System.Drawing.Size(111, 23);
            this.btnOpiniones.TabIndex = 28;
            this.btnOpiniones.Text = "Opiniones";
            this.btnOpiniones.UseVisualStyleBackColor = true;
            this.btnOpiniones.Click += new System.EventHandler(this.btnOpiniones_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.Location = new System.Drawing.Point(378, 479);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(111, 23);
            this.btnPromociones.TabIndex = 29;
            this.btnPromociones.Text = "Promociones";
            this.btnPromociones.UseVisualStyleBackColor = true;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(511, 479);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(111, 23);
            this.btnAgenda.TabIndex = 30;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnDocViaje
            // 
            this.btnDocViaje.Location = new System.Drawing.Point(645, 531);
            this.btnDocViaje.Name = "btnDocViaje";
            this.btnDocViaje.Size = new System.Drawing.Size(135, 23);
            this.btnDocViaje.TabIndex = 31;
            this.btnDocViaje.Text = "Documentos de Viaje";
            this.btnDocViaje.UseVisualStyleBackColor = true;
            this.btnDocViaje.Click += new System.EventHandler(this.btnDocViaje_Click);
            // 
            // btnEquipaje
            // 
            this.btnEquipaje.Location = new System.Drawing.Point(239, 531);
            this.btnEquipaje.Name = "btnEquipaje";
            this.btnEquipaje.Size = new System.Drawing.Size(111, 23);
            this.btnEquipaje.TabIndex = 32;
            this.btnEquipaje.Text = "Equipaje";
            this.btnEquipaje.UseVisualStyleBackColor = true;
            this.btnEquipaje.Click += new System.EventHandler(this.btnEquipaje_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(378, 531);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(111, 23);
            this.btnFacturas.TabIndex = 33;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnGuias
            // 
            this.btnGuias.Location = new System.Drawing.Point(511, 531);
            this.btnGuias.Name = "btnGuias";
            this.btnGuias.Size = new System.Drawing.Size(111, 23);
            this.btnGuias.TabIndex = 34;
            this.btnGuias.Text = "Guias";
            this.btnGuias.UseVisualStyleBackColor = true;
            this.btnGuias.Click += new System.EventHandler(this.btnGuias_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Location = new System.Drawing.Point(98, 531);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(111, 23);
            this.btnHoteles.TabIndex = 35;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // btnActividad
            // 
            this.btnActividad.Location = new System.Drawing.Point(98, 579);
            this.btnActividad.Name = "btnActividad";
            this.btnActividad.Size = new System.Drawing.Size(111, 23);
            this.btnActividad.TabIndex = 36;
            this.btnActividad.Text = "Actividad";
            this.btnActividad.UseVisualStyleBackColor = true;
            this.btnActividad.Click += new System.EventHandler(this.btnActividad_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(239, 579);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(111, 23);
            this.btnTarjetas.TabIndex = 37;
            this.btnTarjetas.Text = "Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btnVehicAlquiler
            // 
            this.btnVehicAlquiler.Location = new System.Drawing.Point(378, 579);
            this.btnVehicAlquiler.Name = "btnVehicAlquiler";
            this.btnVehicAlquiler.Size = new System.Drawing.Size(111, 23);
            this.btnVehicAlquiler.TabIndex = 38;
            this.btnVehicAlquiler.Text = "Vehic Alquiler";
            this.btnVehicAlquiler.UseVisualStyleBackColor = true;
            this.btnVehicAlquiler.Click += new System.EventHandler(this.btnVehicAlquiler_Click);
            // 
            // btnVisados
            // 
            this.btnVisados.Location = new System.Drawing.Point(511, 579);
            this.btnVisados.Name = "btnVisados";
            this.btnVisados.Size = new System.Drawing.Size(111, 23);
            this.btnVisados.TabIndex = 39;
            this.btnVisados.Text = "Visados";
            this.btnVisados.UseVisualStyleBackColor = true;
            this.btnVisados.Click += new System.EventHandler(this.btnVisados_Click);
            // 
            // FrmAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 658);
            this.Controls.Add(this.btnVisados);
            this.Controls.Add(this.btnVehicAlquiler);
            this.Controls.Add(this.btnTarjetas);
            this.Controls.Add(this.btnActividad);
            this.Controls.Add(this.btnHoteles);
            this.Controls.Add(this.btnGuias);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnEquipaje);
            this.Controls.Add(this.btnDocViaje);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnPromociones);
            this.Controls.Add(this.btnOpiniones);
            this.Controls.Add(this.btnSeguros);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnPaqueteviaje);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.dtpFechaRegreso);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCupos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgencia";
            this.Load += new System.EventHandler(this.FrmAgencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnPaqueteviaje;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.Button btnSeguros;
        private System.Windows.Forms.Button btnOpiniones;
        private System.Windows.Forms.Button btnPromociones;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnDocViaje;
        private System.Windows.Forms.Button btnEquipaje;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnGuias;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button btnActividad;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.Button btnVehicAlquiler;
        private System.Windows.Forms.Button btnVisados;
    }
}