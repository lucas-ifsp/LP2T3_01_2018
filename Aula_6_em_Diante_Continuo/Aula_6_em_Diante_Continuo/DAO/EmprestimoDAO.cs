using Aula_6_em_Diante_Continuo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo.DAO
{
    class EmprestimoDAO
    {
        private Database bd;

        public EmprestimoDAO()
        {
            bd = Database.GetInstance();
        }

        public void Save(Emprestimo e)
        {
            String sql = string.Format("INSERT INTO emprestimo(dataEmprestimo,dataDevolucao,usuario,livro,finalizado) VALUES('{0}','{1}','{2}','{3}','{4}')", e.Entrega.ToString("yyyy-MM-dd"), e.Devolucao.ToString("yyyy-MM-dd"), e.Usuario.Cpf, e.Livro.Codigo, e.Finalizado ? 1 : 0);
            bd.ExecuteQuery(sql);
        }

        public void Update(Emprestimo e)
        {
            String sql = string.Format("UPDATE emprestimo SET finalizado='{0}' WHERE codigo={1}", e.Finalizado ? 1 : 0, e.Codigo);
            bd.ExecuteQuery(sql);
            Database data = Database.GetInstance();

        }

        public Emprestimo Read(long chave)
        {
            string qry = "SELECT * FROM emprestimo WHERE codigo=" + chave;
            DataSet ds = bd.ExecuteQuery(qry);
            Emprestimo e = null;

            DataRow dr = ds.Tables[0].Rows[0];
            if (dr != null)
            {
                e = new Emprestimo();
                e.Codigo = long.Parse(dr["codigo"].ToString());
                e.Finalizado = int.Parse(dr["finalizado"].ToString()) == 0 ? false : true;
                e.Entrega = DateTime.Parse(dr["dataEmprestimo"].ToString());
                e.Devolucao = DateTime.Parse(dr["dataDevolucao"].ToString());

                LivroDAO lDAO = new LivroDAO();
                e.Livro = lDAO.Read(int.Parse(dr["livro"].ToString()));

                UsuarioDAO uDAO = new UsuarioDAO();
                e.Usuario = uDAO.Read(dr["usuario"].ToString());
            }
            return e;
        }

        public List<Emprestimo> List()
        {
            return List(null);
        }

        public List<Emprestimo> List(string user)
        {
            string qry = "SELECT * FROM emprestimo";
            qry += user == null ? "" : " WHERE usuario='" + user + "'";

            DataSet ds = bd.ExecuteQuery(qry);
            List<Emprestimo> emprestimo = new List<Emprestimo>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Emprestimo e = new Emprestimo();
                e.Codigo = long.Parse(dr["codigo"].ToString());
                e.Finalizado = int.Parse(dr["finalizado"].ToString()) == 0 ? false : true;
                e.Entrega = DateTime.Parse(dr["dataEmprestimo"].ToString());
                e.Devolucao = DateTime.Parse(dr["dataDevolucao"].ToString());

                Console.WriteLine("=> " + dr["codigo"].ToString());
                LivroDAO lDAO = new LivroDAO();
                e.Livro = lDAO.Read(int.Parse(dr["livro"].ToString()));

                UsuarioDAO uDAO = new UsuarioDAO();
                e.Usuario = uDAO.Read(dr["usuario"].ToString());

                emprestimo.Add(e);
            }
            return emprestimo;
        }
    }
}
