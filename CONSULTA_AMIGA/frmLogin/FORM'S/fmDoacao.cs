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
    public partial class fmDoacao : Form
    {
        public fmDoacao()
        {
            InitializeComponent();

            maskDoacaoData.Text = DateTime.Now.ToShortDateString();           
        }

        private void btnAnimaisProcurar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void MostrarExtrato()
        {
            fmExtratoDoacao extratoDoacao = new fmExtratoDoacao();

            extratoDoacao.StartPosition = FormStartPosition.CenterScreen;

            extratoDoacao.WindowState = FormWindowState.Maximized;

            extratoDoacao.Show();
        }

        private void LimpaCampos()
        {
            txtDoacaoDoador.Text = "";
            maskDoacaoData.Text = "";
            txtDoacaoValor.Text = "";
            comboBoxDoacaoPagamento.SelectedIndex = 0;
            txtDoacaoObservacoes.Text = "";
        }

        private Doacao GetDTO()
        {
            Doacao d = null;

            try
            {
                d = new Doacao();
                d.Doador = txtDoacaoDoador.Text;
                d.Data = Convert.ToDateTime(maskDoacaoData.Text);
                d.Valor = Convert.ToDouble(txtDoacaoValor.Text);
                d.Pagamento = comboBoxDoacaoPagamento.Text;
                d.Observacoes = txtDoacaoObservacoes.Text;
            }
            catch (FormatException)
            {
                d = null;

                MessageBox.Show("DIGITE OS VALORES CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return d;
        }

        private void btnDoacaoRegistrar_Click(object sender, EventArgs e)
        {
            DoacaoDAO doacaoDAO = new DoacaoDAO();
            Doacao doacao = GetDTO();

            if(doacao != null)
            {
                if(doacaoDAO.Criar(doacao)== true)
                {
                    MessageBox.Show("DOAÇÃO REGISTRADA!");
                    MostrarExtrato();
                    LimpaCampos();
                }
                else
                    MessageBox.Show("ERRO AO REGISTRAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            maskDoacaoData.Text = DateTime.Now.ToShortDateString();
        }

        private void txtDoacaoValor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtDoacaoValor.Text);
            }
            catch (FormatException)
            {
                txtDoacaoValor.Text = "";
            }
            catch (System.OverflowException)
            {
                txtDoacaoValor.Text = "";
            }
        }

        private void txtDoacaoValor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                double valor = double.Parse(txtDoacaoValor.Text);
            }
            catch (FormatException)
            {
                txtDoacaoValor.Text = "";
            }
            catch (System.OverflowException)
            {
                txtDoacaoValor.Text = "";
            }
        }
    }
}
