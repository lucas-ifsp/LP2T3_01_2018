using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa aluno = new Pessoa();
            aluno.Idade = 10;
            aluno.Nome = "Lucas";
            

            Animal cachorro = new Animal();
            cachorro.Nome = "Huffman";

            aluno.Pet = cachorro;
            cachorro.Dono = aluno;
            
            Console.WriteLine(aluno.Pet.Nome);
            Console.Read();

        }
    }
}
