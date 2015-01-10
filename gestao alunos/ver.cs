using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gestao_alunos.Properties;

namespace gestao_alunos
{
    public partial class ver : Form
    {
        public ver()
        {
            InitializeComponent();
        }

        private void ver_Load(object sender, EventArgs e)
        {
            if (Settings.Default.tema == 0)
            {
                this.BackColor = Color.White;
            }
            if (Settings.Default.tema == 1)
            {
                this.BackColor = Color.Black;
            }
        }
    }
}
