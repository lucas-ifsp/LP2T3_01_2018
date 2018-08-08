using System;
using System.Windows.Forms;
using Aula_6_em_Diante_Continuo.DAO;

namespace Aula_6_em_Diante_Continuo
{
    public partial class FormLivro : Form
    {
        private bool editMode = false;

        public FormLivro()
        {
            InitializeComponent();
        }

        public FormLivro(Livro l, bool edit)
        {
            InitializeComponent();
            
            if (edit)
            {
                Text = "Editar Livro";
                btnSalvar.Text = "Atualizar";
                txtNumero.ReadOnly = true;
                editMode = true;
            }
            else
            {
                Text = "Visualizar Livro";
                btnCancelar.Visible = false;
                btnSalvar.Text = "Ok";
                btnSalvar.Click -= new System.EventHandler(this.btnSalvar_Click);
                btnSalvar.Click += new System.EventHandler(this.btnCancelar_Click);
                Disable();
            }
            SetDTO(l);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivroDAO dao = new LivroDAO();
            //GenericDAO dao = new GenericDAO();

            Console.WriteLine(editMode);
            if (editMode)
                dao.Update(GetDTO());
            else
                dao.Save(GetDTO());
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private Livro GetDTO()
        {
            Livro l = new Livro();
            l.Autor = txtAutor.Text;
            l.Titulo = txtLivro.Text;
            if(txtNumero.Text != "")
                l.Codigo = long.Parse(txtNumero.Text);
            return l;  
        }

        private void SetDTO(Livro l)
        {
            txtAutor.Text = l.Autor;
            txtLivro.Text = l.Titulo;
            txtNumero.Text = l.Codigo.ToString();
        }

        private void Disable()
        {
            txtAutor.Enabled = false;
            txtLivro.Enabled = false;
            txtNumero.Enabled = false;
        }
    }
}
