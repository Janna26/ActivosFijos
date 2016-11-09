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
            /*Esto es un comment de prueba*/
         /*   var parametro = from Param in db.Parametroes
                           where (Param.añoProceso.ToString().Contains(txtNAnoProceso.Text) ||
                           Param.mesProceso.ToString().Contains(tx.Text) ||
                           Param.de.ToString().Contains(txt.Text))

                           select Param;
            dgvParametro.DataSource = parametro.ToList();*/
        }
        private void btnBuscarParametro_Click(object sender, EventArgs e)
        {

        }
    }
}
