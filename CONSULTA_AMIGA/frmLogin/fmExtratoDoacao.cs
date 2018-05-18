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
    public partial class fmExtratoDoacao : Form
    {
        public fmExtratoDoacao()
        {
            InitializeComponent();
        }

        private void fmExtratoDoacao_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = string.Format("select * from doacao where codigo in (select max(codigo) from doacao)");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportExtratoDoacao relat = new CrystalReportExtratoDoacao();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "doacao");

            relat.SetDataSource(ds);

            crystalReportViewerExtratoDoacao.ReportSource = relat;
            conn.Close();
        }
    }
}
