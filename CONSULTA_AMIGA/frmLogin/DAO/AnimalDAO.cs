using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class AnimalDAO
    {
        public bool Criar(Pessoa p, Animal a)
        {
            DataBase dbAnimal = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("INSERT INTO ANIMAL VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", p.Cpf, a.Nome, a.Raca, a.Especie, a.Peso, a.Sexo, a.Porte, a.Nascimento.ToString("yyyy-MM-dd"), a.Observacao);

                if (dbAnimal.ExecuteSQL(qry) == false)
                    return false;
                else
                    return true;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public Animal Procurar(string cpf, string nome)
        {
            Animal a = null;
            
            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM ANIMAL WHERE CPF_RESP = '" + cpf + "' AND NOME = '" + nome + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                a = new Animal();

                a.Responsavel = dr.GetString("cpf_resp");
                a.Nome = dr.GetString("nome");
                a.Raca = dr.GetString("raca");
                a.Especie = dr.GetString("especie");
                a.Nascimento = dr.GetDateTime("data_nasc");
                a.Peso = dr.GetString("peso");
                a.Sexo = dr.GetString("sexo");
                a.Porte = dr.GetString("porte");
                a.Observacao = dr.GetString("observacoes");
            }

            conexao.Close();

            return a;
        }

        public bool Alterar(Pessoa p,Animal a)
        {
            DataBase dbAnimal = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("UPDATE ANIMAL SET nome='{0}', raca='{1}', especie='{2}', peso='{3}', sexo='{4}', porte='{5}', data_nasc='{6}', observacoes='{7}' WHERE cpf_resp = '{8}' AND nome = '{9}'",a.Nome, a.Raca, a.Especie, a.Peso, a.Sexo, a.Porte, a.Nascimento.ToString("yyyy-MM-dd"), a.Observacao,p.Cpf,a.Nome);

                if (dbAnimal.ExecuteSQL(qry) == false)
                    return false;
                else
                    return true;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public void Excluir(Pessoa p, Animal a)
        {
            DataBase dbAnimal = DataBase.GetInstance();

            string qry = string.Format("DELETE FROM ANIMAL WHERE CPF_RESP = '" + p.Cpf + "' AND NOME = '" + a.Nome + "'");

            dbAnimal.ExecuteSQL(qry);
        }

        public List<Animal> ListarAnimaisCpf(Pessoa p)
        {
            Animal a = null;

            List<Animal> pets = new List<Animal>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM ANIMAL WHERE CPF_RESP = '" + p.Cpf + "'");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while(dr.Read())
            {
                a = new Animal();

                a.Responsavel = dr.GetString("cpf_resp");
                a.Nome = dr.GetString("nome");
                a.Raca = dr.GetString("raca");
                a.Especie = dr.GetString("especie");
                a.Nascimento = dr.GetDateTime("data_nasc");
                a.Peso = dr.GetString("peso");
                a.Sexo = dr.GetString("sexo");
                a.Porte = dr.GetString("porte");
                a.Observacao = dr.GetString("observacoes");

                pets.Add(a);
            }

            conexao.Close();

            return pets;
        }

        public List<Animal> ListarAnimais()
        {
            Animal a = null;

            List<Animal> pets = new List<Animal>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM ANIMAL");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                a = new Animal();

                a.Responsavel = dr.GetString("cpf_resp");
                a.Nome = dr.GetString("nome");
                a.Raca = dr.GetString("raca");
                a.Especie = dr.GetString("especie");
                a.Nascimento = dr.GetDateTime("data_nasc");
                a.Peso = dr.GetString("peso");
                a.Sexo = dr.GetString("sexo");
                a.Porte = dr.GetString("porte");
                a.Observacao = dr.GetString("observacoes");

                pets.Add(a);
            }

            conexao.Close();

            return pets;
        }

        public List<Animal> ListarAnimaisNome(string nome)
        {
            Animal a = null;

            List<Animal> pets = new List<Animal>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM ANIMAL WHERE NOME LIKE '%{0}%'",nome);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                a = new Animal();

                a.Responsavel = dr.GetString("cpf_resp");
                a.Nome = dr.GetString("nome");
                a.Raca = dr.GetString("raca");
                a.Especie = dr.GetString("especie");
                a.Nascimento = dr.GetDateTime("data_nasc");
                a.Peso = dr.GetString("peso");
                a.Sexo = dr.GetString("sexo");
                a.Porte = dr.GetString("porte");
                a.Observacao = dr.GetString("observacoes");

                pets.Add(a);
            }

            conexao.Close();

            return pets;
        }
    }
}

