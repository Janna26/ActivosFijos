namespace Mantenimientos
{
    partial class TipoDePago
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
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbDescTipoPago = new System.Windows.Forms.ComboBox();
            this.txtIdTipoPago = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.dgvTipoPago = new System.Windows.Forms.DataGridView();
            this.txtBuscarTipoPago = new System.Windows.Forms.TextBox();
            this.btnBuscarTipoPago = new System.Windows.Forms.Button();
            this.btnGuardarTipPago = new System.Windows.Forms.Button();
            this.btnEliminarTipoPago = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarTipoPago);
            this.panel1.Controls.Add(this.btnGuardarTipPago);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.cmbDescTipoPago);
            this.panel1.Controls.Add(this.txtIdTipoPago);
            this.panel1.Controls.Add(this.Estado);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(43, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 237);
            this.panel1.TabIndex = 0;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(93, 108);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(100, 21);
            this.cmbEstado.TabIndex = 6;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbDescTipoPago
            // 
            this.cmbDescTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescTipoPago.FormattingEnabled = true;
            this.cmbDescTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito",
            "Nota de Crédito",
            "Cupón"});
            this.cmbDescTipoPago.Location = new System.Drawing.Point(93, 61);
            this.cmbDescTipoPago.Name = "cmbDescTipoPago";
            this.cmbDescTipoPago.Size = new System.Drawing.Size(100, 21);
            this.cmbDescTipoPago.TabIndex = 5;
            this.cmbDescTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbDescTipoPago_SelectedIndexChanged);
            // 
            // txtIdTipoPago
            // 
            this.txtIdTipoPago.Location = new System.Drawing.Point(93, 12);
            this.txtIdTipoPago.Name = "txtIdTipoPago";
            this.txtIdTipoPago.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoPago.TabIndex = 3;
            this.txtIdTipoPago.Visible = false;
            this.txtIdTipoPago.TextChanged += new System.EventHandler(this.txtIdTipoPago_TextChanged);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(22, 111);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 2;
            this.Estado.Text = "Estado";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(22, 64);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripción";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(22, 19);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            this.Id.Visible = false;
            // 
            // dgvTipoPago
            // 
            this.dgvTipoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPago.Location = new System.Drawing.Point(413, 57);
            this.dgvTipoPago.Name = "dgvTipoPago";
            this.dgvTipoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoPago.Size = new System.Drawing.Size(368, 237);
            this.dgvTipoPago.TabIndex = 1;
            this.dgvTipoPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPago_CellContentClick);
            this.dgvTipoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPago_CellContentClick);
            // 
            // txtBuscarTipoPago
            // 
            this.txtBuscarTipoPago.Location = new System.Drawing.Point(413, 28);
            this.txtBuscarTipoPago.Name = "txtBuscarTipoPago";
            this.txtBuscarTipoPago.Size = new System.Drawing.Size(340, 20);
            this.txtBuscarTipoPago.TabIndex = 4;
            this.txtBuscarTipoPago.TextChanged += new System.EventHandler(this.txtBuscarTipoPago_TextChanged);
            // 
            // btnBuscarTipoPago
            // 
            this.btnBuscarTipoPago.Location = new System.Drawing.Point(759, 28);
            this.btnBuscarTipoPago.Name = "btnBuscarTipoPago";
            this.btnBuscarTipoPago.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipoPago.TabIndex = 9;
            this.btnBuscarTipoPago.Text = "Buscar";
            this.btnBuscarTipoPago.UseVisualStyleBackColor = true;
            this.btnBuscarTipoPago.Click += new System.EventHandler(this.btnBuscarTipoPago_Click);
            // 
            // btnGuardarTipPago
            // 
            this.btnGuardarTipPago.Location = new System.Drawing.Point(25, 189);
            this.btnGuardarTipPago.Name = "btnGuardarTipPago";
            this.btnGuardarTipPago.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTipPago.TabIndex = 7;
            this.btnGuardarTipPago.Text = "Guardar";
            this.btnGuardarTipPago.UseVisualStyleBackColor = true;
            this.btnGuardarTipPago.Click += new System.EventHandler(this.btnGuardarTipPago_Click);
            // 
            // btnEliminarTipoPago
            // 
            this.btnEliminarTipoPago.Location = new System.Drawing.Point(151, 189);
            this.btnEliminarTipoPago.Name = "btnEliminarTipoPago";
            this.btnEliminarTipoPago.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTipoPago.TabIndex = 8;
            this.btnEliminarTipoPago.Text = "Eliminar";
            this.btnEliminarTipoPago.UseVisualStyleBackColor = true;
            this.btnEliminarTipoPago.Click += new System.EventHandler(this.btnEliminarTipoPago_Click);
            // 
            // TipoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 329);
            this.Controls.Add(this.btnBuscarTipoPago);
            this.Controls.Add(this.txtBuscarTipoPago);
            this.Controls.Add(this.dgvTipoPago);
            this.Controls.Add(this.panel1);
            this.Name = "TipoDePago";
            this.Text = "Tipos de Pago";
            this.Load += new System.EventHandler(this.TipoDePago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbDescTipoPago;
        private System.Windows.Forms.TextBox txtIdTipoPago;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.DataGridView dgvTipoPago;
        private System.Windows.Forms.TextBox txtBuscarTipoPago;
        private System.Windows.Forms.Button btnBuscarTipoPago;
        private System.Windows.Forms.Button btnEliminarTipoPago;
        private System.Windows.Forms.Button btnGuardarTipPago;
    }
}