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
    public partial class Ubicaciones : Form
    {
        ActivosFijosEntities db = new ActivosFijosEntities();
        public Ubicaciones()
        {
            InitializeComponent();
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardaUbic_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDescripcionUbic.Text))
            {
                MessageBox.Show("La descripción de la ubicación es obligatoria ", "Error");
                return;
            }

            Ubicacions ubicacion = new Ubicacions();
            ubicacion.Descripcion = txtDescripcionUbic.Text;
            ubicacion.Direccion = txtDireccionUbic.Text;
            ubicacion.Edificio = txtEdificioUbic.Text;
            ubicacion.Estado = cmbEstadoUbicacion.Text;

            db.Ubicacions.Add(ubicacion);
            db.SaveChanges();

            MessageBox.Show("Datos guardados correctamente");

             LlenarGrid();

            txtDescripcionUbic.Text = "";
            txtDireccionUbic.Text = "";
            txtEdificioUbic.Text = "";
            cmbEstadoUbicacion.Text = "";
        }

        private void LlenarGrid()
        {
            dgvUbicaciones.DataSource = db.Ubicacions.ToList();
        }

        private void btnEliminarUbic_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                if (dgvUbicaciones.SelectedRows.Count > 0)
                {

                    int id = Convert.ToInt32(dgvUbicaciones.SelectedRows[0].Cells[0].Value.ToString());

                    var ubicacion = (from ubic in db.Ubicacions
                                        where ubic.Id.Equals(id)
                                        select ubic).FirstOrDefault();

                    if (ubicacion != null)
                    {
                        db.Ubicacions.Remove(ubicacion);
                        db.SaveChanges();
                        MessageBox.Show("Ubicación eliminada con éxito");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ubicación no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna Ubicación");
                }
        }

        private void consultarPorCriterio()
        {
            var ubicacion = from ubic in db.Ubicacions
                               where (ubic.Id.ToString().Contains(txtBuscarUbic.Text) ||
                               ubic.Descripcion.ToString().Contains(txtBuscarUbic.Text) ||
                               ubic.Estado.ToString().Contains(txtBuscarUbic.Text))

                               select ubic;
            dgvUbicaciones.DataSource = ubicacion.ToList();
        }

        private void btnBuscarUbic_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void Ubicaciones_Load(object sender, EventArgs e)
        {
            cmbEstadoUbicacion.SelectedIndex = 0;
            LlenarGrid();
        }

        private void txtBuscarUbic_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarUbic.MaxLength > 0) {
                LlenarGrid();
            }
        }

        private void dgvUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

