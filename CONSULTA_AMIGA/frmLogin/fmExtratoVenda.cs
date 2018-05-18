using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    public partial class fmExtratoVenda : Form
    {
        public fmExtratoVenda()
        {
            InitializeComponent();
        }

        private void fmExtratoVenda_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = string.Format("select V.data, V.consumidor, V.pagamento, V.desconto, V.valor_total, P.codigo, P.nome, P.precovenda from (produto P join itensvenda I on I.codigo_produto = P.codigo) join venda V on I.codigo_venda = V.codigo where V.codigo IN (select max(codigo) from venda)");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportExtratoVenda relat = new CrystalReportExtratoVenda();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "produto");
            da.Fill(ds, "venda");

            relat.SetDataSource(ds);

            crystalReportViewerExtratoVenda.ReportSource = relat;
            conn.Close();

        }
    }
}
