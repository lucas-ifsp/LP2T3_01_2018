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
    public partial class fmPesquisarConsultas : Form
    {
        public fmPesquisarConsultas()
        {
            InitializeComponent();

            CarregarConsultas();
        }

        public void CarregarConsultas()
        {
            RealizadaDAO consultaDAO = new RealizadaDAO();

            List<Realizada> consultas = new List<Realizada>();

            consultas = consultaDAO.ListarConsultas();

            dataGridViewPesqConsultas.Rows.Clear();

            foreach (Realizada r in consultas)
                dataGridViewPesqConsultas.Rows.Add(r.Data.ToString("dd/MM/yyyy"), r.Horario, r.Responsavel, r.Animal);

            dataGridViewPesqConsultas.Refresh();

        }

        private void btnPesqConsultasVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewPesqConsultas_DoubleClick(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dataGridViewPesqConsultas.CurrentRow.Cells[0].Value.ToString());
            string cpf = Convert.ToString(dataGridViewPesqConsultas.CurrentRow.Cells[2].Value.ToString());
            string animal = Convert.ToString(dataGridViewPesqConsultas.CurrentRow.Cells[3].Value.ToString());

            RealizadaDAO consultalDAO = new RealizadaDAO();

            Realizada consulta = consultalDAO.Procurar(cpf, animal, data);

            if (consulta != null)
            {
                fmConsulta formConsulta = new fmConsulta(data, cpf, animal);

                formConsulta.StartPosition = FormStartPosition.CenterScreen;

                formConsulta.Show();

                this.Close();
            }
            else
                dataGridViewPesqConsultas.Rows.Remove(dataGridViewPesqConsultas.CurrentRow);
        }

        private void maskPesqConsultasResp_KeyUp(object sender, KeyEventArgs e)
        {
            RealizadaDAO consultaDAO = new RealizadaDAO();

            List<Realizada> consultas = new List<Realizada>();

            string cpf = maskPesqConsultasResp.Text;

            consultas = consultaDAO.ListarConsultasResponsavel(cpf);

            dataGridViewPesqConsultas.Rows.Clear();

            foreach (Realizada r in consultas)
                dataGridViewPesqConsultas.Rows.Add(r.Data.ToString("dd/MM/yyyy"), r.Horario, r.Responsavel, r.Animal);

            dataGridViewPesqConsultas.Refresh();
        }

        private void btnPesqConsultasRefresh_Click(object sender, EventArgs e)
        {
            CarregarConsultas();
        }
    }
}
