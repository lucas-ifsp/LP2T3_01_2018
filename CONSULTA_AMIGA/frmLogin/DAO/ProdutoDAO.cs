using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class ProdutoDAO
    {
        public bool Criar(Produto p)
        {
            DataBase dbProduto = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("INSERT INTO Produto(nome,marca,tipo,precoCusto,precoVenda,descricao,quantidade,dosagem) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", p.Nome, p.Marca, p.Tipo, p.PrecoCusto, p.PrecoVenda, p.Descricao, p.Quantidade, p.Dosagem);

                    if (dbProduto.ExecuteSQL(qry) == true)
                        return true;
                    else
                        return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public Produto Procurar(string nome)
        {
            Produto p = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM PRODUTO WHERE NOME = '" + nome + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                p = new Produto();

                p.Codigo = dr.GetInt32("codigo");
                p.Nome = dr.GetString("nome");
                p.Marca = dr.GetString("marca");
                p.Tipo = dr.GetString("tipo");
                p.PrecoCusto = dr.GetDouble("precoCusto");
                p.PrecoVenda = dr.GetDouble("precoVenda");
                p.Descricao = dr.GetString("descricao");
                p.Quantidade = dr.GetInt32("quantidade");
                p.Dosagem = dr.GetString("dosagem");
            }

            conexao.Close();

            return p;
        }

        public Produto ProcurarCodigo(int codigo)
        {
            Produto p = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM PRODUTO WHERE CODIGO = " + codigo;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                p = new Produto();

                p.Codigo = dr.GetInt32("codigo");
                p.Nome = dr.GetString("nome");
                p.Marca = dr.GetString("marca");
                p.Tipo = dr.GetString("tipo");
                p.PrecoCusto = dr.GetDouble("precoCusto");
                p.PrecoVenda = dr.GetDouble("precoVenda");
                p.Descricao = dr.GetString("descricao");
                p.Quantidade = dr.GetInt32("quantidade");
                p.Dosagem = dr.GetString("dosagem");
            }

            conexao.Close();

            return p;
        }

        public bool Alterar(Produto p)
        {
            DataBase dbProduto = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("UPDATE PRODUTO SET nome = '{0}', marca = '{1}', tipo = '{2}', precoCusto = '{3}', precoVenda = '{4}', descricao = '{5}', quantidade ='{6}', dosagem ='{7}' WHERE codigo = '{8}'", p.Nome, p.Marca, p.Tipo, p.PrecoCusto, p.PrecoVenda, p.Descricao, p.Quantidade, p.Dosagem, p.Codigo);

                if (dbProduto.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;

            }
            catch(System.NullReferenceException)
            {
                return false;
            }
        }

        public void Excluir(int codigo)
        {
            DataBase dbProduto = DataBase.GetInstance();

            string qry = string.Format("DELETE FROM PRODUTO WHERE CODIGO = " + codigo);

            dbProduto.ExecuteSQL(qry);
        }

        public List<Produto> ListarProdutos()
        {
            Produto p = null;

            List<Produto> produtos = new List<Produto>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM PRODUTO");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                p = new Produto();

                p.Codigo = dr.GetInt32("codigo");
                p.Nome = dr.GetString("nome");
                p.Marca = dr.GetString("marca");
                p.Tipo = dr.GetString("tipo");
                p.PrecoCusto = dr.GetDouble("precoCusto");
                p.PrecoVenda = dr.GetDouble("precoVenda");
                p.Descricao = dr.GetString("descricao");
                p.Quantidade = dr.GetInt32("quantidade");
                p.Dosagem = dr.GetString("dosagem");

                produtos.Add(p);
            }

            conexao.Close();

            return produtos;
        }

        public List<Produto> ListarProdutosNome(string nome)
        {
            Produto p = null;

            List<Produto> produtos = new List<Produto>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM PRODUTO WHERE NOME LIKE '%{0}%'",nome);

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                p = new Produto();

                p.Codigo = dr.GetInt32("codigo");
                p.Nome = dr.GetString("nome");
                p.Marca = dr.GetString("marca");
                p.Tipo = dr.GetString("tipo");
                p.PrecoCusto = dr.GetDouble("precoCusto");
                p.PrecoVenda = dr.GetDouble("precoVenda");
                p.Descricao = dr.GetString("descricao");
                p.Quantidade = dr.GetInt32("quantidade");
                p.Dosagem = dr.GetString("dosagem");

                produtos.Add(p);
            }

            conexao.Close();

            return produtos;
        }

        public void AtualizarEstoque(Produto p)
        {
            DataBase dbProduto = DataBase.GetInstance();

            string qry = string.Format("UPDATE PRODUTO SET nome = '{0}', quantidade ='{1}' WHERE nome = '{2}'", p.Nome, p.Quantidade, p.Nome);

            dbProduto.ExecuteSQL(qry);
        }

        public int AtribuirCodigo()
        {
            int codigo  = 0;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("select max(codigo) as codigo from produto");

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

            return codigo+1;
        }
    }
}