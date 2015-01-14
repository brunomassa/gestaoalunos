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
    public partial class ver : Form
    {
        public ver()
        {
            InitializeComponent();
        }

        private void ver_Load(object sender, EventArgs e)
        {
            if (Settings.Default.tema == 0)
            {
                this.BackColor = Color.White;
            }
            if (Settings.Default.tema == 1)
            {
                this.BackColor = Color.Black;
            }
            try
            {
                string conexao = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection con = new MySqlConnection(conexao);
                MySqlCommand cmd = new MySqlCommand("select*from bdgestaoalunos.alunos",con);

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex, "erro");
            }
        }
    }
}
