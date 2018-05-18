using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class RealizadaDAO
    {
        public bool Criar(Pessoa p, Animal a, Realizada r)
        {
            DataBase dbRealizada = DataBase.GetInstance();

            try
            {
                string qry = string.Format("INSERT INTO CONSULTA VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", p.Cpf, a.Nome, r.Data.ToString("yyyy-MM-dd"), r.Horario, r.Tipo, r.Diagnostico, r.Receita, r.Observacoes, r.Crmv);

                if (dbRealizada.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch(System.NullReferenceException)
            {
                return false;
            }
         }

        public Realizada Procurar(string cpf, string animal, DateTime data)
        {
            Realizada r = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM CONSULTA WHERE CPF_RESP = '" + cpf + "' AND NOME_ANIMAL = '" + animal + "'" + " AND DATA = '" + data.ToString("yyyy-MM-dd") + "'");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                r = new Realizada();

                r.Data = dr.GetDateTime("data");
                r.Horario = dr.GetString("horario");
                r.Tipo = dr.GetString("tipo");
                r.Responsavel = dr.GetString("cpf_resp");
                r.Animal = dr.GetString("nome_animal");
                r.Diagnostico = dr.GetString("diagnostico");
                r.Receita = dr.GetString("receita");
                r.Observacoes = dr.GetString("observacoes");
                r.Crmv = dr.GetInt32("crmv");
            }

            conexao.Close();

            return r;
        }

        public bool Alterar(Pessoa p, Animal a, Realizada r)
        {
            DataBase dbRealizada = DataBase.GetInstance();

            try
            {
                string qry = string.Format("UPDATE CONSULTA SET cpf_resp='{0}', nome_animal='{1}', data='{2}', horario='{3}', tipo='{4}', diagnostico='{5}', receita='{6}', observacoes='{7}', crmv='{8}' WHERE cpf_resp = '{9}' AND nome_animal = '{10}' and data= '{11}'", p.Cpf, a.Nome, r.Data.ToString("yyyy-MM-dd"), r.Horario, r.Tipo, r.Diagnostico, r.Receita, r.Observacoes, r.Crmv, p.Cpf, a.Nome, r.Data.ToString("yyyy-MM-dd"));

                if (dbRealizada.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch(System.NullReferenceException)
            {
                return false;
            }
        }

        public void Excluir(string cpf, string animal, DateTime data)
        {
            DataBase dbRealizada = DataBase.GetInstance();

            string qry = string.Format("DELETE FROM CONSULTA WHERE CPF_RESP = '" + cpf + "' AND NOME_ANIMAL = '" + animal + "'" + " AND DATA = '" + data.ToString("yyyy-MM-dd") + "'");

            dbRealizada.ExecuteSQL(qry);
        }

        public List<Realizada> ListarConsultas()
        {
            Realizada r = null;

            List<Realizada> consultas = new List<Realizada>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM CONSULTA");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                r = new Realizada();

                r.Responsavel = dr.GetString("cpf_resp");
                r.Animal = dr.GetString("nome_animal");
                r.Data = dr.GetDateTime("data");
                r.Horario = dr.GetString("horario");
                r.Tipo = dr.GetString("tipo");
                r.Diagnostico = dr.GetString("diagnostico");
                r.Receita = dr.GetString("receita");
                r.Observacoes = dr.GetString("observacoes");
                r.Crmv = dr.GetInt32("crmv");

                consultas.Add(r);
            }

            conexao.Close();

            return consultas;
        }

        public List<Realizada> ListarConsultasResponsavel(string cpf)
        {
            Realizada r = null;

            List<Realizada> consultas = new List<Realizada>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM CONSULTA WHERE CPF_RESP LIKE '%{0}%'", cpf);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                r = new Realizada();

                r.Responsavel = dr.GetString("cpf_resp");
                r.Animal = dr.GetString("nome_animal");
                r.Data = dr.GetDateTime("data");
                r.Horario = dr.GetString("horario");
                r.Tipo = dr.GetString("tipo");
                r.Diagnostico = dr.GetString("diagnostico");
                r.Receita = dr.GetString("receita");
                r.Observacoes = dr.GetString("observacoes");
                r.Crmv = dr.GetInt32("crmv");

                consultas.Add(r);
            }

            conexao.Close();

            return consultas;
        }
    }
}
