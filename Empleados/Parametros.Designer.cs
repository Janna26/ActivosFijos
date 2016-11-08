namespace Mantenimientos
{
    partial class Parametros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMetodoDeprec = new System.Windows.Forms.ComboBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.btnEliminarParametro = new System.Windows.Forms.Button();
            this.btnBuscarParametro = new System.Windows.Forms.Button();
            this.btnGuardarParametro = new System.Windows.Forms.Button();
            this.metodoDepreciacion = new System.Windows.Forms.Label();
            this.RNCParametro = new System.Windows.Forms.Label();
            this.txtMesProceso = new System.Windows.Forms.TextBox();
            this.mesProcesoParametro = new System.Windows.Forms.Label();
            this.txtNAnoProceso = new System.Windows.Forms.TextBox();
            this.depreciacionCalculada = new System.Windows.Forms.Label();
            this.añoProcesoParametro = new System.Windows.Forms.Label();
            this.dgvParametro = new System.Windows.Forms.DataGridView();
            this.txtBuscarParametro = new System.Windows.Forms.TextBox();
            this.txtDepParametro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDepParametro);
            this.panel1.Controls.Add(this.cmbMetodoDeprec);
            this.panel1.Controls.Add(this.txtRNC);
            this.panel1.Controls.Add(this.btnEliminarParametro);
            this.panel1.Controls.Add(this.btnGuardarParametro);
            this.panel1.Controls.Add(this.metodoDepreciacion);
            this.panel1.Controls.Add(this.RNCParametro);
            this.panel1.Controls.Add(this.txtMesProceso);
            this.panel1.Controls.Add(this.mesProcesoParametro);
            this.panel1.Controls.Add(this.txtNAnoProceso);
            this.panel1.Controls.Add(this.depreciacionCalculada);
            this.panel1.Controls.Add(this.añoProcesoParametro);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 352);
            this.panel1.TabIndex = 4;
            // 
            // cmbMetodoDeprec
            // 
            this.cmbMetodoDeprec.FormattingEnabled = true;
            this.cmbMetodoDeprec.Items.AddRange(new object[] {
            "Línea Recta",
            "Digito de años"});
            this.cmbMetodoDeprec.Location = new System.Drawing.Point(138, 220);
            this.cmbMetodoDeprec.Name = "cmbMetodoDeprec";
            this.cmbMetodoDeprec.Size = new System.Drawing.Size(100, 21);
            this.cmbMetodoDeprec.TabIndex = 21;
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(138, 146);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(100, 20);
            this.txtRNC.TabIndex = 19;
            // 
            // btnEliminarParametro
            // 
            this.btnEliminarParametro.Location = new System.Drawing.Point(208, 302);
            this.btnEliminarParametro.Name = "btnEliminarParametro";
            this.btnEliminarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarParametro.TabIndex = 18;
            this.btnEliminarParametro.Text = "Eliminar";
            this.btnEliminarParametro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarParametro
            // 
            this.btnBuscarParametro.Location = new System.Drawing.Point(998, 9);
            this.btnBuscarParametro.Name = "btnBuscarParametro";
            this.btnBuscarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarParametro.TabIndex = 17;
            this.btnBuscarParametro.Text = "Buscar";
            this.btnBuscarParametro.UseVisualStyleBackColor = true;
            this.btnBuscarParametro.Click += new System.EventHandler(this.btnBuscarParametro_Click);
            // 
            // btnGuardarParametro
            // 
            this.btnGuardarParametro.Location = new System.Drawing.Point(37, 302);
            this.btnGuardarParametro.Name = "btnGuardarParametro";
            this.btnGuardarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarParametro.TabIndex = 16;
            this.btnGuardarParametro.Text = "Guardar";
            this.btnGuardarParametro.UseVisualStyleBackColor = true;
            // 
            // metodoDepreciacion
            // 
            this.metodoDepreciacion.AutoSize = true;
            this.metodoDepreciacion.Location = new System.Drawing.Point(12, 228);
            this.metodoDepreciacion.Name = "metodoDepreciacion";
            this.metodoDepreciacion.Size = new System.Drawing.Size(109, 13);
            this.metodoDepreciacion.TabIndex = 12;
            this.metodoDepreciacion.Text = "Método Depreciación";
            // 
            // RNCParametro
            // 
            this.RNCParametro.AutoSize = true;
            this.RNCParametro.Location = new System.Drawing.Point(18, 146);
            this.RNCParametro.Name = "RNCParametro";
            this.RNCParametro.Size = new System.Drawing.Size(30, 13);
            this.RNCParametro.TabIndex = 10;
            this.RNCParametro.Text = "RNC";
            this.RNCParametro.Click += new System.EventHandler(this.tipoPersonaProveedor_Click);
            // 
            // txtMesProceso
            // 
            this.txtMesProceso.Location = new System.Drawing.Point(138, 96);
            this.txtMesProceso.Name = "txtMesProceso";
            this.txtMesProceso.Size = new System.Drawing.Size(100, 20);
            this.txtMesProceso.TabIndex = 7;
            // 
            // mesProcesoParametro
            // 
            this.mesProcesoParametro.AutoSize = true;
            this.mesProcesoParametro.Location = new System.Drawing.Point(18, 103);
            this.mesProcesoParametro.Name = "mesProcesoParametro";
            this.mesProcesoParametro.Size = new System.Drawing.Size(69, 13);
            this.mesProcesoParametro.TabIndex = 6;
            this.mesProcesoParametro.Text = "Mes Proceso";
            // 
            // txtNAnoProceso
            // 
            this.txtNAnoProceso.Location = new System.Drawing.Point(138, 58);
            this.txtNAnoProceso.Name = "txtNAnoProceso";
            this.txtNAnoProceso.Size = new System.Drawing.Size(100, 20);
            this.txtNAnoProceso.TabIndex = 4;
            // 
            // depreciacionCalculada
            // 
            this.depreciacionCalculada.AutoSize = true;
            this.depreciacionCalculada.Location = new System.Drawing.Point(12, 184);
            this.depreciacionCalculada.Name = "depreciacionCalculada";
            this.depreciacionCalculada.Size = new System.Drawing.Size(120, 13);
            this.depreciacionCalculada.TabIndex = 3;
            this.depreciacionCalculada.Text = "Depreciación Calculada";
            // 
            // añoProcesoParametro
            // 
            this.añoProcesoParametro.AutoSize = true;
            this.añoProcesoParametro.Location = new System.Drawing.Point(19, 61);
            this.añoProcesoParametro.Name = "añoProcesoParametro";
            this.añoProcesoParametro.Size = new System.Drawing.Size(68, 13);
            this.añoProcesoParametro.TabIndex = 2;
            this.añoProcesoParametro.Text = "Año Proceso";
            // 
            // dgvParametro
            // 
            this.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametro.Location = new System.Drawing.Point(492, 46);
            this.dgvParametro.Name = "dgvParametro";
            this.dgvParametro.Size = new System.Drawing.Size(577, 318);
            this.dgvParametro.TabIndex = 5;
            this.dgvParametro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametro_CellContentClick);
            // 
            // txtBuscarParametro
            // 
            this.txtBuscarParametro.Location = new System.Drawing.Point(492, 12);
            this.txtBuscarParametro.Name = "txtBuscarParametro";
            this.txtBuscarParametro.Size = new System.Drawing.Size(500, 20);
            this.txtBuscarParametro.TabIndex = 22;
            // 
            // txtDepParametro
            // 
            this.txtDepParametro.Location = new System.Drawing.Point(138, 181);
            this.txtDepParametro.Name = "txtDepParametro";
            this.txtDepParametro.Size = new System.Drawing.Size(100, 20);
            this.txtDepParametro.TabIndex = 22;
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 387);
            this.Controls.Add(this.txtBuscarParametro);
            this.Controls.Add(this.dgvParametro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarParametro);
            this.Name = "Parametros";
            this.Text = "Parametros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.Button btnEliminarParametro;
        private System.Windows.Forms.Button btnBuscarParametro;
        private System.Windows.Forms.Button btnGuardarParametro;
        private System.Windows.Forms.Label metodoDepreciacion;
        private System.Windows.Forms.Label RNCParametro;
        private System.Windows.Forms.TextBox txtMesProceso;
        private System.Windows.Forms.Label mesProcesoParametro;
        private System.Windows.Forms.TextBox txtNAnoProceso;
        private System.Windows.Forms.Label depreciacionCalculada;
        private System.Windows.Forms.Label añoProcesoParametro;
        private System.Windows.Forms.ComboBox cmbMetodoDeprec;
        private System.Windows.Forms.DataGridView dgvParametro;
        private System.Windows.Forms.TextBox txtBuscarParametro;
        private System.Windows.Forms.TextBox txtDepParametro;
    }
}