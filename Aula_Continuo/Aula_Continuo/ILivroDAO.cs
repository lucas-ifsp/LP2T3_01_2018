using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Continuo
{
    //Interface os métodos CRUD que todas as classes que 
    //'armazenam' livros precisam ter. 
    interface ILivroDAO
    {
        void Save(Livro l);
        void Delete(long id);
        void Update(Livro l);
        Livro Read(long id);
        List<Livro> ListAll();

    }
}
