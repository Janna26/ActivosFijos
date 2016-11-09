namespace Mantenimientos
{
    partial class Empleados
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
            this.txtDeptEmp = new System.Windows.Forms.ComboBox();
            this.dateTimeEmpleado = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarEmp = new System.Windows.Forms.Button();
            this.btnGuardarEmp = new System.Windows.Forms.Button();
            this.fechaIngreso = new System.Windows.Forms.Label();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.tipoPersonaEmpleado = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.Label();
            this.txtCedulaEmp = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.Label();
            this.cmbEstadoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.estadoEmpleado = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDeptEmp);
            this.panel1.Controls.Add(this.dateTimeEmpleado);
            this.panel1.Controls.Add(this.btnEliminarEmp);
            this.panel1.Controls.Add(this.btnGuardarEmp);
            this.panel1.Controls.Add(this.fechaIngreso);
            this.panel1.Controls.Add(this.cmbTipoPersona);
            this.panel1.Controls.Add(this.tipoPersonaEmpleado);
            this.panel1.Controls.Add(this.departamento);
            this.panel1.Controls.Add(this.txtCedulaEmp);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Controls.Add(this.cmbEstadoEmpleado);
            this.panel1.Controls.Add(this.txtNombreEmp);
            this.panel1.Controls.Add(this.estadoEmpleado);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 354);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDeptEmp
            // 
            this.txtDeptEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDeptEmp.FormattingEnabled = true;
            this.txtDeptEmp.Items.AddRange(new object[] {
            "TI",
            "Contabilidad",
            "Recursos Humanos",
            "Mercadeo"});
            this.txtDeptEmp.Location = new System.Drawing.Point(107, 136);
            this.txtDeptEmp.Name = "txtDeptEmp";
            this.txtDeptEmp.Size = new System.Drawing.Size(100, 21);
            this.txtDeptEmp.TabIndex = 24;
            this.txtDeptEmp.SelectedIndexChanged += new System.EventHandler(this.txtDeptEmp_SelectedIndexChanged);
            // 
            // dateTimeEmpleado
            // 
            this.dateTimeEmpleado.Location = new System.Drawing.Point(107, 250);
            this.dateTimeEmpleado.MaxDate = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            this.dateTimeEmpleado.Name = "dateTimeEmpleado";
            this.dateTimeEmpleado.Size = new System.Drawing.Size(198, 20);
            this.dateTimeEmpleado.TabIndex = 20;
            this.dateTimeEmpleado.Value = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            this.dateTimeEmpleado.ValueChanged += new System.EventHandler(this.dateTimeEmpleado_ValueChanged);
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.Location = new System.Drawing.Point(197, 300);
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEmp.TabIndex = 19;
            this.btnEliminarEmp.Text = "Eliminar";
            this.btnEliminarEmp.UseVisualStyleBackColor = true;
            this.btnEliminarEmp.Click += new System.EventHandler(this.btnEliminarEmp_Click);
            // 
            // btnGuardarEmp
            // 
            this.btnGuardarEmp.Location = new System.Drawing.Point(17, 300);
            this.btnGuardarEmp.Name = "btnGuardarEmp";
            this.btnGuardarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEmp.TabIndex = 14;
            this.btnGuardarEmp.Text = "Guardar";
            this.btnGuardarEmp.UseVisualStyleBackColor = true;
            this.btnGuardarEmp.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSize = true;
            this.fechaIngreso.Location = new System.Drawing.Point(18, 250);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(75, 13);
            this.fechaIngreso.TabIndex = 12;
            this.fechaIngreso.Text = "Fecha Ingreso";
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(107, 172);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoPersona.TabIndex = 11;
            // 
            // tipoPersonaEmpleado
            // 
            this.tipoPersonaEmpleado.AutoSize = true;
            this.tipoPersonaEmpleado.Location = new System.Drawing.Point(14, 175);
            this.tipoPersonaEmpleado.Name = "tipoPersonaEmpleado";
            this.tipoPersonaEmpleado.Size = new System.Drawing.Size(85, 13);
            this.tipoPersonaEmpleado.TabIndex = 10;
            this.tipoPersonaEmpleado.Text = "Tipo de Persona";
            // 
            // departamento
            // 
            this.departamento.AutoSize = true;
            this.departamento.Location = new System.Drawing.Point(18, 136);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(74, 13);
            this.departamento.TabIndex = 9;
            this.departamento.Text = "Departamento";
            this.departamento.Click += new System.EventHandler(this.departamento_Click);
            // 
            // txtCedulaEmp
            // 
            this.txtCedulaEmp.Location = new System.Drawing.Point(107, 100);
            this.txtCedulaEmp.MaxLength = 13;
            this.txtCedulaEmp.Name = "txtCedulaEmp";
            this.txtCedulaEmp.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaEmp.TabIndex = 7;
            this.txtCedulaEmp.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedulaEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Location = new System.Drawing.Point(18, 103);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(40, 13);
            this.cedula.TabIndex = 6;
            this.cedula.Text = "Cédula";
            this.cedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEstadoEmpleado
            // 
            this.cmbEstadoEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.cmbEstadoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEmpleado.FormattingEnabled = true;
            this.cmbEstadoEmpleado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoEmpleado.Location = new System.Drawing.Point(107, 207);
            this.cmbEstadoEmpleado.Name = "cmbEstadoEmpleado";
            this.cmbEstadoEmpleado.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoEmpleado.Sorted = true;
            this.cmbEstadoEmpleado.TabIndex = 5;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(107, 58);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 4;
            this.txtNombreEmp.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombreEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmp_KeyPress);
            // 
            // estadoEmpleado
            // 
            this.estadoEmpleado.AutoSize = true;
            this.estadoEmpleado.Location = new System.Drawing.Point(18, 210);
            this.estadoEmpleado.Name = "estadoEmpleado";
            this.estadoEmpleado.Size = new System.Drawing.Size(40, 13);
            this.estadoEmpleado.TabIndex = 3;
            this.estadoEmpleado.Text = "Estado";
            this.estadoEmpleado.Click += new System.EventHandler(this.estado_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(14, 61);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Location = new System.Drawing.Point(874, 42);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmp.TabIndex = 15;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(340, 70);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(596, 296);
            this.dgvEmpleados.TabIndex = 2;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(353, 44);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(504, 20);
            this.txtBuscarEmpleado.TabIndex = 5;
            this.txtBuscarEmpleado.TextChanged += new System.EventHandler(this.txtBuscarEmpleado_TextChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 383);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnBuscarEmp);
            this.Controls.Add(this.panel1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Activated += new System.EventHandler(this.Empleados_Activated);
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Empleados_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ComboBox cmbEstadoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.Label estadoEmpleado;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.TextBox txtCedulaEmp;
        private System.Windows.Forms.Label departamento;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.Label tipoPersonaEmpleado;
        private System.Windows.Forms.Label fechaIngreso;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.Button btnGuardarEmp;
        private System.Windows.Forms.Button btnEliminarEmp;
        private System.Windows.Forms.DateTimePicker dateTimeEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.ComboBox txtDeptEmp;
    }
}

