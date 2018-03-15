using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    sealed class TrianguloRetangulo : Figura
    {
        private double baseT, altura;

        //A palavra 'base' faz referência ao método construtor da 
        //superclasse (Figura). Como não há construtor padrão em 
        //figura, a declaração explícita base(int x, int y) é necessária
        public TrianguloRetangulo(int x, int y, double baseT, double altura) : base(x, y)
        {
            BaseT = baseT;
            Altura = altura;
        }

        //Sobrescreve o método Area da superclasse Figura. Note que é necessário
        //utilizar o modificador 'override' para indicar a sobreposição.
        public override double Area()
        {
            return  (baseT * altura)/2;
        }

        //Sobrescreve o ToString já sobrescrito pela classe Figura, adicionando
        //novas informações sobre o TrianguloRetangulo, mas mantendo o resultado da 
        //implementação da superclasse (Figura) por meio do método 'base'.
        public override string ToString()
        {
            return base.ToString() + "Base: " + BaseT + " Altura: " + Altura;
        }

        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public double BaseT
        {
            get
            {
                return baseT;
            }

            set
            {
                baseT = value;
            }
        }
    }
}
