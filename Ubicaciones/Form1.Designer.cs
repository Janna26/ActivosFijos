namespace Ubicaciones
{
    partial class Ubicacion
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
            this.edificio = new System.Windows.Forms.Panel();
            this.estado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.cmbEstadoUbicacion = new System.Windows.Forms.ComboBox();
            this.edificio.SuspendLayout();
            this.SuspendLayout();
            // 
            // edificio
            // 
            this.edificio.Controls.Add(this.cmbEstadoUbicacion);
            this.edificio.Controls.Add(this.txtEdificio);
            this.edificio.Controls.Add(this.txtDireccion);
            this.edificio.Controls.Add(this.txtDescripcion);
            this.edificio.Controls.Add(this.txtId);
            this.edificio.Controls.Add(this.estado);
            this.edificio.Controls.Add(this.label4);
            this.edificio.Controls.Add(this.direccion);
            this.edificio.Controls.Add(this.descripcion);
            this.edificio.Controls.Add(this.Id);
            this.edificio.Location = new System.Drawing.Point(12, 12);
            this.edificio.Name = "edificio";
            this.edificio.Size = new System.Drawing.Size(310, 250);
            this.edificio.TabIndex = 0;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(38, 172);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 4;
            this.estado.Text = "Estado";
            this.estado.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edificio";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(38, 100);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(52, 13);
            this.direccion.TabIndex = 2;
            this.direccion.Text = "Dirección";
            this.direccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(38, 61);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripción";
            this.descripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(38, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 61);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 93);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(121, 131);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(100, 20);
            this.txtEdificio.TabIndex = 8;
            // 
            // cmbEstadoUbicacion
            // 
            this.cmbEstadoUbicacion.FormattingEnabled = true;
            this.cmbEstadoUbicacion.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoUbicacion.Location = new System.Drawing.Point(121, 169);
            this.cmbEstadoUbicacion.Name = "cmbEstadoUbicacion";
            this.cmbEstadoUbicacion.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoUbicacion.TabIndex = 9;
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 274);
            this.Controls.Add(this.edificio);
            this.Name = "Ubicacion";
            this.Text = "Ubicaciones";
            this.edificio.ResumeLayout(false);
            this.edificio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel edificio;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbEstadoUbicacion;
    }
}

