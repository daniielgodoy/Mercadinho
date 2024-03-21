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
    public partial class TelaGerente : Form
    {
        public TelaGerente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaProdutos = new CadastroProdutos();
            TelaProdutos.FormClosed += (s, args) => this.Close();
            TelaProdutos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaFunc = new CadastroFunc();
            TelaFunc.FormClosed += (s, args) => this.Close();
            TelaFunc.Show();
        }
    }
}
