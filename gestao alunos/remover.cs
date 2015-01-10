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
    public partial class remover : Form
    {
        public remover()
        {
            InitializeComponent();
        }

        private void remover_Load(object sender, EventArgs e)
        {
            if (Settings.Default.tema == 0)
            {
                this.BackColor = Color.White;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;
                label5.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if (Settings.Default.tema == 1)
            {
                this.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox2.Items.Add("IG");
            comboBox2.Items.Add("D");
            comboBox2.Items.Add("E");
            comboBox2.Items.Add("CSA");
            comboBox2.Items.Add("CSB");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default["remonome"] = textBox1.Text;
            Settings.Default["remoidade"] = textBox2.Text;
            Settings.Default["remoano"] = comboBox1.Text;
            Settings.Default["remonum"] = textBox3.Text;
            Settings.Default["remoturma"] = comboBox2.Text;
            Settings.Default.Save();
            MessageBox.Show("Dados guardados com sucesso!", "Guardar");
        }

        private void carregarDadosGuardadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.remonome;
            textBox2.Text = Settings.Default.remoidade;
            comboBox1.Text = Settings.Default.remoano;
            textBox3.Text = Settings.Default.remonum;
            comboBox2.Text = Settings.Default.remoturma;
            MessageBox.Show("Dados carregados com sucesso!", "Carregar");
        }
    }
}
