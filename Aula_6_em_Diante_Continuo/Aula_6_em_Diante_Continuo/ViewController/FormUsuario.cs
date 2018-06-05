using System;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo
{
    public partial class FormUsuario : Form
    {
        private bool editMode = false;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(Usuario u, bool view)
        {
            InitializeComponent();
            if (view)
            {
                Text = "Visualizar Usuário";
                btnCancelar.Visible = false;
                btnSalvar.Text = "Fechar";
                btnSalvar.Click -= new System.EventHandler(this.btnSalvar_Click);
                btnSalvar.Click += new System.EventHandler(this.btnCancelar_Click);
                Disable();
            }
            else
            {
                Text = "Editar Usuário";
                txtCPF.ReadOnly = true;
                btnSalvar.Text = "Atualizar";
                editMode = true;
            }
            SetDTO(u);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            if (!editMode)
                uDAO.Create(GetDTO());
            else
                uDAO.Update(GetDTO());

            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private Usuario GetDTO()
        {
            Usuario usuario = new Usuario();
            usuario.Cpf = txtCPF.Text;
            usuario.Nome = txtNome.Text;
            usuario.DataNasc = dtPicker.Value;
            return usuario;
        }

        private void SetDTO(Usuario usuario)
        {
            txtCPF.Text = usuario.Cpf;
            txtNome.Text = usuario.Nome;
            dtPicker.Value = usuario.DataNasc;
        }

        private void Disable()
        {
            txtCPF.ReadOnly = true;
            txtNome.ReadOnly = true;
            dtPicker.Enabled = false;
        }
    }
}
