using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
    internal class NewPostulants
    {
        /// <summary>
        /// Creates a new postulant by executing the corresponding MySql Stored Procedure
        /// </summary>
        /// <param name="newPostulant"></param>
        /// <returns>
        /// SP's response as a string value
        /// </returns>
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
                command.Parameters.Add("NewName", MySqlDbType.VarChar).Value =
                newPostulant.FirstName;
                command.Parameters.Add("NewLastName", MySqlDbType.VarChar).Value =
                newPostulant.LastName;
                command.Parameters.Add("NewDocumentType", MySqlDbType.VarChar).Value =
                newPostulant.DocumentType;
                command.Parameters.Add("NewDocument", MySqlDbType.Int32).Value =
                newPostulant.Document;
                MySqlParameter response = new MySqlParameter();
                response.ParameterName = "Response";
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
                Debug.WriteLine($"Error executing NewPostulant SP: {ex.Message}");
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
