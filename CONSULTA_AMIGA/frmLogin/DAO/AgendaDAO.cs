using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace frmLogin
{
    class AgendaDAO
    {
        public bool Criar(Agenda a)
        {
            DataBase dbAgenda = DataBase.GetInstance();

            try
            { 
                string qry = string.Format("INSERT INTO AGENDA VALUES('{0}','{1}','{2}','{3}','{4}')", a.Data.ToString("yyyy-MM-dd"), a.Responsavel, a.Animal, a.Horario, a.Tipo);

                if (dbAgenda.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch(System.NullReferenceException)
            {
                return false;
            }      
        }

        public Agenda Procurar(DateTime data, string resp, string animal)
        {
            Agenda a = null;

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = "SELECT * FROM AGENDA WHERE DATA = '" + data.ToString("yyyy-MM-dd") + "' AND RESPONSAVEL = '" + resp + "'" + " AND ANIMAL = '" + animal + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                a = new Agenda();

                a.Data = dr.GetDateTime("data");
                a.Responsavel = dr.GetString("responsavel");
                a.Animal = dr.GetString("animal");             
                a.Horario = dr.GetString("horario");
                a.Tipo = dr.GetString("tipo");
            }

            conexao.Close();

            return a;
        }

        public bool Alterar(Agenda a)
        {
            DataBase dbAgenda = DataBase.GetInstance();

            try
            {
                string qry = string.Format("UPDATE AGENDA SET  data='{0}', responsavel='{1}', animal='{2}', horario='{3}', tipo='{4}' WHERE data='{5}' AND responsavel = '{6}' AND animal = '{7}'", a.Data.ToString("yyyy-MM-dd"), a.Responsavel, a.Animal, a.Horario, a.Tipo, a.Data.ToString("yyyy-MM-dd"), a.Responsavel, a.Animal);

                if (dbAgenda.ExecuteSQL(qry) == true)
                    return true;
                else
                    return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public void Excluir(Agenda a)
        {
            DataBase dbAgenda = DataBase.GetInstance();

            string qry = string.Format("DELETE FROM AGENDA WHERE DATA= '" + a.Data.ToString("yyyy-MM-dd") + "' AND RESPONSAVEL = '" + a.Responsavel + "'" + " AND ANIMAL = '" + a.Animal+ "'");

            dbAgenda.ExecuteSQL(qry);
        }

        public List<Agenda> ListarAgenda()
        {
            Agenda a = null;

            List<Agenda> agenda = new List<Agenda>();

            MySqlConnection conexao = DataBase.GetInstance().GetConnection();

            string qry = string.Format("SELECT * FROM AGENDA");

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                a = new Agenda();

                a.Data = dr.GetDateTime("data");
                a.Responsavel = dr.GetString("responsavel");
                a.Animal = dr.GetString("animal");
                a.Horario = dr.GetString("horario");
                a.Tipo = dr.GetString("tipo");

                agenda.Add(a);
            }

            conexao.Close();

            return agenda;
        }  
    }
}
