using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Mercadinho
{
    public partial class Mercadinho : Form
    {
        string valor_total;
        string valor_uni;
        string id_vendas;
        string id_itens_vendas;
        string valor_venda;
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string id_produtos;
        int produtos;
        public Mercadinho()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_vendas;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            INICIARCOMPRA();
        }

        private void VALORTOTAL()
        {
            try
            {

                conexao.Open();
                comando.CommandText = "SELECT SUM(valor_venda) FROM tbl_itens_vendas WHERE fk_vendas = '" + id_vendas + "';";
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    valor_total = resultado.GetDouble(0).ToString().Replace(",", ".");
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

        private void VALORUNI()
        {
            try
            {

                conexao.Open();
                comando.CommandText = "SELECT preco FROM tbl_produtos WHERE id = '" + textBoxCODIGO.Text + "';";
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    valor_uni = resultado.GetDouble(0).ToString();
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
        private void PRODUTOS()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_produtos;";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_produtos = resultado.GetInt32(0).ToString();
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

        private void INICIARCOMPRA()
        {
            try
            {

                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_vendas(data_compra, fk_funcionarios) VALUES (CURDATE(),'"+variavel.id_func+"');";
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
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_vendas;";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_vendas = resultado.GetInt32(0).ToString();
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


        private void LIMPAR()
        {
            textBoxCODIGO.Clear();
            numericUpDown1.Text = "1";
            textBoxDESC.Clear();
        }
        private void DATAGRID_CARRINHO()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT descricao, preco, quantidade, valor_venda FROM tbl_produtos INNER JOIN tbl_itens_vendas ON (tbl_itens_vendas.fk_produtos = tbl_produtos.id) WHERE tbl_itens_vendas.fk_vendas = '" + id_vendas + "'; ;";
                MySqlDataAdapter adaptadorMerc = new MySqlDataAdapter(comando);
                DataTable tabelaMerc = new DataTable();
                adaptadorMerc.Fill(tabelaMerc);
                dataGridViewCARRINHO.DataSource = tabelaMerc;
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
        private void DATAGRID_ITENS()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produtos WHERE id = '" + textBoxCODIGO.Text + "';";
                MySqlDataAdapter adaptadorMerc = new MySqlDataAdapter(comando);
                DataTable tabelaMerc = new DataTable();
                adaptadorMerc.Fill(tabelaMerc);
                dataGridViewITENS.DataSource = tabelaMerc;
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
        private void DATAGRID_PESQUISA()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produtos WHERE descricao = '" + textBoxDESC.Text + "';";
                MySqlDataAdapter adaptadorMerc = new MySqlDataAdapter(comando);
                DataTable tabelaMerc = new DataTable();
                adaptadorMerc.Fill(tabelaMerc);
                dataGridViewPESQUISA.DataSource = tabelaMerc;
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

        private void textBoxCODIGO_TextChanged(object sender, EventArgs e)
        {
            PRODUTOS();
            if (valor_uni == null)
            {
                valor_uni = "0";
            }
            if (textBoxCODIGO.Text.Length > 0 && numericUpDown1.Text != "")
            {
                DATAGRID_ITENS();
                VALORUNI();
                labelVALORUNI.Text = $"R$ " + valor_uni + "";
                double valorUnitario = double.Parse(valor_uni);
                int quantidade = int.Parse(numericUpDown1.Text);
                labelTOTALITEM.Text = $"R$ " + valorUnitario * quantidade + "";
            }
        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            PRODUTOS();
            int produtos = int.Parse(id_produtos);
            int codigo = Convert.ToInt32(textBoxCODIGO.Text);
            if (textBoxCODIGO.Text != "" && numericUpDown1.Text != "" && codigo <= produtos)
            {
                try
                {

                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_itens_vendas(fk_produtos, fk_vendas, quantidade) VALUES('" + textBoxCODIGO.Text + "', '" + id_vendas + "', '" + numericUpDown1.Text + "');";
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
                try
                {
                    conexao.Open();
                    comando.CommandText = "SELECT MAX(id) FROM tbl_itens_vendas;";

                    MySqlDataReader resultado = comando.ExecuteReader();

                    if (resultado.Read())
                    {
                        id_itens_vendas = resultado.GetInt32(0).ToString();
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
                    comando.CommandText = "SELECT SUM((preco * " + numericUpDown1.Text + ")) FROM tbl_produtos WHERE tbl_produtos.id = '" + textBoxCODIGO.Text + "'";

                    MySqlDataReader resultado = comando.ExecuteReader();

                    if (resultado.Read())
                    {
                        valor_venda = resultado.GetDouble(0).ToString().Replace(",", ".");
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
                    comando.CommandText = "UPDATE tbl_itens_vendas SET valor_venda = " + valor_venda + " WHERE id = " + id_itens_vendas + "";
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
                LIMPAR();
                DATAGRID_PESQUISA();
                DATAGRID_CARRINHO();
                VALORTOTAL();
                labelSUBTOTAL.Text = $"R$ " + valor_total + "";
                labelTOTALITEM.Text = "R$00.00";
                labelVALORUNI.Text = "R$00.00";
            }
            else
            {
                MessageBox.Show("Código ou Quantidade em branco e/ou Código Inexistente! Por favor preencha corretamente.");
            }


        }

        private void buttonFINALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_vendas SET valor_total = " + valor_total + " WHERE id = " + id_vendas + "";
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
            MessageBox.Show("Compra finalizada com sucesso!");
            LIMPAR();
            id_vendas = null;
            if (DialogResult.Yes == MessageBox.Show("Deseja iniciar uma nova venda? Caso escolha NÃO o aplicativo irá retornar a tela de login!", "Nova Venda!", MessageBoxButtons.YesNo))
            {
                DATAGRID_PESQUISA();
                DATAGRID_CARRINHO();
                DATAGRID_ITENS();
                INICIARCOMPRA();
            }
            else
            {
                this.Hide();
                Form TelaLogin = new TelaLogin();
                TelaLogin.FormClosed += (s, args) => this.Close();
                TelaLogin.Show();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (textBoxCODIGO.Text.Length > 0 && numericUpDown1.Text != "")
            {
                DATAGRID_ITENS();
                VALORUNI();
                labelVALORUNI.Text = $"R$ " + valor_uni + "";
                double valorUnitario = double.Parse(valor_uni);
                int quantidade = int.Parse(numericUpDown1.Value.ToString());
                labelTOTALITEM.Text = $"R$ " + (valorUnitario * quantidade) + "";
            }
        }

        private void textBoxDESC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDESC.Text.Length > 0)
            {
                DATAGRID_PESQUISA();
            }
        }

        private void dataGridViewPESQUISA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxCODIGO.Text = dataGridViewPESQUISA.CurrentRow.Cells[0].Value.ToString();
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

