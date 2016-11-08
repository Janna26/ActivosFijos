using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Mantenimientos.Empleados emp = new Mantenimientos.Empleados();
            emp.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            Departamentos dept = new Departamentos();
            dept.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.Show();
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            Ubicaciones ubic = new Ubicaciones();
            ubic.Show();
        }

        private void btnParámetros_Click(object sender, EventArgs e)
        {
           Parametros param = new Parametros();
            param.Show();
        }

        private void btnActivosFijos_Click(object sender, EventArgs e)
        {
            ActivosFijos activos = new ActivosFijos();
            activos.Show();
        }

        private void btncalculoDepreciacionAF_Click(object sender, EventArgs e)
        {

        }
    }
}
