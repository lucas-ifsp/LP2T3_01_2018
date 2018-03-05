using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    //Classe que representa as pessoas no escopo do nosso programa
    class Pessoa
    {
        private string  nome, profissao;
        private int idade;
        private long identidade;
        //Cada pessoa pode ter um animal, que será referenciado
        //pela variável (objeto) 'pet'
        private Animal pet;

        public string Falar()
        {
            return nome + " está falando olá!";
        }

        public void Trabalhar (int horas)
        {
            Console.WriteLine(nome + " está trabalhando a "+ horas + " horas.");
        }

        public void Comer()
        {
            Console.WriteLine(nome + "está comendo");
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

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            //Note que 'set' permite que o valor a ser atribuído
            //seja controlado dentro da classe. Isso evita que o
            //objeto da classe entre em um estado inconsistente.
            //Ninguém tem menos do que '0' anos de idade!
            set
            {
                idade = value >= 0 ? value: 0;
            }
        }

        public long Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = value;
            }
        }

        internal Animal Pet
        {
            get
            {
                return pet;
            }

            set
            {
                pet = value;
            }
        }
    }
}
