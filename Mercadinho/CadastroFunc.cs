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
    public partial class CadastroFunc : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string id_gerente;
        public CadastroFunc()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_vendas;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }
        private void LIMPAR()
        {
            textBoxNOME.Clear();
            textBoxCPF.Clear();
            textBoxSENHA.Clear();
            comboBoxCARGO.Text = "Funcionário";
        }

        private void DELETARGERENTE()
        {
            try
            {

                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_funcionarios WHERE nome = 'Gerente' AND cpf = '10020030040' AND senha = '0000';\r\n";
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_gerente = resultado.GetInt32(0).ToString();

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
            try
            {

                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_funcionarios WHERE id != '"+id_gerente+"' AND cargo = 'Gerente';";
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    try
                    {

                        conexao.Open();
                        comando.CommandText = "DELETE FROM tbl_funcionarios WHERE id = '" + id_gerente + "';";
                        comando.ExecuteNonQuery();
                        


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

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if (textBoxNOME.Text != "" && textBoxCPF.Text != "" && textBoxSENHA.Text != "" && comboBoxCARGO.Text != "" && textBoxCPF.Text.Length == 11)
            {
                try
                {

                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_funcionarios(nome, cpf, senha, cargo) VALUES('" + textBoxNOME.Text + "','" + textBoxCPF.Text + "','" + textBoxSENHA.Text + "','" + comboBoxCARGO.Text + "')";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionário cadastrado!");

                }
                catch (Exception erro_mysql)
                {
                    MessageBox.Show(erro_mysql.Message);
                }
                finally
                {
                    conexao.Close();
                    LIMPAR();
                    DELETARGERENTE();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos campos corretamente. (Verifique o CPF).");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaGerente = new TelaGerente();
            TelaGerente.FormClosed += (s, args) => this.Close();
            TelaGerente.Show();
        }

        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNOME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
