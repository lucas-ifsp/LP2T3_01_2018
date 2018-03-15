using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    //Circulo herda Figura, logo, tem todos os métodos e atributos da superclasse
    class Circulo : Figura
    {
        private double raio;

        //A palavra 'base' faz referência ao método construtor da 
        //superclasse (Figura). Como não há construtor padrão em 
        //figura, a declaração explícita base(int x, int y) é necessária
        public Circulo(int x, int y, double raio) : base(x, y)
        {
            this.Raio = raio;
        }

        //Sobrescreve o método Area da superclasse Figura. Note que é necessário
        //utilizar o modificador 'override' para indicar a sobreposição.
        public override double Area()
        {
            return Math.PI * Math.Pow(raio,2);
        }

        //Funcionalidade de cálculo do diamentro agora implementada como
        //uma property
        public double Diametro
        {
            get{return 2 * Math.PI * raio;}
        }

        //Sobrescreve o ToString já sobrescrito pela classe Figura, adicionando
        //novas informações sobre o Circulo, mas mantendo o resultado da 
        //implementação da superclasse (Figura) por meio do método 'base'.
        public override string ToString()
        {
            return base.ToString() + "Raio: " + Raio; 
        }

        public double Raio
        {
            get
            {
                return raio;
            }

            set
            {
                raio = value;
            }
        }
    }
}
