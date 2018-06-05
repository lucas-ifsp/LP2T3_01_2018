using Aula_6_em_Diante_Continuo.ViewController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo
{
    public partial class formPrincipal : Form
    {
        private FormGerenciaLivro formLivro;
        private FormGerenciaUsuarios formUsuario;
        private FormEmprestimo formEmprestimo;
        private FormDevolucao formDevolucao;
        private FormConsultaLivroUsuario formConsultaLivroUsuario;

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void miAcervo_Click(object sender, EventArgs e)
        {
            if (formLivro == null)
            {
                formLivro = new FormGerenciaLivro();
                formLivro.MdiParent = this;
            }
            formLivro.WindowState = FormWindowState.Maximized;
            formLivro.Show();
        }

        private void miUsuario_Click(object sender, EventArgs e)
        {
            if (formUsuario == null)
            {
                formUsuario = new FormGerenciaUsuarios();
                formUsuario.MdiParent = this;
            }
            formUsuario.WindowState = FormWindowState.Maximized;
            formUsuario.Show();
        }

        private void miEmprestimo_Click(object sender, EventArgs e)
        {
            if (formEmprestimo == null)
            {
                formEmprestimo = new FormEmprestimo();
                formEmprestimo.MdiParent = this;
            }
            formEmprestimo.WindowState = FormWindowState.Maximized;
            formEmprestimo.Show();
        }

        private void miDevolucao_Click(object sender, EventArgs e)
        {
            if (formDevolucao == null)
            {
                formDevolucao = new FormDevolucao();
                formDevolucao.MdiParent = this;
            }
            formDevolucao.WindowState = FormWindowState.Maximized;
            formDevolucao.Show();
        }

        private void miHistoricoUsuário_Click(object sender, EventArgs e)
        {
            if (formConsultaLivroUsuario == null)
            {
                formConsultaLivroUsuario = new FormConsultaLivroUsuario();
                formConsultaLivroUsuario.MdiParent = this;
            }
            formConsultaLivroUsuario.WindowState = FormWindowState.Maximized;
            formConsultaLivroUsuario.Show();
        }
    }
}
