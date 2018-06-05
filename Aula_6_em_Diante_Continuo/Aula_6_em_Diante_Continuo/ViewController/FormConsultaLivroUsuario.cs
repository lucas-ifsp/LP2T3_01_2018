using Aula_6_em_Diante_Continuo.DAO;
using Aula_6_em_Diante_Continuo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo.ViewController
{
    public partial class FormConsultaLivroUsuario : Form
    {
        public FormConsultaLivroUsuario()
        {
            InitializeComponent();
        }

        private void panelUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void FormConsultaLivroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            Usuario u = uDAO.Read(txtCPF.Text);
            if(u != null && u.Cpf == txtCPF.Text)
            {
                lbNomeResult.Text = u.Nome;
                Fill();
            }else
            {
                lbNomeResult.Text = "";
                dgvAcervo.Rows.Clear();
            }
        }

        private void Fill()
        {
            EmprestimoDAO eDAO = new EmprestimoDAO();
            List<Emprestimo> emps = eDAO.List(txtCPF.Text);

            dgvAcervo.Rows.Clear();
            foreach (Emprestimo e in emps)
                dgvAcervo.Rows.Add(e.Codigo, e.Livro.Titulo, e.Livro.Autor,e.Entrega,e.Devolucao, e.Finalizado ? "Devolvido" : "Em aberto");

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            EmprestimoDAO eDAO = new EmprestimoDAO();
            List<Emprestimo> emps = eDAO.List(txtCPF.Text);

            dgvAcervo.Rows.Clear();
            foreach (Emprestimo emp in emps)
            {
                if (emp.Livro.Autor.Contains(txtBuscar.Text) || emp.Livro.Titulo.Contains(txtBuscar.Text))
                    dgvAcervo.Rows.Add(emp.Codigo, emp.Livro.Titulo, emp.Livro.Autor, emp.Entrega, emp.Devolucao, emp.Finalizado ? "Devolvido" : "Em aberto");
            }
        }
    }
}
