using Empleados;
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
        private ActivosFijosEntities db = new ActivosFijosEntities();
        private Usuarios usuarioLogeado;

        public Menu()
        {
            InitializeComponent();
        }

        private void CargarMenu()
        {
            // esta parte es un poco ninja


            var permisos = usuarioLogeado.Permiso.ToList(); // aqui buscamos los menues a los cual es usuario puede acceder

            foreach (var permiso in permisos) // por cada uno de los permisos
            {
                // Basicamente lo que haremos sera asignar dinamicamente los elementos de los menues
                // y el evento OnClick de cada uno de estos

                System.Reflection.MethodInfo Show = null; // Aqui se guardara el metodo "Show" del formulario

                Object InstanciaDinamica = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("Mantenimientos." + permiso.Permiso1);
                // El objecto InstanciaDinamica sera realmente un formulario

                if (InstanciaDinamica == null) // Si lo guardaste mal en la base de datos no lo agrego
                    continue;

                var Shows = (InstanciaDinamica.GetType().GetMethods()).Where(a => a.Name == "Show").ToList();
                // Esto aqui es algo enredado, realmente no te esfuerces mucho en averiguar que es esto

                // Esta parte es porque estamos buscando el metodo show
                // que se encuentra en el formulario, pero tiene 2, uno que toma un parametro y otro que no
                // el que nos interesa es el que no coge parametros

                foreach (var s in Shows)
                {
                    // En caso de que no tenga parametros..
                    if (s.GetParameters().Length == 0)
                        Show = s;
                }

                // Agragamos al menu el elemento y su evento click
                menuMantenimiento.DropDownItems.Add(permiso.Permiso1, null, (s, k) => { Show.Invoke(InstanciaDinamica, null); });
            }
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            CargarMenu();
        }

        public void setUsuarioLogeado(Usuarios usuario)
        {
            usuarioLogeado = usuario;
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

        private void tipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDePago tipoPago = new TipoDePago();
            tipoPago.Show();
        }

        private void btnTipoDeActivo_Click(object sender, EventArgs e)
        {
            TipoDeActivo tipoActivo = new TipoDeActivo();
            tipoActivo.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
