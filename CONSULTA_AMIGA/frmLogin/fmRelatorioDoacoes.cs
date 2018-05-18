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
    public partial class fmRelatorioDoacoes : Form
    {
        public fmRelatorioDoacoes()
        {
            InitializeComponent();
        }

        private void fmRelatorioDoacoes_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM doacao";

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportDocaoes relat = new CrystalReportDocaoes();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "doacao");
           
            relat.SetDataSource(ds);

            crystalReportViewer.ReportSource = relat;
            conn.Close();
        }
    }
}
