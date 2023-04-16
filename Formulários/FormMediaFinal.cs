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
    public partial class FormMediaFinal : Form
    {
        public FormMediaFinal()
        {
            InitializeComponent();
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double mf = 0;
            double exame = 0;
            double media = 0;

            //media = (6*mf + 4*exame)/10

            mf = Convert.ToDouble(txtMediaFinal.Text);
            exame = Convert.ToDouble(txtExame.Text);
            media = (6*mf + 4*exame)/10;

            if(media >= 50)
            {
                txtMedia.Text = txtNome.Text +", parabéns você foi aprovado com uma média de "+ media.ToString();
            }
            else
            {
                txtMedia.Text = txtNome.Text + ", você não foi aprovado com uma média de " + media.ToString();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtMediaFinal.Text = string.Empty;
            txtExame.Text = string.Empty;
            txtMedia.Text = string.Empty;
        }
    }
}
