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
    public partial class fmPesquisarProdutos : Form
    {
        public void CarregarProdutos()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            List<Produto> produtos = new List<Produto>();

            produtos = produtoDAO.ListarProdutos();

            dataGridViewPesqProdutos.Rows.Clear();

            foreach (Produto p in produtos)
                dataGridViewPesqProdutos.Rows.Add(p.Codigo, p.Tipo, p.Nome, p.Marca, p.PrecoCusto.ToString("C"), p.PrecoVenda.ToString("C"), p.Quantidade, p.Dosagem);

            dataGridViewPesqProdutos.Refresh();

        }

        public fmPesquisarProdutos()
        {
            InitializeComponent();

            CarregarProdutos();
        }

        private void btnPesqAnimaisVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesqProdutosNome_KeyUp(object sender, KeyEventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            List<Produto> produtos = new List<Produto>();

            string nome = txtPesqProdutosNome.Text;

            produtos = produtoDAO.ListarProdutosNome(nome);

            dataGridViewPesqProdutos.Rows.Clear();

            foreach (Produto p in produtos)
                dataGridViewPesqProdutos.Rows.Add(p.Codigo, p.Tipo, p.Nome, p.Marca, p.PrecoCusto.ToString("C"), p.PrecoVenda.ToString("C"), p.Quantidade, p.Dosagem);

            dataGridViewPesqProdutos.Refresh();
        }

        private void dataGridViewPesqProdutos_DoubleClick(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridViewPesqProdutos.CurrentRow.Cells[0].Value.ToString());

            ProdutoDAO produtoDAO = new ProdutoDAO();

            Produto produto = produtoDAO.ProcurarCodigo(codigo);

            if (produto != null)
            {
                fmProduto formProduto = new fmProduto(codigo);

                formProduto.StartPosition = FormStartPosition.CenterScreen;

                formProduto.Show();

                this.Close();
            }
            else
                dataGridViewPesqProdutos.Rows.Remove(dataGridViewPesqProdutos.CurrentRow);
        }

        private void btnPesqProdutosRefresh_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }
    }
}
