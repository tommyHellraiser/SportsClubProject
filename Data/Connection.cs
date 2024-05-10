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
            string? query = File.ReadAllText("../../../MySql/SchemaReset.sql");
            string sp_creation = File.ReadAllText("../../../MySql/LoginClub.sql");
			if (query == null)
            {
                throw new ArgumentNullException("Database reset file was empty!");
            }

            //  Open connection
            MySqlConnection conn = GetInstance().CreateConnection();
            conn.Open();

            //  Execute schema reset
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //  Create SP
            cmd.CommandText = sp_creation;
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
