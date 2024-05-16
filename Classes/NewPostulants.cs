using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
    internal class NewPostulants
    {
        public string NewPostulant(Postulant newPostulant)
        {
            string? exit;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Connection.GetInstance().CreateConnection();
                MySqlCommand command = new MySqlCommand("NewPostulant",
                sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Nam", MySqlDbType.VarChar).Value =
                newPostulant.Name;
                command.Parameters.Add("LstN", MySqlDbType.VarChar).Value =
                newPostulant.LastName;
                command.Parameters.Add("Typ", MySqlDbType.VarChar).Value =
                newPostulant.TDoc;
                command.Parameters.Add("DocP", MySqlDbType.Int32).Value =
                newPostulant.Doc;
                MySqlParameter response = new MySqlParameter();
                response.ParameterName = "res";
                response.MySqlDbType = MySqlDbType.Int32;
                response.Direction = ParameterDirection.Output;
                command.Parameters.Add(response);
                sqlCon.Open();
                command.ExecuteNonQuery();
                exit = Convert.ToString(response.Value);
            }
            catch (Exception ex)
            {
                exit = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return exit;
        }
    }
}
