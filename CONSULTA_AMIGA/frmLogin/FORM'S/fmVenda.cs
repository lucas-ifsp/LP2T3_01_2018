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
    public partial class fmVenda : Form
    {
        public void NovoCodigo()
        {
            VendaDAO vendaDAO = new VendaDAO();

            int codigo = vendaDAO.AtribuirCodigo();

            txtVendaCodigo.Text = Convert.ToString(codigo);
        }

        public fmVenda()
        {
            InitializeComponent();

            maskVendaData.Text = DateTime.Now.ToShortDateString();

            ProdutoDAO produtoDAO = new ProdutoDAO();

            List<Produto> produtos = new List<Produto>();

            produtos = produtoDAO.ListarProdutos();

            dataGridViewVendaPesqProdutos.Rows.Clear();

            foreach (Produto p in produtos)
                dataGridViewVendaPesqProdutos.Rows.Add(p.Codigo, p.Tipo, p.Nome, p.Marca, p.PrecoVenda.ToString("C"), p.Quantidade, p.Dosagem);

            dataGridViewVendaPesqProdutos.Refresh();

            NovoCodigo();
        }

        private Venda GetDTO()
        {
            VendaDAO vendaDAO = new VendaDAO();
            Venda v = null;

            try
            {
                v = new Venda();

                v.Codigo = Convert.ToInt32(txtVendaCodigo.Text);
                v.Data = Convert.ToDateTime(maskVendaData.Text);
                v.Consumidor = txtVendaConsumidor.Text;
                v.Pagamento = comboBoxVendaPagamento.Text;
                if (txtVendaDesconto.Text == "")
                    v.Desconto = 0;
                else
                    v.Desconto = Convert.ToDouble(txtVendaDesconto.Text);
                v.ValorTotal = Convert.ToDouble(txtVendaValorTotal.Text);
            }
            catch (FormatException)
            {
                v = null;

                MessageBox.Show("INSIRA OS VALORES E PRODUTOS CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return v;
        }


        private void fmVenda_Load(object sender, EventArgs e)
        {

        }

        public void ProdutosVendidos(int codigoVenda)
        {
            VendaDAO vendaDAO = new VendaDAO();

            int codigoProduto = 0;

            foreach(DataGridViewRow d in dataGridViewVenda.Rows)
            {
                codigoProduto = int.Parse(d.Cells[0].Value.ToString());

                vendaDAO.InserirProdutos(codigoVenda, codigoProduto);
            }
        }

        public void AlterarEstoque()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto p = null;

            int codigo;
            int quantidade;

            foreach (DataGridViewRow x in dataGridViewVenda.Rows)
            {
                codigo = Convert.ToInt32(x.Cells[0].Value.ToString());
                quantidade = Convert.ToInt32(x.Cells[2].Value.ToString());

                p = produtoDAO.ProcurarCodigo(codigo);

                p.Quantidade = p.Quantidade - quantidade;

                produtoDAO.AtualizarEstoque(p);
            }               
        }

        public void MostarExtrato()
        {
            fmExtratoVenda extratoVenda = new fmExtratoVenda();

            extratoVenda.StartPosition = FormStartPosition.CenterScreen;

            extratoVenda.WindowState = FormWindowState.Maximized;

            extratoVenda.Show();
        }

        private void btnVendaFinalizar_Click(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();

            Venda venda = GetDTO();

            if (venda != null)
            {
                if(venda.ValorTotal > 0)
                {
                    if (MessageBox.Show("DESEJA FINALIZAR VENDA?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (vendaDAO.Criar(venda) == true)
                        {
                            AlterarEstoque();
                            ProdutosVendidos(venda.Codigo);
                            MessageBox.Show("VENDA REALIZADA!");
                            MostarExtrato();
                            Close();
                        }
                        else
                            MessageBox.Show("ERRO AO FINALIZAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("INSIRA OS VALORES E PRODUTOS CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVendaCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtVendaNomeProduto_KeyUp(object sender, KeyEventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            List<Produto> produtos = new List<Produto>();

            string nome = txtVendaNomeProduto.Text;

            produtos = produtoDAO.ListarProdutosNome(nome);

            dataGridViewVendaPesqProdutos.Rows.Clear();

            foreach (Produto p in produtos)
                dataGridViewVendaPesqProdutos.Rows.Add(p.Codigo, p.Tipo, p.Nome, p.Marca, p.PrecoVenda.ToString("C"), p.Quantidade, p.Dosagem);

            dataGridViewVendaPesqProdutos.Refresh();
        }

        private double SomarVenda()
        {
            double valorTotal = 0;
            string valorTotalAux;

            try
            {
                foreach (DataGridViewRow x in dataGridViewVenda.Rows)
                {
                    valorTotalAux = x.Cells[4].Value.ToString();
                    valorTotalAux = valorTotalAux.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace("$", "");
                    valorTotal += Convert.ToDouble(valorTotalAux);
                }

                txtVendaValorTotal.Text = Convert.ToString(valorTotal);
            }                    
            catch(System.FormatException)
            {
                MessageBox.Show("DIGITE OS VALORES CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorTotal;
        }

        private void dataGridViewVendaPesqProdutos_DoubleClick(object sender, EventArgs e)
        {

            ProdutoDAO produtoDAO = new ProdutoDAO();

            Produto p = null;

            string nome;
            string totalUnitarioAux;
            int quantidade = 0;
            int estoque = 0;
            double soma = 0;
            double totalUnitario = 0;

            nome = Convert.ToString(dataGridViewVendaPesqProdutos.CurrentRow.Cells[2].Value.ToString());

            p = produtoDAO.Procurar(nome);

            try
            {
                quantidade = int.Parse(txtVendaQuantidade.Text);

                if (quantidade <= 0 || txtVendaQuantidade.Text == "")
                {
                    MessageBox.Show("QUANTIDADE INVÁLIDA!");
                }
                else
                {
                    estoque = int.Parse(dataGridViewVendaPesqProdutos.CurrentRow.Cells[5].Value.ToString());

                    if(quantidade > estoque)
                    {
                        MessageBox.Show("QUANTIDADE MAIOR QUE O ESTOQUE!");
                    }
                    else
                    {
                        soma = p.PrecoVenda * quantidade;
                        dataGridViewVenda.Rows.Add(p.Codigo, p.Nome, quantidade, p.PrecoVenda.ToString("C"), soma.ToString("C"));

                        foreach (DataGridViewRow x in dataGridViewVenda.Rows)
                        {
                            totalUnitarioAux = x.Cells[4].Value.ToString();
                            totalUnitarioAux = totalUnitarioAux.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace("$", "");
                            totalUnitario += Convert.ToDouble(totalUnitarioAux);
                        }
                            
                        SomarVenda();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("INFORME A QUANTIDADE!");
            }
            catch (InvalidCastException)
            {}
        }

        private void txtVendaDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            double desconto = 0;
            double valorTotal = 0;

            try
            {
                if (txtVendaDesconto.Text == "")
                {
                    SomarVenda();
                }
                else
                {
                    valorTotal = SomarVenda();

                    desconto = Convert.ToDouble(txtVendaDesconto.Text);

                    valorTotal = valorTotal - desconto;

                    txtVendaValorTotal.Text = Convert.ToString(valorTotal);
                }
            }
            catch(System.FormatException)
            {
                txtVendaDesconto.Text = "";
            }
            catch (System.OverflowException)
            {
                txtVendaDesconto.Text = "";
            }

        }

        private void txtVendaDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtVendaDesconto.Text);
            }
            catch (FormatException)
            {
                txtVendaDesconto.Text = "";
            }
            catch (System.OverflowException)
            {
                txtVendaDesconto.Text = "";
            }
        }

        private void dataGridViewVenda_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SomarVenda();
        }

        private void txtVendaQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int quantidade = int.Parse(txtVendaQuantidade.Text);
            }
            catch (FormatException)
            {
                txtVendaQuantidade.Text = "";
            }
            catch (System.OverflowException)
            {
                txtVendaQuantidade.Text = "";
            }
        }

        private void txtVendaQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int quantidade = int.Parse(txtVendaQuantidade.Text);
            }
            catch (FormatException)
            {
                txtVendaQuantidade.Text = "";
            }
            catch (System.OverflowException)
            {
                txtVendaQuantidade.Text = "";
            }
        }


    }
}
