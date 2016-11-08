using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void departamento_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaIngresoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ActivosFijosEntities db = new ActivosFijosEntities();


            db.Empleadoes.Add(new Empleado
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Departamento = txtDepartamento.Text,
                tipoPersona = cmbEstadoEmpleado.Text
            });

            db.SaveChanges();
            MessageBox.Show("Datos guardados correctamente");
            this.Close();
        }
    }
}
