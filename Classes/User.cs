using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportsClubProject.Classes
{
    internal class User:Person
    {
        public User(string? name, string? lastname, string pass, int phone, string? email, string? role, DateTime birthdate)
        : base(name, lastname, pass, phone, email, role, birthdate)
        {
            
        }
        
        public DataTable LogUser ()
        {
            MySqlDataReader result;
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Connection.getInstance().CreateConnection();

                MySqlCommand command = new MySqlCommand ("Login", sqlCon);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Usu",
                MySqlDbType.VarChar).Value = this.Name;
                command.Parameters.Add("Pass", MySqlDbType.VarChar).Value = this.Pass;

                sqlCon.Open();
                result = command.ExecuteReader(); 

                dt.Load(result); 

                return dt;
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }   
        
    }
}
