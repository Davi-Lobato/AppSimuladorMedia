using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSimuladorMedia.Formulários
{
    public partial class FormNotaMinima : Form
    {
        public FormNotaMinima()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double mf = 0;
            double notaM = 0;

            //notaM = (500-6*mf)/4

            mf = Convert.ToDouble(txtMediaF.Text);
            notaM = (500 - 6 * mf) / 4;

            txtNotaM.Text = txtNome.Text + ", você precisa de " + notaM.ToString() + " para a aprovação" ;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtMediaF.Text = string.Empty;
            txtNotaM.Text = string.Empty;
        }
    }
}
