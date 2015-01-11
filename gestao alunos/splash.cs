using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestao_alunos
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar modificada
            amazingProgressBar1.Increment(1);
            label3.Text = "( " + Convert.ToString(amazingProgressBar1.Value) + "% )";
            if (amazingProgressBar1.Value == 50)
            {
                label2.Text = "A Iniciar";
            }
            else if (amazingProgressBar1.Value == 101)
            {
                timer1.Stop();
                
            }
        }
    }
}
