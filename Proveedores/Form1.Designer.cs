namespace Proveedores
{
    partial class Proveedor
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
            this.cmbTipoPersonaProveedor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaIngresoProveedor = new System.Windows.Forms.TextBox();
            this.fechaIngresoProveedor = new System.Windows.Forms.Label();
            this.tipoPersonaProveedor = new System.Windows.Forms.Label();
            this.txtCedulaProveedor = new System.Windows.Forms.TextBox();
            this.cedulaProveedor = new System.Windows.Forms.Label();
            this.cmbEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.estadoProveedor = new System.Windows.Forms.Label();
            this.nombreProveedor = new System.Windows.Forms.Label();
            this.idProveedor = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoPersonaProveedor
            // 
            this.cmbTipoPersonaProveedor.FormattingEnabled = true;
            this.cmbTipoPersonaProveedor.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cmbTipoPersonaProveedor.Location = new System.Drawing.Point(107, 146);
            this.cmbTipoPersonaProveedor.Name = "cmbTipoPersonaProveedor";
            this.cmbTipoPersonaProveedor.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoPersonaProveedor.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFechaIngresoProveedor);
            this.panel1.Controls.Add(this.fechaIngresoProveedor);
            this.panel1.Controls.Add(this.cmbTipoPersonaProveedor);
            this.panel1.Controls.Add(this.tipoPersonaProveedor);
            this.panel1.Controls.Add(this.txtCedulaProveedor);
            this.panel1.Controls.Add(this.cedulaProveedor);
            this.panel1.Controls.Add(this.cmbEstadoProveedor);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.estadoProveedor);
            this.panel1.Controls.Add(this.nombreProveedor);
            this.panel1.Controls.Add(this.idProveedor);
            this.panel1.Controls.Add(this.txtIdProveedor);
            this.panel1.Location = new System.Drawing.Point(43, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 304);
            this.panel1.TabIndex = 2;
            // 
            // txtFechaIngresoProveedor
            // 
            this.txtFechaIngresoProveedor.Location = new System.Drawing.Point(107, 225);
            this.txtFechaIngresoProveedor.Name = "txtFechaIngresoProveedor";
            this.txtFechaIngresoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtFechaIngresoProveedor.TabIndex = 13;
            // 
            // fechaIngresoProveedor
            // 
            this.fechaIngresoProveedor.AutoSize = true;
            this.fechaIngresoProveedor.Location = new System.Drawing.Point(12, 228);
            this.fechaIngresoProveedor.Name = "fechaIngresoProveedor";
            this.fechaIngresoProveedor.Size = new System.Drawing.Size(79, 13);
            this.fechaIngresoProveedor.TabIndex = 12;
            this.fechaIngresoProveedor.Text = "Fecha Registro";
            // 
            // tipoPersonaProveedor
            // 
            this.tipoPersonaProveedor.AutoSize = true;
            this.tipoPersonaProveedor.Location = new System.Drawing.Point(12, 146);
            this.tipoPersonaProveedor.Name = "tipoPersonaProveedor";
            this.tipoPersonaProveedor.Size = new System.Drawing.Size(85, 13);
            this.tipoPersonaProveedor.TabIndex = 10;
            this.tipoPersonaProveedor.Text = "Tipo de Persona";
            this.tipoPersonaProveedor.Click += new System.EventHandler(this.tipoPersona_Click);
            // 
            // txtCedulaProveedor
            // 
            this.txtCedulaProveedor.Location = new System.Drawing.Point(107, 100);
            this.txtCedulaProveedor.Name = "txtCedulaProveedor";
            this.txtCedulaProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaProveedor.TabIndex = 7;
            // 
            // cedulaProveedor
            // 
            this.cedulaProveedor.AutoSize = true;
            this.cedulaProveedor.Location = new System.Drawing.Point(18, 103);
            this.cedulaProveedor.Name = "cedulaProveedor";
            this.cedulaProveedor.Size = new System.Drawing.Size(40, 13);
            this.cedulaProveedor.TabIndex = 6;
            this.cedulaProveedor.Text = "Cédula";
            // 
            // cmbEstadoProveedor
            // 
            this.cmbEstadoProveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.cmbEstadoProveedor.FormattingEnabled = true;
            this.cmbEstadoProveedor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoProveedor.Location = new System.Drawing.Point(107, 184);
            this.cmbEstadoProveedor.Name = "cmbEstadoProveedor";
            this.cmbEstadoProveedor.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoProveedor.Sorted = true;
            this.cmbEstadoProveedor.TabIndex = 5;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(107, 58);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // estadoProveedor
            // 
            this.estadoProveedor.AutoSize = true;
            this.estadoProveedor.Location = new System.Drawing.Point(12, 184);
            this.estadoProveedor.Name = "estadoProveedor";
            this.estadoProveedor.Size = new System.Drawing.Size(40, 13);
            this.estadoProveedor.TabIndex = 3;
            this.estadoProveedor.Text = "Estado";
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.AutoSize = true;
            this.nombreProveedor.Location = new System.Drawing.Point(14, 61);
            this.nombreProveedor.Name = "nombreProveedor";
            this.nombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.nombreProveedor.TabIndex = 2;
            this.nombreProveedor.Text = "Nombre";
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSize = true;
            this.idProveedor.Location = new System.Drawing.Point(22, 17);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(16, 13);
            this.idProveedor.TabIndex = 1;
            this.idProveedor.Text = "Id";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(107, 17);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 0;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 363);
            this.Controls.Add(this.panel1);
            this.Name = "Proveedor";
            this.Text = "Proveedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPersonaProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFechaIngresoProveedor;
        private System.Windows.Forms.Label fechaIngresoProveedor;
        private System.Windows.Forms.Label tipoPersonaProveedor;
        private System.Windows.Forms.TextBox txtCedulaProveedor;
        private System.Windows.Forms.Label cedulaProveedor;
        internal System.Windows.Forms.ComboBox cmbEstadoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label estadoProveedor;
        private System.Windows.Forms.Label nombreProveedor;
        private System.Windows.Forms.Label idProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
    }
}

