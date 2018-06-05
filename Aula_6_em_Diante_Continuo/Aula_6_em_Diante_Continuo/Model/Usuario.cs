using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_em_Diante_Continuo
{
    public class Usuario
    {
        private string cpf;
        private string nome;
        private DateTime dataNasc;

        public Usuario(string cpf, string nome, DateTime dataNasc)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.DataNasc = dataNasc;
        }

        public Usuario()
        {

        }

        public override string ToString()
        {
            return cpf + " / " + nome + " / " + dataNasc ;
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }
    }
}
