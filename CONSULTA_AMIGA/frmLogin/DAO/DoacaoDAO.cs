using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class DoacaoDAO
    {
        public bool Criar(Doacao d)
        {
            DataBase dbPessoa = DataBase.GetInstance();

            try
            {
                string qry = string.Format("INSERT INTO DOACAO ( doador, data, valor, pagamento, observacoes) VALUES ('{0}','{1}','{2}','{3}','{4}')", d.Doador, d.Data.ToString("yyyy-MM-dd"), d.Valor, d.Pagamento, d.Observacoes);

                dbPessoa.ExecuteSQL(qry);

                return true;
            }                       
            catch (System.NullReferenceException)
            {
                return false;
            }

        }

        public List<Doacao> ListarDoacoes()
        {
            Doacao d = null;

            List<Doacao> doacoes = new List<Doacao>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM DOACAO");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                d = new Doacao();

                d.Doador = dr.GetString("doador");
                d.Data = dr.GetDateTime("data");
                d.Valor = dr.GetDouble("valor");
                d.Pagamento = dr.GetString("pagamento");
                d.Observacoes = dr.GetString("observacoes");

                doacoes.Add(d);
            }

            conexao.Close();

            return doacoes;
        }

        public int AtribuirCodigo()
        {
            int codigo = 0;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("select max(codigo) as codigo from doacao");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    codigo = dr.GetInt32("codigo");
                }
            }
            catch (System.Data.SqlTypes.SqlNullValueException)
            {
                conexao.Close();

                return codigo + 1;
            }

            conexao.Close();

            return codigo;
        }

        public double SomaDoacoes()
        {
            double soma = 0;
            double valor = 0;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM DOACAO");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                valor = dr.GetDouble("valor");

                soma += valor;
            }

            conexao.Close();

            return soma;
        }
    }

}
