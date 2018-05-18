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
    public partial class fmUsuario : Form
    {
        private void SetDTO(Usuario u)
        {
            textUsuarioNovaSenha.Text = u.Senha;
            textUsuarioPerguntaSecreta.Text = u.Pergunta;
        }

        public fmUsuario()
        {
            InitializeComponent();

        }

        private void fmUsuario_Load(object sender, EventArgs e)
        {
           
        }

        public void LimpaCampos()
        {
            textUsuarioSenhaAtual.Text = "";
            textUsuarioNovaSenha.Text = "";
            textUsuarioPerguntaSecreta.Text = "";
        }

        private Usuario GetDTO()
        {
            Usuario u = new Usuario();

            u.Registro = 1;
            u.Senha = textUsuarioNovaSenha.Text;
            u.Pergunta = textUsuarioPerguntaSecreta.Text;

            return u;
        }

        private void btnUsuarioCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarioAlterar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = null;

            usuario = usuarioDAO.Listar();

            if (usuario != null && usuario.Senha == textUsuarioSenhaAtual.Text)
            {
                usuario = GetDTO();

                if(usuarioDAO.Alterar(usuario)==true)
                    MessageBox.Show("SENHA E PERGUNTA ALTERADAS!");
                else
                    MessageBox.Show("ERRO AO ALTERAR!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("SENHA INCORRETA!");

            LimpaCampos();

        }
    }
}
