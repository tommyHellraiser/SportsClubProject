using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Data;
using System.Diagnostics;

namespace SportsClubProject.Classes
{
    internal class User:Person
    {
        public User() : base()
        {

        }
                
        public static User? LogUserIn (string inputName, string inputPass)
        {

            DataTable table = ExecLoginStoredProc(inputName, inputPass);
            User? newUser = null;

            //  If there was a User match, extract data
            if (table.Rows.Count > 0)
            {
                //  If a user is found, overwrite newUser, otherwis, it'll be null
                User user = new User();

                user.Username = table.Rows[0]["Username"].ToString();
                user.FirstName = table.Rows[0]["FirstName"].ToString();
				user.LastName = table.Rows[0]["LastName"].ToString();
				user.Phone = table.Rows[0]["Phone"].ToString();
				user.Email = table.Rows[0]["Email"].ToString();
				user.BirthDate = Convert.ToDateTime(table.Rows[0]["Birthdate"].ToString());
				user.UserRole = table.Rows[0]["FirstName"].ToString();

                newUser = user;
			}

            return newUser;
        }


        #region Database methods

        private static DataTable ExecLoginStoredProc(string inputUsername, string inputPass)
        {

			MySqlDataReader result;
			DataTable dt = new DataTable();
			MySqlConnection conn = new MySqlConnection();

			try
			{
				conn = Connection.GetInstance().CreateConnection();

				MySqlCommand command = new MySqlCommand("Login", conn);
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.Add("InputUsername", MySqlDbType.VarChar).Value = inputUsername;
				command.Parameters.Add("InputPass", MySqlDbType.VarChar).Value = inputPass;

				conn.Open();
				result = command.ExecuteReader();

				dt.Load(result);

                conn.Close();

				return dt;
			}
			catch (Exception ex)
			{
                Debug.WriteLine($"Error executing Login SP: {ex.Message}");
				throw;
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{ 
                    conn.Close();
                }
			}
        }

        #endregion

    }
}
