namespace FrontEndFarmacia.Presentacion
{
    partial class frmNuevoPresupuesto
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
            panelDatosPersonales = new Panel();
            btnAceptarCliente = new Button();
            cboBuscarClientes = new ComboBox();
            lblClienteBusqueda = new Label();
            txtFecha = new TextBox();
            dgvDetallePresup = new DataGridView();
            Col_idMedic = new DataGridViewTextBoxColumn();
            Col_Medicamento = new DataGridViewTextBoxColumn();
            Col_Cantidad = new DataGridViewTextBoxColumn();
            Col_Precio = new DataGridViewTextBoxColumn();
            Col_Quitar = new DataGridViewButtonColumn();
            panelPresupuesto = new Panel();
            chkBoxReceta = new CheckBox();
            lblReceta = new Label();
            cboObraSocial = new ComboBox();
            lblObSocial = new Label();
            numericUpDownCantidad = new NumericUpDown();
            lblCantidad = new Label();
            lblMedic = new Label();
            cboMedicamentos = new ComboBox();
            lblPresupuestoNro = new Label();
            txtPresupNro = new TextBox();
            panelPagos = new Panel();
            cboFormaEntrega = new ComboBox();
            lblFormaEntrega = new Label();
            cboMedioPago = new ComboBox();
            lblMedioPago = new Label();
            cboFormaPago = new ComboBox();
            lblFormaPAgo = new Label();
            lblSubTotal = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnAceptar = new Button();
            panelAceptar = new Panel();
            panelCancelar = new Panel();
            btnCancelar = new Button();
            panelTotalSubTotal = new Panel();
            btnSalir = new Button();
            lblNroAfiliado = new Label();
            txtCliente = new TextBox();
            btnAgregar = new Button();
            panelAgregar = new Panel();
            txtAfiliadoNro = new TextBox();
            cboFarmaceutico = new ComboBox();
            lblFarmaceutico = new Label();
            txtVendedor = new TextBox();
            lblVendedor = new Label();
            panelDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePresup).BeginInit();
            panelPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            panelPagos.SuspendLayout();
            panelAceptar.SuspendLayout();
            panelCancelar.SuspendLayout();
            panelTotalSubTotal.SuspendLayout();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panelDatosPersonales
            // 
            panelDatosPersonales.BackColor = Color.FromArgb(0, 64, 0);
            panelDatosPersonales.Controls.Add(cboFarmaceutico);
            panelDatosPersonales.Controls.Add(lblFarmaceutico);
            panelDatosPersonales.Controls.Add(btnAceptarCliente);
            panelDatosPersonales.Controls.Add(cboBuscarClientes);
            panelDatosPersonales.Controls.Add(lblClienteBusqueda);
            panelDatosPersonales.Location = new Point(362, 22);
            panelDatosPersonales.Margin = new Padding(4, 3, 4, 3);
            panelDatosPersonales.Name = "panelDatosPersonales";
            panelDatosPersonales.Size = new Size(545, 70);
            panelDatosPersonales.TabIndex = 0;
            // 
            // btnAceptarCliente
            // 
            btnAceptarCliente.BackColor = Color.White;
            btnAceptarCliente.BackgroundImageLayout = ImageLayout.None;
            btnAceptarCliente.FlatAppearance.BorderSize = 0;
            btnAceptarCliente.FlatStyle = FlatStyle.Flat;
            btnAceptarCliente.ForeColor = Color.FromArgb(0, 64, 0);
            btnAceptarCliente.Location = new Point(468, 21);
            btnAceptarCliente.Margin = new Padding(4, 3, 4, 3);
            btnAceptarCliente.Name = "btnAceptarCliente";
            btnAceptarCliente.Size = new Size(57, 27);
            btnAceptarCliente.TabIndex = 30;
            btnAceptarCliente.Text = "Aceptar";
            btnAceptarCliente.UseVisualStyleBackColor = false;
            btnAceptarCliente.Click += btnAceptarCliente_Click;
            // 
            // cboBuscarClientes
            // 
            cboBuscarClientes.BackColor = SystemColors.Menu;
            cboBuscarClientes.FormattingEnabled = true;
            cboBuscarClientes.Location = new Point(65, 24);
            cboBuscarClientes.Margin = new Padding(4, 3, 4, 3);
            cboBuscarClientes.Name = "cboBuscarClientes";
            cboBuscarClientes.Size = new Size(156, 23);
            cboBuscarClientes.TabIndex = 10;
            // 
            // lblClienteBusqueda
            // 
            lblClienteBusqueda.AutoSize = true;
            lblClienteBusqueda.BackColor = Color.FromArgb(0, 64, 0);
            lblClienteBusqueda.ForeColor = Color.White;
            lblClienteBusqueda.Location = new Point(10, 28);
            lblClienteBusqueda.Margin = new Padding(4, 0, 4, 0);
            lblClienteBusqueda.Name = "lblClienteBusqueda";
            lblClienteBusqueda.Size = new Size(53, 15);
            lblClienteBusqueda.TabIndex = 0;
            lblClienteBusqueda.Text = "Cliente...";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = SystemColors.Menu;
            txtFecha.Location = new Point(971, 30);
            txtFecha.Margin = new Padding(4, 3, 4, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(116, 23);
            txtFecha.TabIndex = 1;
            // 
            // dgvDetallePresup
            // 
            dgvDetallePresup.AllowUserToAddRows = false;
            dgvDetallePresup.AllowUserToDeleteRows = false;
            dgvDetallePresup.BackgroundColor = SystemColors.Menu;
            dgvDetallePresup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePresup.Columns.AddRange(new DataGridViewColumn[] { Col_idMedic, Col_Medicamento, Col_Cantidad, Col_Precio, Col_Quitar });
            dgvDetallePresup.Location = new Point(38, 260);
            dgvDetallePresup.Margin = new Padding(4, 3, 4, 3);
            dgvDetallePresup.Name = "dgvDetallePresup";
            dgvDetallePresup.ReadOnly = true;
            dgvDetallePresup.Size = new Size(721, 126);
            dgvDetallePresup.TabIndex = 2;
            dgvDetallePresup.CellContentClick += dgvDetallePresup_CellContentClick;
            // 
            // Col_idMedic
            // 
            Col_idMedic.HeaderText = "IdMedic";
            Col_idMedic.Name = "Col_idMedic";
            Col_idMedic.ReadOnly = true;
            Col_idMedic.Visible = false;
            // 
            // Col_Medicamento
            // 
            Col_Medicamento.HeaderText = "Medicamento";
            Col_Medicamento.Name = "Col_Medicamento";
            Col_Medicamento.ReadOnly = true;
            Col_Medicamento.Visible = false;
            // 
            // Col_Cantidad
            // 
            Col_Cantidad.HeaderText = "Cantidad";
            Col_Cantidad.Name = "Col_Cantidad";
            Col_Cantidad.ReadOnly = true;
            Col_Cantidad.Visible = false;
            // 
            // Col_Precio
            // 
            Col_Precio.HeaderText = "Precio $";
            Col_Precio.Name = "Col_Precio";
            Col_Precio.ReadOnly = true;
            Col_Precio.Visible = false;
            // 
            // Col_Quitar
            // 
            Col_Quitar.HeaderText = "Quitar";
            Col_Quitar.Name = "Col_Quitar";
            Col_Quitar.ReadOnly = true;
            Col_Quitar.Resizable = DataGridViewTriState.True;
            Col_Quitar.SortMode = DataGridViewColumnSortMode.Automatic;
            Col_Quitar.Visible = false;
            // 
            // panelPresupuesto
            // 
            panelPresupuesto.BackColor = Color.FromArgb(0, 64, 0);
            panelPresupuesto.Controls.Add(chkBoxReceta);
            panelPresupuesto.Controls.Add(lblReceta);
            panelPresupuesto.Controls.Add(cboObraSocial);
            panelPresupuesto.Controls.Add(lblObSocial);
            panelPresupuesto.Controls.Add(numericUpDownCantidad);
            panelPresupuesto.Controls.Add(lblCantidad);
            panelPresupuesto.Controls.Add(lblMedic);
            panelPresupuesto.Controls.Add(cboMedicamentos);
            panelPresupuesto.Location = new Point(38, 177);
            panelPresupuesto.Margin = new Padding(4, 3, 4, 3);
            panelPresupuesto.Name = "panelPresupuesto";
            panelPresupuesto.Size = new Size(821, 61);
            panelPresupuesto.TabIndex = 3;
            // 
            // chkBoxReceta
            // 
            chkBoxReceta.AutoSize = true;
            chkBoxReceta.Location = new Point(792, 24);
            chkBoxReceta.Margin = new Padding(4, 3, 4, 3);
            chkBoxReceta.Name = "chkBoxReceta";
            chkBoxReceta.Size = new Size(15, 14);
            chkBoxReceta.TabIndex = 9;
            chkBoxReceta.UseVisualStyleBackColor = true;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.BackColor = Color.FromArgb(0, 64, 0);
            lblReceta.ForeColor = Color.White;
            lblReceta.Location = new Point(733, 22);
            lblReceta.Margin = new Padding(4, 0, 4, 0);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(51, 15);
            lblReceta.TabIndex = 8;
            lblReceta.Text = "Receta...";
            // 
            // cboObraSocial
            // 
            cboObraSocial.BackColor = SystemColors.Menu;
            cboObraSocial.FormattingEnabled = true;
            cboObraSocial.Location = new Point(565, 19);
            cboObraSocial.Margin = new Padding(4, 3, 4, 3);
            cboObraSocial.Name = "cboObraSocial";
            cboObraSocial.Size = new Size(142, 23);
            cboObraSocial.TabIndex = 7;
            // 
            // lblObSocial
            // 
            lblObSocial.AutoSize = true;
            lblObSocial.BackColor = Color.FromArgb(0, 64, 0);
            lblObSocial.ForeColor = Color.White;
            lblObSocial.Location = new Point(480, 22);
            lblObSocial.Margin = new Padding(4, 0, 4, 0);
            lblObSocial.Name = "lblObSocial";
            lblObSocial.Size = new Size(76, 15);
            lblObSocial.TabIndex = 6;
            lblObSocial.Text = "Obra Social...";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(408, 19);
            numericUpDownCantidad.Margin = new Padding(4, 3, 4, 3);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(50, 23);
            numericUpDownCantidad.TabIndex = 5;
            numericUpDownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(0, 64, 0);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(331, 22);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(64, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad...";
            // 
            // lblMedic
            // 
            lblMedic.AutoSize = true;
            lblMedic.BackColor = Color.FromArgb(0, 64, 0);
            lblMedic.ForeColor = Color.White;
            lblMedic.Location = new Point(16, 22);
            lblMedic.Margin = new Padding(4, 0, 4, 0);
            lblMedic.Name = "lblMedic";
            lblMedic.Size = new Size(90, 15);
            lblMedic.TabIndex = 2;
            lblMedic.Text = "Medicamento...";
            // 
            // cboMedicamentos
            // 
            cboMedicamentos.BackColor = SystemColors.Menu;
            cboMedicamentos.FormattingEnabled = true;
            cboMedicamentos.Location = new Point(125, 18);
            cboMedicamentos.Margin = new Padding(4, 3, 4, 3);
            cboMedicamentos.Name = "cboMedicamentos";
            cboMedicamentos.Size = new Size(185, 23);
            cboMedicamentos.TabIndex = 0;
            // 
            // lblPresupuestoNro
            // 
            lblPresupuestoNro.AutoSize = true;
            lblPresupuestoNro.BackColor = Color.Green;
            lblPresupuestoNro.ForeColor = Color.White;
            lblPresupuestoNro.Location = new Point(42, 30);
            lblPresupuestoNro.Margin = new Padding(4, 0, 4, 0);
            lblPresupuestoNro.Name = "lblPresupuestoNro";
            lblPresupuestoNro.Size = new Size(98, 15);
            lblPresupuestoNro.TabIndex = 2;
            lblPresupuestoNro.Text = "Presupuesto N°...";
            // 
            // txtPresupNro
            // 
            txtPresupNro.BackColor = SystemColors.Menu;
            txtPresupNro.Location = new Point(142, 22);
            txtPresupNro.Margin = new Padding(4, 3, 4, 3);
            txtPresupNro.Name = "txtPresupNro";
            txtPresupNro.Size = new Size(46, 23);
            txtPresupNro.TabIndex = 4;
            // 
            // panelPagos
            // 
            panelPagos.BackColor = Color.FromArgb(0, 64, 0);
            panelPagos.Controls.Add(cboFormaEntrega);
            panelPagos.Controls.Add(lblFormaEntrega);
            panelPagos.Controls.Add(cboMedioPago);
            panelPagos.Controls.Add(lblMedioPago);
            panelPagos.Controls.Add(cboFormaPago);
            panelPagos.Controls.Add(lblFormaPAgo);
            panelPagos.Location = new Point(38, 410);
            panelPagos.Margin = new Padding(4, 3, 4, 3);
            panelPagos.Name = "panelPagos";
            panelPagos.Size = new Size(721, 55);
            panelPagos.TabIndex = 5;
            // 
            // cboFormaEntrega
            // 
            cboFormaEntrega.BackColor = SystemColors.Menu;
            cboFormaEntrega.FormattingEnabled = true;
            cboFormaEntrega.Location = new Point(587, 16);
            cboFormaEntrega.Margin = new Padding(4, 3, 4, 3);
            cboFormaEntrega.Name = "cboFormaEntrega";
            cboFormaEntrega.Size = new Size(107, 23);
            cboFormaEntrega.TabIndex = 14;
            // 
            // lblFormaEntrega
            // 
            lblFormaEntrega.AutoSize = true;
            lblFormaEntrega.BackColor = Color.FromArgb(0, 64, 0);
            lblFormaEntrega.ForeColor = Color.White;
            lblFormaEntrega.Location = new Point(481, 21);
            lblFormaEntrega.Margin = new Padding(4, 0, 4, 0);
            lblFormaEntrega.Name = "lblFormaEntrega";
            lblFormaEntrega.Size = new Size(93, 15);
            lblFormaEntrega.TabIndex = 13;
            lblFormaEntrega.Text = "Forma Entrega...";
            // 
            // cboMedioPago
            // 
            cboMedioPago.BackColor = SystemColors.Menu;
            cboMedioPago.FormattingEnabled = true;
            cboMedioPago.Location = new Point(350, 16);
            cboMedioPago.Margin = new Padding(4, 3, 4, 3);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(107, 23);
            cboMedioPago.TabIndex = 12;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.BackColor = Color.FromArgb(0, 64, 0);
            lblMedioPago.ForeColor = Color.White;
            lblMedioPago.Location = new Point(258, 21);
            lblMedioPago.Margin = new Padding(4, 0, 4, 0);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(80, 15);
            lblMedioPago.TabIndex = 11;
            lblMedioPago.Text = "Medio Pago...";
            // 
            // cboFormaPago
            // 
            cboFormaPago.BackColor = SystemColors.Menu;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(127, 16);
            cboFormaPago.Margin = new Padding(4, 3, 4, 3);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(107, 23);
            cboFormaPago.TabIndex = 10;
            // 
            // lblFormaPAgo
            // 
            lblFormaPAgo.AutoSize = true;
            lblFormaPAgo.BackColor = Color.FromArgb(0, 64, 0);
            lblFormaPAgo.ForeColor = Color.White;
            lblFormaPAgo.Location = new Point(35, 21);
            lblFormaPAgo.Margin = new Padding(4, 0, 4, 0);
            lblFormaPAgo.Name = "lblFormaPAgo";
            lblFormaPAgo.Size = new Size(80, 15);
            lblFormaPAgo.TabIndex = 1;
            lblFormaPAgo.Text = "Forma Pago...";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Green;
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(20, 22);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(73, 15);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "SubTotal... $ ";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.Menu;
            txtSubTotal.Location = new Point(124, 18);
            txtSubTotal.Margin = new Padding(4, 3, 4, 3);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(69, 23);
            txtSubTotal.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Menu;
            txtTotal.Location = new Point(124, 60);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(69, 23);
            txtTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Green;
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(42, 62);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total... $ ";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Menu;
            btnAceptar.BackgroundImageLayout = ImageLayout.None;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.FromArgb(0, 64, 0);
            btnAceptar.Location = new Point(17, 15);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 27);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // panelAceptar
            // 
            panelAceptar.BackColor = Color.FromArgb(0, 64, 0);
            panelAceptar.Controls.Add(btnAceptar);
            panelAceptar.Location = new Point(429, 585);
            panelAceptar.Margin = new Padding(4, 3, 4, 3);
            panelAceptar.Name = "panelAceptar";
            panelAceptar.Size = new Size(121, 53);
            panelAceptar.TabIndex = 19;
            // 
            // panelCancelar
            // 
            panelCancelar.BackColor = Color.FromArgb(0, 64, 0);
            panelCancelar.Controls.Add(btnCancelar);
            panelCancelar.Location = new Point(587, 585);
            panelCancelar.Margin = new Padding(4, 3, 4, 3);
            panelCancelar.Name = "panelCancelar";
            panelCancelar.Size = new Size(127, 53);
            panelCancelar.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Menu;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(0, 64, 0);
            btnCancelar.Location = new Point(20, 15);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panelTotalSubTotal
            // 
            panelTotalSubTotal.BackColor = Color.FromArgb(0, 64, 0);
            panelTotalSubTotal.Controls.Add(lblSubTotal);
            panelTotalSubTotal.Controls.Add(txtSubTotal);
            panelTotalSubTotal.Controls.Add(lblTotal);
            panelTotalSubTotal.Controls.Add(txtTotal);
            panelTotalSubTotal.Location = new Point(852, 471);
            panelTotalSubTotal.Margin = new Padding(4, 3, 4, 3);
            panelTotalSubTotal.Name = "panelTotalSubTotal";
            panelTotalSubTotal.Size = new Size(215, 102);
            panelTotalSubTotal.TabIndex = 23;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(0, 64, 0);
            btnSalir.Location = new Point(38, 624);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblNroAfiliado
            // 
            lblNroAfiliado.AutoSize = true;
            lblNroAfiliado.BackColor = Color.Green;
            lblNroAfiliado.ForeColor = Color.White;
            lblNroAfiliado.Location = new Point(196, 61);
            lblNroAfiliado.Margin = new Padding(4, 0, 4, 0);
            lblNroAfiliado.Name = "lblNroAfiliado";
            lblNroAfiliado.Size = new Size(74, 15);
            lblNroAfiliado.TabIndex = 25;
            lblNroAfiliado.Text = "Afiliado N°...";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.Menu;
            txtCliente.Location = new Point(38, 58);
            txtCliente.Margin = new Padding(4, 3, 4, 3);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(150, 23);
            txtCliente.TabIndex = 26;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(0, 64, 0);
            btnAgregar.Location = new Point(4, 18);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 27);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar a grilla...";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelAgregar
            // 
            panelAgregar.BackColor = Color.FromArgb(0, 64, 0);
            panelAgregar.Controls.Add(btnAgregar);
            panelAgregar.Location = new Point(920, 177);
            panelAgregar.Margin = new Padding(4, 3, 4, 3);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(125, 61);
            panelAgregar.TabIndex = 28;
            // 
            // txtAfiliadoNro
            // 
            txtAfiliadoNro.BackColor = SystemColors.Menu;
            txtAfiliadoNro.Location = new Point(269, 53);
            txtAfiliadoNro.Margin = new Padding(4, 3, 4, 3);
            txtAfiliadoNro.Name = "txtAfiliadoNro";
            txtAfiliadoNro.Size = new Size(46, 23);
            txtAfiliadoNro.TabIndex = 29;
            // 
            // cboFarmaceutico
            // 
            cboFarmaceutico.BackColor = SystemColors.Menu;
            cboFarmaceutico.FormattingEnabled = true;
            cboFarmaceutico.Location = new Point(341, 23);
            cboFarmaceutico.Margin = new Padding(4, 3, 4, 3);
            cboFarmaceutico.Name = "cboFarmaceutico";
            cboFarmaceutico.Size = new Size(103, 23);
            cboFarmaceutico.TabIndex = 31;
            // 
            // lblFarmaceutico
            // 
            lblFarmaceutico.AutoSize = true;
            lblFarmaceutico.BackColor = Color.FromArgb(0, 64, 0);
            lblFarmaceutico.ForeColor = Color.White;
            lblFarmaceutico.Location = new Point(245, 28);
            lblFarmaceutico.Margin = new Padding(4, 0, 4, 0);
            lblFarmaceutico.Name = "lblFarmaceutico";
            lblFarmaceutico.Size = new Size(88, 15);
            lblFarmaceutico.TabIndex = 31;
            lblFarmaceutico.Text = "Farmaceutico...";
            // 
            // txtVendedor
            // 
            txtVendedor.BackColor = SystemColors.Menu;
            txtVendedor.Location = new Point(1044, 82);
            txtVendedor.Margin = new Padding(4, 3, 4, 3);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(46, 23);
            txtVendedor.TabIndex = 31;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.BackColor = Color.Green;
            lblVendedor.ForeColor = Color.White;
            lblVendedor.Location = new Point(959, 90);
            lblVendedor.Margin = new Padding(4, 0, 4, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(86, 15);
            lblVendedor.TabIndex = 30;
            lblVendedor.Text = "Atendido por...";
            // 
            // frmNuevoPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1133, 678);
            Controls.Add(txtVendedor);
            Controls.Add(lblVendedor);
            Controls.Add(txtAfiliadoNro);
            Controls.Add(panelAgregar);
            Controls.Add(txtCliente);
            Controls.Add(lblNroAfiliado);
            Controls.Add(btnSalir);
            Controls.Add(panelTotalSubTotal);
            Controls.Add(panelCancelar);
            Controls.Add(panelAceptar);
            Controls.Add(panelPagos);
            Controls.Add(txtPresupNro);
            Controls.Add(lblPresupuestoNro);
            Controls.Add(panelPresupuesto);
            Controls.Add(dgvDetallePresup);
            Controls.Add(txtFecha);
            Controls.Add(panelDatosPersonales);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmNuevoPresupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Presupuesto";
            Load += frmNuevoPresupuesto_Load;
            panelDatosPersonales.ResumeLayout(false);
            panelDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePresup).EndInit();
            panelPresupuesto.ResumeLayout(false);
            panelPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            panelPagos.ResumeLayout(false);
            panelPagos.PerformLayout();
            panelAceptar.ResumeLayout(false);
            panelCancelar.ResumeLayout(false);
            panelTotalSubTotal.ResumeLayout(false);
            panelTotalSubTotal.PerformLayout();
            panelAgregar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDatosPersonales;
        private Label lblClienteBusqueda;
        private TextBox txtFecha;
        private DataGridView dgvDetallePresup;
        private Panel panelPresupuesto;
        private Label lblMedic;
        private ComboBox cboMedicamentos;
        private Label lblCantidad;
        private ComboBox cboObraSocial;
        private Label lblObSocial;
        private NumericUpDown numericUpDownCantidad;
        private CheckBox chkBoxReceta;
        private Label lblReceta;
        private Label lblPresupuestoNro;
        private TextBox txtPresupNro;
        private DataGridViewTextBoxColumn Col_idMedic;
        private DataGridViewTextBoxColumn Col_Medicamento;
        private DataGridViewTextBoxColumn Col_Cantidad;
        private DataGridViewTextBoxColumn Col_Precio;
        private DataGridViewButtonColumn Col_Quitar;
        private Panel panelPagos;
        private ComboBox cboFormaPago;
        private Label lblFormaPAgo;
        private ComboBox cboMedioPago;
        private Label lblMedioPago;
        private Label lblSubTotal;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnAceptar;
        private Panel panelAceptar;
        private Panel panelCancelar;
        private Button btnCancelar;
        private ComboBox cboFormaEntrega;
        private Label lblFormaEntrega;
        private Panel panelTotalSubTotal;
        private Button btnSalir;
        private Label lblNroAfiliado;
        private ComboBox cboBuscarClientes;
        private TextBox txtCliente;
        private Button btnAgregar;
        private Panel panelAgregar;
        private TextBox txtAfiliadoNro;
        private Button btnAceptarCliente;
        private ComboBox cboFarmaceutico;
        private Label lblFarmaceutico;
        private TextBox txtVendedor;
        private Label lblVendedor;
    }
}