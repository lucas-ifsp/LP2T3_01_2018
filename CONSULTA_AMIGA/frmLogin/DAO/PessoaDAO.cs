using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class PessoaDAO
    {
        public bool Criar(Pessoa p)
        {
            DataBase dbPessoa = DataBase.GetInstance();

            try
            {
                string qry = string.Format("INSERT INTO Pessoa VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", p.Cpf, p.Nome, p.Nascimento.ToString("yyyy-MM-dd"), p.Telefone, p.Celular, p.Sexo, p.Rua, p.Numero, p.Bairro, p.Estado, p.Cidade, p.Cep);

                if (dbPessoa.ExecuteSQL(qry) == false)
                    return false;
                else
                    return true;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public Pessoa Procurar(string cpf)
        {

            Pessoa p = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM PESSOA WHERE CPF = '" + cpf + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                p = new Pessoa();

                p.Cpf = dr.GetString("cpf");
                p.Nome = dr.GetString("nome");
                p.Nascimento = dr.GetDateTime("data_nasc");
                p.Telefone = dr.GetString("telefone");
                p.Celular = dr.GetString("celular");
                p.Sexo = dr.GetString("sexo");
                p.Rua = dr.GetString("rua");
                p.Numero = dr.GetString("numero");
                p.Bairro = dr.GetString("bairro");
                p.Estado = dr.GetString("estado");
                p.Cidade = dr.GetString("cidade");
                p.Cep = dr.GetString("cep");
            }

            conexao.Close();

            return p;
        }

        public bool Alterar(Pessoa p)
        {
            DataBase dbPessoa = DataBase.GetInstance();

            try
            {
                string qry = string.Format("UPDATE PESSOA SET cpf='{0}', nome='{1}', data_nasc='{2}', telefone='{3}', celular='{4}', sexo='{5}', rua='{6}', numero='{7}', bairro='{8}', estado='{9}', cidade='{10}', cep='{11}' WHERE cpf = '{12}'", p.Cpf, p.Nome, p.Nascimento.ToString("yyyy-MM-dd"), p.Telefone, p.Celular, p.Sexo, p.Rua, p.Numero, p.Bairro, p.Estado, p.Cidade, p.Cep, p.Cpf);

                if (dbPessoa.ExecuteSQL(qry) == false)
                    return false;
                else
                    return true;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }

        }

        public void Excluir(string cpf)
        {
            DataBase dbPessoa = DataBase.GetInstance();

            string qry = string.Format("DELETE FROM PESSOA WHERE CPF = '" + cpf + "'");

            dbPessoa.ExecuteSQL(qry);
        }

        public List<Pessoa> ListarPessoas()
        {
            Pessoa p = null;

            List<Pessoa> pessoas = new List<Pessoa>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM PESSOA");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                p = new Pessoa();

                p.Cpf = dr.GetString("cpf");
                p.Nome = dr.GetString("nome");
                p.Nascimento = dr.GetDateTime("data_nasc");
                p.Telefone = dr.GetString("telefone");
                p.Celular = dr.GetString("celular");
                p.Sexo = dr.GetString("sexo");
                p.Rua = dr.GetString("rua");
                p.Numero = dr.GetString("numero");
                p.Bairro = dr.GetString("bairro");
                p.Estado = dr.GetString("estado");
                p.Cidade = dr.GetString("cidade");
                p.Cep = dr.GetString("cep");

                pessoas.Add(p);
            }

            conexao.Close();

            return pessoas;
        }
     
        public List<Pessoa> ListarPessoasNome(string nome)
        {
            Pessoa p = null;

            List<Pessoa> pessoas = new List<Pessoa>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM PESSOA WHERE NOME LIKE '%{0}%'", nome);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                p = new Pessoa();

                p.Cpf = dr.GetString("cpf");
                p.Nome = dr.GetString("nome");
                p.Nascimento = dr.GetDateTime("data_nasc");
                p.Telefone = dr.GetString("telefone");
                p.Celular = dr.GetString("celular");
                p.Sexo = dr.GetString("sexo");
                p.Rua = dr.GetString("rua");
                p.Numero = dr.GetString("numero");
                p.Bairro = dr.GetString("bairro");
                p.Estado = dr.GetString("estado");
                p.Cidade = dr.GetString("cidade");
                p.Cep = dr.GetString("cep");

                pessoas.Add(p);
            }

            conexao.Close();

            return pessoas;
        }
    }
}
