using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    //Nome da classe que representa os animais
    class Animal
    {
        //Variáveis privadas só podem ser acessadas 
        //dentro do escopo da classe. Se fossem 'public'
        //seriam acessíveis de qualquer lugar
        private string nome, apelido;
        private bool isSelvagem;
        //note que criar uma variável (objeto) do tipo
        //da classe pessoa é exatamente igual a qualquer outra
        //como String e Int32 (que também são objetos)
        private Pessoa dono; 

        //Método Comunicar, como nas funções, retorna uma 
        //string e não recebe nenhum parâmetro
        public string Comunicar()
        {
            // 'nome + "está comunicando!"' é uma string formada
            // pelo conteúdo da variável (objeto!) 'nome' e a 
            // string "está comunicando!"
            return nome + "está comunicando!";
        }

        public void Brincar()
        {
            Console.WriteLine(nome + "está bricando");
        }

        //Uma propriedade expõe os atribuitos de um classe 
        //que são interessantes de serem vistos de fora dela.
        //'get' retorna o conteúdo da variável exposta.
        //'set' fornece um ponto para que o conteúdo da variável
        // em questão seja alterada de fora da classe.
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
