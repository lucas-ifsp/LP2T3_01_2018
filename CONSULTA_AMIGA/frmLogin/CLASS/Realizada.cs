using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    class Realizada : Consulta
    {
        private string responsavel;
        private string animal;
        private string diagnostico;
        private string receita;
        private string observacoes;
        private int crmv;

        public Realizada() : base()
        {

        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }

            set
            {
                diagnostico = value;
            }
        }

        public string Observacoes
        {
            get
            {
                return observacoes;
            }

            set
            {
                observacoes = value;
            }
        }

        public string Receita
        {
            get
            {
                return receita;
            }

            set
            {
                receita = value;
            }
        }

        public int Crmv
        {
            get
            {
                return crmv;
            }

            set
            {
                crmv = value;
            }
        }

        public string Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }

        public string Animal
        {
            get
            {
                return animal;
            }

            set
            {
                animal = value;
            }
        }
    }
}
