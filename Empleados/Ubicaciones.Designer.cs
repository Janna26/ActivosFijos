namespace Mantenimientos
{
    partial class Ubicaciones
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
            this.txtIdUbic = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.btnEliminarUbic = new System.Windows.Forms.Button();
            this.btnGuardaUbic = new System.Windows.Forms.Button();
            this.cmbEstadoUbicacion = new System.Windows.Forms.ComboBox();
            this.txtEdificioUbic = new System.Windows.Forms.TextBox();
            this.txtDireccionUbic = new System.Windows.Forms.TextBox();
            this.txtDescripcionUbic = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.btnBuscarUbic = new System.Windows.Forms.Button();
            this.txtBuscarUbic = new System.Windows.Forms.TextBox();
            this.dgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.edificio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // edificio
            // 
            this.edificio.Controls.Add(this.txtIdUbic);
            this.edificio.Controls.Add(this.Id);
            this.edificio.Controls.Add(this.btnEliminarUbic);
            this.edificio.Controls.Add(this.btnGuardaUbic);
            this.edificio.Controls.Add(this.cmbEstadoUbicacion);
            this.edificio.Controls.Add(this.txtEdificioUbic);
            this.edificio.Controls.Add(this.txtDireccionUbic);
            this.edificio.Controls.Add(this.txtDescripcionUbic);
            this.edificio.Controls.Add(this.estado);
            this.edificio.Controls.Add(this.label4);
            this.edificio.Controls.Add(this.direccion);
            this.edificio.Controls.Add(this.descripcion);
            this.edificio.Location = new System.Drawing.Point(21, 12);
            this.edificio.Name = "edificio";
            this.edificio.Size = new System.Drawing.Size(319, 287);
            this.edificio.TabIndex = 1;
            // 
            // txtIdUbic
            // 
            this.txtIdUbic.Location = new System.Drawing.Point(121, 25);
            this.txtIdUbic.Name = "txtIdUbic";
            this.txtIdUbic.Size = new System.Drawing.Size(100, 20);
            this.txtIdUbic.TabIndex = 25;
            this.txtIdUbic.Visible = false;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(38, 28);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 24;
            this.Id.Text = "Id";
            this.Id.Visible = false;
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // btnEliminarUbic
            // 
            this.btnEliminarUbic.Location = new System.Drawing.Point(209, 232);
            this.btnEliminarUbic.Name = "btnEliminarUbic";
            this.btnEliminarUbic.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUbic.TabIndex = 23;
            this.btnEliminarUbic.Text = "Eliminar";
            this.btnEliminarUbic.UseVisualStyleBackColor = true;
            this.btnEliminarUbic.Click += new System.EventHandler(this.btnEliminarUbic_Click);
            // 
            // btnGuardaUbic
            // 
            this.btnGuardaUbic.Location = new System.Drawing.Point(26, 232);
            this.btnGuardaUbic.Name = "btnGuardaUbic";
            this.btnGuardaUbic.Size = new System.Drawing.Size(75, 23);
            this.btnGuardaUbic.TabIndex = 22;
            this.btnGuardaUbic.Text = "Guardar";
            this.btnGuardaUbic.UseVisualStyleBackColor = true;
            this.btnGuardaUbic.Click += new System.EventHandler(this.btnGuardaUbic_Click);
            // 
            // cmbEstadoUbicacion
            // 
            this.cmbEstadoUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoUbicacion.FormattingEnabled = true;
            this.cmbEstadoUbicacion.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoUbicacion.Location = new System.Drawing.Point(121, 169);
            this.cmbEstadoUbicacion.Name = "cmbEstadoUbicacion";
            this.cmbEstadoUbicacion.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoUbicacion.TabIndex = 9;
            // 
            // txtEdificioUbic
            // 
            this.txtEdificioUbic.Location = new System.Drawing.Point(121, 131);
            this.txtEdificioUbic.Name = "txtEdificioUbic";
            this.txtEdificioUbic.Size = new System.Drawing.Size(100, 20);
            this.txtEdificioUbic.TabIndex = 8;
            // 
            // txtDireccionUbic
            // 
            this.txtDireccionUbic.Location = new System.Drawing.Point(121, 93);
            this.txtDireccionUbic.Name = "txtDireccionUbic";
            this.txtDireccionUbic.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionUbic.TabIndex = 7;
            // 
            // txtDescripcionUbic
            // 
            this.txtDescripcionUbic.Location = new System.Drawing.Point(121, 61);
            this.txtDescripcionUbic.Name = "txtDescripcionUbic";
            this.txtDescripcionUbic.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionUbic.TabIndex = 6;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(38, 172);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 4;
            this.estado.Text = "Estado";
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
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(38, 61);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripción";
            // 
            // btnBuscarUbic
            // 
            this.btnBuscarUbic.Location = new System.Drawing.Point(853, 13);
            this.btnBuscarUbic.Name = "btnBuscarUbic";
            this.btnBuscarUbic.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUbic.TabIndex = 21;
            this.btnBuscarUbic.Text = "Buscar";
            this.btnBuscarUbic.UseVisualStyleBackColor = true;
            this.btnBuscarUbic.Click += new System.EventHandler(this.btnBuscarUbic_Click);
            // 
            // txtBuscarUbic
            // 
            this.txtBuscarUbic.Location = new System.Drawing.Point(386, 15);
            this.txtBuscarUbic.Name = "txtBuscarUbic";
            this.txtBuscarUbic.Size = new System.Drawing.Size(450, 20);
            this.txtBuscarUbic.TabIndex = 24;
            this.txtBuscarUbic.TextChanged += new System.EventHandler(this.txtBuscarUbic_TextChanged);
            // 
            // dgvUbicaciones
            // 
            this.dgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbicaciones.Location = new System.Drawing.Point(386, 52);
            this.dgvUbicaciones.Name = "dgvUbicaciones";
            this.dgvUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUbicaciones.Size = new System.Drawing.Size(542, 247);
            this.dgvUbicaciones.TabIndex = 25;
            this.dgvUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUbicaciones_CellContentClick);
            this.dgvUbicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUbicaciones_CellContentClick);
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 312);
            this.Controls.Add(this.dgvUbicaciones);
            this.Controls.Add(this.txtBuscarUbic);
            this.Controls.Add(this.edificio);
            this.Controls.Add(this.btnBuscarUbic);
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.Ubicaciones_Load);
            this.edificio.ResumeLayout(false);
            this.edificio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel edificio;
        private System.Windows.Forms.ComboBox cmbEstadoUbicacion;
        private System.Windows.Forms.TextBox txtEdificioUbic;
        private System.Windows.Forms.TextBox txtDireccionUbic;
        private System.Windows.Forms.TextBox txtDescripcionUbic;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Button btnBuscarUbic;
        private System.Windows.Forms.Button btnGuardaUbic;
        private System.Windows.Forms.Button btnEliminarUbic;
        private System.Windows.Forms.TextBox txtIdUbic;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtBuscarUbic;
        private System.Windows.Forms.DataGridView dgvUbicaciones;
    }
}