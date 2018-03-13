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
            //Instancia as figuras
            Circulo c = new Circulo(10, 30, 10);
            TrianguloRetangulo tc = new TrianguloRetangulo(10, 10, 20, 30);
            Retangulo r = new Retangulo(0, 0, 10, 15);
            Retangulo q = new Retangulo(10,20, 5, 5);
            Figura f = new Figura(1,1);

            //Chama o método Area sobrescrito pelas subclasses 
            c.Area();
            tc.Area();
            r.Area();
            //Chama o método Area da superclasse
            f.Area();

            //Testa o método isQuadrado para os dois casos
            r.IsQuadrado();
            q.IsQuadrado();

            //Imprime o diâmeto do Circulo 'c'.
            //Note que esse é apenas um exemplo, isso poderia
            //ser implementado coma property, muito mais elegante.
            c.Diametro();

            Console.Read();
        }
    }
}
