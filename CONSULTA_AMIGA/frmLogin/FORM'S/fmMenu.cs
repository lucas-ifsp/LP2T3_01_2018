using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class fmMenu : Form
    {
        public fmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fmConsulta consulta = new fmConsulta();

            consulta.StartPosition = FormStartPosition.CenterScreen;

            consulta.Show();
        }

        private void MenBtnPessoas_Click(object sender, EventArgs e)
        {
            fmPessoa pessoa = new fmPessoa();

            pessoa.StartPosition = FormStartPosition.CenterScreen;

            pessoa.Show();

        }

        private void MenBtnAnimais_Click(object sender, EventArgs e)
        {
            fmAnimal animal = new fmAnimal();

            animal.StartPosition = FormStartPosition.CenterScreen;

            animal.Show();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            fmPesquisar pesquisar = new fmPesquisar();

            pesquisar.StartPosition = FormStartPosition.CenterScreen;

            pesquisar.Show();
        }

        private void MenBtnAgenda_Click(object sender, EventArgs e)
        {
            fmAgenda agenda = new fmAgenda();

            agenda.StartPosition = FormStartPosition.CenterScreen;

            agenda.Show();
        }

        private void MenBtnProdutos_Click(object sender, EventArgs e)
        {
            fmProduto produto = new fmProduto();

            produto.StartPosition = FormStartPosition.CenterScreen;

            produto.Show();
        }

        private void MenBtnVendas_Click(object sender, EventArgs e)
        {
            fmVenda venda = new fmVenda();

            venda.StartPosition = FormStartPosition.CenterScreen;

            venda.ShowDialog();
        }

        private void MenBtnDoacoes_Click(object sender, EventArgs e)
        {
            fmDoacao doacao = new fmDoacao();

            doacao.StartPosition = FormStartPosition.CenterScreen;

            doacao.Show();
        }

        private void MenBtnSaldo_Click(object sender, EventArgs e)
        {
            fmSaldo saldo = new fmSaldo();

            saldo.StartPosition = FormStartPosition.CenterScreen;

            saldo.Show();
        }

        private void MenBtnRelatorios_Click(object sender, EventArgs e)
        {
            fmRelatorios relatorios = new fmRelatorios();

            relatorios.StartPosition = FormStartPosition.CenterScreen;

            relatorios.Show();

        }

        private void MenBtnUsuario_Click(object sender, EventArgs e)
        {
            fmUsuario usuario = new fmUsuario();

            usuario.StartPosition = FormStartPosition.CenterScreen;

            usuario.Show();

        }

        private void MenBtnAjuda_Click(object sender, EventArgs e)
        {
            fmAjuda ajuda = new fmAjuda();

            ajuda.StartPosition = FormStartPosition.CenterScreen;

            ajuda.Show();
        }
    }
}
