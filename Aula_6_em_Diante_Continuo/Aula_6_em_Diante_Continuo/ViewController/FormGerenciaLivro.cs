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
    public partial class FormGerenciaLivro : Form
    {
        public FormGerenciaLivro()
        {
            InitializeComponent();
        }

        private void FormGerenciaLivro_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormLivro form = new FormLivro();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            Fill();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvLivros.CurrentRow != null)
            {
                int key = int.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                LivroDAO dao = new LivroDAO();
                // carrega os dados da janela com base na consulta Read(chave)
                FormLivro form = new FormLivro(dao.Read(key), true);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                Fill();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(dgvLivros.CurrentRow != null)
            {
                int key = int.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                LivroDAO bd = new LivroDAO();
                FormLivro form = new FormLivro(bd.Read(key),false);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione uma linha para visualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow != null)
            {
                int key = int.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                LivroDAO bd = new LivroDAO();
                bd.Delete(key);
                Fill();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            Fill(txtFiltrar.Text);
        }

        private void Fill()
        {
            Fill(null);
        }

        private void Fill(string name)
        {
            LivroDAO dao = new LivroDAO();
            List<Livro> ls = dao.List(name);

            dgvLivros.Rows.Clear();
            foreach (Livro l in ls)
                dgvLivros.Rows.Add(l.Codigo, l.Titulo, l.Autor);
        }
        
        private void FormGerenciaLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormRelatorioLivro report = new FormRelatorioLivro();

            report.StartPosition = FormStartPosition.CenterParent;
            report.ShowDialog(this);
        }
    }
}
