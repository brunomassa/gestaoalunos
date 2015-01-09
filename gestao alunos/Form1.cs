using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace gestao_alunos
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            Thread str = new Thread(new ThreadStart(splash));
            str.Start();
            Thread.Sleep(10750);
            InitializeComponent();
            str.Abort();
        }
        public void splash()
        {
            Application.Run(new splash());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Maximized;
            paginaprincipal pcp = new paginaprincipal();
            pcp.MdiParent = this;
            pcp.WindowState = FormWindowState.Maximized;
            pcp.Show();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            adicionar adaluno = new adicionar();
            adaluno.MdiParent = this;
            adaluno.WindowState = FormWindowState.Maximized;
            adaluno.Show();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            ver als = new ver();
            als.MdiParent = this;
            als.WindowState = FormWindowState.Maximized;
            als.Show();
        }
    }
}
