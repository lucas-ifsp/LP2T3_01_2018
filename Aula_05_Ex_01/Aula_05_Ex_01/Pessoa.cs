using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex_01
{
    class Pessoa
    {
        private String nome;
        private long cpf;
        private List<Cachorro> cachorros = new List<Cachorro>();

        public Pessoa(string nome, long cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public Pessoa()
        {

        }

        public void AddCachorro(Cachorro c)
        {
            cachorros.Add(c);
        }

        public void RmCachorro(Cachorro c)
        {
            cachorros.Remove(c);
        }

        public void RmCachorro(string nome)
        {
            Cachorro temp = null;
            //busca na lista de cachorros se há um cachorro
            //com o nome passado com parâmetro
            foreach(Cachorro c in cachorros)
                //se encontrar, guarda a referência para o cachorro
                //no objeto 'temp', já que não posso alterar a lista
                //enquanto estou percorrendo os elementos.
                if(c.Nome == nome)
                {
                    temp = c;
                    //se encontrei, então posso parar de procurar.
                    break;
                }
            //removo o cachorro da lista utilizando a referência armazenada
            //em 'temp'
            if (temp != null)
            {
                RmCachorro(temp);
                Console.WriteLine("Cachorro removido com sucesso");
            }
            //caso a lista toda seja percorrida e 'temp' ainda esteja 'null'
            //então não há um cachorro com este nome a ser removido
            else
                Console.WriteLine("Cachorro não encontrado");           
        }

        public void ListCachorros()
        {
            foreach (Cachorro c in cachorros)
                Console.WriteLine(c);
        }

        public void ListCachorros(bool isVacinado)
        {
            foreach (Cachorro c in cachorros)
                if (c.IsVacinado == isVacinado)
                    Console.WriteLine(c);    
        }

        //Sobrescreve o método ToString de 'Object' para imprimir o estado do objeto 
        //Além disso, chama o método ToString de todos os objetos cachorro na lista
        //de cachorros.
        public override string ToString()
        {
            string valor = "Nome: " + nome + "\tCPF: " + Cpf + "\nCachorros:";
            foreach (Cachorro c in cachorros)
                valor += "\n" + c.ToString() ;
            return valor;
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

        public long Cpf
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
    }
}
