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
    public partial class fmExtratoConsulta : Form
    {
        public fmExtratoConsulta()
        {
            InitializeComponent();
        }

        public fmExtratoConsulta(string cpf, string animal, DateTime data)
        {
            InitializeComponent();

            MySqlConnection conn = DataBase.GetInstance().GetConnection();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = string.Format("select * from consulta where cpf_resp = '{0}' and nome_animal = '{1}' and data = '{2}'",cpf, animal, data.ToString("yyyy-MM-dd"));

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            consultaamigaDataSet ds = new consultaamigaDataSet();

            CrystalReportExtratoConsulta relat = new CrystalReportExtratoConsulta();

            ds.Clear();

            ds.EnforceConstraints = false;

            da.Fill(ds, "consulta");

            relat.SetDataSource(ds);

            crystalReportViewerExtratoConsulta.ReportSource = relat;
            conn.Close();

        }
    }
}
