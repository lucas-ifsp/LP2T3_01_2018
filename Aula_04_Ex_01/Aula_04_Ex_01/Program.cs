using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[150];
            
            //Povoa o vetor
            for(int i = 0; i < 50; i++)
            {
                figuras[i] = new Circulo(i, i, i + 1);
                figuras[i + 50] = new TrianguloRetangulo(i, i, i + 1, i + 1);
                figuras[i + 100] = new Retangulo(i, i, i + 1, i + 1); 
            }

            double somaArea = 0;
            //Chama o método Area sobrescrito pelas subclasses 
            //e acumula os valores das áreas
            foreach (Figura f in figuras)
            {
                Console.WriteLine(f);
                somaArea += f.Area();
            }

            Console.WriteLine("Soma das áreas: " + somaArea);
            Console.Read();
        }
    }
}
