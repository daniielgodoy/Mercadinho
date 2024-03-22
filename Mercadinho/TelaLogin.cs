using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mercadinho
{
    public partial class TelaLogin : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string cargo;
        public TelaLogin()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_vendas;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {

                conexao.Open();
                comando.CommandText = "SELECT cpf, senha FROM tbl_funcionarios WHERE cpf = '"+textBoxLOGIN.Text+"' AND senha = '"+textBoxSENHA.Text+"';";
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    try
                    {

                        conexao.Open();
                        comando.CommandText = "SELECT cargo FROM tbl_funcionarios WHERE cpf = '" + textBoxLOGIN.Text + "' AND senha = '" + textBoxSENHA.Text + "' AND cargo = 'Gerente';";
                        MySqlDataReader resultado2 = comando.ExecuteReader();

                        if (resultado2.Read())
                        {
                            this.Hide();
                            Form TelaGerente = new TelaGerente();
                            TelaGerente.FormClosed += (s, args) => this.Close();
                            TelaGerente.Show();
                        }
                        else
                        {
                            conexao.Close();
                            try
                            {

                                conexao.Open();
                                comando.CommandText = "SELECT id FROM tbl_funcionarios WHERE cpf = '" + textBoxLOGIN.Text + "' AND senha = '" + textBoxSENHA.Text + "' AND cargo = 'Funcionário';";
                                MySqlDataReader resultado3 = comando.ExecuteReader();

                                if (resultado3.Read())
                                {
                                    variavel.id_func = resultado3.GetInt32(0).ToString();
                                    this.Hide();
                                    Form TelaMercadinho = new Mercadinho();
                                    TelaMercadinho.FormClosed += (s, args) => this.Close();
                                    TelaMercadinho.Show();
                                }

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
                    MessageBox.Show("Usuário e/ou Senha incorreto(s)");
                }
                

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

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxLOGIN.Clear();
            textBoxSENHA.Clear();

        }
    }
}
