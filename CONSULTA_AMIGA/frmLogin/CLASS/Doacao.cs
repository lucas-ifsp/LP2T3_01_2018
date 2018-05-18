using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    class Doacao
    {
        private string doador;
        private DateTime data;
        private double valor;
        private string pagamento;
        private string observacoes;

        public Doacao()
        {

        }

        public string Doador
        {
            get
            {
                return doador;
            }

            set
            {
                doador = value;
            }
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

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Pagamento
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
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

    }
}
