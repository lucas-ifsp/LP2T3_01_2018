using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Aula_6_em_Diante_Continuo
{
    class UsuarioDAO
    {

        private Database bd;
        public UsuarioDAO()
        {
            bd = Database.GetInstance();
        }

        public void Create(Usuario a)
        {
            String sql = string.Format("INSERT INTO usuario(cpf,dtnasc,nome) VALUES('{0}','{1}','{2}')", a.Cpf, a.DataNasc.ToString("yyyy-MM-dd"), a.Nome);
            bd.ExecuteNonQuery(sql);
        }

        public void Update(Usuario a)
        {
            String sql = string.Format("UPDATE usuario SET nome='{0}', dtnasc = '{1}' WHERE cpf={2}", a.Nome, a.DataNasc.ToString("yyyy-MM-dd"), a.Cpf);
            bd.ExecuteNonQuery(sql);
        }
   
        public void Delete(string chave)
        {
            String sql = string.Format("DELETE FROM usuario WHERE cpf=" + chave);
            bd.ExecuteNonQuery(sql);
        }

        public Usuario Read(string chave)
        {
            if(chave != "")
            {
                string qry = "SELECT * FROM usuario WHERE cpf=" + chave;
                DataSet ds = bd.ExecuteQuery(qry);
                Usuario u = new Usuario();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    u.Cpf = dr["cpf"].ToString();
                    u.Nome = dr["nome"].ToString();
                    u.DataNasc = DateTime.Parse(dr["dtnasc"].ToString());
                }
                return u;
            }
            return null;
        }

        public List<Usuario> List(string name)
        {
            string qry = "SELECT * FROM usuario";
            qry += name == null || name == null? "" : " WHERE nome LIKE '%" + name +"%'";

            DataSet ds = bd.ExecuteQuery(qry);
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Usuario u = new Usuario();
                u.Cpf = dr["cpf"].ToString();
                u.Nome = dr["nome"].ToString();
                u.DataNasc = DateTime.Parse(dr["dtnasc"].ToString());
                usuarios.Add(u);
            }
            return usuarios;
        }
    }
}
