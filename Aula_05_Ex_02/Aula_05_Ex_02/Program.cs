using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //lê uma frase do console
            string sentence = Console.ReadLine();
            //lê uma posição para buscar na frase, convertendo de 
            //string para inteiro.
            int position = int.Parse(Console.ReadLine());

            //cria um vetor de strings para receber a separação
            //da frase em substrings divididas nos pontos onde
            //há o caracter ' ' 
            string[] splitted = sentence.Split(' ');

            try
            {
                //Escrevo a palavra invertida
                //new String() cria uma string com o conteúdo passado no construtor
                //splited[position-1] acessa a i-ésima palavra da frase (position - 1, pois o vetor começa em 0) 
                //ToCharArray() é um método que transforma uma string em um vetor de char
                //Reverse recebe um vetor e devolve uma enumeração (IEnumerable) ordenada ao contrário
                //ToArray() transforma a enumeração (objeto do tipo IEnumerable) em um vetor novamente.
                //Em resumo, pegamos a posição do vetor (string), transformamos essa string
                //em vetor de caracteres, invertemos o vetor (mas o resultado é uma enumeração), convertemos
                //a enumeração de novo em vetor e usamos isso como parametro do construtor new String(string s). 
                //Ufaa... =)
                Console.WriteLine(new String(splitted[position - 1].ToCharArray().Reverse().ToArray()));
            }
            catch(IndexOutOfRangeException e)
            {
                //Se acessar uma posição não existir no vetor, trato esse tipo de exceção.
                //Imprimo a mensagem contida em 'e'
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Independentemente do resultado da execução do try ou catch, 
                //o finally sempre ocorre, garantindo que o console não irá
                //fechar antes do usuário pressionar uma tecla.
                Console.Read();
            }
        }
    }
}
