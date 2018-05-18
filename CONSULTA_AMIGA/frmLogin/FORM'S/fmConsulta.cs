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
    public partial class fmConsulta : Form
    {
        DateTime dataConsulta;
        string cpfResp;
        string nomeAnimal;

        private void LimpaCampos()
        {
            maskConsultaCpf.Text = "";
            txtConsultaAnimal.Text = "";
            maskConsultaData.Text = DateTime.Now.ToShortDateString();
            maskConsultaHorario.Text = DateTime.Now.ToShortTimeString();
            comboBoxConsultaTipo.Text = "";
            txtConsultaVeterinario.Text = "";
            txtConsultaReceita.Text = "";
            txtConsultaDiagnostico.Text = "";
            txtConsultaObservacoes.Text = "";

        }

        private void Voltar()
        {
            btnSair.Visible = true;
            lbSair.Visible = true;
            maskConsultaCpf.Enabled = true;
            lbCpfValido.Visible = false;
            lbCpfInvalido.Visible = false;
            btnConsultaCadastrar.Visible = true;
            btnConsultaProcurar.Visible = true;
            btnConsultaAlterar.Visible = false;
            btnConsultaRemover.Visible = false;
            lbConsultaVoltar.Visible = false;
            btnConsultaVoltar.Visible = false;
            btnConsultaImprimir.Visible = false;

            LimpaCampos();
        }

        public fmConsulta()
        {
            InitializeComponent();

            Voltar();
        }

        public fmConsulta(string cpf, string animal)
        {
            InitializeComponent();

            Voltar();
          
            maskConsultaCpf.Text = cpf;

            txtConsultaAnimal.Text = animal;

            lbCpfValido.Visible = true;
            maskConsultaCpf.Enabled = false;
            txtConsultaAnimal.Enabled = false;
            btnConsultaVoltar.Visible = false;
            lbConsultaVoltar.Visible = false;
            btnConsultaVoltar.Visible = false;
            lbConsultaVoltar.Visible = false;
            btnConsultaProcurar.Visible = false;

        }

        public fmConsulta(DateTime data, string cpf, string animal)
        {
            InitializeComponent();

            RealizadaDAO realizadaDAO = new RealizadaDAO();
            Realizada consulta = realizadaDAO.Procurar(cpf, animal, data);

            SetDTO(consulta);

            maskConsultaCpf.Enabled = false;
            lbCpfInvalido.Visible = false;
            lbCpfValido.Visible = true;
            btnConsultaVoltar.Visible = false;
            lbConsultaVoltar.Visible = false;
            btnSair.Visible = true;
            lbSair.Visible = true;

        }

        public bool ImprimirConsulta()
        {
            try
            {   DateTime data = Convert.ToDateTime(maskConsultaData.Text);
                string cpf = maskConsultaCpf.Text;
                string animal = txtConsultaAnimal.Text;

                RealizadaDAO realizadaDAO = new RealizadaDAO();

                Realizada consulta = realizadaDAO.Procurar(cpf, animal, data);

                if(consulta != null)
                {
                    fmExtratoConsulta extratoConsulta = new fmExtratoConsulta(cpf,animal,data);

                    extratoConsulta.StartPosition = FormStartPosition.CenterScreen;

                    extratoConsulta.WindowState = FormWindowState.Maximized;

                    extratoConsulta.Show();

                    return true;
                }
                else
                {
                    MessageBox.Show("CONSULTA NÃO ENCONTRADA!");

                    return false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        private void btnConsultaVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private Realizada GetDTO()
        {
            Realizada r = null;

            try
            {
                if (ValidaCPF.IsCpf(maskConsultaCpf.Text) == true)
                {
                    r = new Realizada();

                    r.Data = Convert.ToDateTime(maskConsultaData.Text);
                    r.Horario = maskConsultaHorario.Text;
                    r.Tipo = comboBoxConsultaTipo.Text;
                    r.Responsavel = maskConsultaCpf.Text;
                    r.Animal = txtConsultaAnimal.Text;
                    r.Diagnostico = txtConsultaDiagnostico.Text;
                    r.Receita = txtConsultaReceita.Text;
                    r.Observacoes = txtConsultaObservacoes.Text;
                    r.Crmv = int.Parse(txtConsultaVeterinario.Text);

                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                r = null;

                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return r;
        }

        private void SetDTO(Realizada consulta)
        {
            maskConsultaCpf.Text = consulta.Responsavel;
            txtConsultaAnimal.Text = consulta.Animal;
            maskConsultaData.Text = consulta.Data.ToString("dd/MM/yyyy");
            maskConsultaHorario.Text = consulta.Horario;
            comboBoxConsultaTipo.Text = consulta.Tipo;
            txtConsultaVeterinario.Text = Convert.ToString(consulta.Crmv);
            txtConsultaReceita.Text = consulta.Receita;
            txtConsultaDiagnostico.Text = consulta.Diagnostico;
            txtConsultaObservacoes.Text = consulta.Observacoes;

            dataConsulta = Convert.ToDateTime(maskConsultaData.Text);
            cpfResp = maskConsultaCpf.Text;
            nomeAnimal = txtConsultaAnimal.Text;
        }

        private void btnConsultaCadastrar_Click(object sender, EventArgs e)
        {
            RealizadaDAO consultaDAO = new RealizadaDAO();
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();

            Realizada consulta = GetDTO();
            Realizada jaCadastrada = null;
            Pessoa pessoa = null;
            Animal animal = null;
            DateTime data;

            try
            {
                string cpf = maskConsultaCpf.Text;
                string nome = txtConsultaAnimal.Text;
                data = Convert.ToDateTime(maskConsultaData.Text);

                pessoa = pessoaDAO.Procurar(cpf);
                animal = animalDAO.Procurar(cpf,nome);
                jaCadastrada = consultaDAO.Procurar(cpf, nome, data);

                if (pessoa != null && animal != null)
                {
                    if (jaCadastrada == null)
                    {
                        if(consultaDAO.Criar(pessoa,animal,consulta)==true)
                        {
                            MessageBox.Show("CONSULTA REGISTRADA!");
                            ImprimirConsulta();
                            Close();
                        }
                        else
                            MessageBox.Show("ERRO AO CADASTRAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                   
                    }
                    else
                        MessageBox.Show("CONSULTA JÁ REGISTRADA NESSA DATA!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }
                else
                    MessageBox.Show("PESSOA OU ANIMAL NÃO ENCONTRADO!");
            }
            catch (FormatException){}            
            catch(System.NullReferenceException){}            
        }

        private void btnConsultaProcurar_Click(object sender, EventArgs e)
        {

            RealizadaDAO consultaDAO = new RealizadaDAO();

            Realizada consulta = null;

            try
            {
                string cpf = maskConsultaCpf.Text;
                string animal = txtConsultaAnimal.Text;
                DateTime data = Convert.ToDateTime(maskConsultaData.Text);

                consulta = consultaDAO.Procurar(cpf, animal, data);

                if (consulta != null)
                {
                    maskConsultaCpf.Enabled = false;
                    btnConsultaCadastrar.Visible = false;
                    btnConsultaProcurar.Visible = false;
                    btnConsultaAlterar.Visible = true;
                    btnConsultaRemover.Visible = true;
                    lbConsultaVoltar.Visible = true;
                    btnConsultaVoltar.Visible = true;
                    btnConsultaImprimir.Visible = true;
                    btnSair.Visible = false;
                    lbSair.Visible = false;

                    SetDTO(consulta);                   
                }
                else
                {
                    MessageBox.Show("CONSULTA NÃO ENCONTRADA!");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("DIGITE A DATA CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultaAlterar_Click(object sender, EventArgs e)
        {

            RealizadaDAO consultaDAO = new RealizadaDAO();
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();

            Realizada consulta = null;
            Animal animal = null;
            Animal animalCadastrado = null;
            Pessoa pessoa = null;

            try
            {
                string novoNome;

                pessoa = pessoaDAO.Procurar(cpfResp);
                animal = animalDAO.Procurar(cpfResp, nomeAnimal);
                consulta = consultaDAO.Procurar(cpfResp, nomeAnimal, dataConsulta);

                if (consulta != null)
                {
                    consulta = GetDTO();

                    novoNome = txtConsultaAnimal.Text;

                    animalCadastrado = animalDAO.Procurar(cpfResp, novoNome);
                    
                    if(animalCadastrado != null)
                    {
                        if(consultaDAO.Alterar(pessoa,animal,consulta)==true)
                        {
                            MessageBox.Show("DADOS ALTERADOS!");
                            Close();
                        }
                        else
                            MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("ANIMAL NÃO CADASTRADO PARA ESTE CPF!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("CONSULTA NÃO ENCONTRADA!");
            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultaRemover_Click(object sender, EventArgs e)
        {
            RealizadaDAO consultaDAO = new RealizadaDAO();

            Realizada consulta = null;

            try
            {
                consulta = consultaDAO.Procurar(cpfResp, nomeAnimal, dataConsulta);

                if (consulta != null)
                {
                    if (MessageBox.Show("DESEJA REALMENTE REMOVER CONSULTA?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        consultaDAO.Excluir(cpfResp, nomeAnimal, dataConsulta);
                        MessageBox.Show("CONSULTA REMOVIDA!");
                        Close();
                    }
                }
                else
                    MessageBox.Show("CONSULTA NÃO ENCONTRADA!");
            }
            catch (FormatException)
            {
                MessageBox.Show("DIGITE A DATA CORRETAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void maskConsultaCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (ValidaCPF.IsCpf(maskConsultaCpf.Text) == true)
            {
                lbCpfValido.Visible = true;
                lbCpfInvalido.Visible = false;
            }
            else
            {
                lbCpfInvalido.Visible = true;
                lbCpfValido.Visible = false;
            }
        }

        private void btnConsultaImprimir_Click(object sender, EventArgs e)
        {
            ImprimirConsulta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConsultaVeterinario_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int crmv = int.Parse(txtConsultaVeterinario.Text);
            }
            catch (FormatException)
            {
                txtConsultaVeterinario.Text = "";
            }
            catch(System.OverflowException)
            {
                txtConsultaVeterinario.Text = "";
            }
        }

        private void txtConsultaVeterinario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int crmv = int.Parse(txtConsultaVeterinario.Text);
            }
            catch (FormatException)
            {
                txtConsultaVeterinario.Text = "";
            }
            catch (System.OverflowException)
            {
                txtConsultaVeterinario.Text = "";
            }
        }
    }
}
