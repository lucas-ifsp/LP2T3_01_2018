using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um objeto da classe cliente
            Cliente c1 = new Cliente();
            //Altera o estado (propriedades) do objeto c1 da classe Cliente
            c1.Cpf = 1234;
            c1.Nome = "Emiliano";

            //Cria um objeto da classe cliente, mas utilizando um construtor
            //que já instancia o objeto configurado com relação ao nome e CPF.
            //Esse códico é equivalente ao acima.
            Cliente c2 = new Cliente("Willian", 4321);

            // Cria um objeto da classe Banco
            Banco b1 = new Banco();
            b1.NumBanco = 1;

            //Cia uma conta associando os dois objetos acima (Cliente c2 e Banco b1) 
            Conta ct1 = new Conta(c2,b1);
            //configura o objeto alterando suas propriedades
            ct1.Senha = 1111;
            ct1.NumConta = 24;
            ct1.NumAgencia = 0;

            // Imprime a propriedade Saldo da Conta ct1.
            Console.WriteLine("Saldo:" + ct1.Saldo);

            // Realiza um depósito (altera o saldo)
            ct1.Depositar(200,1111);
            // Imprime o novo valor da propriedade Saldo da Conta ct1.
            Console.WriteLine("Saldo:" + ct1.Saldo);

            // Lista todas as contas associadas ao banco. O resultado é vazio,
            // pois o banco está associado a conta, mas a conta ainda não foi 
            // associada ao banco.
            Console.WriteLine("Antes de adicionar conta ao banco");
            b1.ListarContas();

            // Adiciona a Conta ct1 a lista de contas do Banco b1
            b1.AddConta(ct1);

            // Lista todas as contas associadas ao banco. A conta ct1,
            // recém associada, irá ser listada agora.
            Console.WriteLine("Após de adicionar conta ao banco");
            b1.ListarContas();

            //Removo a conta do banco. Agora ct1 não está mais associada 
            //ao banco. Note que Banco b1 ainda está associado a Conta ct1.
            b1.RmConta(ct1);

            // Lista todas as contas associadas ao banco. A conta ct1,
            // recém retirada da lista de contas do Banco b1 não é mais listada.
            Console.WriteLine("Após de remover conta ao banco");
            b1.ListarContas();

            // Faz o mesmo teste de listagem, agora com o conjunto de contas
            // do Cliente C2.
            c2.AddConta(ct1);
            c2.ListarContas();

            Console.Read();
        }
    }
}
