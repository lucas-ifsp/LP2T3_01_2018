using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    class Consulta
    {
        private DateTime data;
        private string horario;
        private string tipo;

        public Consulta()
        {

        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Horario
        {
            get
            {
                return horario;
            }

            set
            {
                horario = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
