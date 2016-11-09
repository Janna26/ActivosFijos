using Empleados;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Mantenimientos
{
    public partial class Empleados : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Empleados()
        {
            InitializeComponent();
            dateTimeEmpleado.MaxDate = DateTime.Now;
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
            if (string.IsNullOrWhiteSpace(txtCedulaEmp.Text)) {
                MessageBox.Show("La Cedula es obligatoria", "Error");
                return;
            }
            

            if (string.IsNullOrWhiteSpace(txtNombreEmp.Text))
            {
                MessageBox.Show("El nombre es obligatorio ", "Error");
                return;
            }
            
            Empleadoes empleado = new Empleadoes();
            empleado.Cedula = txtCedulaEmp.Text;
            empleado.Nombre = txtNombreEmp.Text;
            empleado.Departamento = txtDeptEmp.Text;
            empleado.tipoPersona = cmbTipoPersona.Text;
            empleado.fechaIngreso = dateTimeEmpleado.Value;
            empleado.Estado = cmbEstadoEmpleado.Text;

            db.Empleadoes.Add(empleado);
            db.SaveChanges();

            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();

            txtNombreEmp.Text = "";
            txtCedulaEmp.Text = "";
            txtDeptEmp.Text = "";
            cmbTipoPersona.Text = "";
            cmbEstadoEmpleado.Text = "";
            fechaIngreso.Text = "";
            
        }

        private void LlenarGrid()
        {
            dgvEmpleados.DataSource = db.Empleadoes.ToList();
        }

        private void dateTimeEmpleado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cmbEstadoEmpleado.SelectedIndex = 0;
            cmbTipoPersona.SelectedIndex = 0;
            txtDeptEmp.SelectedIndex = 0;
            LlenarGrid();
         
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
        private void consultarPorCriterio()
        {
            var empleados = from em in db.Empleadoes
                            where (em.Id.ToString().Contains(txtBuscarEmpleado.Text) ||
                            em.Nombre.ToString().Contains(txtBuscarEmpleado.Text) ||
                            em.Cedula.ToString().Contains(txtBuscarEmpleado.Text)) ||
                            em.Departamento.ToString().Contains(txtBuscarEmpleado.Text)

                            select em;
            dgvEmpleados.DataSource = empleados.ToList();
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnEliminarEmp_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());

                    var empleado = (from emp in db.Empleadoes
                                    where emp.Id.Equals(id)
                                    select emp).FirstOrDefault();

                    if (empleado != null)
                    {
                        db.Empleadoes.Remove(empleado);
                        db.SaveChanges();
                        MessageBox.Show("Empleado eliminado con éxito");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Empleado no existe");
                    }
                }
                else {
                    MessageBox.Show("No se ha seleccionado ningún empleado");
                }
                
            }

            
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dgvEmpleados.SelectedRows[0];
            Empleadoes empleado = new Empleadoes();
            //txtIdEmp.Text = row.Cells[0].Value.ToString();
            txtNombreEmp.Text = row.Cells[1].Value.ToString();
            txtCedulaEmp.Text = row.Cells[2].Value.ToString();
            txtDeptEmp.Text = row.Cells[3].Value.ToString();
            cmbTipoPersona.Text = row.Cells[4].Value.ToString();
            //dateTimeEmpleado.Date = DateTime.Parse(row.Cells[5].Value.ToString());
            cmbEstadoEmpleado.Text = row.Cells[6].Value.ToString();


        }

        private void Empleados_Activated(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEmp_TextChanged(object sender, EventArgs e)
        {

        }





        private bool validarCedula(string ced)
        {
            string c = ced.Replace("-", "");
            string Cedula = c.Substring(0, c.Length - 1);
            string Verificador = c.Substring(c.Length - 1, 1);
            decimal suma = 0;

            int mod, dig, res;
            res = 0;

            if (txtCedulaEmp.Text != "")
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


        private void txtDeptEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.MaxLength > 0)
            {
                LlenarGrid();
            }
        }

        private void txtNombreEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            MessageBox.Show("Sólo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }

        private void Empleados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

  
    }
}
