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
            //tema de com branca
            if (Settings.Default.tema == 0)
            {
                this.BackColor = Color.White;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;
                label5.BackColor = Color.White;
                label6.BackColor = Color.White;
                label7.BackColor = Color.White;
                label8.BackColor = Color.White;
                label9.BackColor = Color.White;
                label10.BackColor = Color.White;
                label11.BackColor = Color.White;
                label12.BackColor = Color.White;
                label13.BackColor = Color.White;
                label14.BackColor = Color.White;
                label15.BackColor = Color.White;
                tempo.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                tempo.ForeColor = Color.Black;
            }
            //tema de cor preta
            if (Settings.Default.tema == 1)
            {
                this.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
                label13.BackColor = Color.Black;
                label14.BackColor = Color.Black;
                label15.BackColor = Color.Black;
                tempo.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                tempo.ForeColor = Color.White;
            }
            //timer que inicia o relogio
            timer1.Enabled = true;
            //ultima sessao iniciada
            Settings.Default["sesdia"] = Convert.ToString(DateTime.UtcNow.Day);
            Settings.Default["sesmes"] = Convert.ToString(DateTime.UtcNow.Month);
            Settings.Default["sesano"] = Convert.ToString(DateTime.UtcNow.Year);
            Settings.Default.Save();
            label11.Text = Settings.Default.sesdia;
            label13.Text = Settings.Default.sesmes;
            label15.Text = Settings.Default.sesano;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //relogio
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
