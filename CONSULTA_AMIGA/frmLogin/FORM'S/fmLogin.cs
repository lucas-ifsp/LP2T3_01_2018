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
    public partial class fmLogin : Form
    {

        public fmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            panelMenuPergunta.Visible = false;
        }

        private void fnLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = null;

            usuario = usuarioDAO.Listar();

            fmMenu menu = new fmMenu();

            if (txtSenhaLogin.Text == usuario.Senha)
            {
                this.Hide();

                menu.StartPosition = FormStartPosition.CenterScreen;

                menu.ShowDialog();
            
                this.Close();
                 
            }
            else
            {
                MessageBox.Show("SENHA INCORRETA !");
                txtSenhaLogin.Text = "";
            }                 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMenuPergunta.Visible = true;

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = null;

            usuario = usuarioDAO.Listar();

            textBoxLoginPergunta.Text = usuario.Pergunta;
        }

        private void btnSaldoVoltar_Click(object sender, EventArgs e)
        {
            panelMenuPergunta.Visible = false;
        }
    }
}
