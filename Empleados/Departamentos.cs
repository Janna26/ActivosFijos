using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Mantenimientos
{

    public partial class Departamentos : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Departamentos()
        {
            InitializeComponent();
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            /*if ()
            { validar el campo desc para q no tome numeros

            }*/

            if (string.IsNullOrWhiteSpace(txtDescripcionDept.Text))
            {
                MessageBox.Show("La descripción del departamento es obligatoria ", "Error");
                return;
            }

            Departamento departamento = new Departamento();
            departamento.Descripcion = txtDescripcionDept.Text;
            departamento.Estado = cmbEstadoDept.Text;

            db.Departamentoes.Add(departamento);
            db.SaveChanges();

            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();

            txtDescripcionDept.Text = "";
            cmbEstadoDept.Text = "";
        }

        private void LlenarGrid()
        {
            dvgDepartamentos.DataSource = db.Departamentoes.ToList();
        }

        private void dvgDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarDept_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dvgDepartamentos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dvgDepartamentos.SelectedRows[0].Cells[0].Value.ToString());

                var departamento = (from emp in db.Departamentoes
                                where emp.Id.Equals(id)
                                select emp).FirstOrDefault();

                if (departamento != null)
                {
                    db.Departamentoes.Remove(departamento);
                    db.SaveChanges();
                    MessageBox.Show("Departamento eliminado con éxito");
                    LlenarGrid();
                }
                else
                {
                    MessageBox.Show("Departamento no existe");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún departamento");
            }
        }

        private void consultarPorCriterio()
        {
            var departamento = from dept in db.Departamentoes
                            where (dept.Id.ToString().Contains(txtBuscarDept.Text) ||
                            dept.Descripcion.ToString().Contains(txtBuscarDept.Text) ||
                            dept.Estado.ToString().Contains(txtBuscarDept.Text)) 

                            select dept;
            dvgDepartamentos.DataSource = departamento.ToList();
        }

        private void btnBuscarDept_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            cmbEstadoDept.SelectedIndex = 0;
            LlenarGrid();
        }

        private void txtDescripcionDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarDept_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarDept.MaxLength > 0)
            {
                LlenarGrid();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
