using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_em_Diante_Continuo
{
    public class Livro
    {
        private long codigo;
        private string autor, titulo;
        private bool disponivel;

        public Livro()
        {
            this.Disponivel = true;
        }

        public Livro(long codigo, string autor, string titulo)
        {
            this.Codigo = codigo;
            this.Autor = autor;
            this.Titulo = titulo;
            this.Disponivel = true;
        }

        public override string ToString()
        {
            return codigo + " | " + titulo + " | " + autor + " | " + disponivel;
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

        public bool Disponivel
        {
            get
            {
                return disponivel;
            }

            set
            {
                disponivel = value;
            }
        }
    }
}
