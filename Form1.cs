using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSimuladorMedia.Formulários;

namespace AppSimuladorMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            FormSimularMedia form = new FormSimularMedia();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNotaMinima_Click(object sender, EventArgs e)
        {
            FormNotaMinima form = new FormNotaMinima();
            form.ShowDialog();
        }

        private void btMediaFinal_Click(object sender, EventArgs e)
        {
            FormMediaFinal form = new FormMediaFinal();
            form.ShowDialog();
        }
    }
}
