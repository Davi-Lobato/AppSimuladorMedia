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
    public partial class FormSimularMedia : System.Windows.Forms.Form
    {
        public FormSimularMedia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double media = 0;

            //media = (nota1 + nota2)/2

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);

            media = (nota1 + nota2)/2;

            if (media >= 60){
                txtMedia.Text = txtNome.Text + ", párabens você foi aprovado";
            }
            else
            {
                txtMedia.Text = txtNome.Text+", você não foi aprovado";
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtMedia.Text = string.Empty;
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMediaAcademica_Click(object sender, EventArgs e)
        {

        }

        private void lbNota2_Click(object sender, EventArgs e)
        {

        }

        private void lbNota1_Click(object sender, EventArgs e)
        {

        }

        private void lbNomeAcademico_Click(object sender, EventArgs e)
        {

        }
    }
}
