using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreve no console e posiciona o cursor na frente
            Console.Write("Digite o seu nome:");
            //Cria uma variárivel do tipo String chamada palavraLida
            //Atribui à variável o texto lido do console 
            string palavraLida = Console.ReadLine();
            //Cria uma variárivel do tipo int chamada numeroConvertido
            //Atribui à variável o valor lido do console, convertido de String para 'int' 
            int numeroConvertido = int.Parse(palavraLida);
            //Soma 10 ao número 
            numeroConvertido = numeroConvertido + 10;
            //Escreve o valor final no console, posicionando o cursor na prox. linha
            Console.WriteLine(numeroConvertido);
            //Aguarda que o usuário digite algo, evitando que o programa feche antes disso.
            Console.Read();
        }
    }
}
