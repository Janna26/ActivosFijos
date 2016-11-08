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
    public partial class Proveedores : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[0].Value.ToString());

                    var proveedor = (from prov in db.Proveedors
                                    where prov.Id.Equals(id)
                                     select prov).FirstOrDefault();
                    if (proveedor != null)
                    {
                        db.Proveedors.Remove(proveedor);
                        db.SaveChanges();
                        MessageBox.Show("Proveedor eliminado con éxito");
                        LLenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no existe");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún proveedor");
                }

            }
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedulaProveedor.Text))
            {
                MessageBox.Show("La cédula es obligatoria", "Error");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
            {
                MessageBox.Show("El nombre es obligatorio ", "Error");
                return;
            }

            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = txtNombreProveedor.Text;
            proveedor.Cedula = txtCedulaProveedor.Text;
            proveedor.tipoPersona = cmbTipoPersonaProveedor.Text;
            proveedor.Estado = cmbEstadoProveedor.Text;
            proveedor.fechaRegistro = dateTimeProv.Value;

            db.Proveedors.Add(proveedor);
            db.SaveChanges();

            MessageBox.Show("Datos guardados correctamente");

            LLenarGrid();

            txtNombreProveedor.Text = "";
            txtCedulaProveedor.Text = "";
            cmbTipoPersonaProveedor.Text = "";
            cmbEstadoProveedor.Text = "";
            dateTimeProv.Text = "";
        }

        private void LLenarGrid()
        {
            dgvProveedores.DataSource = db.Proveedors.ToList();
        }


        private void consultarPorCriterio()
        {
           //validar en caso de que no exista el id que se esta buscando, aqui y en los demas mantenimientos
           //validar el campo nombre de este mant y del de empleados para que no tome numeros
            {
                var proveedores = from prov in db.Proveedors
                                  where (prov.Id.ToString().StartsWith(txtBuscarProv.Text) ||
                                prov.Nombre.ToString().StartsWith(txtBuscarProv.Text) ||
                                prov.Cedula.ToString().StartsWith(txtBuscarProv.Text)) ||
                                prov.tipoPersona.ToString().StartsWith(txtBuscarProv.Text)

                                  select prov;
                dgvProveedores.DataSource = proveedores.ToList();
            }
        }
        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cmbEstadoProveedor.SelectedIndex = 0;
            cmbTipoPersonaProveedor.SelectedIndex = 0;
            LLenarGrid();
        }


        private bool validarCedula(string ced)
        {
            string c = ced.Replace("-", "");
            string Cedula = c.Substring(0, c.Length - 1);
            string Verificador = c.Substring(c.Length - 1, 1);
            decimal suma = 0;

            int mod, dig, res;
            res = 0;

            if (txtCedulaProveedor.Text != "")
            {

                if (ced.Length != 11)
                {
                    MessageBox.Show("Cédula incompleta");
                    return false;
                }
                for (int i = 0; i < Cedula.Length; i++)
                {
                    mod = 0;
                    if ((i % 2) == 0) mod = 1;
                    else mod = 2;
                    if (int.TryParse(Cedula.Substring(i, 1), out dig))
                    {
                        res = dig * mod;
                    }
                    else
                    {
                        MessageBox.Show("Cédula contiene caracteres no numéricos");
                        return false;
                    }
                    if (res > 9)
                    {
                        res = Convert.ToInt32(res.ToString().Substring(0, 1)) +
                        Convert.ToInt32(res.ToString().Substring(1, 1));
                    }
                    suma += res;

                }
                decimal el_numero = (10 - (suma % 10)) % 10;
                if ((el_numero.ToString() == Verificador) && (Cedula.Substring(0, 3) != "000"))
                {
                    //MessageBox.Show("La Cedula es valida");
                    return true;
                }
                else
                {
                    MessageBox.Show("La Cedula es ilegal \n" + "el digito verificador debio ser " + el_numero.ToString());
                    return false;
                }

            }
            return true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCedulaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCedulaProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvProveedores.SelectedRows[0];
            Proveedor proveedor = new Proveedor();
            txtNombreProveedor.Text = row.Cells[1].Value.ToString();
            txtCedulaProveedor.Text = row.Cells[2].Value.ToString();
            cmbTipoPersonaProveedor.Text = row.Cells[3].Value.ToString();
            cmbEstadoProveedor.Text = row.Cells[4].Value.ToString();
        }

        private void txtBuscarProv_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProv.MaxLength > 0)
            {
                LLenarGrid();
            }
        }

        private void cmbTipoPersonaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
