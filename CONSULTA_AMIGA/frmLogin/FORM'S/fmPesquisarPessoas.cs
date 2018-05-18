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
    public partial class fmPesquisarPessoas : Form
    {
        public void CarregarPessoas()
        {
            PessoaDAO pessoaDAO = new PessoaDAO();

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas = pessoaDAO.ListarPessoas();

            dataGridViewPesqPessoas.Rows.Clear();

            foreach (Pessoa p in pessoas)
                dataGridViewPesqPessoas.Rows.Add(p.Cpf, p.Nome, p.Telefone, p.Celular, p.Cidade, p.Estado);

            dataGridViewPesqPessoas.Refresh();

        }

        public fmPesquisarPessoas()
        {
            InitializeComponent();

            CarregarPessoas();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtPesqPessoasNome_KeyUp(object sender, KeyEventArgs e)
        {
            PessoaDAO pessoaDAO = new PessoaDAO();

            List<Pessoa> pessoas = new List<Pessoa>();

            string nome = txtPesqPessoasNome.Text;

            pessoas = pessoaDAO.ListarPessoasNome(nome);

            dataGridViewPesqPessoas.Rows.Clear();

            foreach (Pessoa p in pessoas)
                dataGridViewPesqPessoas.Rows.Add(p.Cpf, p.Nome, p.Telefone, p.Celular, p.Cidade, p.Estado);

            dataGridViewPesqPessoas.Refresh();

        }

        private void dataGridViewPesqPessoas_DoubleClick(object sender, EventArgs e)
        {
            string cpf = Convert.ToString(dataGridViewPesqPessoas.CurrentRow.Cells[0].Value.ToString());

            PessoaDAO pessoaDAO = new PessoaDAO();

            Pessoa pessoa = pessoaDAO.Procurar(cpf);

            if (pessoa != null)
            {
                fmPessoa formPessoa = new fmPessoa(cpf);

                formPessoa.StartPosition = FormStartPosition.CenterScreen;

                formPessoa.Show();

                this.Close();
            }
            else
                dataGridViewPesqPessoas.Rows.Remove(dataGridViewPesqPessoas.CurrentRow);
        }

        private void btnPesqPessoasRefresh_Click(object sender, EventArgs e)
        {
            CarregarPessoas();
        }
    }
}
