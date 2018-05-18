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
    public partial class fmProduto : Form
    {
        public void NovoCodigo()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            int codigo = produtoDAO.AtribuirCodigo();

            txtProdutoCodigo.Text = Convert.ToString(codigo);
        }

        private void LimpaCampos()
        {
            NovoCodigo();
            txtProdutoPrecoCusto.Text = "";
            txtProdutoPrecoVenda.Text = "";
            txtProdutoNome.Text = "";
            txtProdutoMarca.Text = "";
            txtProdutoQuantidade.Text = "";
            txtProdutoDescricao.Text = "";

            radBtnProdutoGeral.Checked = true;

            if (radBtnProdutoMedicamento.Checked == true)
                radBtnProdutoMedicamento.Checked = false;

            else if (radBtnProdutoVacina.Checked == true)
                radBtnProdutoVacina.Checked = false;

            txtProdutoDosagem.Text = "";

        }

        public void Voltar()
        {
            btnSair.Visible = true;
            lbSair.Visible = true;
            btnProdutoCadastrar.Visible = true;
            btnProdutoProcurar.Visible = true;
            btnProdutoAlterar.Visible = false;
            btnProdutoRemover.Visible = false;
            btnProdutoVoltar.Visible = false;
            lbProdutoVoltar.Visible = false;

            LimpaCampos();
        }

        public fmProduto()
        {
            InitializeComponent();

            Voltar();
        }

        public fmProduto(int codigo)
        {
            InitializeComponent();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto p = produtoDAO.ProcurarCodigo(codigo);

            SetDTO(p);

            btnProdutoVoltar.Visible = false;
            lbProdutoVoltar.Visible = false;
            btnSair.Visible = true;
            lbSair.Visible = true;
        }

        private void fmProduto_Load(object sender, EventArgs e)
        {
            txtProdutoDosagem.Enabled = false;
        }

        private void radBtnProdutoGeral_CheckedChanged(object sender, EventArgs e)
        {
            txtProdutoDosagem.Enabled = false;
            txtProdutoDosagem.Text = "";
        }

        private void radBtnProdutoMedicamento_Click(object sender, EventArgs e)
        {
            txtProdutoDosagem.Enabled = true;
        }

        private void radBtnProdutoVacina_Click(object sender, EventArgs e)
        {
            txtProdutoDosagem.Enabled = true;
        }

        private Produto GetDTO()
        {
            Produto p = new Produto();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            try
            {

                p.Codigo = Convert.ToInt32(txtProdutoCodigo.Text);
                p.Nome = txtProdutoNome.Text;
                p.Marca = txtProdutoMarca.Text;
                p.PrecoCusto = Convert.ToDouble(txtProdutoPrecoCusto.Text);
                p.PrecoVenda = Convert.ToDouble(txtProdutoPrecoVenda.Text);
                p.Descricao = txtProdutoDescricao.Text;
                p.Quantidade = int.Parse(txtProdutoQuantidade.Text);
                p.Dosagem = txtProdutoDosagem.Text;

                if (radBtnProdutoGeral.Checked == true)
                    p.Tipo = "Geral";
                else if (radBtnProdutoMedicamento.Checked == true)
                    p.Tipo = "Medicamento";
                else if (radBtnProdutoVacina.Checked == true)
                    p.Tipo = "Vacina";

            }
            catch (FormatException)
            {
                p = null;

                MessageBox.Show("DIGITE OS VALORES CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return p;
        }

        private void SetDTO(Produto produto)
        {
            if (produto.Tipo == "Geral")
                radBtnProdutoGeral.Checked = true;
            else if (produto.Tipo == "Medicamento")
            {
                txtProdutoDosagem.Enabled = true;
                radBtnProdutoMedicamento.Checked = true;
                txtProdutoDosagem.Text = produto.Dosagem;
            }
            else if (produto.Tipo == "Vacina")
            {
                txtProdutoDosagem.Enabled = true;
                radBtnProdutoVacina.Checked = true;
                txtProdutoDosagem.Text = produto.Dosagem;
            }

            txtProdutoCodigo.Text = Convert.ToString(produto.Codigo);
            txtProdutoNome.Text = produto.Nome;
            txtProdutoMarca.Text = produto.Marca;
            txtProdutoPrecoCusto.Text = Convert.ToString(produto.PrecoCusto);
            txtProdutoPrecoVenda.Text = Convert.ToString(produto.PrecoVenda);
            txtProdutoQuantidade.Text = Convert.ToString(produto.Quantidade);
            txtProdutoDescricao.Text = produto.Descricao;

        }

        private void btnProdutoCadastrar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = GetDTO();
            Produto jaCadastrado = null;

            try
            {
                jaCadastrado = produtoDAO.Procurar(txtProdutoNome.Text);

                if(jaCadastrado == null)
                {
                    if (produtoDAO.Criar(produto)==true)
                    {
                        MessageBox.Show("PRODUTO CADASTRADO!");
                        Close();
                    }
                    else
                        MessageBox.Show("ERRO AO CADASTRAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("PRODUTO JÁ CADASTRADO!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
            }
        }

        private void btnProdutoProcurar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = null;

            try
            {            
                produto = produtoDAO.Procurar(txtProdutoNome.Text);

                if (produto != null)
                {
                    btnSair.Visible = false;
                    lbSair.Visible = false;
                    btnProdutoProcurar.Visible = false;
                    btnProdutoCadastrar.Visible = false;
                    btnProdutoAlterar.Visible = true;
                    btnProdutoRemover.Visible = true;
                    btnProdutoVoltar.Visible = true;
                    lbProdutoVoltar.Visible = true;

                    SetDTO(produto);
                    SetDTO(produto);
                }
                else
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO!");
            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProdutoAlterar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = null;
                      
            try
            {
                produto = produtoDAO.ProcurarCodigo(Convert.ToInt32(txtProdutoCodigo.Text));

                if (produto != null)
                {
                    produto = GetDTO();

                    if(produtoDAO.Alterar(produto)==true)
                    {
                        MessageBox.Show("DADOS ALTERADOS!");
                        Close();
                    }
                    else
                        MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO!");
                
            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProdutoRemover_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = null;

            try
            {
                produto = produtoDAO.ProcurarCodigo(Convert.ToInt32(txtProdutoCodigo.Text));

                if (produto != null)
                {
                    if (MessageBox.Show("DESEJA REALMENTE REMOVER PRODUTO?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        produtoDAO.Excluir(Convert.ToInt32(txtProdutoCodigo.Text));
                        MessageBox.Show("PRODUTO REMOVIDO!");
                        Close();
                    }
                }
                else
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO!");
            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProdutoVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProdutoQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int crmv = int.Parse(txtProdutoQuantidade.Text);
            }
            catch (FormatException)
            {
                txtProdutoQuantidade.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoQuantidade.Text = "";
            }
        }

        private void txtProdutoQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int quantidade = int.Parse(txtProdutoQuantidade.Text);
            }
            catch (FormatException)
            {
                txtProdutoQuantidade.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoQuantidade.Text = "";
            }
        }

        private void txtProdutoPrecoCusto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtProdutoPrecoCusto.Text);
            }
            catch (FormatException)
            {
                txtProdutoPrecoCusto.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoPrecoCusto.Text = "";
            }
        }

        private void txtProdutoPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtProdutoPrecoCusto.Text);
            }
            catch (FormatException)
            {
                txtProdutoPrecoCusto.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoPrecoCusto.Text = "";
            }

        }

        private void txtProdutoPrecoVenda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtProdutoPrecoVenda.Text);
            }
            catch (FormatException)
            {
                txtProdutoPrecoVenda.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoPrecoVenda.Text = "";
            }
        }

        private void txtProdutoPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtProdutoPrecoVenda.Text);
            }
            catch (FormatException)
            {
                txtProdutoPrecoVenda.Text = "";
            }
            catch (System.OverflowException)
            {
                txtProdutoPrecoVenda.Text = "";
            }
        }
    }
}
