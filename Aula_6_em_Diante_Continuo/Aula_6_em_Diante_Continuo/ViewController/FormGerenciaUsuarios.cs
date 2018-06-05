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
    public partial class FormGerenciaUsuarios : Form
    {
        public FormGerenciaUsuarios()
        {
            InitializeComponent();
        }

        private void FormGerenciaUsuarios_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormUsuario gui = new FormUsuario();
            gui.StartPosition = FormStartPosition.CenterParent;
            gui.ShowDialog(this);
            Fill();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                String key = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                UsuarioDAO dao = new UsuarioDAO();
                FormUsuario gui = new FormUsuario(dao.Read(key), false);
                gui.StartPosition = FormStartPosition.CenterParent;
                gui.ShowDialog(this);
                Fill();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                String key = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                UsuarioDAO dao = new UsuarioDAO();
                FormUsuario gui = new FormUsuario(dao.Read(key), true);
                gui.StartPosition = FormStartPosition.CenterParent;
                gui.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione uma linha para visualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                String key = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                UsuarioDAO dao = new UsuarioDAO();
                dao.Delete(key);
                Fill();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Fill(txtFiltrar.Text);
        }

        private void Fill()
        {
            Fill(null);
        }

        private void Fill(string name)
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            List<Usuario> usuarios;
            usuarios = uDAO.List(name);
            dgvUsuarios.Rows.Clear();

            foreach (Usuario u in usuarios)
                dgvUsuarios.Rows.Add(u.Cpf, u.Nome, u.DataNasc.ToString("dd/MM/yyyy"));
        }

        private void FormGerenciaUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormRelatorioUsuario formRelatorio = new FormRelatorioUsuario();
            formRelatorio.StartPosition = FormStartPosition.CenterParent;
            formRelatorio.ShowDialog(this);
        }
    }
}
