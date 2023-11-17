namespace FrontEndFarmacia
{
    partial class frmBusquedaMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaMedicamentos));
            this.panelIcono = new System.Windows.Forms.Panel();
            this.btnBuscarMedicamentos = new System.Windows.Forms.Button();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblBuscarMedicamentos = new System.Windows.Forms.Label();
            this.DgvBusquedaMedicamento = new System.Windows.Forms.DataGridView();
            this.Col_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BajoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosObraSocial = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaMedicamento)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcono
            // 
            this.panelIcono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcono.BackgroundImage")));
            this.panelIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelIcono.Location = new System.Drawing.Point(35, 31);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(77, 69);
            this.panelIcono.TabIndex = 0;
            // 
            // btnBuscarMedicamentos
            // 
            this.btnBuscarMedicamentos.Location = new System.Drawing.Point(19, 97);
            this.btnBuscarMedicamentos.Name = "btnBuscarMedicamentos";
            this.btnBuscarMedicamentos.Size = new System.Drawing.Size(154, 37);
            this.btnBuscarMedicamentos.TabIndex = 8;
            this.btnBuscarMedicamentos.Text = "         Listar todas las              Obras Sociales...";
            this.btnBuscarMedicamentos.UseVisualStyleBackColor = true;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(19, 46);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(154, 20);
            this.txtMedicamento.TabIndex = 7;
            // 
            // lblBuscarMedicamentos
            // 
            this.lblBuscarMedicamentos.AutoSize = true;
            this.lblBuscarMedicamentos.ForeColor = System.Drawing.Color.White;
            this.lblBuscarMedicamentos.Location = new System.Drawing.Point(16, 21);
            this.lblBuscarMedicamentos.Name = "lblBuscarMedicamentos";
            this.lblBuscarMedicamentos.Size = new System.Drawing.Size(71, 13);
            this.lblBuscarMedicamentos.TabIndex = 6;
            this.lblBuscarMedicamentos.Text = "Obra Social...";
            // 
            // DgvBusquedaMedicamento
            // 
            this.DgvBusquedaMedicamento.AllowUserToAddRows = false;
            this.DgvBusquedaMedicamento.AllowUserToDeleteRows = false;
            this.DgvBusquedaMedicamento.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DgvBusquedaMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Medicamento,
            this.Col_Presentacion,
            this.Col_BajoReceta,
            this.Col_Laboratorio,
            this.Col_Vencimiento,
            this.Col_Stock});
            this.DgvBusquedaMedicamento.Location = new System.Drawing.Point(231, 58);
            this.DgvBusquedaMedicamento.Name = "DgvBusquedaMedicamento";
            this.DgvBusquedaMedicamento.ReadOnly = true;
            this.DgvBusquedaMedicamento.Size = new System.Drawing.Size(564, 305);
            this.DgvBusquedaMedicamento.TabIndex = 9;
            // 
            // Col_Medicamento
            // 
            this.Col_Medicamento.HeaderText = "Medicamento";
            this.Col_Medicamento.Name = "Col_Medicamento";
            this.Col_Medicamento.ReadOnly = true;
            // 
            // Col_Presentacion
            // 
            this.Col_Presentacion.HeaderText = "Presentacion";
            this.Col_Presentacion.Name = "Col_Presentacion";
            this.Col_Presentacion.ReadOnly = true;
            // 
            // Col_BajoReceta
            // 
            this.Col_BajoReceta.HeaderText = "Bajo Receta";
            this.Col_BajoReceta.Name = "Col_BajoReceta";
            this.Col_BajoReceta.ReadOnly = true;
            // 
            // Col_Laboratorio
            // 
            this.Col_Laboratorio.HeaderText = "Laboratorio";
            this.Col_Laboratorio.Name = "Col_Laboratorio";
            this.Col_Laboratorio.ReadOnly = true;
            // 
            // Col_Vencimiento
            // 
            this.Col_Vencimiento.HeaderText = "Vencimiento";
            this.Col_Vencimiento.Name = "Col_Vencimiento";
            this.Col_Vencimiento.ReadOnly = true;
            // 
            // Col_Stock
            // 
            this.Col_Stock.HeaderText = "Stock";
            this.Col_Stock.Name = "Col_Stock";
            this.Col_Stock.ReadOnly = true;
            // 
            // lblDatosObraSocial
            // 
            this.lblDatosObraSocial.AutoSize = true;
            this.lblDatosObraSocial.ForeColor = System.Drawing.Color.White;
            this.lblDatosObraSocial.Location = new System.Drawing.Point(228, 31);
            this.lblDatosObraSocial.Name = "lblDatosObraSocial";
            this.lblDatosObraSocial.Size = new System.Drawing.Size(106, 13);
            this.lblDatosObraSocial.TabIndex = 4;
            this.lblDatosObraSocial.Text = "Info Medicamentos...";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelBusqueda.Controls.Add(this.lblBuscarMedicamentos);
            this.panelBusqueda.Controls.Add(this.txtMedicamento);
            this.panelBusqueda.Controls.Add(this.btnBuscarMedicamentos);
            this.panelBusqueda.Location = new System.Drawing.Point(23, 139);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(188, 156);
            this.panelBusqueda.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(23, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(826, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.lblDatosObraSocial);
            this.Controls.Add(this.DgvBusquedaMedicamento);
            this.Controls.Add(this.panelIcono);
            this.Name = "frmBusquedaMedicamentos";
            this.Text = "   Buscar Medicamentos...";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaMedicamento)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Button btnBuscarMedicamentos;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblBuscarMedicamentos;
        private System.Windows.Forms.DataGridView DgvBusquedaMedicamento;
        private System.Windows.Forms.Label lblDatosObraSocial;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BajoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Stock;
    }
}