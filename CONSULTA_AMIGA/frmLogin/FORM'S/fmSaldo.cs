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
    public partial class fmSaldo : Form
    {
        public fmSaldo()
        {
            InitializeComponent();

            DoacaoDAO doacaoDAO = new DoacaoDAO();
            VendaDAO vendaDAO = new VendaDAO();

            double saldoDoacoes = doacaoDAO.SomaDoacoes();
            double saldoVendas = vendaDAO.SomaVendas();
            double saldoTotal = saldoDoacoes + saldoVendas;

            txtSaldoDocaoes.Text = Convert.ToString(saldoDoacoes.ToString("C"));
            txtSaldoVendas.Text = Convert.ToString(saldoVendas.ToString("C"));
            txtSaldoTotal.Text = Convert.ToString(saldoTotal.ToString("C"));
        }

        private void btnPessoaVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
