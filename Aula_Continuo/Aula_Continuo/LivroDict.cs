using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Continuo
{
    //Classe que emula um banco de dados utilizando um dicionário
    //Possui todos os métodos do CRUD, pois implementa a interface ILivroDAO
    class LivroDict : ILivroDAO
    {
        //O dicionário livros armazena os livros, precisa ser estático para ser
        //um objeto único em todas as instâncias de LivroDict. Não faz sentido
        //salvar em um objeto LivroDict e depois não conseguir acessar de outro.
        private static Dictionary<long, Livro> livros = new Dictionary<long, Livro>();
        //Armazena o valor sequencial do número de entradas para permitir gerar
        //um código auto-incremental para cada livro.
        private static long numEntries;

        public void Delete(long id)
        {
            //Remove do dicionário o valor cuja chave é igual a 'id'.
            //'id' representa a chave primária do nosso armazenamento, ou seja,
            //o código de um dado Livro
            livros.Remove(id);
        }

        //Lê no dicionário o valor cuja chave é igual a 'id'.
        public Livro Read(long id)
        {
            return livros[id];
        }

        //Salva o objeto 'l' da classe Livro, mas antes atribui um
        //código auto-incremental único para ele
        public void Save(Livro l)
        {
            //Cria um código auto-incremental
            l.Codigo = ++numEntries;
            livros.Add(l.Codigo, l);
            
        }

        //Atualiza no dicionário o valor cuja chave é igual a 'id' 
        //utilizando a versão do livro alterada na interface gráfica
        public void Update(Livro l)
        {
            livros[l.Codigo] = l;
        }

        //Retorna todos os livros do dicionário
        public List<Livro> ListAll()
        {
            //Values é a coleção de valores do dicionário
            //ToList converte a coleção e uma lista
            return livros.Values.ToList();
        }
    }
}
