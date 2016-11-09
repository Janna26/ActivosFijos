using Mantenimientos;
using global::Empleados;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Mantenimientos
{
    public partial class ActivosFijos : Form
    {

        ActivosFijosEntities db = new ActivosFijosEntities();
        public ActivosFijos()
        {
            InitializeComponent();
        }

        private void fechaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void DepAcumulada_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarActivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDescActivoF.Text))
            {
                MessageBox.Show("La descripción del activo fijo es obligatoria ", "Error");
                return;
            }

            ActivoFijoes activoFijo = new ActivoFijoes();

            activoFijo.Descripcion = cmbDescActivoF.Text;
            activoFijo.Departamento = cmbDeptActivoF.Text;
            activoFijo.tipoActivo = cmbTAcAF.Text;
            activoFijo.Ubicacion = cmbUbicActivoF.Text;
            activoFijo.valorCompra = Convert.ToInt32(txtValorCompraActivoF.Text);
            activoFijo.fechaRegistro = dateTimeActivoF.Value;
            activoFijo.depreciacionAcumulada = Convert.ToString(txtDepAcumAF.Text);


            db.ActivoFijoes.Add(activoFijo);
            db.SaveChanges();


            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();

            cmbDescActivoF.Text = "";
            cmbDeptActivoF.Text = "";
            cmbUbicActivoF.Text = "";
            txtValorCompraActivoF.Text = "";
            txtDepAcumAF.Text = "";
        }

        private void LlenarGrid()
        {
            dgvActivosFijos.DataSource = db.ActivoFijoes.ToList();
        }

        private void txtBuscarActivoF_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivosFijos_Load(object sender, EventArgs e)
        {
            cmbTAcAF.SelectedIndex = 0;
            cmbDescActivoF.SelectedIndex = 0;
            cmbDeptActivoF.SelectedIndex = 0;
            cmbUbicActivoF.SelectedIndex = 0;
            LlenarGrid();


        }

        private void dgvActivosFijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarActivo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dgvActivosFijos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvActivosFijos.SelectedRows[0].Cells[0].Value.ToString());

                    var activoFijo = (from af in db.ActivoFijoes
                                      where af.Id.Equals(id)
                                      select af).FirstOrDefault();

                    if (activoFijo != null)
                    {
                        db.ActivoFijoes.Remove(activoFijo);
                        db.SaveChanges();
                        MessageBox.Show("Activo eliminado con éxito");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Activo no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún activo");
                }
        }


        private void consultarPorCriterio()
        {
            var activoFijo = from af in db.ActivoFijoes
                             where (af.Id.ToString().Contains(txtBuscarActivoF.Text) ||
                             af.Descripcion.ToString().Contains(txtBuscarActivoF.Text) ||
                             af.Ubicacion.ToString().Contains(txtBuscarActivoF.Text)) ||
                             af.tipoActivo.ToString().Contains(txtBuscarActivoF.Text) ||
                             af.Departamento.ToString().Contains(txtBuscarActivoF.Text)

                             select af;
            dgvActivosFijos.DataSource = activoFijo.ToList();
        }

        private void btnBuscarActivoF_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
    }
}

