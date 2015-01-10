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
    public partial class editar : Form
    {
        public editar()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default["editnome"] = textBox1.Text;
            Settings.Default["editidade"] = textBox2.Text;
            Settings.Default["editano"] = comboBox1.Text;
            Settings.Default["editnum"] = textBox3.Text;
            Settings.Default["editturma"] = comboBox2.Text;
            Settings.Default.Save();
            MessageBox.Show("Dados guardados com sucesso!", "Guardar");
        }

        private void carregarDadosGuardadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.editnome;
            textBox2.Text = Settings.Default.editidade;
            comboBox1.Text = Settings.Default.editano;
            textBox3.Text = Settings.Default.editnum;
            comboBox2.Text = Settings.Default.editturma;
            MessageBox.Show("Dados carregados com sucesso!", "Carregar");
        }

        private void editar_Load(object sender, EventArgs e)
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
    }
}
