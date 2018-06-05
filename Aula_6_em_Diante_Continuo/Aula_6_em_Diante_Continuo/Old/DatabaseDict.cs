using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_em_Diante_Continuo
{
    class DatabaseDict 
    {
        private static Dictionary<long, Livro> livros = new Dictionary<long, Livro>();

        public void Delete(long keyLivro)
        {
            livros.Remove(keyLivro);
        }

        public List<Livro> ListAll()
        {
            return ListByName("");
        }

        public List<Livro> ListByName(string name)
        {
            List<Livro> ls = new List<Livro>();
            foreach (KeyValuePair<long, Livro> k in livros)
                if(k.Value.Titulo.Contains(name) || k.Value.Autor.Contains(name))
                    ls.Add(k.Value);
            return ls;
        }

        public Livro Read(long keyLivro)
        {
            return livros[keyLivro];
        }

        public void Save(Livro l)
        {
            l.Codigo = livros.Count;
            livros.Add(l.Codigo, l);
        }

        public void Update(Livro l)
        {
            livros[l.Codigo] = l;
        }
    }
}
