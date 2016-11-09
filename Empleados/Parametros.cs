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
    public partial class Parametros : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Parametros()
        {
            InitializeComponent();
        }

        private void tipoPersonaProveedor_Click(object sender, EventArgs e)
        {

        }

        private void dgvParametro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultarPorCriterio()
        {

            var parametro = from Param in db.Parametro
                            where (Param.depreciacionCalculada.ToString().Contains(btnBuscarParametro.Text) ||
                            Param.fechaDepreciacion.ToString().Contains(btnBuscarParametro.Text) ||
                            Param.metodoDepreciacion.ToString().Contains(btnBuscarParametro.Text))

                            select Param;
            dgvParametro.DataSource = parametro.ToList();
        }

        private void btnBuscarParametro_Click(object sender, EventArgs e)
        {

        }

        private void fechaDepreciacion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarParametro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRNC.Text))
            {
                MessageBox.Show("El RNC es obligatorio ", "Error");
                return;
            }

            Parametro parametro = new Parametro();
            parametro.fechaDepreciacion = dateTimeFechaDep.Value;
            parametro.depreciacionCalculada = cmbDepCalculada.Text;
            parametro.metodoDepreciacion = cmbMetodoDeprec.Text;
            parametro.RNC = Convert.ToInt32(txtRNC.Text);

            db.Parametro.Add(parametro);
            db.SaveChanges();

            MessageBox.Show("Datos guardados correctamente");

            LlenarGrid();

            dateTimeFechaDep.Text = "";
            cmbDepCalculada.Text = "";
            cmbMetodoDeprec.Text = "";
            txtRNC.Text = "";



        }

        private void btnBuscarParametro_Click_1(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void LlenarGrid()
        {
            dgvParametro.DataSource = db.Parametro.ToList();
        }

        private void btnEliminarParametro_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dgvParametro.SelectedRows.Count > 0)
                {

                    int id = Convert.ToInt32(dgvParametro.SelectedRows[0].Cells[0].Value.ToString());

                    var parametro = (from param in db.Parametro
                                     where param.Id.Equals(id)
                                     select param).FirstOrDefault();

                    if (parametro != null)
                    {
                        db.Parametro.Remove(parametro);
                        db.SaveChanges();
                        MessageBox.Show("Registro eliminado con éxito");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Registro no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún registro");
                }
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            cmbDepCalculada.SelectedIndex = 0;
            cmbMetodoDeprec.SelectedIndex = 0;
            LlenarGrid();

        }
    }
}
