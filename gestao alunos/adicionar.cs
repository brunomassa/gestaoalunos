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
    public partial class adicionar : Form
    {
        public adicionar()
        {
            InitializeComponent();
        }

        private void adicionar_Load(object sender, EventArgs e)
        {
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
            Settings.Default["nome"] = textBox1.Text;
            Settings.Default["idade"] = textBox2.Text;
            Settings.Default["ano"] = comboBox1.Text;
            Settings.Default["numero"] = textBox3.Text;
            Settings.Default["turma"] = comboBox2.Text;
            Settings.Default.Save();
            MessageBox.Show("Dados guardados com sucesso!", "Guardar");
        }

        private void carregarDadosGuardadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.nome;
            textBox2.Text = Settings.Default.idade;
            comboBox1.Text = Settings.Default.ano;
            textBox3.Text = Settings.Default.numero;
            comboBox2.Text = Settings.Default.turma;
            MessageBox.Show("Dados carregados com sucesso!", "Carregar");
        }

        private void guardarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
