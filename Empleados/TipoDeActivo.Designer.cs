namespace Mantenimientos
{
    partial class TipoDeActivo
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
            this.id = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.cuentaCC = new System.Windows.Forms.Label();
            this.cuentaCD = new System.Windows.Forms.Label();
            this.estadoTipoActivo = new System.Windows.Forms.Label();
            this.txtIdTipoActivo = new System.Windows.Forms.TextBox();
            this.txtCCD = new System.Windows.Forms.TextBox();
            this.txtCCC = new System.Windows.Forms.TextBox();
            this.cmbDescTipoAct = new System.Windows.Forms.ComboBox();
            this.cmbEstadoTA = new System.Windows.Forms.ComboBox();
            this.btnBuscarTipoAct = new System.Windows.Forms.Button();
            this.eliminarTipoAct = new System.Windows.Forms.Button();
            this.dgvTipoActivo = new System.Windows.Forms.DataGridView();
            this.txtBuscarTipoAct = new System.Windows.Forms.TextBox();
            this.buscarTipoAct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eliminarTipoAct);
            this.panel1.Controls.Add(this.btnBuscarTipoAct);
            this.panel1.Controls.Add(this.cmbEstadoTA);
            this.panel1.Controls.Add(this.cmbDescTipoAct);
            this.panel1.Controls.Add(this.txtCCC);
            this.panel1.Controls.Add(this.txtCCD);
            this.panel1.Controls.Add(this.txtIdTipoActivo);
            this.panel1.Controls.Add(this.estadoTipoActivo);
            this.panel1.Controls.Add(this.cuentaCD);
            this.panel1.Controls.Add(this.cuentaCC);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(26, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 319);
            this.panel1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(19, 25);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 0;
            this.id.Text = "Id";
            this.id.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(19, 66);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripción";
            // 
            // cuentaCC
            // 
            this.cuentaCC.AutoSize = true;
            this.cuentaCC.Location = new System.Drawing.Point(19, 119);
            this.cuentaCC.Name = "cuentaCC";
            this.cuentaCC.Size = new System.Drawing.Size(125, 13);
            this.cuentaCC.TabIndex = 2;
            this.cuentaCC.Text = "Cuenta Contable Compra";
            // 
            // cuentaCD
            // 
            this.cuentaCD.AutoSize = true;
            this.cuentaCD.Location = new System.Drawing.Point(19, 179);
            this.cuentaCD.Name = "cuentaCD";
            this.cuentaCD.Size = new System.Drawing.Size(152, 13);
            this.cuentaCD.TabIndex = 3;
            this.cuentaCD.Text = "Cuenta Contable Depreciación";
            this.cuentaCD.Click += new System.EventHandler(this.label4_Click);
            // 
            // estadoTipoActivo
            // 
            this.estadoTipoActivo.AutoSize = true;
            this.estadoTipoActivo.Location = new System.Drawing.Point(19, 229);
            this.estadoTipoActivo.Name = "estadoTipoActivo";
            this.estadoTipoActivo.Size = new System.Drawing.Size(40, 13);
            this.estadoTipoActivo.TabIndex = 4;
            this.estadoTipoActivo.Text = "Estado";
            this.estadoTipoActivo.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIdTipoActivo
            // 
            this.txtIdTipoActivo.Location = new System.Drawing.Point(174, 25);
            this.txtIdTipoActivo.Name = "txtIdTipoActivo";
            this.txtIdTipoActivo.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoActivo.TabIndex = 5;
            this.txtIdTipoActivo.Visible = false;
            // 
            // txtCCD
            // 
            this.txtCCD.Location = new System.Drawing.Point(174, 179);
            this.txtCCD.Name = "txtCCD";
            this.txtCCD.Size = new System.Drawing.Size(100, 20);
            this.txtCCD.TabIndex = 6;
            this.txtCCD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCCC
            // 
            this.txtCCC.Location = new System.Drawing.Point(174, 119);
            this.txtCCC.Name = "txtCCC";
            this.txtCCC.Size = new System.Drawing.Size(100, 20);
            this.txtCCC.TabIndex = 7;
            // 
            // cmbDescTipoAct
            // 
            this.cmbDescTipoAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescTipoAct.FormattingEnabled = true;
            this.cmbDescTipoAct.Items.AddRange(new object[] {
            "Ejemplo1",
            "Ejemplo2"});
            this.cmbDescTipoAct.Location = new System.Drawing.Point(174, 63);
            this.cmbDescTipoAct.Name = "cmbDescTipoAct";
            this.cmbDescTipoAct.Size = new System.Drawing.Size(100, 21);
            this.cmbDescTipoAct.TabIndex = 8;
            // 
            // cmbEstadoTA
            // 
            this.cmbEstadoTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoTA.FormattingEnabled = true;
            this.cmbEstadoTA.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoTA.Location = new System.Drawing.Point(174, 221);
            this.cmbEstadoTA.Name = "cmbEstadoTA";
            this.cmbEstadoTA.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoTA.TabIndex = 9;
            // 
            // btnBuscarTipoAct
            // 
            this.btnBuscarTipoAct.Location = new System.Drawing.Point(22, 276);
            this.btnBuscarTipoAct.Name = "btnBuscarTipoAct";
            this.btnBuscarTipoAct.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipoAct.TabIndex = 10;
            this.btnBuscarTipoAct.Text = "Guardar";
            this.btnBuscarTipoAct.UseVisualStyleBackColor = true;
            // 
            // eliminarTipoAct
            // 
            this.eliminarTipoAct.Location = new System.Drawing.Point(174, 276);
            this.eliminarTipoAct.Name = "eliminarTipoAct";
            this.eliminarTipoAct.Size = new System.Drawing.Size(75, 23);
            this.eliminarTipoAct.TabIndex = 11;
            this.eliminarTipoAct.Text = "Eliminar";
            this.eliminarTipoAct.UseVisualStyleBackColor = true;
            // 
            // dgvTipoActivo
            // 
            this.dgvTipoActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoActivo.Location = new System.Drawing.Point(343, 57);
            this.dgvTipoActivo.Name = "dgvTipoActivo";
            this.dgvTipoActivo.Size = new System.Drawing.Size(579, 294);
            this.dgvTipoActivo.TabIndex = 1;
            // 
            // txtBuscarTipoAct
            // 
            this.txtBuscarTipoAct.Location = new System.Drawing.Point(343, 32);
            this.txtBuscarTipoAct.Name = "txtBuscarTipoAct";
            this.txtBuscarTipoAct.Size = new System.Drawing.Size(456, 20);
            this.txtBuscarTipoAct.TabIndex = 12;
            // 
            // buscarTipoAct
            // 
            this.buscarTipoAct.Location = new System.Drawing.Point(847, 29);
            this.buscarTipoAct.Name = "buscarTipoAct";
            this.buscarTipoAct.Size = new System.Drawing.Size(75, 23);
            this.buscarTipoAct.TabIndex = 12;
            this.buscarTipoAct.Text = "Buscar";
            this.buscarTipoAct.UseVisualStyleBackColor = true;
            this.buscarTipoAct.Click += new System.EventHandler(this.button3_Click);
            // 
            // TipoDeActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 371);
            this.Controls.Add(this.buscarTipoAct);
            this.Controls.Add(this.txtBuscarTipoAct);
            this.Controls.Add(this.dgvTipoActivo);
            this.Controls.Add(this.panel1);
            this.Name = "TipoDeActivo";
            this.Text = "Tipos de Activos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cuentaCD;
        private System.Windows.Forms.Label cuentaCC;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtIdTipoActivo;
        private System.Windows.Forms.Label estadoTipoActivo;
        private System.Windows.Forms.ComboBox cmbEstadoTA;
        private System.Windows.Forms.ComboBox cmbDescTipoAct;
        private System.Windows.Forms.TextBox txtCCC;
        private System.Windows.Forms.TextBox txtCCD;
        private System.Windows.Forms.Button eliminarTipoAct;
        private System.Windows.Forms.Button btnBuscarTipoAct;
        private System.Windows.Forms.DataGridView dgvTipoActivo;
        private System.Windows.Forms.TextBox txtBuscarTipoAct;
        private System.Windows.Forms.Button buscarTipoAct;
    }
}