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
    public partial class fmAgenda : Form
    {

        public void CarregarAgenda()
        {
            AgendaDAO agendaDAO = new AgendaDAO();

            List<Agenda> agendaVet = new List<Agenda>();

            agendaVet = agendaDAO.ListarAgenda();

            dataGridViewAgenda.Rows.Clear();
        
            foreach (Agenda a in agendaVet)
                dataGridViewAgenda.Rows.Add(a.Data.ToString("dd/MM/yyyy"), a.Horario, a.Tipo, a.Responsavel, a.Animal);

            dataGridViewAgenda.Refresh();
           
        }

        public fmAgenda()
        {
            InitializeComponent();

            CarregarAgenda();
        }

        private void btnAgendaVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpaCampos()
        {
            dateTimeAgenda.Text = DateTime.Now.ToShortDateString();
            maskAgendaData.Text = "";
            txtAgendaResponsavel.Text = "";
            maskAgendaHorario.Text = "";
            comboBoxAgendaTipo.Text = "";
            txtAgendaAnimal.Text = "";
            
        }

        private Agenda GetDTO()
        {
            Agenda a = null;

            try
            {
                a = new Agenda();

                a.Data = Convert.ToDateTime(maskAgendaData.Text);
                a.Horario = maskAgendaHorario.Text;
                a.Responsavel = txtAgendaResponsavel.Text;
                a.Animal = txtAgendaAnimal.Text;
                a.Tipo = comboBoxAgendaTipo.Text;

            }
            catch (FormatException)
            {
                a = null;

                MessageBox.Show("INFORME O AGENDAMENTO CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return a;
        }

        private void SetDTO(Agenda agenda)
        {
            maskAgendaData.Text = agenda.Data.ToString("dd-MM-yyyy");
            txtAgendaResponsavel.Text = agenda.Responsavel;
            maskAgendaHorario.Text = agenda.Horario;
            comboBoxAgendaTipo.Text = agenda.Tipo;
            txtAgendaAnimal.Text = agenda.Animal;
        }

        private void btnAgendaAgendar_Click(object sender, EventArgs e)
        {
            AgendaDAO agendaDAO = new AgendaDAO();
            Agenda agenda = GetDTO();

            if (agendaDAO.Criar(agenda) == true)
                LimpaCampos();
            else
                MessageBox.Show("ERRO AO AGENDAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CarregarAgenda();        
        }

        private void dataGridViewAgenda_DoubleClick(object sender, EventArgs e)
        {
            maskAgendaData.Text = dataGridViewAgenda.CurrentRow.Cells[0].Value.ToString();
            maskAgendaHorario.Text = dataGridViewAgenda.CurrentRow.Cells[1].Value.ToString();
            comboBoxAgendaTipo.Text = dataGridViewAgenda.CurrentRow.Cells[2].Value.ToString();
            txtAgendaResponsavel.Text = dataGridViewAgenda.CurrentRow.Cells[3].Value.ToString();                    
            txtAgendaAnimal.Text = dataGridViewAgenda.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAgendaAlterar_Click(object sender, EventArgs e)
        {
            AgendaDAO agendaDAO = new AgendaDAO();

            Agenda agenda = null;

            try
            { 
                string responsavel = txtAgendaResponsavel.Text ;
                string animal = txtAgendaAnimal.Text;
                DateTime data = Convert.ToDateTime(maskAgendaData.Text);

                agenda = agendaDAO.Procurar(data, responsavel, animal);

                if (agenda != null)
                {
                    agenda = GetDTO();

                    if(agendaDAO.Alterar(agenda)==true)
                    {
                        MessageBox.Show("AGENDAMENTO ALTERADO!");
                        LimpaCampos();
                    }
                    else
                        MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CarregarAgenda();
                LimpaCampos();
            }
            catch(FormatException)
            {
                MessageBox.Show("INFORME O AGENDAMENTO CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnAgendaRemover_Click(object sender, EventArgs e)
        {
            AgendaDAO agendaDAO = new AgendaDAO();

            Agenda agenda = null;

            try
            { 
                string responsavel = txtAgendaResponsavel.Text;
                string animal = txtAgendaAnimal.Text;
                DateTime data = Convert.ToDateTime(maskAgendaData.Text);

                agenda = agendaDAO.Procurar(data, responsavel, animal);

                if (agenda != null)
                {
                    if (MessageBox.Show("DESEJA REALMENTE REMOVER AGENDAMENTO?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        agendaDAO.Excluir(agenda);
                        MessageBox.Show("AGENDAMENTO REMOVIDO!");
                        CarregarAgenda();
                        LimpaCampos();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("INFORME O AGENDAMENTO CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimeAgenda_MouseUp(object sender, MouseEventArgs e)
        {
            maskAgendaData.Text = dateTimeAgenda.Value.ToString();
        }

        private void dateTimeAgenda_ValueChanged(object sender, EventArgs e)
        {
            maskAgendaData.Text = dateTimeAgenda.Value.ToString();
        }
    }
}
