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
    public partial class fmAnimal : Form
    {
        string nomeAnimal;
        string cpfResp;

        private void LimpaCampos()
        {
            maskAnimalResp.Text = "";
            txtAnimaisNome.Text = "";
            txtAnimaisEspecie.Text = "";
            txtAnimaisRaca.Text = "";
            txtAnimalPeso.Text = "";
            maskAnimalNasc.Text = "";
            txtAnimaisObservacoes.Text = "";

            if (radioButtonAnimaisMacho.Checked == true)
                radioButtonAnimaisMacho.Checked = false;
            else if (radioButtonAnimaisFemea.Checked == true)
                radioButtonAnimaisFemea.Checked = false;

            if (radioButtonAnimaisPequeno.Checked == true)
                radioButtonAnimaisPequeno.Checked = false;
            else if (radioButtonAnimaisMedio.Checked == true)
                radioButtonAnimaisMedio.Checked = false;
            else if (radioButtonAnimaisGrande.Checked == true)
                radioButtonAnimaisGrande.Checked = false;
        }

        public void Voltar()
        {
            btnSair.Visible = true;
            lbSair.Visible = true;
            lbCpfValido.Visible = false;
            lbCpfInvalido.Visible = false;
            maskAnimalResp.Enabled = true;
            btnAnimaisCadastrar.Visible = true;
            btnAnimaisProcurar.Visible = true;
            btnAnimaisAlterar.Visible = false;
            btnAnimaisRemover.Visible = false;
            btnAnimaisVoltar.Visible = false;
            btnAnimaisNovaConsulta.Visible = false;
            lbAnimaisVoltar.Visible = false;

            LimpaCampos();
        }

        public fmAnimal(string cpf)
        {
            InitializeComponent();

            Voltar();

            maskAnimalResp.Text = cpf;

            maskAnimalResp.Enabled = false;

            btnAnimaisProcurar.Visible = false;
        }

        public fmAnimal()
        {
            InitializeComponent();

            Voltar();
        }

        public fmAnimal(string cpf, string nome)
        {
            InitializeComponent();

            AnimalDAO animalDAO = new AnimalDAO();
            Animal animal = animalDAO.Procurar(cpf, nome);

            SetDTO(animal);

            maskAnimalResp.Enabled = false;
            lbCpfValido.Visible = true;
            lbCpfInvalido.Visible = false;
            btnAnimaisVoltar.Visible = false;
            lbAnimaisVoltar.Visible = false;
            btnSair.Visible = true;
            lbSair.Visible = true;

        }

        private void fmAnimal_Load(object sender, EventArgs e)
        {

        }

        private Animal GetDTO()
        {
            Animal a = null;

            try
            {
                if (ValidaCPF.IsCpf(maskAnimalResp.Text) == true)
                {
                    a = new Animal();

                    a.Responsavel = maskAnimalResp.Text;
                    a.Nome = txtAnimaisNome.Text;
                    a.Nascimento = Convert.ToDateTime(maskAnimalNasc.Text);
                    a.Raca = txtAnimaisRaca.Text;
                    a.Especie = txtAnimaisEspecie.Text;
                    a.Observacao = txtAnimaisObservacoes.Text;
                    a.Peso = txtAnimalPeso.Text;

                    if (radioButtonAnimaisMacho.Checked == true)
                        a.Sexo = "Macho";
                    else if (radioButtonAnimaisFemea.Checked == true)
                        a.Sexo = "Fêmea";

                    if (radioButtonAnimaisPequeno.Checked == true)
                        a.Porte = "Pequeno";
                    else if (radioButtonAnimaisMedio.Checked == true)
                        a.Porte = "Médio";
                    else if (radioButtonAnimaisGrande.Checked == true)
                        a.Porte = "Grande";
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                a = null;

                MessageBox.Show("DIGITE OS CAMPOS CORRETAMENTE!", "DADOS INCORRETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return a;
        }

        private void SetDTO(Animal animal)
        {
            maskAnimalResp.Text = animal.Responsavel;
            txtAnimaisNome.Text = animal.Nome;
            txtAnimaisEspecie.Text = animal.Especie;
            txtAnimaisRaca.Text = animal.Raca;
            txtAnimalPeso.Text = animal.Peso;
            maskAnimalNasc.Text = animal.Nascimento.ToString("dd/MM/yyyy");
            txtAnimaisObservacoes.Text = animal.Observacao;

            nomeAnimal = txtAnimaisNome.Text;
            cpfResp = maskAnimalResp.Text;

            if (animal.Sexo == "Macho")
                radioButtonAnimaisMacho.Checked = true;
            else if (animal.Sexo == "Fêmea")
                radioButtonAnimaisFemea.Checked = true;

            if (animal.Porte == "Pequeno")
                radioButtonAnimaisPequeno.Checked = true;
            else if (animal.Porte == "Médio")
                radioButtonAnimaisMedio.Checked = true;
            else if (animal.Porte == "Grande")
                radioButtonAnimaisGrande.Checked = true;
        }

        private void btnAnimaisCadastrar_Click(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();
            Animal jaCadastrado = null;
            Animal animal = GetDTO();
            Pessoa pessoa = null;

            string cpf = maskAnimalResp.Text;
            string nome = txtAnimaisNome.Text;

            pessoa = pessoaDAO.Procurar(cpf);
            jaCadastrado = animalDAO.Procurar(cpf, nome);

            if (pessoa!=null)
            {
                if (jaCadastrado == null)
                {
                    if(animalDAO.Criar(pessoa,animal)==true)
                    {
                        MessageBox.Show("ANIMAL CADASTRADO!");
                        Close();
                    }
                    else
                        MessageBox.Show("ERRO AO CADASTRAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else              
                    MessageBox.Show("ANIMAL JÁ CADASTRADO PARA ESSE CPF!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("PESSOA NÃO CADASTRADA!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAnimaisProcurar_Click(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();
            Animal animal = null;
            Pessoa pessoa = null;

            string nome = txtAnimaisNome.Text;
            string cpf = maskAnimalResp.Text;

            pessoa = pessoaDAO.Procurar(cpf);
            animal = animalDAO.Procurar(cpf,nome);

            if(pessoa != null)
            {
                if (animal != null)
                {
                    maskAnimalResp.Enabled = false;
                    btnAnimaisCadastrar.Visible = false;
                    btnAnimaisProcurar.Visible = false;
                    btnAnimaisAlterar.Visible = true;
                    btnAnimaisRemover.Visible = true;
                    lbAnimaisVoltar.Visible = true;
                    btnAnimaisVoltar.Visible = true;
                    btnAnimaisNovaConsulta.Visible = true;
                    btnSair.Visible = false;
                    lbSair.Visible = false;

                    SetDTO(animal);
                }
                else
                    MessageBox.Show("ANIMAL NÃO ENCONTRADO!");
            }
            else
                MessageBox.Show("PESSOA NÃO ECONTRADA!");

        }

        private void btnAnimaisAlterar_Click(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();
            Animal animal = null;
            Pessoa pessoa = null;

            pessoa = pessoaDAO.Procurar(cpfResp);
            animal = animalDAO.Procurar(cpfResp, nomeAnimal);

            if (pessoa != null && animal != null)
            {
                animal = GetDTO();

                if(animalDAO.Alterar(pessoa,animal)==true)
                {
                    MessageBox.Show("DADOS ALTERADOS!");
                    Close();
                }
                else
                    MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("PESSOA OU ANIMAL NÃO ECONTRADO!");  

        }

        private void btnAnimaisRemover_Click(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            PessoaDAO pessoaDAO = new PessoaDAO();
            Animal animal = null;
            Pessoa pessoa = null;

            pessoa = pessoaDAO.Procurar(cpfResp);
            animal = animalDAO.Procurar(cpfResp, nomeAnimal);

            if (pessoa != null && animal != null)
            {
                if (MessageBox.Show("DESEJA REALMENTE REMOVER ANIMAL?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    animalDAO.Excluir(pessoa,animal);
                    MessageBox.Show("ANIMAL REMOVIDO!");
                    Close();
                }
            }
            else
                MessageBox.Show("PESSOA OU ANIMAL NÃO ECONTRADO!");
                      
        }

        private void maskAnimalResp_KeyUp(object sender, KeyEventArgs e)
        {
            if (ValidaCPF.IsCpf(maskAnimalResp.Text) == true)
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

        private void btnAnimaisVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnAnimaisNovaConsulta_Click(object sender, EventArgs e)
        {
            fmConsulta novaConsulta = new fmConsulta(maskAnimalResp.Text, txtAnimaisNome.Text);

            novaConsulta.StartPosition = FormStartPosition.CenterScreen;

            novaConsulta.ShowDialog();

            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
