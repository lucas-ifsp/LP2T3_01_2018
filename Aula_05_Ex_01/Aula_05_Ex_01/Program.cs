using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = -1;
            PetShop ps = new PetShop();
            long cpf = 0;
            string nomeCachorro = "";
            string input = null;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Add Pessoa");
                Console.WriteLine("2 - Add Cachorro");
                Console.WriteLine("3 - Lista Clientes");
                Console.WriteLine("4 - Lista Cachorros");
                Console.WriteLine("5 - Remover Pessoa");
                Console.WriteLine("6 - Remover Cachorro");
                Console.WriteLine("7 - Lista Vacinados");
                Console.WriteLine("8 - Lista Vacinados (CPF)");
                Console.WriteLine("0 - Sair");
                Console.Write(">>");
                opt = int.Parse(Console.ReadLine());

                
                switch (opt)
                {
                    //Add Pessoa
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());
                        
                        //Invoco o método que adiciona pessoas ao dicionário de clientes.
                        //Note que não preciso criar um 'objeto' do tipo Pessoa aqui, então
                        //posso criar uma 'referência' anônima diretamente no método.
                        ps.AddPessoa(new Pessoa(nome, cpf));
                        break;

                    //Add Cachorro
                    case 2:
                        //Para adicionar um cachorro, primeiro preciso saber quem é 
                        //o dono do animal. O cachorro será adicionado na lista de 
                        //cachorros da pessoa identificada pelo CPF.
                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        nomeCachorro = Console.ReadLine();

                        Console.Write("Raça: ");
                        string raca = Console.ReadLine();

                        //Essa lógica transforma uma resposta 'S' ou 'N' para a variável booleana 
                        //vacinado, que será armazenada na propriedade isVacinado do objeto da classe Cachorro.
                        bool vacinado = false;
                        do
                        {
                            Console.Clear();
                            Console.Write("Vacinado [S/N]: ");
                            input = Console.ReadLine();

                            if (input == "S")
                                vacinado = true;
                            else if (input == "N")
                                vacinado = false;
                            else
                                input = null;                           
                        } while (input == null);

                        //O método AddCachorro encontra o objeto Pessoa no dicionário de
                        //clientes e, na sequência, adiciona o cachorro na lista de cachorros
                        //desse cliente.
                        ps.AddCachorro(cpf, new Cachorro(nomeCachorro, raca, vacinado));
                        break;

                    //Lista Clientes
                    case 3:
                        ps.ListPessoas();
                        Console.ReadKey();
                        break;

                    //Lista Cachorros
                    case 4:
                        //Solicita o CPF de um dado cliente 
                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());
                        //Solicita a impressão de cachorros do dado cliente.
                        //Note que essa lista está localizada na classe Pessoa,
                        //que é a resposável por gerenciar a lista de cachorros.
                        ps.ListCachorros(cpf);
                        Console.ReadKey();
                        break;

                    //Remover Pessoa
                    case 5:
                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());
                        ps.RmPessoa(cpf);
                        Console.ReadKey();
                        break;

                    //Remover Cachorro
                    case 6:
                        //Solicita o CPF de um dado cliente
                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());
                        //Solicita o nome do cachorro do cliente a ser excluído
                        Console.Write("Nome Pet: ");
                        nomeCachorro = Console.ReadLine();
                        //Solicita a remoção do cachorro do cliente. Note que essa 
                        //lista da qual o cachorro será removido está localizada na 
                        //classe Pessoa, resposável por gerenciar seus cachorros.
                        ps.RmCachorro(cpf, nomeCachorro);
                        break;

                    //Lista Vacinados
                    case 7:
                        //Essa lógica transforma uma resposta 'S' ou 'N' para a variável booleana.
                        do
                        {
                            Console.Clear();
                            Console.Write("Vacinado [S/N]: ");
                            input = Console.ReadLine();
                            if (input == "S")
                                //Invoca, de cada Pessoa na lista de clientes, o método ListCachorros
                                ps.ListCachorros(true);
                            else if (input == "N")
                                //Invoca, de cada Pessoa na lista de clientes, o método ListCachorros
                                ps.ListCachorros(false);
                            else
                                input = null;
                        } while (input == null);

                        Console.ReadKey();
                        break;

                    //Lista Vacinados (CPF)
                    case 8:
                        //Essa lógica transforma uma resposta 'S' ou 'N' para a variável booleana.
                        Console.Write("CPF: ");
                        cpf = long.Parse(Console.ReadLine());

                        do
                        {
                            Console.Clear();
                            Console.Write("Vacinado [S/N]: ");
                            input = Console.ReadLine();
                            if (input == "S")
                                //Invoca, de cada Pessoa na lista de clientes, o método ListCachorros
                                ps.ListCachorros(cpf,true);
                            else if (input == "N")
                                //Invoca, de cada Pessoa na lista de clientes, o método ListCachorros
                                ps.ListCachorros(cpf, false);
                            else
                                input = null;
                        } while (input == null);
                        Console.ReadKey();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }

            } while (opt != 0);
        }
    }
}
