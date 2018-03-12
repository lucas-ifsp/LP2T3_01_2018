using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Conta
    {
        private long numConta, numAgencia, senha;
        private int tempoConta;
        private double limite, saldo;
        private Cliente cliente;
        private Banco banco;

        //No caso da Conta, não há construtor padrão, mas um com dois
        //argumentos: o cliente abrindo a conta e o banco no qual a 
        //conta foi aberta. Não faz sentido uma conta surgir sem que 
        //ela tenha um dono e um banco desde o início.
        public Conta(Cliente c, Banco b)
        {
            Cliente = c;
            Banco = b;
            Saldo = 0;
            Limite = 200;
            tempoConta = 0;
        }

        //Altera o valor da variável privada 'saldo', sem dar acesso direto a ela 
        //de fora da classe.
        public Boolean Sacar(double valor, long senha)
        {
            if(senha == Senha)
            {
                if(valor <= Saldo + Limite)
                {
                    Saldo -= valor;
                    Console.WriteLine("Saque realizado, novo saldo: " + Saldo);
                    return true;
                }
                else
                {
                    Console.WriteLine("Erro: Não há saldo suficiente.");
                    return false;
                }
            }else
            {
                Console.WriteLine("Erro: Senha inválida.");
                return false;
            }
        }

        //Altera o valor da variável privada 'saldo', sem dar acesso direto a ela 
        //de fora da classe.
        public Boolean Depositar(double valor, long senha)
        {
            if (senha == Senha)
            {
                 Saldo += valor;
                 Console.WriteLine("Depósito realizado, novo saldo: " + Saldo);
                 return true;
            }
            else
            {
                Console.WriteLine("Erro: Senha inválida.");
                return false;
            }
        }

        //Recebe o pedido de alteração do limite, verifica se a senha 
        // é válida e encaminha o pedido ao método AprovarLimite da classe Banco, 
        // adicionando o parâmetro 'TempoConta', que é usado no cálculo.
        public double SolicitarLimite(double valor, long senha)
        {
            if(senha == Senha)
                return banco.AprovarLimite(valor,TempoConta);
            Console.WriteLine("Erro: Senha inválida.");
            return 0;
        }


        public long NumConta
        {
            get
            {
                return numConta;
            }

            set
            {
                numConta = value;
            }
        }

        public long NumAgencia
        {
            get
            {
                return numAgencia;
            }

            set
            {
                numAgencia = value;
            }
        }

        public long Senha
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

        public int TempoConta
        {
            get
            {
                return tempoConta;
            }

            set
            {
                tempoConta = value;
            }
        }

        public double Limite
        {
            get
            {
                return limite;
            }

            set
            {
                limite = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        internal Banco Banco
        {
            get
            {
                return banco;
            }

            set
            {
                banco = value;
            }
        }
    }
}
