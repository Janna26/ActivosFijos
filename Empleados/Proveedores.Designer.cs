namespace Mantenimientos
{
    partial class Proveedores
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
            this.dateTimeProv = new System.Windows.Forms.DateTimePicker();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.idProveedor = new System.Windows.Forms.Label();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnGuardarProv = new System.Windows.Forms.Button();
            this.fechaIngresoProveedor = new System.Windows.Forms.Label();
            this.tipoPersonaProveedor = new System.Windows.Forms.Label();
            this.txtCedulaProveedor = new System.Windows.Forms.TextBox();
            this.cedulaProveedor = new System.Windows.Forms.Label();
            this.cmbEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.estadoProveedor = new System.Windows.Forms.Label();
            this.nombreProveedor = new System.Windows.Forms.Label();
            this.btnBuscarProv = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscarProv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoPersonaProveedor
            // 
            this.cmbTipoPersonaProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersonaProveedor.FormattingEnabled = true;
            this.cmbTipoPersonaProveedor.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cmbTipoPersonaProveedor.Location = new System.Drawing.Point(107, 146);
            this.cmbTipoPersonaProveedor.Name = "cmbTipoPersonaProveedor";
            this.cmbTipoPersonaProveedor.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoPersonaProveedor.TabIndex = 11;
            this.cmbTipoPersonaProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonaProveedor_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeProv);
            this.panel1.Controls.Add(this.txtIdProveedor);
            this.panel1.Controls.Add(this.idProveedor);
            this.panel1.Controls.Add(this.btnEliminarProv);
            this.panel1.Controls.Add(this.btnGuardarProv);
            this.panel1.Controls.Add(this.fechaIngresoProveedor);
            this.panel1.Controls.Add(this.cmbTipoPersonaProveedor);
            this.panel1.Controls.Add(this.tipoPersonaProveedor);
            this.panel1.Controls.Add(this.txtCedulaProveedor);
            this.panel1.Controls.Add(this.cedulaProveedor);
            this.panel1.Controls.Add(this.cmbEstadoProveedor);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.estadoProveedor);
            this.panel1.Controls.Add(this.nombreProveedor);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 345);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimeProv
            // 
            this.dateTimeProv.Location = new System.Drawing.Point(107, 220);
            this.dateTimeProv.Name = "dateTimeProv";
            this.dateTimeProv.Size = new System.Drawing.Size(200, 20);
            this.dateTimeProv.TabIndex = 21;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(107, 22);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 20;
            this.txtIdProveedor.Visible = false;
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSize = true;
            this.idProveedor.Location = new System.Drawing.Point(18, 22);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(16, 13);
            this.idProveedor.TabIndex = 19;
            this.idProveedor.Text = "Id";
            this.idProveedor.Visible = false;
            this.idProveedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Location = new System.Drawing.Point(197, 302);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProv.TabIndex = 18;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.UseVisualStyleBackColor = true;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
            // 
            // btnGuardarProv
            // 
            this.btnGuardarProv.Location = new System.Drawing.Point(37, 302);
            this.btnGuardarProv.Name = "btnGuardarProv";
            this.btnGuardarProv.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProv.TabIndex = 16;
            this.btnGuardarProv.Text = "Guardar";
            this.btnGuardarProv.UseVisualStyleBackColor = true;
            this.btnGuardarProv.Click += new System.EventHandler(this.btnGuardarProv_Click);
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
            // 
            // txtCedulaProveedor
            // 
            this.txtCedulaProveedor.Location = new System.Drawing.Point(107, 100);
            this.txtCedulaProveedor.Name = "txtCedulaProveedor";
            this.txtCedulaProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaProveedor.TabIndex = 7;
            this.txtCedulaProveedor.TextChanged += new System.EventHandler(this.txtCedulaProveedor_TextChanged);
            this.txtCedulaProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaProveedor_KeyPress);
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
            this.cmbEstadoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // btnBuscarProv
            // 
            this.btnBuscarProv.Location = new System.Drawing.Point(743, 21);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProv.TabIndex = 17;
            this.btnBuscarProv.Text = "Buscar";
            this.btnBuscarProv.UseVisualStyleBackColor = true;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(378, 66);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(440, 300);
            this.dgvProveedores.TabIndex = 4;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // txtBuscarProv
            // 
            this.txtBuscarProv.Location = new System.Drawing.Point(378, 21);
            this.txtBuscarProv.Name = "txtBuscarProv";
            this.txtBuscarProv.Size = new System.Drawing.Size(344, 20);
            this.txtBuscarProv.TabIndex = 19;
            this.txtBuscarProv.TextChanged += new System.EventHandler(this.txtBuscarProv_TextChanged);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 387);
            this.Controls.Add(this.txtBuscarProv);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.panel1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPersonaProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fechaIngresoProveedor;
        private System.Windows.Forms.Label tipoPersonaProveedor;
        private System.Windows.Forms.TextBox txtCedulaProveedor;
        private System.Windows.Forms.Label cedulaProveedor;
        internal System.Windows.Forms.ComboBox cmbEstadoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label estadoProveedor;
        private System.Windows.Forms.Label nombreProveedor;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.Button btnGuardarProv;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtBuscarProv;
        private System.Windows.Forms.Label idProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.DateTimePicker dateTimeProv;
    }
}