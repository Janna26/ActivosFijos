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
    public partial class Login : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void restablecerLogin()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
        }

        private void hacerLogin()
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Debe completar ambos campos");
                return;
            }

            /*var usuarioRetornado = from user in db.Usuarios
                            where (user.Usuario1.ToString().Contains(txtUsuario.Text) &&
                            user.Clave.ToString().Contains(txtClave.Text))

                            select user;
                            */
            var usuarioRetornado = db.Usuarios.FirstOrDefault(a => a.Usuario1.Equals(usuario));

            //si el usuario no es encontrado
            if (usuarioRetornado == null)
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }

            //si la clave no coincide
            if (!usuarioRetornado.Clave.Equals(clave))
            {
                MessageBox.Show("Password invalido");
                return;
            }

            //finalmente si todo salio bien

            Menu menues = new Mantenimientos.Menu();
            menues.setUsuarioLogeado(usuarioRetornado); // le mando el usuario que me devolvio para luego evaluar sus permisos
            menues.Show(); // mosstrar el menu

            this.Hide(); // ocultar el formulario de login

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            hacerLogin();
        }


        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                hacerLogin();
        }
    }
}
