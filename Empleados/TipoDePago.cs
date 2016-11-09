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
    public partial class TipoDePago : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public TipoDePago()
        {
            InitializeComponent();
        }

        private void TipoDePago_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            cmbDescTipoPago.SelectedIndex = 0;
            LlenarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void consultarPorCriterio()
        {
            var tipoPago = from TipoPago in db.TipoPagoes
                            where (TipoPago.Id.ToString().Contains(txtIdTipoPago.Text) ||
                            TipoPago.Descripcion.ToString().Contains(cmbDescTipoPago.Text) ||
                            TipoPago.Estado.ToString().Contains(cmbEstado.Text))

                            select TipoPago;
            dgvTipoPago.DataSource = tipoPago.ToList();
        }
        private void btnBuscarTipoPago_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void guardarTipoActivo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTA_Click(object sender, EventArgs e)
        {

        }

        private void dgvTipoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdTipoPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDescTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarTipPago_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(cmbEstado.Text))
             {
                 MessageBox.Show("La descripción del tipo de pago es obligatoria ", "Error");
                 return;
             }

            TipoPagoes tipoPago = new TipoPagoes();
            tipoPago.Descripcion = cmbDescTipoPago.Text;
            tipoPago.Estado = cmbEstado.Text;

            db.TipoPagoes.Add(tipoPago);
            db.SaveChanges();



            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();
            cmbDescTipoPago.Text = "";
            cmbEstado.Text = "";

        }

        private void LlenarGrid()
        {
            dgvTipoPago.DataSource = db.TipoPagoes.ToList();
        }

        private void btnEliminarTipoPago_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dgvTipoPago.SelectedRows.Count > 0)
                {

                    int id = Convert.ToInt32(dgvTipoPago.SelectedRows[0].Cells[0].Value.ToString());

                    var tipoPago = (from TipoPago in db.TipoPagoes
                                     where TipoPago.Id.Equals(id)
                                     select TipoPago).FirstOrDefault();

                    if (tipoPago != null)
                    {
                        db.TipoPagoes.Remove(tipoPago);
                        db.SaveChanges();
                        MessageBox.Show("Pago eliminado con éxito");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de pago no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna tipo de pago");
                }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarTipoPago_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscarTipoPago.MaxLength > 0)
            {
                LlenarGrid();
            }
        }
    }
}
