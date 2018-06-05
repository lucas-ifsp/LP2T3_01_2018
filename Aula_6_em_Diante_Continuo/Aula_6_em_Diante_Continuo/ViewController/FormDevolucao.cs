using Aula_6_em_Diante_Continuo.DAO;
using Aula_6_em_Diante_Continuo.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo.ViewController
{
    public partial class FormDevolucao : Form
    {
        public FormDevolucao()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo devolver o(s) livro(s) selecionado(s)?", "Confirmar devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmprestimoDAO eDAO = new EmprestimoDAO();
                Emprestimo emp = new Emprestimo();
                LivroDAO lDAO;

                foreach(DataGridViewRow r in dgvEmprestimos.SelectedRows)
                {
                    emp = eDAO.Read(long.Parse(r.Cells[0].Value.ToString()));

                    emp.Livro.Disponivel = true;
                    emp.Finalizado = true;

                    lDAO = new LivroDAO();
                    lDAO.Update(emp.Livro);

                    eDAO.Update(emp);
                }
                Fill();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Fill()
        {
            EmprestimoDAO dao = new EmprestimoDAO();
            List<Emprestimo> ls = dao.List(txtCPF.Text);

            dgvEmprestimos.Rows.Clear();
            foreach (Emprestimo l in ls)
            {
                if (!l.Finalizado)
                    dgvEmprestimos.Rows.Add(l.Codigo, l.Livro.Titulo, l.Livro.Autor, l.Entrega.ToString("dd/MM/yyyy"), l.Devolucao.ToString("dd/MM/yyyy"));
            }
        }
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Read(txtCPF.Text);

            if (usuario != null && usuario.Cpf == txtCPF.Text.Trim())
            {
                lbNomeResult.Text = usuario.Nome;
                Fill();
            }
            else
            {
                lbNomeResult.Text = "";
                dgvEmprestimos.Rows.Clear();
            }
        }

        private void FormDevolucao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();    
        }

        private void FormDevolucao_Activated(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            Fill();
        }
    }
}
