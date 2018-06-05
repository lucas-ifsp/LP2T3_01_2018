using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo
{
    class LivroDAO 
    {
        private Database bd;

        public LivroDAO()
        {
            bd = Database.GetInstance();
        }

       public void Save(Livro l)
        {
            String sql = string.Format("INSERT INTO livro(autor,titulo,disponivel) VALUES(@AUTOR,@TITULO,@DISPONIVEL)");
            SQLiteCommand com = new SQLiteCommand(sql);
            
            com.Parameters.Add(new SQLiteParameter("@AUTOR", l.Autor));
            com.Parameters.Add(new SQLiteParameter("@TITULO", l.Titulo));
            com.Parameters.Add(new SQLiteParameter("@DISPONIVEL", l.Disponivel ? 1 : 0));
            
            bd.ExecuteNonQuery(com);
        }

        /*public void Save(Livro l)
        {
            String sql = string.Format("INSERT INTO livro(autor,disponivel,titulo) VALUES('{0}','{1}','{2}')", l.Autor, l.Disponivel ? 1 : 0, l.Titulo);
            bd.ExecuteNonQuery(sql);
        }*/

        public void Update(Livro l)
        {
            String sql = string.Format("UPDATE livro SET autor='{0}', titulo = '{1}', disponivel = '{2}' WHERE codigo={3}", l.Autor, l.Titulo, l.Disponivel ? 1 : 0,  l.Codigo);
            bd.ExecuteNonQuery(sql);
        }

        public void Delete(int chave)
        {
            String sql = string.Format("DELETE FROM livro WHERE codigo=" + chave);
            bd.ExecuteNonQuery(sql);
        }

        public Livro Read(int chave)
        {
            string qry = "SELECT * FROM livro WHERE codigo=" + chave;
            DataSet ds = bd.ExecuteQuery(qry);
            Livro l = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                l = new Livro();
                l.Codigo = int.Parse(dr["codigo"].ToString());
                l.Autor = dr["autor"].ToString();
                l.Titulo = dr["titulo"].ToString();
                l.Disponivel = int.Parse(dr["disponivel"].ToString()) == 0 ? false : true;
            }
            return l;
        }

        public List<Livro> List(string name)
        {
            string qry = "SELECT * FROM livro"; 
            qry += name == null  ? "" : " WHERE titulo LIKE '%" + name + "%' OR autor LIKE '%" + name + "%'";

            DataSet ds = bd.ExecuteQuery(qry);
            List<Livro> livros = new List<Livro>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Livro l = new Livro();
                l.Codigo = int.Parse(dr["codigo"].ToString());
                l.Autor = dr["autor"].ToString();
                l.Titulo = dr["titulo"].ToString();
                l.Disponivel = int.Parse(dr["disponivel"].ToString()) == 0 ? false : true;
                livros.Add(l);
            }
            return livros;
        }
    }
}
