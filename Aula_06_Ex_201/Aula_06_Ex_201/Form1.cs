using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Ex_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double largura = -1, comprimento = -1;

            if(txtLargura.Text != "" && txtComprimento.Text != "")
            {
                largura = double.Parse(txtLargura.Text);
                comprimento = double.Parse(txtComprimento.Text);
                lbResultadoArea.Text = (largura * comprimento).ToString(); 
            }
            else
            {
                MessageBox.Show("Você precisa preencher os campos Largura e Comprimento.", "Erro: Campos não preenchidos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnPreco_Click(object sender, EventArgs e)
        {
            double largura = -1, comprimento = -1, preco = -1;

            if (txtLargura.Text != "" && txtComprimento.Text != "" && txtPreco.Text != "")
            {
                largura = double.Parse(txtLargura.Text);
                comprimento = double.Parse(txtComprimento.Text);
                preco = double.Parse(txtPreco.Text);
                lbResultadoArea.Text = (largura * comprimento).ToString();
                lbResultadoPreco.Text = (largura * comprimento * preco).ToString("C");
            }
        }
    }
}
