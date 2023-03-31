using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructura_de_Datos
{
    public partial class frmStructuradato : Form
    {
        public frmStructuradato()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosPersonaLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            {
              frmSist sistema = new frmSist();
                sistema.ShowDialog();
                sistema.ShowDialog(this);

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
