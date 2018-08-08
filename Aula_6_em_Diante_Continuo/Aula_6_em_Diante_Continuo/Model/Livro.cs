using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_6_em_Diante_Continuo.Util;

namespace Aula_6_em_Diante_Continuo
{
    public class Livro : IEntity
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

        public Dictionary<string, string> Atts()
        {
            Dictionary<String, String> atts = new Dictionary<string, string>();
            atts.Add("codigo", Codigo.ToString());
            atts.Add( "autor", Autor );
            atts.Add("titulo", Titulo);
            atts.Add("disponivel", disponivel.ToString());

            return atts;
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
