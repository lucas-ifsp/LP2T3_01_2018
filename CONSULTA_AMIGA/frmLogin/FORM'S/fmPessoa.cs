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
    public partial class fmPessoa : Form
    {
        List<Animal> pets = new List<Animal>();

        private void LimpaCampos()
        {
            maskPessoaCpf.Text = "";
            txtPessoaNome.Text = "";
            maskPessoaNasc.Text = "";
            maskPessoaTelefone.Text = "";
            maskPessoaCelular.Text = "";

            if (radBtnPessoaFeminino.Checked == true)
                radBtnPessoaFeminino.Checked = false;

            else if (radBtnPessoaMasculino.Checked == true)
                radBtnPessoaMasculino.Checked = false;

            txtPessoaRua.Text = "";
            txtPessoaNumero.Text = "";
            txtPessoaBairro.Text = "";
            comboBoxPessoaEstado.SelectedIndex = 0;
            txtPessoaCidade.Text = "";
            txtPessoaCep.Text = "";

            lbCpfValido.Visible = false;
            lbCpfInvalido.Visible = false;

            dataGridViewPessoaAnimais.Rows.Clear();
        }

        private void Voltar()
        {
            btnSair.Visible = true;
            lbSair.Visible = true;

            lbCpfValido.Visible = false;
            lbCpfInvalido.Visible = false;
            maskPessoaCpf.Enabled = true;
            groupBoxPessoaAnimais.Visible = false;

            btnPessoaCadastrar.Visible = true;
            btnPessoaAlterar.Visible = false;
            btnPessoaRemover.Visible = false;

            lbPessoaVoltar.Visible = false;
            btnPessoaVoltar.Visible = false;

            btnPessoaProcurar.Visible = true;

            LimpaCampos();
        }

        public fmPessoa()
        {
            InitializeComponent();

            Voltar();
        }

        public fmPessoa(string cpf)
        {
            InitializeComponent();

            PessoaDAO pessoaDAO = new PessoaDAO();

            Pessoa p = pessoaDAO.Procurar(cpf);

            SetDTO(p);

            maskPessoaCpf.Enabled = false;
            lbCpfValido.Visible = true;
            lbCpfInvalido.Visible = false;
            btnPessoaVoltar.Visible = false;
            lbPessoaVoltar.Visible = false;
            btnSair.Visible = true;
            lbSair.Visible = true;
        }

        private void fmPessoa_Load(object sender, EventArgs e)
        {

        }

        public void MostrarAnimais()
        {
            List<Animal> pets = new List<Animal>();

            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();

            Pessoa pessoa = null;

            string cpf = maskPessoaCpf.Text;

            dataGridViewPessoaAnimais.Rows.Clear();

            pessoa = pessoaDAO.Procurar(cpf);

            pets = animalDAO.ListarAnimaisCpf(pessoa);

            foreach (Animal a in pets)
                dataGridViewPessoaAnimais.Rows.Add(a.Nome, a.Especie, a.Raca, a.Nascimento.ToString("dd/MM/yyyy"));

            dataGridViewPessoaAnimais.Refresh();

        }

        private Pessoa GetDTO()
        {
            Pessoa p = null;

            try
            {
                if (ValidaCPF.IsCpf(maskPessoaCpf.Text) == true)
                {
                    p = new Pessoa();

                    p.Cpf = maskPessoaCpf.Text;
                    p.Nome = txtPessoaNome.Text;
                    p.Nascimento = Convert.ToDateTime(maskPessoaNasc.Text);
                    p.Telefone = maskPessoaTelefone.Text;
                    p.Celular = maskPessoaCelular.Text;

                    if(radBtnPessoaFeminino.Checked == true)
                    p.Sexo = "F";

                    else if (radBtnPessoaMasculino.Checked == true)
                    p.Sexo = "M";

                    p.Rua = txtPessoaRua.Text;
                    p.Numero = txtPessoaNumero.Text;
                    p.Bairro = txtPessoaBairro.Text;
                    p.Estado = comboBoxPessoaEstado.Text;
                    p.Cidade = txtPessoaCidade.Text;
                    p.Cep = txtPessoaCep.Text;
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                p = null;

                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return p;
        }

        private void SetDTO(Pessoa pessoa)
        {
            maskPessoaCpf.Text = Convert.ToString(pessoa.Cpf);
            txtPessoaNome.Text = pessoa.Nome;
            maskPessoaNasc.Text = pessoa.Nascimento.ToString("dd/MM/yyyy");
            maskPessoaTelefone.Text = pessoa.Telefone;
            maskPessoaCelular.Text = pessoa.Celular;

            if (pessoa.Sexo == "F")
                radBtnPessoaFeminino.Checked = true;

            else if (pessoa.Sexo == "M")
                radBtnPessoaMasculino.Checked = true;

            txtPessoaRua.Text = pessoa.Rua;
            txtPessoaNumero.Text = pessoa.Numero;
            txtPessoaBairro.Text = pessoa.Bairro;
            comboBoxPessoaEstado.Text = pessoa.Estado;
            txtPessoaCidade.Text = pessoa.Cidade;
            txtPessoaCep.Text = pessoa.Cep;

            MostrarAnimais();
        }

        private void btnPessoaCadastrar_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            Pessoa jaCadastrada = null;
            Pessoa pessoa = GetDTO();
            string cpf;

            if(pessoa != null)
            {
                cpf = maskPessoaCpf.Text;
                jaCadastrada = pessoaDAO.Procurar(cpf);

                if (jaCadastrada == null)
                {
                    if (pessoaDAO.Criar(pessoa)==true)
                    {
                        MessageBox.Show("PESSOA CADASTRADA!");
                        Close();
                    }
                    else
                        MessageBox.Show("ERRO AO CADASTRAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                } 
                else
                    MessageBox.Show("CPF JÁ CADASTRADO!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        private void btnPessoaProcurar_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();

            Pessoa pessoa = null;

            string cpf = maskPessoaCpf.Text;

            pessoa = pessoaDAO.Procurar(cpf);
            
            if (pessoa != null)
            {
                btnPessoaCadastrar.Visible = false;
                groupBoxPessoaAnimais.Visible = true;
                btnPessoaAlterar.Visible = true;
                btnPessoaRemover.Visible = true;
                maskPessoaCpf.Enabled = false;
                lbPessoaVoltar.Visible = true;
                btnPessoaVoltar.Visible = true;
                btnPessoaProcurar.Visible = false;
                btnSair.Visible = false;
                lbSair.Visible = false;

                SetDTO(pessoa);
            }
            else
            {
                MessageBox.Show("PESSOA NÃO ENCONTRADA!");
            }                
        }

        private void btnPessoaAlterar_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            Pessoa pessoa = null;

            string cpf = maskPessoaCpf.Text;

            pessoa = pessoaDAO.Procurar(cpf);

            if(pessoa!=null)
            {
                pessoa = GetDTO();

                if(pessoaDAO.Alterar(pessoa)==true)
                {
                    MessageBox.Show("DADOS ALTERADOS!");
                    Close();
                }
                else
                    MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("PESSOA NÃO ECONTRADA!");
         
        }

        private void btnPessoaRemover_Click(object sender, EventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();
            Pessoa pessoa = null;

            string cpf = maskPessoaCpf.Text;

            pessoa = pessoaDAO.Procurar(cpf);

            if (pessoa != null)
            {
                
                if (MessageBox.Show("DESEJA REALMENTE REMOVER PESSOA?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pessoaDAO.Excluir(cpf);
                    MessageBox.Show("PESSOA REMOVIDA!");
                    Close();
                }
            }
            else
                MessageBox.Show("PESSOA NÃO ECONTRADA!");
            
        }

        private void maskPessoaCpf_KeyUp(object sender, KeyEventArgs e)
        {

            if (ValidaCPF.IsCpf(maskPessoaCpf.Text) == true)
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

        private void btnPessoaVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnPessoaAnimal_Click(object sender, EventArgs e)
        {
            fmAnimal cadastrarAnimal = new fmAnimal(maskPessoaCpf.Text);

            cadastrarAnimal.StartPosition = FormStartPosition.CenterScreen;

            cadastrarAnimal.ShowDialog();
        }

        private void dataGridViewPessoaAnimais_DoubleClick(object sender, EventArgs e)
        {
            string cpf = Convert.ToString(maskPessoaCpf.Text);

            string animal = Convert.ToString(dataGridViewPessoaAnimais.CurrentRow.Cells[0].Value.ToString());

            AnimalDAO animalDAO = new AnimalDAO();

            Animal a = animalDAO.Procurar(cpf,animal);

            if(a != null)
            {
                fmAnimal formAnimal = new fmAnimal(cpf, animal);

                formAnimal.StartPosition = FormStartPosition.CenterScreen;

                formAnimal.ShowDialog();
            }
            else
                dataGridViewPessoaAnimais.Rows.Remove(dataGridViewPessoaAnimais.CurrentRow);
        }

        private void btnPessoaRefresh_Click(object sender, EventArgs e)
        {
            MostrarAnimais();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPessoaCep_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                long cep = long.Parse(txtPessoaCep.Text);
            }
            catch (FormatException)
            {
                txtPessoaCep.Text = "";
            }
            catch (System.OverflowException)
            {
                txtPessoaCep.Text = "";
            }
        }

        private void txtPessoaCep_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                long cep = long.Parse(txtPessoaCep.Text);
            }
            catch (FormatException)
            {
                txtPessoaCep.Text = "";
            }
            catch (System.OverflowException)
            {
                txtPessoaCep.Text = "";
            }
        }
    }
}
