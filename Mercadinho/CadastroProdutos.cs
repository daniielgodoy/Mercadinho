using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class CadastroProdutos : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public CadastroProdutos()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_vendas;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if (textBoxDESCRICAO.Text != "" && textBoxVALOR.Text != "" && textBoxCENTAVO.Text != "")
            {
                try
                {

                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_produtos(descricao, preco) VALUES('" + textBoxDESCRICAO.Text + "', '" + textBoxVALOR.Text + "" + labelPONTO.Text + "" + textBoxCENTAVO.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado!");
                }
                catch (Exception erro_mysql)
                {
                    MessageBox.Show(erro_mysql.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos campos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaGerente = new TelaGerente();
            TelaGerente.FormClosed += (s, args) => this.Close();
            TelaGerente.Show();
        }
    }
}
