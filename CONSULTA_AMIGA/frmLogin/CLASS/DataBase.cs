using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace frmLogin
{
    class DataBase
    {
        private static MySqlConnection conexao;
        private static DataBase instance;
        private string URL = "Server=127.0.0.1;Database=ConsultaAmiga;Uid=root;Pwd=root;";

        private DataBase()
        {
            conexao = new MySqlConnection(URL);
        }

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();

            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return conexao;
        }

        public bool ExecuteSQL(string qry)
        {
            try
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();
                MySqlCommand comm = new MySqlCommand(qry, conexao);
                comm.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }
    }
}
