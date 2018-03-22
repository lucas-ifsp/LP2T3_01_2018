using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex_01
{
    class Cachorro
    {
        private String nome, raca;
        private bool isVacinado;

        public Cachorro(string nome, string raça, bool isVacinado)
        {
            this.Nome = nome;
            this.Raca = raça;
            this.IsVacinado = isVacinado;
        }

        public Cachorro()
        {

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

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public bool IsVacinado
        {
            get
            {
                return isVacinado;
            }

            set
            {
                isVacinado = value;
            }
        }

        //Sobrescreve o método ToString de 'Object' para imprimir o estado do objeto 
        public override string ToString()
        {
            return "Nome: " + nome + "\tRaça: " + raca + "\tVacinado: " + (isVacinado? "Sim": "Não");
        }
    }
}
