using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class UsuarioDAO
    {
        public Usuario Procurar(string senha)
        {
            Usuario u = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM USUARIO WHERE SENHA = '" + senha + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                u = new Usuario();

                u.Registro = dr.GetInt16("registro");
                u.Senha = dr.GetString("senha");
                u.Pergunta = dr.GetString("pergunta");
            }

            conexao.Close();

            return u;
        }

        public bool Alterar(Usuario u)
        {
            DataBase dbUsuario = DataBase.GetInstance();

            try
            {
                string qry = string.Format("UPDATE USUARIO SET SENHA='{0}', PERGUNTA='{1}' WHERE REGISTRO = '{2}'", u.Senha, u.Pergunta, u.Registro);

                if (dbUsuario.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public Usuario Listar()
        {
            Usuario u = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM USUARIO";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                u = new Usuario();

                u.Registro = dr.GetInt16("registro");
                u.Senha = dr.GetString("senha");
                u.Pergunta = dr.GetString("pergunta");
            }

            conexao.Close();

            return u;
        }
    }
}
