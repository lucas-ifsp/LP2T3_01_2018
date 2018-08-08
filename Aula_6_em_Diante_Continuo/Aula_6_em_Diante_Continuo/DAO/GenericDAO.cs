using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_6_em_Diante_Continuo.Util;
using System.Data.SQLite;

namespace Aula_6_em_Diante_Continuo.DAO
{
     class GenericDAO
    {

        private Database bd;

        public GenericDAO()
        {
            bd = Database.GetInstance();
        }
        public void Save(IEntity e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO " +  e.GetType().Name.ToUpper() + " (");

            for (int i = 0; i < e.Atts().Keys.Count - 1; i++) 
                sql.Append(e.Atts().Keys.ToArray()[i].ToLower() + ", ");
            sql.Append(e.Atts().Keys.ToArray()[e.Atts().Keys.Count-1] + ") VALUES ( ");

            for (int i = 0; i < e.Atts().Keys.Count - 1; i++)
                sql.Append("@" + e.Atts().Keys.ToArray()[i].ToLower() + ", ");
            sql.Append("@" + e.Atts().Keys.ToArray()[e.Atts().Keys.Count - 1] + ");");

            SQLiteCommand com = new SQLiteCommand(sql.ToString());

            foreach (var v in e.Atts())
                com.Parameters.Add(new SQLiteParameter("@"+ v.Key, v.Value));

            bd.ExecuteNonQuery(com);
        }
    }
}
