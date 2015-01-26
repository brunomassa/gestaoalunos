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
            comboBox4.Items.Add("sexo");
            comboBox4.Items.Add("Masculino");
            comboBox4.Items.Add("Feminino");
            
            
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
            Settings.Default["nompai"] = textBox4.Text;
            Settings.Default["nommae"] = textBox5.Text;
            Settings.Default["idadepai"] = textBox6.Text;
            Settings.Default["idademae"] = textBox7.Text;
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
            textBox4.Text = Settings.Default.nompai;
            textBox5.Text = Settings.Default.nommae;
            textBox6.Text = Settings.Default.idadepai;
            textBox7.Text = Settings.Default.idademae;
            MessageBox.Show("Dados carregados com sucesso!", "Carregar");
        }

        private void guardarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection con = new MySqlConnection(conexao);
                MySqlCommand cmd=new MySqlCommand("insert into bdgestaoalunos.alunos(nomealuno,idade,nacionalidade,sexo,codigopostal,ano,numero,turma,nomepai,idadepai,nomemae,idademae) values('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox3.Text+"','"+comboBox4.Text+"','"+textBox8.Text+"-"+textBox9.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"','"+comboBox2.Text+"','"+textBox4.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox7.Text+"')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Aluno adicionado com sucesso!", "Adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex, "Erro");
            }
        }
    }
}
