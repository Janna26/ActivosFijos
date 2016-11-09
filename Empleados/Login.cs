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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Debe completar ambos campos");
                txtUsuario.Focus();
                return;
            }
            else {
                /*var usuarioRetornado = from user in db.Usuarios
                                where (user.Usuario1.ToString().Contains(txtUsuario.Text) &&
                                user.Clave.ToString().Contains(txtClave.Text))

                                select user;
                                */
                var usuarioRetornado = db.Usuarios.FirstOrDefault(a=>a.Usuario1.Equals(usuario));
                if (usuarioRetornado != null)
                {
                    if (usuarioRetornado.Clave.Equals(clave))
                    {
                        MessageBox.Show("Felicidades Janna, Eres Dura");
                    }
                    else {
                        MessageBox.Show("Fracase -_-");
                    }
                }
                else {
                    MessageBox.Show("NO encontre na de naaa!!");
                }


            }

        }
    }
}
