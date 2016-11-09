using Empleados;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Mantenimientos
{
    public partial class TipoDeActivo : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public TipoDeActivo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void consultarPorCriterio()
        {
            var tipoActivo = from TA in db.TipoActivoes
                            where (TA.Id.ToString().Contains(txtBuscarTipoAct.Text) ||
                            TA.Descripcion.ToString().Contains(txtBuscarTipoAct.Text) ||
                            TA.Estado.ToString().Contains(txtBuscarTipoAct.Text))
                           
                            select TA;
            dgvTipoActivo.DataSource = tipoActivo.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarTipoAct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCCC.Text))
            {
                MessageBox.Show("La cuenta contable compra es obligatoria ", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCCD.Text))
            {
                MessageBox.Show("Lacuenta contable depreciación es obligatoria ", "Error");
                return;
            }

            TipoActivo tipoActivo = new TipoActivo();
            tipoActivo.Descripcion = cmbDescTipoAct.Text;
            tipoActivo.cuentaContableCompra = Convert.ToInt32(txtCCC.Text);
            tipoActivo.cuentaContableDepreciacion = Convert.ToInt32(txtCCD.Text);
            tipoActivo.Estado = cmbEstadoTA.Text;

            db.TipoActivo.Add(tipoActivo);
            db.SaveChanges(); 

            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();
            cmbDescTipoAct.Text = "";
            txtCCC.Text = "";
            txtCCD.Text = "";
            cmbEstadoTA.Text = "";
        }

        private void LlenarGrid()
        {
            dgvTipoActivo.DataSource = db.TipoActivoes.ToList();
        }

        private void eliminarTipoAct_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dgvTipoActivo.SelectedRows.Count > 0)
                {

                    int id = Convert.ToInt32(dgvTipoActivo.SelectedRows[0].Cells[0].Value.ToString());

                    var tipoActivo = (from TA in db.TipoActivoes
                                     where TA.Id.Equals(id)
                                     select TA).FirstOrDefault();

                    if (tipoActivo != null)
                    {
                        db.TipoActivoes.Remove(tipoActivo);
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

        private void btnBuscarTA_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void TipoDeActivo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            cmbDescTipoAct.SelectedIndex = 0;
            cmbEstadoTA.SelectedIndex = 0;
        }
    }
    
}
