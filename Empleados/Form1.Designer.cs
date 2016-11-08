namespace Empleados
{
    partial class Form1
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
            this.txtFechaIngresoEmpleado = new System.Windows.Forms.TextBox();
            this.fechaIngreso = new System.Windows.Forms.Label();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.tipoPersona = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.Label();
            this.cmbEstadoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtFechaIngresoEmpleado);
            this.panel1.Controls.Add(this.fechaIngreso);
            this.panel1.Controls.Add(this.cmbTipoPersona);
            this.panel1.Controls.Add(this.tipoPersona);
            this.panel1.Controls.Add(this.departamento);
            this.panel1.Controls.Add(this.txtDepartamento);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Controls.Add(this.cmbEstadoEmpleado);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.txtIdEmpleado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 335);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFechaIngresoEmpleado
            // 
            this.txtFechaIngresoEmpleado.Location = new System.Drawing.Point(107, 250);
            this.txtFechaIngresoEmpleado.Name = "txtFechaIngresoEmpleado";
            this.txtFechaIngresoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtFechaIngresoEmpleado.TabIndex = 13;
            this.txtFechaIngresoEmpleado.TextChanged += new System.EventHandler(this.txtFechaIngresoEmpleado_TextChanged);
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
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(107, 172);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoPersona.TabIndex = 11;
            // 
            // tipoPersona
            // 
            this.tipoPersona.AutoSize = true;
            this.tipoPersona.Location = new System.Drawing.Point(14, 175);
            this.tipoPersona.Name = "tipoPersona";
            this.tipoPersona.Size = new System.Drawing.Size(85, 13);
            this.tipoPersona.TabIndex = 10;
            this.tipoPersona.Text = "Tipo de Persona";
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
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(107, 133);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtDepartamento.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(107, 100);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 7;
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(18, 210);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 3;
            this.estado.Text = "Estado";
            this.estado.Click += new System.EventHandler(this.estado_Click);
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
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(22, 17);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(107, 17);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(168, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(17, 295);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 359);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ComboBox cmbEstadoEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label departamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.Label tipoPersona;
        private System.Windows.Forms.TextBox txtFechaIngresoEmpleado;
        private System.Windows.Forms.Label fechaIngreso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

