using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Continuo
{
    public partial class FormLivro : Form
    {
        //indica que o form foi aberto em modo de edição
        private bool editMode = false;

        public FormLivro()
        {
            InitializeComponent();
        }

        //sobrecarga de construtor para os modo de edição e visualização
        public FormLivro(Livro l, bool editMode)
        {
            InitializeComponent();
            //método criado para colocar os valores de um objeto livro 
            //na interface gráfica. No caso, l é o livro que passo como 
            //parametro para edição ou visualização
            setDTO(l);
            this.editMode = editMode;

            //Se abriu em modo de visualização
            if (!this.editMode)
            {
                //coloco todos os controles do form como ReadOnly
                ReadOnly();
                //Mudo a posição do cancelar para cima do salvar
                btnCancelar.Location = btnSalvar.Location;
                //Deixo o botão salvar invisível
                btnSalvar.Visible = false;
                //Muda o texto de "Cancelar" para "Ok"
                btnCancelar.Text = "Ok";
                //Esses últimos três comandos são estéticos, pois 
                //não faz sentido ter Salvar e Cancelar apenas para
                //visualizar. Você não estará salvando nada. =D
            }
                
        }

        //Desabilita todos os campos de texto do form.
        private void ReadOnly()
        {
            txtAutor.ReadOnly = true;
            txtTitulo.ReadOnly = true;
        }

        //Pega os atributos do objeto 'l' da classe Livro 
        //e coloca nas elementos da interface gráfica
        private void setDTO(Livro l)
        {
            txtAutor.Text = l.Autor;
            txtCodigo.Text = l.Codigo.ToString();
            txtTitulo.Text = l.Titulo;
        }

        //Pega os valores dos elementos da interface gráfica 
        //e guarda em um objeto do da classe Livro 
        private Livro getDTO()
        {
            Livro l = new Livro();
            l.Autor = txtAutor.Text;
            l.Titulo = txtTitulo.Text;

            if(txtCodigo.Text != "")
                l.Codigo = long.Parse(txtCodigo.Text);

            return l;
        }

        //O botão "btnSalvar" serve tanto para salvar um novo objeto
        //quanto para editar um já existente. Para saber quando fezer
        //cada um dos dois, utilizamos o valor de "editMode", que por 
        //padrão está como falso (salvar é o padrão).
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ILivroDAO livroDAO = new LivroDict();

            if (editMode)
                livroDAO.Update(getDTO());
            else
                livroDAO.Save(getDTO());

            Dispose();
        }

        //O botão "btnCancelar" apenas chama o método Dispose() da
        //classe Form, que fecha a janela.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
