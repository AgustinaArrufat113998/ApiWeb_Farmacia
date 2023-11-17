namespace FrontEndFarmacia
{
    partial class frmBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClientes));
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.DgvBusquedaClientes = new System.Windows.Forms.DataGridView();
            this.Col_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DniCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaClientes)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCliente.Location = new System.Drawing.Point(16, 24);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(48, 13);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Cliente...";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCliente.Location = new System.Drawing.Point(19, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(154, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // DgvBusquedaClientes
            // 
            this.DgvBusquedaClientes.AllowUserToAddRows = false;
            this.DgvBusquedaClientes.AllowUserToDeleteRows = false;
            this.DgvBusquedaClientes.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DgvBusquedaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Apellido,
            this.Col_Nombre,
            this.Col_DniCuil,
            this.Col_ObraSocial,
            this.Col_Telefono});
            this.DgvBusquedaClientes.Location = new System.Drawing.Point(229, 61);
            this.DgvBusquedaClientes.Name = "DgvBusquedaClientes";
            this.DgvBusquedaClientes.ReadOnly = true;
            this.DgvBusquedaClientes.Size = new System.Drawing.Size(564, 305);
            this.DgvBusquedaClientes.TabIndex = 2;
            // 
            // Col_Apellido
            // 
            this.Col_Apellido.HeaderText = "Apellido";
            this.Col_Apellido.Name = "Col_Apellido";
            this.Col_Apellido.ReadOnly = true;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            // 
            // Col_DniCuil
            // 
            this.Col_DniCuil.HeaderText = "Dni/Cuil";
            this.Col_DniCuil.Name = "Col_DniCuil";
            this.Col_DniCuil.ReadOnly = true;
            // 
            // Col_ObraSocial
            // 
            this.Col_ObraSocial.HeaderText = "Obra Social";
            this.Col_ObraSocial.Name = "Col_ObraSocial";
            this.Col_ObraSocial.ReadOnly = true;
            // 
            // Col_Telefono
            // 
            this.Col_Telefono.HeaderText = "Telefono";
            this.Col_Telefono.Name = "Col_Telefono";
            this.Col_Telefono.ReadOnly = true;
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.AutoSize = true;
            this.lblInfoCliente.ForeColor = System.Drawing.Color.White;
            this.lblInfoCliente.Location = new System.Drawing.Point(226, 32);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Size = new System.Drawing.Size(69, 13);
            this.lblInfoCliente.TabIndex = 3;
            this.lblInfoCliente.Text = "Info Cliente...";
            // 
            // panelIcono
            // 
            this.panelIcono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcono.BackgroundImage")));
            this.panelIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelIcono.Location = new System.Drawing.Point(33, 32);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(71, 65);
            this.panelIcono.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(19, 94);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(154, 23);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Listar todos los Clientes...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelBusqueda.Controls.Add(this.lblBuscarCliente);
            this.panelBusqueda.Controls.Add(this.btnBuscarCliente);
            this.panelBusqueda.Controls.Add(this.txtCliente);
            this.panelBusqueda.Location = new System.Drawing.Point(14, 136);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(188, 148);
            this.panelBusqueda.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(14, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(826, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelIcono);
            this.Controls.Add(this.lblInfoCliente);
            this.Controls.Add(this.DgvBusquedaClientes);
            this.Name = "frmBuscarClientes";
            this.Text = "Buscar Clientes...";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaClientes)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView DgvBusquedaClientes;
        private System.Windows.Forms.Label lblInfoCliente;
        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DniCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Telefono;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button btnSalir;
    }
}