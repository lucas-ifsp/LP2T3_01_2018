using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Ex_01
{
    class PetShop
    {
        private Dictionary<long, Pessoa> clientes;

        public PetShop()
        {
            clientes = new Dictionary<long, Pessoa>();
        }

        public void AddPessoa(Pessoa a)
        {
            clientes.Add(a.Cpf, a);
        }

        public void AddCachorro(long cpf, Cachorro c)
        {
            //verifica se existe um cliente com esse cpf
            if (clientes.ContainsKey(cpf))
                //adiciona o cachorro na lista de cachorros deste cliente
                clientes[cpf].AddCachorro(c);
            else
                Console.WriteLine("Cliente não encontrado!");
        }

        public void ListCachorros(bool isVacinado)
        {
            //como estou percorrendo um dicionário de clientes, sempre trabalho
            //com elementos compostos de chave e valor ('KeyValuePair').
            foreach (KeyValuePair<long, Pessoa> k in clientes)
                //Se tenho interesse no valor, então pego a propriedade 'Value'
                //do conjunto par-valor. Se quisesse a chave, usaria a propriedade 'Key'
                k.Value.ListCachorros(isVacinado);
        }

        public void RmCachorro(long cpf, string nome)
        {
            if (clientes.ContainsKey(cpf))
                //clientes[cpf] é um objeto do tipo Pessoa armazenado no end de referência
                //identificado unicamente pelo valor da chave contido em cpf.
                clientes[cpf].RmCachorro(nome);
            else
                Console.WriteLine("Cliente não encontrado!");
        }

        public void RmPessoa(long cpf)
        {
            if (clientes.ContainsKey(cpf))
            {
                clientes.Remove(cpf);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        public void ListPessoas()
        {
            foreach (KeyValuePair<long, Pessoa> k in clientes)
                Console.WriteLine(k.Value);
        }

        public void ListCachorros(long cpf)
        {
            if (clientes.ContainsKey(cpf))
            {
                Pessoa p = clientes[cpf];
                p.ListCachorros();
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        public void ListCachorros(long cpf, bool isVacinado)
        {
            if (clientes.ContainsKey(cpf))
            {
                Pessoa p = clientes[cpf];
                p.ListCachorros(isVacinado);
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }


    }
}
