using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crio um objeto da classe Pessoa chamado de aluno
            //A palavra chave 'new' cria um espaço para o objeto na 
            //memória, mas ele ainda não teve seu estado alterado.
            Pessoa aluno = new Pessoa();
            //Altera a propriedade Idade do objeto aluno para '10'
            aluno.Idade = 10;
            //Altera a propriedade 'Nome' do aluno para "Lucas"
            //Note que 'Nome' é um atributo do objeto 'aluno' e não o 
            //nome do objeto em si. O nome do objeto é 'aluno'.
            aluno.Nome = "Lucas";
            
            //Crio um objeto da classe animal. O nome do objeto (ou variável)
            //é 'cachorro'.
            Animal cachorro = new Animal();
            //Altero a propriedade Nome do objeto cachorro para "Huffman"
            cachorro.Nome = "Huffman";

            //Nesse ponto temos dois objetos, um da classe Pessoa (aluno)
            //e outro da classe Animal (huffman). Embora o Pessoa tenha uma
            //variável Animal dentro dela (chamada de 'pet'), não indicamos
            //ainda qual é este animal. Por isso, precisamos alterar a propriedade
            //'Pet' de aluno, atribuindo a ela a referência do objeto cachorro.
            aluno.Pet = cachorro;
            //Agora o conteúdo da variável Pet aponta para o lugar na memória 
            //onde está o conteúdo do objeto "cachorro".

            //Agora faço o mesmo para a propriedade Dono do objeto cachorro.
            //Se não atribuir o valor como a seguir, o valor para "Dono" seria 
            //'null', pois não apontaria para lugar nenhum.
            cachorro.Dono = aluno;
            
            // aluno.Pet imprime a referência para o objeto Pet (cachorro, no caso),
            // mas não queremos imprimir a referência do Pet e sim seu nome.
            // Logo, chamamos a propriedade "Nome" do objeto "aluno.Pet" (ou seja, a 
            // propriedade nome do objeto "cachorro").
            Console.WriteLine(aluno.Pet.Nome);
            Console.Read();

        }
    }
}
