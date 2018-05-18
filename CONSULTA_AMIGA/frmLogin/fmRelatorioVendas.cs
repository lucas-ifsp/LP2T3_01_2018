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
    public partial class fmRelatorioVendas : Form
    {
        public fmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void fmRelatorioVendas_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM VENDA";

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportVendas relat = new CrystalReportVendas();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "venda");

            relat.SetDataSource(ds);

            crystalReportViewerVendas.ReportSource = relat;
            conn.Close();

        }
    }
}
