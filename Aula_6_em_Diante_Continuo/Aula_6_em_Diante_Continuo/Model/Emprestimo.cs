using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_em_Diante_Continuo.Model
{
    public class Emprestimo
    {
        private DateTime entrega, devolucao;
        private Livro livro;
        private Usuario usuario;
        private bool finalizado;
        private long codigo;

        public Emprestimo()
        {
            Finalizado = false;
        }
        public override string ToString()
        {
            return codigo + " | " + entrega.ToString("yyyy-MM-dd") + " | " + devolucao.ToString("yyyy-MM-dd") + " | " + livro.Codigo + " | " + usuario.Cpf + " | " + finalizado;
        }
        public DateTime Entrega
        {
            get
            {
                return entrega;
            }

            set
            {
                entrega = value;
            }
        }

        public DateTime Devolucao
        {
            get
            {
                return devolucao;
            }

            set
            {
                devolucao = value;
            }
        }

        public Livro Livro
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public bool Finalizado
        {
            get
            {
                return finalizado;
            }

            set
            {
                finalizado = value;
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
    }
}
