using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    class Usuario
    {
        private int registro;
        private string senha;
        private string pergunta;

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Pergunta
        {
            get
            {
                return pergunta;
            }

            set
            {
                pergunta = value;
            }
        }

        public int Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
            }
        }

        public Usuario()
        {

        }


    }
}
