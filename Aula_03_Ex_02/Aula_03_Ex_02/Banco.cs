using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Banco
    {
        // Objetos da classe banco;
        private int numBanco;
        // Coleção (array) de contas pertencentes ao banco
        private Conta[] contas;
        // Define o número máximo de contas que o banco pode ter.
        private const int MAX_CONTAS = 3;
        // Controla quantas contas o banco tem atualmente
        private int numContas;

        public Banco()
        {
            // Inicializa o array de contas com o número máximo de contas possível
            contas = new Conta[MAX_CONTAS];
            // Define que não há contas no banco no momento, já que o objeto banco 
            // acabou de ser criado.
            numContas = 0;
        }

        public void ListarContas()
        {
            // Percorre o array de contas imprimindo as propriedades NumConta e NumAgencia de 
            // cada conta dentro do array.
            for (int i = 0; i < numContas; i++)
                Console.WriteLine("CC: " + contas[i].NumConta + " Agencia: " +contas[i].NumAgencia);
        }

        public void ListarContas(int numAgencia)
        {
            // Faz o mesmo que o método anterior, somente filtra no IF para imprimir somente
            // contas da agência numAgencia, passada como parâmetro.
            for (int i = 0; i < numContas; i++)
                if(contas[i].NumAgencia == numAgencia)
                    Console.WriteLine("CC: " + contas[i].NumConta);
        }

        public double AprovarLimite(double valor, int tempConta)
        {
            // Dá o limite pedido pelo cliente ou o máximo permitido
            // dentro das políticas do banco (definidas no enunciado)
            return Math.Min(valor, 200 + (300*tempConta));
        }

        // adiciona uma conta no array de contas
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

        // remove uma conta no array de contas
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
            if (idx == -1)
              return;

            for (int i = idx; i < numContas - 1; i++)
                contas[i] = contas[i + 1];
            contas[numContas - 1] = null;
            numContas--;
        }


        public int NumBanco
        {
            get
            {
                return numBanco;
            }

            set
            {
                numBanco = value;
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
