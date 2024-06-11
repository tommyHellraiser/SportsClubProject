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
		
		/// <summary>
		/// Logs the user in by executing the corresponding MySql Stored Procedure
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="inputPass"></param>
		/// <returns>
		/// An instance of the User class if successful, null otherwise
		/// </returns>
		/// <exception cref="InvalidDataException"></exception>
        public static User? LogUserIn (string inputName, string inputPass)
        {

            DataTable table = ExecLoginStoredProc(inputName, inputPass);
			User? newUser;

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
				user.UserRole = table.Rows[0]["RoleName"].ToString();

                newUser = user;
			}
			else
			{
				throw new InvalidDataException("Usuario o pass invalidos!");
			}

            return newUser;
        }


        #region Database methods

		/// <summary>
		///	Executes the login Stored Procedure
		/// </summary>
		/// <param name="inputUsername"></param>
		/// <param name="inputPass"></param>
		/// <returns>
		/// A datatable containing the User class data
		/// </returns>
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
				conn.Close();
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
