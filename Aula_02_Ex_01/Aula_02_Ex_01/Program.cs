using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, preco;
            Console.Write("Largura:");
            string valor = Console.ReadLine();
            largura = double.Parse(valor);
            Console.Write("Comprimento:");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Preço:");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("O tamanho da sala é:" + (largura * comprimento));
            Console.WriteLine("O preco total é {0} reais.", largura * comprimento * preco);

            Console.Read();
        }
    }
}
