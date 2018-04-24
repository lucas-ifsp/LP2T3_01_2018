using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Continuo
{
    //Classe que representa um livro e seus atributos
    //O estado de objetos dessa classe serão alterados na 
    //interface gráfica
    public class Livro
    {
        private string autor, titulo;
        private long codigo;

        public Livro(string autor, string titulo, long codigo)
        {
            Autor = autor;
            Titulo = titulo;
            Codigo = codigo;
        }

        public Livro()
        {
            
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public long Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }
    }
}
