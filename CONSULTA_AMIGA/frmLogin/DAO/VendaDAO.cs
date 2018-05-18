using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class VendaDAO
    {
        public bool Criar(Venda v)
        {
            DataBase dbVenda = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("INSERT INTO VENDA(data,consumidor,pagamento,desconto,valor_total) VALUES('{0}','{1}','{2}','{3}','{4}')", v.Data.ToString("yyyy-MM-dd"), v.Consumidor, v.Pagamento, v.Desconto, v.ValorTotal);

                if (dbVenda.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public List<Venda> ListarVendas()
        {
            Venda v = null;

            List<Venda> vendas = new List<Venda>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM VENDA");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                v = new Venda();

                v.Codigo = dr.GetInt32("codigo");
                v.Data = dr.GetDateTime("data");
                v.Consumidor = dr.GetString("consumidor");
                v.Pagamento = dr.GetString("pagamento");
                v.Desconto = dr.GetDouble("desconto");
                v.ValorTotal = dr.GetDouble("valor_total");

                vendas.Add(v);
            }

            conexao.Close();

            return vendas;
        }

        public double SomaVendas()
        {
            double soma = 0;
            double valor = 0;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM VENDA");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                valor = dr.GetDouble("valor_total");

                soma += valor;
            }

            conexao.Close();

            return soma;
        }

        public int AtribuirCodigo()
        {
            int codigo = 0;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("select max(codigo) as codigo, data from venda");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            try
            {
                if(dr.Read())
                {
                    codigo = dr.GetInt32("codigo");
                }
            }
            catch(System.Data.SqlTypes.SqlNullValueException)
            {
                conexao.Close();

                return codigo + 1;
            }

            conexao.Close();

            return codigo+1;
        }

        public bool InserirProdutos(int codigoVenda, int codigoProduto)
        {
            DataBase dbVenda = DataBase.GetInstance();

            try
            {
                string qry = string.Format("INSERT INTO ITENSVENDA VALUES ('{0}','{1}')", codigoVenda, codigoProduto);

                if (dbVenda.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public List<Produto> ProdutosVendidos(int codigoVenda)
        {
            Produto p = null;

            List<Produto> produtos = new List<Produto>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT P.CODIGO, P.NOME, P.MARCA, P.TIPO, P.PRECOCUSTO, P.PRECOVENDA, P.DESCRICAO, P.QUANTIDADE, P.DOSAGEM FROM PRODUTO P, VENDA V, ITENSVENDA I WHERE V.CODIGO = '{0}' AND I.CODIGO_VENDA = V.CODIGO AND P.CODIGO = I.CODIGO_PRODUTO ORDER BY I.CODIGO_PRODUTO ",codigoVenda);

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
    }
}
