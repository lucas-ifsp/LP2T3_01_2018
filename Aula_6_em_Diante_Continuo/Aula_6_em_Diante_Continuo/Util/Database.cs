using System;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Aula_6_em_Diante_Continuo
{
    class Database
    {
        private static SQLiteConnection connection;
        private static Database instance;
        private const string URL = "database.db";

        private Database()
        {
            if (!File.Exists(URL))
            {
                SQLiteConnection.CreateFile(URL);
                CreateDatabase();
            }
            connection = new SQLiteConnection("Data Source=" + URL);
        }

        private void CreateDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + URL);
            try
            {
                conn.Open();
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE usuario(cpf VARCHAR(14), nome VARCHAR(40), dtnasc DATE, PRIMARY KEY(cpf));");
                sql.AppendLine("CREATE TABLE livro (codigo INTEGER PRIMARY KEY AUTOINCREMENT,autor VARCHAR(40),titulo VARCHAR(40), disponivel INTEGER);");
                sql.AppendLine("CREATE TABLE emprestimo (codigo INTEGER PRIMARY KEY AUTOINCREMENT,dataEmprestimo DATE,dataDevolucao DATE,usuario VARCHAR(40) NOT NULL, livro INT NOT NULL, finalizado INTEGER, FOREIGN KEY(usuario) REFERENCES usuario(cpf), FOREIGN KEY(livro) REFERENCES livro(codigo));");
                SQLiteCommand comm = new SQLiteCommand(sql.ToString(), conn);
                comm.ExecuteNonQuery();

                Populate();
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possível executar o comando SQL: " + e.Message, "Erro de Conexão");
            }
            finally
            {
                conn.Close();
            }
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteNonQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, connection);
            comm.ExecuteNonQuery();

            connection.Close();
        }

        public void ExecuteNonQuery(SQLiteCommand cmd)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            connection.Close();
            return ds;
        }

        private void Populate()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + URL);
            StringBuilder livros = new StringBuilder();

            conn.Open();
            livros.AppendLine("insert into livro (codigo, autor, titulo, disponivel) values (1, 'Grete Franklen', 'Quality-focused methodical framework', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(2, 'Evan Leverington', 'Secured didactic model', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(3, 'Alexandro Baudichon', 'Quality-focused neutral strategy', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(4, 'Sibylle Bernli', 'Adaptive web-enabled analyzer', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(5, 'Romy Poxon', 'Advanced even-keeled artificial intelligence', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(6, 'Ailee Robertshaw', 'Programmable needs-based moratorium', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(7, 'Lyndsay Bryers', 'Versatile mission-critical data-warehouse', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(8, 'Eddy Arkcoll', 'Stand-alone zero administration hub', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(9, 'Christoph Rops', 'Self-enabling intermediate framework', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(10, 'Mano Dodge', 'Enhanced incremental database', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(11, 'Skippy Deedes', 'Cloned executive challenge', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(12, 'Natalya Andric', 'Open-architected asymmetric interface', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(13, 'Fidel Goligher', 'Persistent multi-tasking standardization', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(14, 'Yale Arndtsen', 'Compatible tertiary internet solution', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(15, 'Chauncey Janczyk', 'Robust bandwidth-monitored software', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(16, 'Isabella Oakden', 'Balanced user-facing database', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(17, 'Travis Tume', 'Streamlined 5th generation artificial intelligence', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(18, 'Anatole Broschke', 'Reduced contextually-based emulation', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(19, 'Shelley Cohrs', 'Total needs-based access', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(20, 'Brander Mayger', 'Managed multi-tasking conglomeration', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(21, 'Virge Ryrie', 'Enhanced well-modulated paradigm', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(22, 'Shaina Side', 'Networked systematic framework', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(23, 'Tybi Jerche', 'User-friendly user-facing extranet', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(24, 'Veda Omand', 'Innovative global instruction set', 1);");
            livros.AppendLine("insert into livro(codigo, autor, titulo, disponivel) values(25, 'Anetta Veregan', 'Reactive responsive analyzer', 1);");

            SQLiteCommand comm = new SQLiteCommand(livros.ToString(), conn);
            comm.ExecuteNonQuery();

            StringBuilder usuarios = new StringBuilder();
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('58053123743', 'Mendie Norkutt', '1987-01-21');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('66630186471', 'Karrah Colenutt', '1982-02-19');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('17935137524', 'Mollee Rosel', '1999-03-02');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('41802123658', 'Gillie Syers', '1970-11-18');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('50086607659', 'Kimbra Blazdell', '1998-09-28');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('16324028505', 'Cathrin Wrathmell', '2000-01-27');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('76515999020', 'Tammie Hartington', '2001-12-03');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('73263140721', 'Renata McBoyle', '2002-11-22');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('64377953360', 'Venita Warlock', '1965-07-07');");
            usuarios.AppendLine("insert into usuario(cpf, nome, dtnasc) values('70571214571', 'Bab Studman', '1997-04-02');");

            comm = new SQLiteCommand(usuarios.ToString(), conn);
            comm.ExecuteNonQuery();

            conn.Close();
        }
    }
}
