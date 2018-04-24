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
    public partial class FormGerenciaLivros : Form
    {
        //No modo visual, altere as seguintes propriedades do DataGridView:
        // - RowsHeadersVisible = false -> Some com o cabeçalho a esqueda para as linhas
        // - MultiSelect = false -> Permite selecionar apenas uma linha por vez.
        // - SelectionMode = FullRowSelection -> a linha toda é selecionada ao clicar
        // ** Isso é opcional, mas melhora o uso do datagrid. =)
    
        public FormGerenciaLivros()
        {
            InitializeComponent();
        }

        //Trata o evento de click do botão 'Novo'
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Cria um form para cadastro de novo livro
            FormLivro form = new FormLivro();
            //Ajusta a abertura do form para o centro do form que o invocou (parent)
            form.StartPosition = FormStartPosition.CenterParent;
            //Usa o método ShowDialog para abrir o Form como modal, ou seja, 
            //bloqueado o form parent que o invocou (this)
            form.ShowDialog(this);
            //Fill é um método criado por nós para atualizar o datagridview
            //com o conteúdo do dicionário
            Fill();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verifico se uma linha foi selecionada para evitar um erro
            if (dgvLivros.SelectedRows.Count == 1)
            {
                //Crio um objeto concreto LivroDict do tipo da interface ILivroDAO
                ILivroDAO livroDAO = new LivroDict();
                //CurrentRow retorna a linha selecionada. Cells é a lista de células
                //dessa linha. Cells[0] é a primeira célula de Cells.
                //Value retorna o valor dentro de uma dada Cell. 
                //ToString converte Value para String, para depois converter para Long
                //com o método Parse. O resultado é guardado em Key, que é a chave 
                //'codigo' utilizada para obter o Livro armazenado no dicionário ou similar
                long key = long.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                //Chamo o método Read do objeto de armazenamento que estamos usando. 
                //Nesse caso específico, estamos guardando em um dicionário. O método
                //Read retorna o Livro cujo código (chave) é igual a 'key'.
                Livro l = livroDAO.Read(key);

                //Abro a janela passando livro 'l' como parâmetro, para que a gui
                //inicie com os valores de 'l' para edição. 'true' indica para FormLivro
                //que ele deve abrir em modo de edição. Veja FormLivro para mais detalhes
                FormLivro form = new FormLivro(l, true);
                //O resto é igual ao método anterior
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);

                Fill();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //Implementação similar ao método anterior, mas abre o Form 
            //no formato ReadOnly, com todos os elementos disabilitados.
            if (dgvLivros.SelectedRows.Count == 1)
            {
                ILivroDAO livroDAO = new LivroDict();
                long key = long.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                Livro l = livroDAO.Read(key);

                FormLivro form = new FormLivro(l, false);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);

                Fill();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Implementação similar ao método anterior, mas nem abre
            //uma nova janela, só remove do armazenamento o objeto cujo 
            //código é igual ao da linha selecionada.
            if (dgvLivros.SelectedRows.Count == 1)
            {
                ILivroDAO livroDAO = new LivroDict();
                long key = long.Parse(dgvLivros.CurrentRow.Cells[0].Value.ToString());
                livroDAO.Delete(key);
                
                Fill();
            }
        }

        //Por enquanto, não vamos utilizar isso aqui. =D
        private void FormGerenciaLivros_Load(object sender, EventArgs e)
        {
            Fill();
        }

        //Preenche o datagrid com os livros já armazenados 
        //Antes de preencher, chamamos o Clear para limpar 
        //as linhas anteriores. 
        private void Fill()
        {
            ILivroDAO livroDAO = new LivroDict();
            List<Livro> livros = livroDAO.ListAll();
            dgvLivros.Rows.Clear();
            foreach (Livro l in livros)
                //Rows é a lista de linhas do datagridview. Add adiciona uma
                //nova linha a lista.
                dgvLivros.Rows.Add(l.Codigo.ToString(), l.Titulo, l.Autor);
        }
    }
}
