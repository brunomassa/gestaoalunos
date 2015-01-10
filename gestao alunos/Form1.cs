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
using gestao_alunos.Properties;

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
            Settings.Default.janela = 0;
            WindowState = FormWindowState.Maximized;
            paginaprincipal pcp = new paginaprincipal();
            pcp.MdiParent = this;
            pcp.WindowState = FormWindowState.Maximized;
            pcp.Show();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            Settings.Default.janela = 1;
            adicionar adaluno = new adicionar();
            adaluno.MdiParent = this;
            adaluno.WindowState = FormWindowState.Maximized;
            adaluno.Show();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            Settings.Default.janela = 4;
            ver als = new ver();
            als.MdiParent = this;
            als.WindowState = FormWindowState.Maximized;
            als.Show();
        }

        private void ribbonOrbMenuItem1_Click(object sender, EventArgs e)
        {
            Settings.Default.janela = 0;
            paginaprincipal pcp = new paginaprincipal();
            pcp.MdiParent = this;
            pcp.WindowState = FormWindowState.Maximized;
            pcp.Show();
        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            var Sobre = new sobre();
            Sobre.Show();
        }

        private void ribbonOrbMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            Settings.Default.janela = 2;
            remover remoaluno = new remover();
            remoaluno.MdiParent = this;
            remoaluno.WindowState = FormWindowState.Maximized;
            remoaluno.Show();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            Settings.Default.janela = 3;
            editar edit = new editar();
            edit.MdiParent = this;
            edit.WindowState = FormWindowState.Maximized;
            edit.Show();
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            Settings.Default["tema"] = 0;
            Settings.Default.Save();
            if (Settings.Default.janela == 0)
            {
                Settings.Default.janela = 0;
                WindowState = FormWindowState.Maximized;
                paginaprincipal pcp = new paginaprincipal();
                pcp.MdiParent = this;
                pcp.WindowState = FormWindowState.Maximized;
                pcp.Show();
            }
            if (Settings.Default.janela == 1)
            {
                Settings.Default.janela = 1;
                adicionar adaluno = new adicionar();
                adaluno.MdiParent = this;
                adaluno.WindowState = FormWindowState.Maximized;
                adaluno.Show();
            }
            if (Settings.Default.janela == 2)
            {
                Settings.Default.janela = 2;
                remover remoaluno = new remover();
                remoaluno.MdiParent = this;
                remoaluno.WindowState = FormWindowState.Maximized;
                remoaluno.Show();
            }
            if (Settings.Default.janela == 3)
            {
                Settings.Default.janela = 3;
                editar edit = new editar();
                edit.MdiParent = this;
                edit.WindowState = FormWindowState.Maximized;
                edit.Show();
            }
            if (Settings.Default.janela == 4)
            {
                Settings.Default.janela = 4;
                ver als = new ver();
                als.MdiParent = this;
                als.WindowState = FormWindowState.Maximized;
                als.Show();
            }
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            Settings.Default["tema"] = 1;
            Settings.Default.Save();
            if (Settings.Default.janela == 0)
            {
                Settings.Default.janela = 0;
                WindowState = FormWindowState.Maximized;
                paginaprincipal pcp = new paginaprincipal();
                pcp.MdiParent = this;
                pcp.WindowState = FormWindowState.Maximized;
                pcp.Show();
            }
            if (Settings.Default.janela == 1)
            {
                Settings.Default.janela = 1;
                adicionar adaluno = new adicionar();
                adaluno.MdiParent = this;
                adaluno.WindowState = FormWindowState.Maximized;
                adaluno.Show();
            }
            if (Settings.Default.janela == 2)
            {
                Settings.Default.janela = 2;
                remover remoaluno = new remover();
                remoaluno.MdiParent = this;
                remoaluno.WindowState = FormWindowState.Maximized;
                remoaluno.Show();
            }
            if (Settings.Default.janela == 3)
            {
                Settings.Default.janela = 3;
                editar edit = new editar();
                edit.MdiParent = this;
                edit.WindowState = FormWindowState.Maximized;
                edit.Show();
            }
            if (Settings.Default.janela == 4)
            {
                Settings.Default.janela = 4;
                ver als = new ver();
                als.MdiParent = this;
                als.WindowState = FormWindowState.Maximized;
                als.Show();
            }
        }
    }
}
