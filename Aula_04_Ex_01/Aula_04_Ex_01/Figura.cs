using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    abstract class Figura
    {
        private int x, y;

        public Figura(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //O modificador 'abstract' indica que o método 
        // deve seer sobrescrito sobrescrito pelas subclasses desta classe.
        public abstract double Area();

        //Sobrescrevo o método ToString de 'Object' para imprimir as 
        //coordenadas da Figura ao invés do <<namespace.nomedaclasse>>.
        //ps: O método GetType.Name retorna o nome da classe referente a instância.
        public override string ToString()
        {
            return "Tipo da Figura: "  + this.GetType().Name + "\t Posição: ("+X+","+Y+") \t";
        }
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
