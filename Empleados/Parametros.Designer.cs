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
            this.dateTimeFechaDep = new System.Windows.Forms.DateTimePicker();
            this.fechaDepreciacion = new System.Windows.Forms.Label();
            this.cmbMetodoDeprec = new System.Windows.Forms.ComboBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.btnEliminarParametro = new System.Windows.Forms.Button();
            this.btnGuardarParametro = new System.Windows.Forms.Button();
            this.metodoDepreciacion = new System.Windows.Forms.Label();
            this.RNCParametro = new System.Windows.Forms.Label();
            this.depreciacionCalculada = new System.Windows.Forms.Label();
            this.añoProcesoParametro = new System.Windows.Forms.Label();
            this.dgvParametro = new System.Windows.Forms.DataGridView();
            this.txtBuscarParametro = new System.Windows.Forms.TextBox();
            this.btnBuscarParametro = new System.Windows.Forms.Button();
            this.cmbDepCalculada = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbDepCalculada);
            this.panel1.Controls.Add(this.dateTimeFechaDep);
            this.panel1.Controls.Add(this.fechaDepreciacion);
            this.panel1.Controls.Add(this.cmbMetodoDeprec);
            this.panel1.Controls.Add(this.txtRNC);
            this.panel1.Controls.Add(this.btnEliminarParametro);
            this.panel1.Controls.Add(this.btnGuardarParametro);
            this.panel1.Controls.Add(this.metodoDepreciacion);
            this.panel1.Controls.Add(this.RNCParametro);
            this.panel1.Controls.Add(this.depreciacionCalculada);
            this.panel1.Controls.Add(this.añoProcesoParametro);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 331);
            this.panel1.TabIndex = 4;
            // 
            // dateTimeFechaDep
            // 
            this.dateTimeFechaDep.Location = new System.Drawing.Point(155, 60);
            this.dateTimeFechaDep.Name = "dateTimeFechaDep";
            this.dateTimeFechaDep.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaDep.TabIndex = 24;
            // 
            // fechaDepreciacion
            // 
            this.fechaDepreciacion.AutoSize = true;
            this.fechaDepreciacion.Location = new System.Drawing.Point(31, 60);
            this.fechaDepreciacion.Name = "fechaDepreciacion";
            this.fechaDepreciacion.Size = new System.Drawing.Size(118, 13);
            this.fechaDepreciacion.TabIndex = 23;
            this.fechaDepreciacion.Text = "Fecha de Depreciación";
            this.fechaDepreciacion.Click += new System.EventHandler(this.fechaDepreciacion_Click);
            // 
            // cmbMetodoDeprec
            // 
            this.cmbMetodoDeprec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoDeprec.FormattingEnabled = true;
            this.cmbMetodoDeprec.Items.AddRange(new object[] {
            "Línea Recta",
            "Digito de años"});
            this.cmbMetodoDeprec.Location = new System.Drawing.Point(157, 170);
            this.cmbMetodoDeprec.Name = "cmbMetodoDeprec";
            this.cmbMetodoDeprec.Size = new System.Drawing.Size(100, 21);
            this.cmbMetodoDeprec.TabIndex = 21;
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(157, 96);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(100, 20);
            this.txtRNC.TabIndex = 19;
            // 
            // btnEliminarParametro
            // 
            this.btnEliminarParametro.Location = new System.Drawing.Point(227, 252);
            this.btnEliminarParametro.Name = "btnEliminarParametro";
            this.btnEliminarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarParametro.TabIndex = 18;
            this.btnEliminarParametro.Text = "Eliminar";
            this.btnEliminarParametro.UseVisualStyleBackColor = true;
            this.btnEliminarParametro.Click += new System.EventHandler(this.btnEliminarParametro_Click);
            // 
            // btnGuardarParametro
            // 
            this.btnGuardarParametro.Location = new System.Drawing.Point(56, 252);
            this.btnGuardarParametro.Name = "btnGuardarParametro";
            this.btnGuardarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarParametro.TabIndex = 16;
            this.btnGuardarParametro.Text = "Guardar";
            this.btnGuardarParametro.UseVisualStyleBackColor = true;
            this.btnGuardarParametro.Click += new System.EventHandler(this.btnGuardarParametro_Click);
            // 
            // metodoDepreciacion
            // 
            this.metodoDepreciacion.AutoSize = true;
            this.metodoDepreciacion.Location = new System.Drawing.Point(31, 178);
            this.metodoDepreciacion.Name = "metodoDepreciacion";
            this.metodoDepreciacion.Size = new System.Drawing.Size(109, 13);
            this.metodoDepreciacion.TabIndex = 12;
            this.metodoDepreciacion.Text = "Método Depreciación";
            // 
            // RNCParametro
            // 
            this.RNCParametro.AutoSize = true;
            this.RNCParametro.Location = new System.Drawing.Point(37, 96);
            this.RNCParametro.Name = "RNCParametro";
            this.RNCParametro.Size = new System.Drawing.Size(30, 13);
            this.RNCParametro.TabIndex = 10;
            this.RNCParametro.Text = "RNC";
            this.RNCParametro.Click += new System.EventHandler(this.tipoPersonaProveedor_Click);
            // 
            // depreciacionCalculada
            // 
            this.depreciacionCalculada.AutoSize = true;
            this.depreciacionCalculada.Location = new System.Drawing.Point(31, 134);
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
            this.añoProcesoParametro.Size = new System.Drawing.Size(0, 13);
            this.añoProcesoParametro.TabIndex = 2;
            // 
            // dgvParametro
            // 
            this.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametro.Location = new System.Drawing.Point(440, 38);
            this.dgvParametro.Name = "dgvParametro";
            this.dgvParametro.Size = new System.Drawing.Size(591, 318);
            this.dgvParametro.TabIndex = 5;
            this.dgvParametro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametro_CellContentClick);
            // 
            // txtBuscarParametro
            // 
            this.txtBuscarParametro.Location = new System.Drawing.Point(440, 12);
            this.txtBuscarParametro.Name = "txtBuscarParametro";
            this.txtBuscarParametro.Size = new System.Drawing.Size(500, 20);
            this.txtBuscarParametro.TabIndex = 22;
            // 
            // btnBuscarParametro
            // 
            this.btnBuscarParametro.Location = new System.Drawing.Point(956, 9);
            this.btnBuscarParametro.Name = "btnBuscarParametro";
            this.btnBuscarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarParametro.TabIndex = 23;
            this.btnBuscarParametro.Text = "Buscar";
            this.btnBuscarParametro.UseVisualStyleBackColor = true;
            this.btnBuscarParametro.Click += new System.EventHandler(this.btnBuscarParametro_Click_1);
            // 
            // cmbDepCalculada
            // 
            this.cmbDepCalculada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepCalculada.FormattingEnabled = true;
            this.cmbDepCalculada.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbDepCalculada.Location = new System.Drawing.Point(157, 131);
            this.cmbDepCalculada.Name = "cmbDepCalculada";
            this.cmbDepCalculada.Size = new System.Drawing.Size(100, 21);
            this.cmbDepCalculada.TabIndex = 25;
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 383);
            this.Controls.Add(this.btnBuscarParametro);
            this.Controls.Add(this.txtBuscarParametro);
            this.Controls.Add(this.dgvParametro);
            this.Controls.Add(this.panel1);
            this.Name = "Parametros";
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.Parametros_Load);
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
        private System.Windows.Forms.Button btnGuardarParametro;
        private System.Windows.Forms.Label metodoDepreciacion;
        private System.Windows.Forms.Label RNCParametro;
        private System.Windows.Forms.Label depreciacionCalculada;
        private System.Windows.Forms.Label añoProcesoParametro;
        private System.Windows.Forms.ComboBox cmbMetodoDeprec;
        private System.Windows.Forms.DataGridView dgvParametro;
        private System.Windows.Forms.TextBox txtBuscarParametro;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDep;
        private System.Windows.Forms.Label fechaDepreciacion;
        private System.Windows.Forms.Button btnBuscarParametro;
        private System.Windows.Forms.ComboBox cmbDepCalculada;
    }
}