namespace Mantenimientos
{
    partial class Departamentos
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
            this.txtIdDept = new System.Windows.Forms.TextBox();
            this.ideDept = new System.Windows.Forms.Label();
            this.btnEliminarDept = new System.Windows.Forms.Button();
            this.btnGuardarDept = new System.Windows.Forms.Button();
            this.cmbEstadoDept = new System.Windows.Forms.ComboBox();
            this.txtDescripcionDept = new System.Windows.Forms.TextBox();
            this.estadoDept = new System.Windows.Forms.Label();
            this.descripcionDept = new System.Windows.Forms.Label();
            this.btnBuscarDept = new System.Windows.Forms.Button();
            this.dvgDepartamentos = new System.Windows.Forms.DataGridView();
            this.txtBuscarDept = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdDept);
            this.panel1.Controls.Add(this.ideDept);
            this.panel1.Controls.Add(this.btnEliminarDept);
            this.panel1.Controls.Add(this.btnGuardarDept);
            this.panel1.Controls.Add(this.cmbEstadoDept);
            this.panel1.Controls.Add(this.txtDescripcionDept);
            this.panel1.Controls.Add(this.estadoDept);
            this.panel1.Controls.Add(this.descripcionDept);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 303);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdDept
            // 
            this.txtIdDept.Location = new System.Drawing.Point(98, 46);
            this.txtIdDept.Name = "txtIdDept";
            this.txtIdDept.Size = new System.Drawing.Size(100, 20);
            this.txtIdDept.TabIndex = 23;
            this.txtIdDept.Visible = false;
            // 
            // ideDept
            // 
            this.ideDept.AutoSize = true;
            this.ideDept.Location = new System.Drawing.Point(22, 46);
            this.ideDept.Name = "ideDept";
            this.ideDept.Size = new System.Drawing.Size(16, 13);
            this.ideDept.TabIndex = 22;
            this.ideDept.Text = "Id";
            this.ideDept.Visible = false;
            // 
            // btnEliminarDept
            // 
            this.btnEliminarDept.Location = new System.Drawing.Point(194, 229);
            this.btnEliminarDept.Name = "btnEliminarDept";
            this.btnEliminarDept.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDept.TabIndex = 21;
            this.btnEliminarDept.Text = "Eliminar";
            this.btnEliminarDept.UseVisualStyleBackColor = true;
            this.btnEliminarDept.Click += new System.EventHandler(this.btnEliminarDept_Click);
            // 
            // btnGuardarDept
            // 
            this.btnGuardarDept.Location = new System.Drawing.Point(35, 229);
            this.btnGuardarDept.Name = "btnGuardarDept";
            this.btnGuardarDept.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDept.TabIndex = 19;
            this.btnGuardarDept.Text = "Guardar";
            this.btnGuardarDept.UseVisualStyleBackColor = true;
            this.btnGuardarDept.Click += new System.EventHandler(this.btnGuardarProv_Click);
            // 
            // cmbEstadoDept
            // 
            this.cmbEstadoDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoDept.FormattingEnabled = true;
            this.cmbEstadoDept.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoDept.Location = new System.Drawing.Point(98, 121);
            this.cmbEstadoDept.Name = "cmbEstadoDept";
            this.cmbEstadoDept.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoDept.Sorted = true;
            this.cmbEstadoDept.TabIndex = 5;
            // 
            // txtDescripcionDept
            // 
            this.txtDescripcionDept.Location = new System.Drawing.Point(98, 80);
            this.txtDescripcionDept.Name = "txtDescripcionDept";
            this.txtDescripcionDept.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionDept.TabIndex = 4;
            this.txtDescripcionDept.TextChanged += new System.EventHandler(this.txtDescripcionDept_TextChanged);
            // 
            // estadoDept
            // 
            this.estadoDept.AutoSize = true;
            this.estadoDept.Location = new System.Drawing.Point(22, 124);
            this.estadoDept.Name = "estadoDept";
            this.estadoDept.Size = new System.Drawing.Size(40, 13);
            this.estadoDept.TabIndex = 3;
            this.estadoDept.Text = "Estado";
            // 
            // descripcionDept
            // 
            this.descripcionDept.AutoSize = true;
            this.descripcionDept.Location = new System.Drawing.Point(22, 87);
            this.descripcionDept.Name = "descripcionDept";
            this.descripcionDept.Size = new System.Drawing.Size(63, 13);
            this.descripcionDept.TabIndex = 2;
            this.descripcionDept.Text = "Descripción";
            // 
            // btnBuscarDept
            // 
            this.btnBuscarDept.Location = new System.Drawing.Point(784, 29);
            this.btnBuscarDept.Name = "btnBuscarDept";
            this.btnBuscarDept.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDept.TabIndex = 20;
            this.btnBuscarDept.Text = "Buscar";
            this.btnBuscarDept.UseVisualStyleBackColor = true;
            this.btnBuscarDept.Click += new System.EventHandler(this.btnBuscarDept_Click);
            // 
            // dvgDepartamentos
            // 
            this.dvgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDepartamentos.Location = new System.Drawing.Point(414, 58);
            this.dvgDepartamentos.Name = "dvgDepartamentos";
            this.dvgDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDepartamentos.Size = new System.Drawing.Size(445, 257);
            this.dvgDepartamentos.TabIndex = 2;
            this.dvgDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDepartamentos_CellContentClick);
            // 
            // txtBuscarDept
            // 
            this.txtBuscarDept.Location = new System.Drawing.Point(414, 29);
            this.txtBuscarDept.Name = "txtBuscarDept";
            this.txtBuscarDept.Size = new System.Drawing.Size(348, 20);
            this.txtBuscarDept.TabIndex = 24;
            this.txtBuscarDept.TextChanged += new System.EventHandler(this.txtBuscarDept_TextChanged);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 342);
            this.Controls.Add(this.txtBuscarDept);
            this.Controls.Add(this.dvgDepartamentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarDept);
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ComboBox cmbEstadoDept;
        private System.Windows.Forms.TextBox txtDescripcionDept;
        private System.Windows.Forms.Label estadoDept;
        private System.Windows.Forms.Label descripcionDept;
        private System.Windows.Forms.Button btnEliminarDept;
        private System.Windows.Forms.Button btnBuscarDept;
        private System.Windows.Forms.Button btnGuardarDept;
        private System.Windows.Forms.Label ideDept;
        private System.Windows.Forms.TextBox txtIdDept;
        private System.Windows.Forms.DataGridView dvgDepartamentos;
        private System.Windows.Forms.TextBox txtBuscarDept;
    }
}