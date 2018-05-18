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
    public partial class fmRelatorios : Form
    {
        public fmRelatorios()
        {
            InitializeComponent();
        }

        private void fmRelatorios_Load(object sender, EventArgs e)
        {
            dataGridViewRelatoriosConsultas.Visible = false;
            dataGridViewRelatoriosDoacoes.Visible = false;
            dataGridViewRelatoriosVendas.Visible = false;
            dataGridViewRelatoriosItensVenda.Visible = false;
            btnRelatoriosDoacoesImprimir.Visible = false;
            btnRelatoriosVendasImprimir.Visible = false;
            btnRelatoriosConsultasImprimir.Visible = false;
        }

        private void btnRelatoriosConsultas_Click(object sender, EventArgs e)
        {
            dataGridViewRelatoriosConsultas.Visible = true;
            btnRelatoriosConsultasImprimir.Visible = true;
            dataGridViewRelatoriosDoacoes.Visible = false;
            dataGridViewRelatoriosVendas.Visible = false;
            dataGridViewRelatoriosItensVenda.Visible = false;
            btnRelatoriosDoacoesImprimir.Visible = false;
            btnRelatoriosVendasImprimir.Visible = false;

            RealizadaDAO realizadaDAO = new RealizadaDAO();

            List<Realizada> consultas = new List<Realizada>();

            consultas = realizadaDAO.ListarConsultas();

            dataGridViewRelatoriosConsultas.Rows.Clear();

            foreach (Realizada r in consultas)
                dataGridViewRelatoriosConsultas.Rows.Add(r.Data.ToString("dd/MM/yyyy"), r.Horario, r.Responsavel, r.Animal, r.Diagnostico, r.Receita, r.Observacoes);

            dataGridViewRelatoriosConsultas.Refresh();
        }

        private void btnRelatoriosDoacoes_Click(object sender, EventArgs e)
        {
            dataGridViewRelatoriosDoacoes.Visible = true;
            btnRelatoriosDoacoesImprimir.Visible = true;
            dataGridViewRelatoriosConsultas.Visible = false;
            dataGridViewRelatoriosVendas.Visible = false;
            dataGridViewRelatoriosItensVenda.Visible = false;
            btnRelatoriosVendasImprimir.Visible = false;
            btnRelatoriosConsultasImprimir.Visible = false;

            DoacaoDAO doacaoDAO = new DoacaoDAO();

            List<Doacao> doacoes = new List<Doacao>();

            doacoes = doacaoDAO.ListarDoacoes();

            dataGridViewRelatoriosDoacoes.Rows.Clear();

            foreach (Doacao d in doacoes)
                dataGridViewRelatoriosDoacoes.Rows.Add(d.Data.ToString("dd/MM/yyyy"), d.Doador, d.Valor.ToString("C"), d.Pagamento, d.Observacoes);

            dataGridViewRelatoriosDoacoes.Refresh();

        }

        private void btnRelatoriosVendas_Click(object sender, EventArgs e)
        {
            dataGridViewRelatoriosVendas.Visible = true;
            btnRelatoriosVendasImprimir.Visible = true;
            btnRelatoriosDoacoesImprimir.Visible = false;
            dataGridViewRelatoriosConsultas.Visible = false;
            dataGridViewRelatoriosDoacoes.Visible = false;
            dataGridViewRelatoriosItensVenda.Visible = false;
            btnRelatoriosConsultasImprimir.Visible = false;

            VendaDAO vendaDAO = new VendaDAO();

            List<Venda> vendas = new List<Venda>();

            vendas = vendaDAO.ListarVendas();

            dataGridViewRelatoriosVendas.Rows.Clear();

            foreach (Venda v in vendas)
                dataGridViewRelatoriosVendas.Rows.Add(v.Codigo, v.Data.ToString("dd/MM/yyyy"), v.Consumidor, v.Pagamento, v.Desconto.ToString("C"), v.ValorTotal.ToString("C"));

            dataGridViewRelatoriosVendas.Refresh();

        }

        private void btnPessoaVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewRelatoriosVendas_DoubleClick(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();

            int codigoVenda = Convert.ToInt32(dataGridViewRelatoriosVendas.CurrentRow.Cells[0].Value.ToString());

            List<Produto> produtos = new List<Produto>();

            produtos = vendaDAO.ProdutosVendidos(codigoVenda);

            dataGridViewRelatoriosVendas.Visible = false;

            dataGridViewRelatoriosItensVenda.Visible = true;
            dataGridViewRelatoriosItensVenda.Rows.Clear();

            foreach (Produto p in produtos)
                dataGridViewRelatoriosItensVenda.Rows.Add(p.Codigo, p.Nome, p.Marca, p.Tipo, p.PrecoVenda.ToString("C"), p.Dosagem);

            dataGridViewRelatoriosItensVenda.Refresh();

        }

        private void btnRelatoriosDoacoesImprimir_Click(object sender, EventArgs e)
        {
            fmRelatorioDoacoes relatorioDoacoes = new fmRelatorioDoacoes();

            relatorioDoacoes.StartPosition = FormStartPosition.CenterScreen;

            relatorioDoacoes.WindowState = FormWindowState.Maximized;

            relatorioDoacoes.Show();
        }

        private void btnRelatoriosVendasImprimir_Click(object sender, EventArgs e)
        {
            fmRelatorioVendas relatorioVendas = new fmRelatorioVendas();

            relatorioVendas.StartPosition = FormStartPosition.CenterScreen;

            relatorioVendas.WindowState = FormWindowState.Maximized;

            relatorioVendas.Show();
        }

        private void btnRelatoriosConsultasImprimir_Click(object sender, EventArgs e)
        {
            fmRelatorioConsultas relatorioConsultas = new fmRelatorioConsultas();

            relatorioConsultas.StartPosition = FormStartPosition.CenterScreen;

            relatorioConsultas.WindowState = FormWindowState.Maximized;

            relatorioConsultas.Show();
        }
    }
}
