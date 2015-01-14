using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gestao_alunos.Properties;

using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.Types;

namespace gestao_alunos
{
    public partial class editar : Form
    {
        int edit = 0;
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
            comboBox3.Items.Add("sexo");
            comboBox3.Items.Add("Masculino");
            comboBox3.Items.Add("femenino");
            comboBox4.Items.Add("Português");
            comboBox4.Items.Add("Espanhol");
            comboBox4.Items.Add("Françês");
            comboBox4.Items.Add("Italiano");
            comboBox4.Items.Add("Alemão");
            comboBox4.Items.Add("outra");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection con = new MySqlConnection(conexao);
                MySqlCommand cmd = new MySqlCommand("select*from bdgestaoalunos.alunos", con);

                con.Open();
                MySqlDataAdapter adpter = new MySqlDataAdapter();
                adpter.SelectCommand = cmd;
                DataTable dtt = new DataTable();
                adpter.Fill(dtt);
                BindingSource bins = new BindingSource();
                bins.DataSource = dtt;
                dataGridView1.DataSource = bins;
                adpter.Update(dtt);
                con.Close();
                edit = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex, "erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                MessageBox.Show("Primeiro ter de ver o aluno que pretende editar", "Editar");
            }
            else if (edit == 1)
            {

            }
        }
    }
}
