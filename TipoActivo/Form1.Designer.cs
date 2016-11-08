namespace TipoActivo
{
    partial class TipoActivo
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
            System.Windows.Forms.ComboBox cmbEstadoTipoActivo;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCuentaContableDepreciacion = new System.Windows.Forms.TextBox();
            this.txtCuentaContableCompra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.cuentaContableDepreciacion = new System.Windows.Forms.Label();
            this.cuentaContableCompra = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            cmbEstadoTipoActivo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstadoTipoActivo
            // 
            cmbEstadoTipoActivo.FormattingEnabled = true;
            cmbEstadoTipoActivo.IntegralHeight = false;
            cmbEstadoTipoActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            cmbEstadoTipoActivo.Location = new System.Drawing.Point(183, 166);
            cmbEstadoTipoActivo.Name = "cmbEstadoTipoActivo";
            cmbEstadoTipoActivo.Size = new System.Drawing.Size(100, 21);
            cmbEstadoTipoActivo.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(cmbEstadoTipoActivo);
            this.panel1.Controls.Add(this.txtCuentaContableDepreciacion);
            this.panel1.Controls.Add(this.txtCuentaContableCompra);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.cuentaContableDepreciacion);
            this.panel1.Controls.Add(this.cuentaContableCompra);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 219);
            this.panel1.TabIndex = 0;
            // 
            // txtCuentaContableDepreciacion
            // 
            this.txtCuentaContableDepreciacion.Location = new System.Drawing.Point(183, 131);
            this.txtCuentaContableDepreciacion.Name = "txtCuentaContableDepreciacion";
            this.txtCuentaContableDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaContableDepreciacion.TabIndex = 8;
            // 
            // txtCuentaContableCompra
            // 
            this.txtCuentaContableCompra.Location = new System.Drawing.Point(183, 89);
            this.txtCuentaContableCompra.Name = "txtCuentaContableCompra";
            this.txtCuentaContableCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaContableCompra.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(183, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(183, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(22, 169);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 4;
            this.estado.Text = "Estado";
            // 
            // cuentaContableDepreciacion
            // 
            this.cuentaContableDepreciacion.AutoSize = true;
            this.cuentaContableDepreciacion.Location = new System.Drawing.Point(22, 131);
            this.cuentaContableDepreciacion.Name = "cuentaContableDepreciacion";
            this.cuentaContableDepreciacion.Size = new System.Drawing.Size(152, 13);
            this.cuentaContableDepreciacion.TabIndex = 3;
            this.cuentaContableDepreciacion.Text = "Cuenta Contable Depreciación";
            // 
            // cuentaContableCompra
            // 
            this.cuentaContableCompra.AutoSize = true;
            this.cuentaContableCompra.Location = new System.Drawing.Point(22, 92);
            this.cuentaContableCompra.Name = "cuentaContableCompra";
            this.cuentaContableCompra.Size = new System.Drawing.Size(125, 13);
            this.cuentaContableCompra.TabIndex = 2;
            this.cuentaContableCompra.Text = "Cuenta Contable Compra";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(22, 58);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripción";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(22, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 0;
            this.id.Text = "Id";
            // 
            // TipoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 246);
            this.Controls.Add(this.panel1);
            this.Name = "TipoActivo";
            this.Text = "Tipo de Activo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCuentaContableDepreciacion;
        private System.Windows.Forms.TextBox txtCuentaContableCompra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label cuentaContableDepreciacion;
        private System.Windows.Forms.Label cuentaContableCompra;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label id;
    }
}

