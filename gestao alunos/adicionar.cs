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
            comboBox3.Items.Add("Português");
            comboBox3.Items.Add("Espanhol");
            comboBox3.Items.Add("Françês");
            comboBox3.Items.Add("Italiano");
            comboBox3.Items.Add("Alemão");
            comboBox3.Items.Add("outra");
            comboBox4.Items.Add("Português");
            comboBox4.Items.Add("Espanhol");
            comboBox4.Items.Add("Françês");
            comboBox4.Items.Add("Italiano");
            comboBox4.Items.Add("Alemão");
            comboBox4.Items.Add("outra");
            comboBox5.Items.Add("Português");
            comboBox5.Items.Add("Espanhol");
            comboBox5.Items.Add("Françês");
            comboBox5.Items.Add("Italiano");
            comboBox5.Items.Add("Alemão");
            comboBox5.Items.Add("outra");
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
