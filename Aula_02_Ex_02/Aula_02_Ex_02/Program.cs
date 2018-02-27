using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("N1:");
            a = double.Parse(Console.ReadLine());

            Console.Write("N2:");
            b = double.Parse(Console.ReadLine());

            Console.Write("N3:");
            c = double.Parse(Console.ReadLine());

            double media = (a + b + c) / 3;
            Console.WriteLine("O aluno está: " + (media>=6 ? "Aprovado": (media >= 4? "IFA" : "Reprovado" )));

            Console.Read();
        }
    }
}
