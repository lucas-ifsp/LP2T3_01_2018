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
    public partial class fmRelatorioConsultas : Form
    {
        public fmRelatorioConsultas()
        {
            InitializeComponent();
        }

        private void fmRelatorioConsultas_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM CONSULTA";

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportConsultas relat = new CrystalReportConsultas();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "consulta");

            relat.SetDataSource(ds);

            crystalReportViewerConsultas.ReportSource = relat;
            conn.Close();
        }
    }
}
