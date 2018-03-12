using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{

    //COMENTÁRIOS SIMILARES NA CLASSE BANCO. FAVOR VERIFICAR NA OUTRA CLASSE.
    class Cliente
    {
        private String nome;
        private long cpf;
        private Conta[] contas;
        private const int MAX_CONTAS = 3;
        private int numContas;

        public Cliente()
        {
            contas = new Conta[MAX_CONTAS];
            numContas = 0;
        }

        public Cliente(string nome, long cpf)
        {
            contas = new Conta[MAX_CONTAS];
            numContas = 0;
            Nome = nome;
            Cpf = cpf;
        }

        public void ListarContas()
        {
            for (int i = 0; i < numContas; i++)
                Console.WriteLine("Banco: " + contas[i].Banco.NumBanco + " CC: " + contas[i].NumConta + " Agencia: " + contas[i].NumAgencia);
        }

        public void AddConta(Conta c)
        {
            if (numContas < MAX_CONTAS)
            {
                contas[numContas] = c;
                numContas++;
            }
            else
            {
                Console.WriteLine("Não há espaço para uma nova conta.");
            }   
        }

        public void RmConta(Conta c)
        {
            int idx = -1;
            for (int i = 0; i < numContas; ++i)
            {
                if (contas[i] == c)
                {
                    idx = i;
                    break;
                }
            }
            for (int i = idx; i < numContas - 1; i++)
                contas[i] = contas[i + 1];
            contas[numContas - 1] = null;
            numContas--;

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

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        internal Conta[] Contas
        {
            get
            {
                return contas;
            }

            set
            {
                contas = value;
            }
        }
    }
}
