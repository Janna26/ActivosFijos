namespace Departamentos
{
    partial class Departamento
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
            this.cmbEstadoDepartamento = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEstadoDepartamento);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 143);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbEstadoDepartamento
            // 
            this.cmbEstadoDepartamento.FormattingEnabled = true;
            this.cmbEstadoDepartamento.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoDepartamento.Location = new System.Drawing.Point(98, 94);
            this.cmbEstadoDepartamento.Name = "cmbEstadoDepartamento";
            this.cmbEstadoDepartamento.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoDepartamento.Sorted = true;
            this.cmbEstadoDepartamento.TabIndex = 5;
            this.cmbEstadoDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 52);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(22, 94);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 3;
            this.estado.Text = "Estado";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(22, 52);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 2;
            this.descripcion.Text = "Descripción";
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 185);
            this.Controls.Add(this.panel1);
            this.Name = "Departamento";
            this.Text = "Departamentos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.ComboBox cmbEstadoDepartamento;
    }
}

