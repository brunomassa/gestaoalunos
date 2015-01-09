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
    public partial class paginaprincipal : Form
    {
        private int hr;
        private int min;
        private int sec;
        public paginaprincipal()
        {
            InitializeComponent();
        }

        private void paginaprincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
            label1.Text =Convert.ToString(DateTime.UtcNow.DayOfWeek)+" "+Convert.ToString(DateTime.UtcNow.Day)+"/"+Convert.ToString(DateTime.UtcNow.Month)+"/"+Convert.ToString(DateTime.UtcNow.Year);

            if (sec % 2 == 0)
            {
                tempo.Text = hr + ":" + min;
            }
            else
            {
                tempo.Text = hr + " " + min;
            }
        }
    }
}
