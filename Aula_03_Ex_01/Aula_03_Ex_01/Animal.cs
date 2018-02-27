using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Animal
    {
        private string nome, apelido;
        private bool isSelvagem;
        private Pessoa dono;

        public string Comunicar()
        {
            return nome + "está comunicando!";
        }

        public void Brincar()
        {
            Console.WriteLine(nome + "está bricando");
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        public bool IsSelvagem
        {
            get { return isSelvagem; }
            set { isSelvagem = value; }
        }

        public Pessoa Dono
        {
            get { return dono; }
            set { dono = value; }
        }
    }
}
