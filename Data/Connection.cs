using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SportsClubProject.Data
{
    public class Connection
    {
        private string database;
        private string server;
        private string port;
        private string user;
        private string key;
        private static Connection? con = null;
        private Connection()

        {
            this.database = Config.Database!;
            this.server = Config.Server!;
            this.port = Config.Port!;
            this.user = Config.User!;
            this.key = "";
        }

        public MySqlConnection CreateConnection()
        {
            MySqlConnection? newString = new MySqlConnection();
            try
            {
                newString.ConnectionString = "datasource=" + this.server +
                ";port=" + this.port +
                ";username=" + this.user +
                ";password=" + this.key +
                ";Database=" + this.database;

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error connecting to MySql: {ex.Message}");
                throw;
            }
            return newString;
        }
        public static Connection GetInstance()
        {
            if (con == null) 
            {
                con = new Connection();
            }
            return con;
        }

        internal static void ResetDatabase()
        {
            //  Fetch reset scripts
            string reset_query = $"DROP DATABASE IF EXISTS {Config.Database!}; \nCREATE DATABASE {Config.Database!}; \nUSE {Config.Database!};";
            string? query = File.ReadAllText("../../../MySql/SchemaReset.sql");
            reset_query += query;
            string sp_creation = File.ReadAllText("../../../MySql/LoginClub.sql");
            string sp_creation2 = File.ReadAllText("../../../MySql/ProcedureNewPostulant.sql");
            if (query == null)
            {
                throw new ArgumentNullException("Database reset file was empty!");
            }

            //  Open connection
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "datasource=" + Config.Server +
				";port=" + Config.Port +
				";username=" + Config.User +
				";password=" + Config.Pass;
			conn.Open();

            //  Execute schema reset
            MySqlCommand cmd = new MySqlCommand(reset_query, conn);
            cmd.ExecuteNonQuery();

            //  Create SP
            cmd.CommandText = sp_creation;
            cmd.ExecuteNonQuery();
            //  Create SP2
            cmd.CommandText = sp_creation2;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
