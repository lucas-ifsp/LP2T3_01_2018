using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    class Produto
    {
        private int codigo;
        private string nome;
        private string marca;
        private string tipo;
        private double precoCusto;
        private double precoVenda;
        private string descricao;
        private int quantidade;
        private string dosagem;


        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
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

        public double PrecoCusto
        {
            get
            {
                return precoCusto;
            }

            set
            {
                precoCusto = value;
            }
        }

        public double PrecoVenda
        {
            get
            {
                return precoVenda;
            }

            set
            {
                precoVenda = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public string Dosagem
        {
            get
            {
                return dosagem;
            }

            set
            {
                dosagem = value;
            }
        }

        public Produto()
        {

        }



    }
}
