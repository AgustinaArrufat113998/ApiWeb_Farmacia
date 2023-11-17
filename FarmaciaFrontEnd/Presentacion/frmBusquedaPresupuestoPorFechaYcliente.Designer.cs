namespace FrontEndFarmacia.Presentacion
{
    partial class frmBusquedaPresupuestoPorFechaYcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaPresupuestoPorFechaYcliente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtPickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDesde = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.lblInfoPresup = new System.Windows.Forms.Label();
            this.DgvBusquedaPresup = new System.Windows.Forms.DataGridView();
            this.Col_NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaPresup)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(27, 414);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 27);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelBusqueda.Controls.Add(this.lblFechaHasta);
            this.panelBusqueda.Controls.Add(this.lblFechaDesde);
            this.panelBusqueda.Controls.Add(this.dtPickerHasta);
            this.panelBusqueda.Controls.Add(this.dtPickerDesde);
            this.panelBusqueda.Controls.Add(this.lblBuscarCliente);
            this.panelBusqueda.Controls.Add(this.txtCliente);
            this.panelBusqueda.Location = new System.Drawing.Point(72, 32);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(546, 143);
            this.panelBusqueda.TabIndex = 21;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lblFechaHasta.Location = new System.Drawing.Point(262, 76);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(78, 15);
            this.lblFechaHasta.TabIndex = 26;
            this.lblFechaHasta.Text = "Fecha hasta...";
            this.lblFechaHasta.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.ForeColor = System.Drawing.Color.White;
            this.lblFechaDesde.Location = new System.Drawing.Point(259, 18);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(81, 15);
            this.lblFechaDesde.TabIndex = 25;
            this.lblFechaDesde.Text = "Fecha desde...";
            // 
            // dtPickerHasta
            // 
            this.dtPickerHasta.Location = new System.Drawing.Point(266, 95);
            this.dtPickerHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPickerHasta.Name = "dtPickerHasta";
            this.dtPickerHasta.Size = new System.Drawing.Size(251, 23);
            this.dtPickerHasta.TabIndex = 24;
            // 
            // dtPickerDesde
            // 
            this.dtPickerDesde.Location = new System.Drawing.Point(266, 37);
            this.dtPickerDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPickerDesde.Name = "dtPickerDesde";
            this.dtPickerDesde.Size = new System.Drawing.Size(251, 23);
            this.dtPickerDesde.TabIndex = 23;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCliente.Location = new System.Drawing.Point(27, 45);
            this.lblBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(53, 15);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Cliente...";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(30, 63);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(156, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // panelIcono
            // 
            this.panelIcono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcono.BackgroundImage")));
            this.panelIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelIcono.Location = new System.Drawing.Point(27, 29);
            this.panelIcono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(79, 76);
            this.panelIcono.TabIndex = 20;
            // 
            // lblInfoPresup
            // 
            this.lblInfoPresup.AutoSize = true;
            this.lblInfoPresup.BackColor = System.Drawing.Color.White;
            this.lblInfoPresup.ForeColor = System.Drawing.Color.Green;
            this.lblInfoPresup.Location = new System.Drawing.Point(31, 203);
            this.lblInfoPresup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoPresup.Name = "lblInfoPresup";
            this.lblInfoPresup.Size = new System.Drawing.Size(105, 15);
            this.lblInfoPresup.TabIndex = 19;
            this.lblInfoPresup.Text = "Info Presupuesto...";
            // 
            // DgvBusquedaPresup
            // 
            this.DgvBusquedaPresup.AllowUserToAddRows = false;
            this.DgvBusquedaPresup.AllowUserToDeleteRows = false;
            this.DgvBusquedaPresup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DgvBusquedaPresup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaPresup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_NroFactura,
            this.Col_Fecha,
            this.Col_Apellido,
            this.Col_PrecioTotal,
            this.Col_ObraSocial});
            this.DgvBusquedaPresup.Location = new System.Drawing.Point(35, 222);
            this.DgvBusquedaPresup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvBusquedaPresup.Name = "DgvBusquedaPresup";
            this.DgvBusquedaPresup.ReadOnly = true;
            this.DgvBusquedaPresup.Size = new System.Drawing.Size(635, 100);
            this.DgvBusquedaPresup.TabIndex = 18;
            // 
            // Col_NroFactura
            // 
            this.Col_NroFactura.HeaderText = "N° Factura";
            this.Col_NroFactura.Name = "Col_NroFactura";
            this.Col_NroFactura.ReadOnly = true;
            // 
            // Col_Fecha
            // 
            this.Col_Fecha.HeaderText = "Fecha";
            this.Col_Fecha.Name = "Col_Fecha";
            this.Col_Fecha.ReadOnly = true;
            // 
            // Col_Apellido
            // 
            this.Col_Apellido.HeaderText = "Apellido";
            this.Col_Apellido.Name = "Col_Apellido";
            this.Col_Apellido.ReadOnly = true;
            // 
            // Col_PrecioTotal
            // 
            this.Col_PrecioTotal.HeaderText = "Precio Total $";
            this.Col_PrecioTotal.Name = "Col_PrecioTotal";
            this.Col_PrecioTotal.ReadOnly = true;
            // 
            // Col_ObraSocial
            // 
            this.Col_ObraSocial.HeaderText = "Obra Social";
            this.Col_ObraSocial.Name = "Col_ObraSocial";
            this.Col_ObraSocial.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(477, 414);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(631, 414);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(88, 27);
            this.btnAnular.TabIndex = 24;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(315, 414);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(88, 27);
            this.btnAbrir.TabIndex = 25;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Menu;
            this.panelFondo.Controls.Add(this.panelBusqueda);
            this.panelFondo.Controls.Add(this.lblInfoPresup);
            this.panelFondo.Controls.Add(this.DgvBusquedaPresup);
            this.panelFondo.Location = new System.Drawing.Point(176, 29);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(705, 354);
            this.panelFondo.TabIndex = 27;
            // 
            // frmBusquedaPresupuestoPorFechaYcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelIcono);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBusquedaPresupuestoPorFechaYcliente";
            this.Text = "Buscar Presupuesto...";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaPresup)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Label lblInfoPresup;
        private System.Windows.Forms.DataGridView DgvBusquedaPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ObraSocial;
        private System.Windows.Forms.DateTimePicker dtPickerDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtPickerHasta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Panel panelFondo;
    }
}