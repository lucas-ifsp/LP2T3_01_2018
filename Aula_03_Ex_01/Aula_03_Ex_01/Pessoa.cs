using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Pessoa
    {
        private string  nome, profissao;
        private int idade;
        private long identidade;
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
