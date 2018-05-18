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
    public partial class fmPesquisarAnimais : Form
    {
        public void CarregarAnimais()
        {
            AnimalDAO animalDAO = new AnimalDAO();

            List<Animal> animais = new List<Animal>();

            animais = animalDAO.ListarAnimais();

            dataGridViewPesqAnimais.Rows.Clear();

            foreach (Animal a in animais)
                dataGridViewPesqAnimais.Rows.Add(a.Responsavel, a.Nome, a.Especie, a.Raca, a.Nascimento.ToString("dd/MM/yyyy"), a.Sexo, a.Porte);

            dataGridViewPesqAnimais.Refresh();

        }

        public fmPesquisarAnimais()
        {
            InitializeComponent();

            CarregarAnimais();
        }


        private void btnPesqAnimaisVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesAnimaisEspecie_KeyUp(object sender, KeyEventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();

            List<Animal> animais = new List<Animal>();

            string nome = txtPesqAnimaisNome.Text;

            animais = animalDAO.ListarAnimaisNome(nome);

            dataGridViewPesqAnimais.Rows.Clear();

            foreach (Animal a in animais)
                dataGridViewPesqAnimais.Rows.Add(a.Responsavel, a.Nome, a.Especie, a.Raca, a.Nascimento.ToString("dd/MM/yyyy"), a.Sexo, a.Porte);

            dataGridViewPesqAnimais.Refresh();
        }

        private void dataGridViewPesqAnimais_DoubleClick(object sender, EventArgs e)
        {
            string cpf = Convert.ToString(dataGridViewPesqAnimais.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(dataGridViewPesqAnimais.CurrentRow.Cells[1].Value.ToString());

            AnimalDAO animalDAO = new AnimalDAO();

            Animal animal = animalDAO.Procurar(cpf, nome);

            if (animal != null)
            {
                fmAnimal formAnimal = new fmAnimal(cpf, nome);

                formAnimal.StartPosition = FormStartPosition.CenterScreen;

                formAnimal.Show();

                this.Close();
            }
            else
                dataGridViewPesqAnimais.Rows.Remove(dataGridViewPesqAnimais.CurrentRow);
        }

        private void btnPesqAnimaisRefresh_Click(object sender, EventArgs e)
        {
            CarregarAnimais();
        }
    }
}
