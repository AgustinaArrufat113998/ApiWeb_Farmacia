namespace FrontEndFarmacia.Presentacion
{
    partial class frmBusquedaPresupuestoPorNroPresup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaPresupuestoPorNroPresup));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNroPresupuesto = new System.Windows.Forms.Label();
            this.txtNroPresup = new System.Windows.Forms.TextBox();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.DgvBusquedaPresupNro = new System.Windows.Forms.DataGridView();
            this.Col_NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosVenta = new System.Windows.Forms.Label();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaPresupNro)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(331, 449);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(88, 27);
            this.btnAbrir.TabIndex = 33;
            this.btnAbrir.Text = "Consultar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(646, 449);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(88, 27);
            this.btnAnular.TabIndex = 32;
            this.btnAnular.Text = "Eliminar";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(489, 449);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(31, 449);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.lblNroPresupuesto);
            this.panelBusqueda.Controls.Add(this.txtNroPresup);
            this.panelBusqueda.Location = new System.Drawing.Point(85, 53);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(500, 172);
            this.panelBusqueda.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNroPresupuesto
            // 
            this.lblNroPresupuesto.AutoSize = true;
            this.lblNroPresupuesto.ForeColor = System.Drawing.Color.White;
            this.lblNroPresupuesto.Location = new System.Drawing.Point(107, 72);
            this.lblNroPresupuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroPresupuesto.Name = "lblNroPresupuesto";
            this.lblNroPresupuesto.Size = new System.Drawing.Size(98, 15);
            this.lblNroPresupuesto.TabIndex = 0;
            this.lblNroPresupuesto.Text = "Presupuesto N°...";
            // 
            // txtNroPresup
            // 
            this.txtNroPresup.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNroPresup.Location = new System.Drawing.Point(213, 69);
            this.txtNroPresup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNroPresup.Name = "txtNroPresup";
            this.txtNroPresup.Size = new System.Drawing.Size(60, 23);
            this.txtNroPresup.TabIndex = 1;
            // 
            // panelIcono
            // 
            this.panelIcono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcono.BackgroundImage")));
            this.panelIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelIcono.Location = new System.Drawing.Point(31, 29);
            this.panelIcono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(79, 76);
            this.panelIcono.TabIndex = 28;
            // 
            // DgvBusquedaPresupNro
            // 
            this.DgvBusquedaPresupNro.AllowUserToAddRows = false;
            this.DgvBusquedaPresupNro.AllowUserToDeleteRows = false;
            this.DgvBusquedaPresupNro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DgvBusquedaPresupNro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaPresupNro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_NroFactura,
            this.Col_Fecha,
            this.Col_Cliente,
            this.Col_PrecioTotal,
            this.Col_Vendedor});
            this.DgvBusquedaPresupNro.Location = new System.Drawing.Point(20, 278);
            this.DgvBusquedaPresupNro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvBusquedaPresupNro.Name = "DgvBusquedaPresupNro";
            this.DgvBusquedaPresupNro.ReadOnly = true;
            this.DgvBusquedaPresupNro.Size = new System.Drawing.Size(635, 98);
            this.DgvBusquedaPresupNro.TabIndex = 26;
            // 
            // Col_NroFactura
            // 
            this.Col_NroFactura.HeaderText = "N° Presupuesto";
            this.Col_NroFactura.Name = "Col_NroFactura";
            this.Col_NroFactura.ReadOnly = true;
            this.Col_NroFactura.Width = 120;
            // 
            // Col_Fecha
            // 
            this.Col_Fecha.HeaderText = "Fecha";
            this.Col_Fecha.Name = "Col_Fecha";
            this.Col_Fecha.ReadOnly = true;
            // 
            // Col_Cliente
            // 
            this.Col_Cliente.HeaderText = "Cliente";
            this.Col_Cliente.Name = "Col_Cliente";
            this.Col_Cliente.ReadOnly = true;
            // 
            // Col_PrecioTotal
            // 
            this.Col_PrecioTotal.HeaderText = "Precio Total $";
            this.Col_PrecioTotal.Name = "Col_PrecioTotal";
            this.Col_PrecioTotal.ReadOnly = true;
            // 
            // Col_Vendedor
            // 
            this.Col_Vendedor.HeaderText = "Vendedor";
            this.Col_Vendedor.Name = "Col_Vendedor";
            this.Col_Vendedor.ReadOnly = true;
            // 
            // lblDatosVenta
            // 
            this.lblDatosVenta.AutoSize = true;
            this.lblDatosVenta.ForeColor = System.Drawing.Color.Green;
            this.lblDatosVenta.Location = new System.Drawing.Point(16, 260);
            this.lblDatosVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosVenta.Name = "lblDatosVenta";
            this.lblDatosVenta.Size = new System.Drawing.Size(105, 15);
            this.lblDatosVenta.TabIndex = 34;
            this.lblDatosVenta.Text = "Info Presupuesto...";
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Menu;
            this.panelFondo.Controls.Add(this.lblDatosVenta);
            this.panelFondo.Controls.Add(this.panelBusqueda);
            this.panelFondo.Controls.Add(this.DgvBusquedaPresupNro);
            this.panelFondo.Location = new System.Drawing.Point(195, 29);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(671, 397);
            this.panelFondo.TabIndex = 35;
            // 
            // frmBusquedaPresupuestoPorNroPresup
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
            this.Name = "frmBusquedaPresupuestoPorNroPresup";
            this.Text = "Buscar Presupuesto...";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaPresupNro)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrir;
        private Button btnAnular;
        private Button btnEditar;
        private Button btnSalir;
        private Panel panelBusqueda;
        private Label lblNroPresupuesto;
        private TextBox txtNroPresup;
        private Panel panelIcono;
        private DataGridView DgvBusquedaPresupNro;
        private Label lblDatosVenta;
        private Panel panelFondo;
        private DataGridViewTextBoxColumn Col_NroFactura;
        private DataGridViewTextBoxColumn Col_Fecha;
        private DataGridViewTextBoxColumn Col_Cliente;
        private DataGridViewTextBoxColumn Col_PrecioTotal;
        private DataGridViewTextBoxColumn Col_Vendedor;
        private Button btnBuscar;
    }
}