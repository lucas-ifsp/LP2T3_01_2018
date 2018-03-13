using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Retangulo : Figura
    {
        private double largura, comprimento;

        //A palavra 'base' faz referência ao método construtor da 
        //superclasse (Figura). Como não há construtor padrão em 
        //figura, a declaração explícita base(int x, int y) é necessária
        public Retangulo(int x, int y, double largura, double comprimento) : base(x, y)
        {
            Comprimento = comprimento;
            Largura = largura;
        }

        //Sobrescreve o método Area da superclasse Figura. Note que é necessário
        //utilizar o modificador 'override' para indicar a sobreposição.
        public override void Area()
        {
            Console.WriteLine("Área retagulo: "+ largura * comprimento);
        }

        public void IsQuadrado()
        {
            Console.WriteLine(largura == comprimento ? "É um quadrado" : "Não é um quadrado");
        } 

        public double Comprimento
        {
            get
            {
                return comprimento;
            }

            set
            {
                comprimento = value;
            }
        }

        public double Largura
        {
            get
            {
                return largura;
            }

            set
            {
                largura = value;
            }
        }
    }
}
