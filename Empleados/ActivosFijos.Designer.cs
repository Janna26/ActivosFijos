namespace Mantenimientos
{
    partial class ActivosFijos
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
            this.btnEliminarActivo = new System.Windows.Forms.Button();
            this.btnGuardarActivo = new System.Windows.Forms.Button();
            this.txtDepAcumAF = new System.Windows.Forms.TextBox();
            this.txtValorCompraActivoF = new System.Windows.Forms.TextBox();
            this.dateTimeActivoF = new System.Windows.Forms.DateTimePicker();
            this.cmbTAcAF = new System.Windows.Forms.ComboBox();
            this.cmbUbicActivoF = new System.Windows.Forms.ComboBox();
            this.cmbDeptActivoF = new System.Windows.Forms.ComboBox();
            this.cmbDescActivoF = new System.Windows.Forms.ComboBox();
            this.valorCompra = new System.Windows.Forms.Label();
            this.fechaRegistro = new System.Windows.Forms.Label();
            this.tipoActivo = new System.Windows.Forms.Label();
            this.DepAcumulada = new System.Windows.Forms.Label();
            this.Ubicacion = new System.Windows.Forms.Label();
            this.Departamento = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtIdActivoF = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.txtBuscarActivoF = new System.Windows.Forms.TextBox();
            this.btnBuscarActivoF = new System.Windows.Forms.Button();
            this.dgvActivosFijos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosFijos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarActivo);
            this.panel1.Controls.Add(this.btnGuardarActivo);
            this.panel1.Controls.Add(this.txtDepAcumAF);
            this.panel1.Controls.Add(this.txtValorCompraActivoF);
            this.panel1.Controls.Add(this.dateTimeActivoF);
            this.panel1.Controls.Add(this.cmbTAcAF);
            this.panel1.Controls.Add(this.cmbUbicActivoF);
            this.panel1.Controls.Add(this.cmbDeptActivoF);
            this.panel1.Controls.Add(this.cmbDescActivoF);
            this.panel1.Controls.Add(this.valorCompra);
            this.panel1.Controls.Add(this.fechaRegistro);
            this.panel1.Controls.Add(this.tipoActivo);
            this.panel1.Controls.Add(this.DepAcumulada);
            this.panel1.Controls.Add(this.Ubicacion);
            this.panel1.Controls.Add(this.Departamento);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.txtIdActivoF);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEliminarActivo
            // 
            this.btnEliminarActivo.Location = new System.Drawing.Point(223, 358);
            this.btnEliminarActivo.Name = "btnEliminarActivo";
            this.btnEliminarActivo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarActivo.TabIndex = 17;
            this.btnEliminarActivo.Text = "Eliminar";
            this.btnEliminarActivo.UseVisualStyleBackColor = true;
            this.btnEliminarActivo.Click += new System.EventHandler(this.btnEliminarActivo_Click);
            // 
            // btnGuardarActivo
            // 
            this.btnGuardarActivo.Location = new System.Drawing.Point(28, 358);
            this.btnGuardarActivo.Name = "btnGuardarActivo";
            this.btnGuardarActivo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarActivo.TabIndex = 16;
            this.btnGuardarActivo.Text = "Guardar";
            this.btnGuardarActivo.UseVisualStyleBackColor = true;
            this.btnGuardarActivo.Click += new System.EventHandler(this.btnGuardarActivo_Click);
            // 
            // txtDepAcumAF
            // 
            this.txtDepAcumAF.Location = new System.Drawing.Point(197, 306);
            this.txtDepAcumAF.Name = "txtDepAcumAF";
            this.txtDepAcumAF.Size = new System.Drawing.Size(139, 20);
            this.txtDepAcumAF.TabIndex = 15;
            // 
            // txtValorCompraActivoF
            // 
            this.txtValorCompraActivoF.Location = new System.Drawing.Point(197, 260);
            this.txtValorCompraActivoF.Name = "txtValorCompraActivoF";
            this.txtValorCompraActivoF.Size = new System.Drawing.Size(139, 20);
            this.txtValorCompraActivoF.TabIndex = 14;
            // 
            // dateTimeActivoF
            // 
            this.dateTimeActivoF.Location = new System.Drawing.Point(197, 219);
            this.dateTimeActivoF.Name = "dateTimeActivoF";
            this.dateTimeActivoF.Size = new System.Drawing.Size(202, 20);
            this.dateTimeActivoF.TabIndex = 13;
            // 
            // cmbTAcAF
            // 
            this.cmbTAcAF.FormattingEnabled = true;
            this.cmbTAcAF.Location = new System.Drawing.Point(197, 176);
            this.cmbTAcAF.Name = "cmbTAcAF";
            this.cmbTAcAF.Size = new System.Drawing.Size(139, 21);
            this.cmbTAcAF.TabIndex = 12;
            // 
            // cmbUbicActivoF
            // 
            this.cmbUbicActivoF.FormattingEnabled = true;
            this.cmbUbicActivoF.Location = new System.Drawing.Point(197, 141);
            this.cmbUbicActivoF.Name = "cmbUbicActivoF";
            this.cmbUbicActivoF.Size = new System.Drawing.Size(139, 21);
            this.cmbUbicActivoF.TabIndex = 11;
            // 
            // cmbDeptActivoF
            // 
            this.cmbDeptActivoF.FormattingEnabled = true;
            this.cmbDeptActivoF.Location = new System.Drawing.Point(197, 97);
            this.cmbDeptActivoF.Name = "cmbDeptActivoF";
            this.cmbDeptActivoF.Size = new System.Drawing.Size(139, 21);
            this.cmbDeptActivoF.TabIndex = 10;
            // 
            // cmbDescActivoF
            // 
            this.cmbDescActivoF.FormattingEnabled = true;
            this.cmbDescActivoF.Location = new System.Drawing.Point(197, 61);
            this.cmbDescActivoF.Name = "cmbDescActivoF";
            this.cmbDescActivoF.Size = new System.Drawing.Size(139, 21);
            this.cmbDescActivoF.TabIndex = 9;
            // 
            // valorCompra
            // 
            this.valorCompra.AutoSize = true;
            this.valorCompra.Location = new System.Drawing.Point(25, 263);
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.Size = new System.Drawing.Size(70, 13);
            this.valorCompra.TabIndex = 8;
            this.valorCompra.Text = "Valor Compra";
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.AutoSize = true;
            this.fechaRegistro.Location = new System.Drawing.Point(25, 219);
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.Size = new System.Drawing.Size(94, 13);
            this.fechaRegistro.TabIndex = 7;
            this.fechaRegistro.Text = "Fecha de Registro";
            this.fechaRegistro.Click += new System.EventHandler(this.fechaRegistro_Click);
            // 
            // tipoActivo
            // 
            this.tipoActivo.AutoSize = true;
            this.tipoActivo.Location = new System.Drawing.Point(25, 179);
            this.tipoActivo.Name = "tipoActivo";
            this.tipoActivo.Size = new System.Drawing.Size(61, 13);
            this.tipoActivo.TabIndex = 6;
            this.tipoActivo.Text = "Tipo Activo";
            // 
            // DepAcumulada
            // 
            this.DepAcumulada.AutoSize = true;
            this.DepAcumulada.Location = new System.Drawing.Point(21, 309);
            this.DepAcumulada.Name = "DepAcumulada";
            this.DepAcumulada.Size = new System.Drawing.Size(126, 13);
            this.DepAcumulada.TabIndex = 5;
            this.DepAcumulada.Text = "Depreciación Acumulada";
            this.DepAcumulada.Click += new System.EventHandler(this.DepAcumulada_Click);
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSize = true;
            this.Ubicacion.Location = new System.Drawing.Point(25, 144);
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Size = new System.Drawing.Size(55, 13);
            this.Ubicacion.TabIndex = 4;
            this.Ubicacion.Text = "Ubicación";
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Location = new System.Drawing.Point(21, 105);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(74, 13);
            this.Departamento.TabIndex = 3;
            this.Departamento.Text = "Departamento";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(21, 69);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripción";
            this.Descripcion.Click += new System.EventHandler(this.Descripcion_Click);
            // 
            // txtIdActivoF
            // 
            this.txtIdActivoF.Location = new System.Drawing.Point(197, 24);
            this.txtIdActivoF.Name = "txtIdActivoF";
            this.txtIdActivoF.Size = new System.Drawing.Size(139, 20);
            this.txtIdActivoF.TabIndex = 1;
            this.txtIdActivoF.Visible = false;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(25, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            this.Id.Visible = false;
            // 
            // txtBuscarActivoF
            // 
            this.txtBuscarActivoF.Location = new System.Drawing.Point(493, 15);
            this.txtBuscarActivoF.Name = "txtBuscarActivoF";
            this.txtBuscarActivoF.Size = new System.Drawing.Size(513, 20);
            this.txtBuscarActivoF.TabIndex = 16;
            this.txtBuscarActivoF.TextChanged += new System.EventHandler(this.txtBuscarActivoF_TextChanged);
            // 
            // btnBuscarActivoF
            // 
            this.btnBuscarActivoF.Location = new System.Drawing.Point(1029, 12);
            this.btnBuscarActivoF.Name = "btnBuscarActivoF";
            this.btnBuscarActivoF.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarActivoF.TabIndex = 18;
            this.btnBuscarActivoF.Text = "Buscar";
            this.btnBuscarActivoF.UseVisualStyleBackColor = true;
            this.btnBuscarActivoF.Click += new System.EventHandler(this.btnBuscarActivoF_Click);
            // 
            // dgvActivosFijos
            // 
            this.dgvActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivosFijos.Location = new System.Drawing.Point(481, 59);
            this.dgvActivosFijos.Name = "dgvActivosFijos";
            this.dgvActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivosFijos.Size = new System.Drawing.Size(660, 363);
            this.dgvActivosFijos.TabIndex = 19;
            this.dgvActivosFijos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivosFijos_CellContentClick);
            // 
            // ActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 434);
            this.Controls.Add(this.dgvActivosFijos);
            this.Controls.Add(this.btnBuscarActivoF);
            this.Controls.Add(this.txtBuscarActivoF);
            this.Controls.Add(this.panel1);
            this.Name = "ActivosFijos";
            this.Text = "ActivosFijos";
            this.Load += new System.EventHandler(this.ActivosFijos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosFijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label valorCompra;
        private System.Windows.Forms.Label fechaRegistro;
        private System.Windows.Forms.Label tipoActivo;
        private System.Windows.Forms.Label DepAcumulada;
        private System.Windows.Forms.Label Ubicacion;
        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtIdActivoF;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.ComboBox cmbDescActivoF;
        private System.Windows.Forms.Button btnEliminarActivo;
        private System.Windows.Forms.Button btnGuardarActivo;
        private System.Windows.Forms.TextBox txtDepAcumAF;
        private System.Windows.Forms.TextBox txtValorCompraActivoF;
        private System.Windows.Forms.DateTimePicker dateTimeActivoF;
        private System.Windows.Forms.ComboBox cmbTAcAF;
        private System.Windows.Forms.ComboBox cmbUbicActivoF;
        private System.Windows.Forms.ComboBox cmbDeptActivoF;
        private System.Windows.Forms.TextBox txtBuscarActivoF;
        private System.Windows.Forms.Button btnBuscarActivoF;
        private System.Windows.Forms.DataGridView dgvActivosFijos;
    }
}