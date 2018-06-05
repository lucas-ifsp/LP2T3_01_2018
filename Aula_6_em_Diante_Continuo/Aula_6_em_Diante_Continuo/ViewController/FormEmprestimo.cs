using Aula_6_em_Diante_Continuo.DAO;
using Aula_6_em_Diante_Continuo.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo.ViewController
{
    public partial class FormEmprestimo : Form
    {
        public FormEmprestimo()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(lbNomeResult.Text != "")
            {
                if(dgvEmprestimo.RowCount > 0)
                {
                    EmprestimoDAO eDAO = new EmprestimoDAO();
                    Console.WriteLine("NUM -> " + dgvEmprestimo.Rows.Count);
                    foreach(DataGridViewRow p in dgvEmprestimo.Rows)
                    {
                        Emprestimo emp = new Emprestimo();
                        emp.Devolucao =  DateTime.Today.AddDays(7);
                        emp.Entrega = DateTime.Today;
                        emp.Finalizado = false;

                        LivroDAO lDAO = new LivroDAO();
                        emp.Livro = lDAO.Read(int.Parse(p.Cells[0].Value.ToString()));

                        UsuarioDAO uDAO = new UsuarioDAO();
                        emp.Usuario = uDAO.Read(txtCPF.Text);

                        eDAO.Save(emp);

                        //Marca o livro como não disponível
                        emp.Livro.Disponivel = false;
                        lDAO.Update(emp.Livro);
 
                    }
                    MessageBox.Show("Empréstimo realizado com sucesso");
                    Hide();
                }
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvAcervo.SelectedRows)
            {
                AddNaoRepetido(r);
            }
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            Fill(null);
        }

        private void Fill(string name)
        {
            LivroDAO dao = new LivroDAO();
            List<Livro> ls = dao.List(name);

            dgvAcervo.Rows.Clear();
            foreach (Livro l in ls)
            {
                Console.WriteLine(l);
                if (l.Disponivel)
                    dgvAcervo.Rows.Add(l.Codigo, l.Titulo, l.Autor, l.Disponivel ? "Sim" : "Não");
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Read(txtCPF.Text);
            if (usuario != null )
                lbNomeResult.Text = usuario.Nome;
        }

        private void AddNaoRepetido(DataGridViewRow r)
        {
            bool repetido = false;
            foreach(DataGridViewRow p in dgvEmprestimo.Rows)
            {
                if (r.Cells[0].Value.ToString() == p.Cells[0].Value.ToString())
                    repetido = true;
            }
            if(!repetido)
                dgvEmprestimo.Rows.Add(r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString());

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fill(txtBuscar.Text);
        }

        private void FormEmprestimo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormEmprestimo_Activated(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtCPF.Text = "";
            lbNomeResult.Text = "";
            dgvEmprestimo.Rows.Clear();
            Fill();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimo.SelectedRows.Count > 0)
            {
                dgvEmprestimo.Rows.RemoveAt(dgvEmprestimo.CurrentRow.Index);
            }
        }
    }
}
