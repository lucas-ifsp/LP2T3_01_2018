using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Figura
    {
        private int x, y;

        public Figura(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //O modificador 'virtual' indica que o método pode ser
        //sobrescrito por subclasses desta classe.
        public virtual void Area()
        {
            Console.WriteLine("Indefinido");
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
