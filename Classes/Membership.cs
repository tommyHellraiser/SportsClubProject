using MySql.Data.MySqlClient;
using SportsClubProject.Data;

namespace SportsClubProject.Classes
{
	internal class Membership
	{
		internal int? ID { get; set; }
		internal int PostulantID { get; set; }
		internal DateTime? ExpirationDate { get; set; }
		internal float? Amount { get; set; }
		internal bool Paid { get; set; }

		/// <summary>
		/// Creates an instance of Membership from a Postulant object
		/// </summary>
		/// <param name="post"></param>
		/// <returns></returns>
		internal static Membership FromPostulant(Postulant post)
		{
			Membership membership = new();
			membership.PostulantID = post.ID;
			membership.Paid = false;

			return membership;
		}

		/// <summary>
		/// Assigns the amount value received as parameter to instance of Mermbership's amount 
		/// field, sets the "paid" field as true, and sets the expiration date as one month from now.
		/// Finally it'll execute the Update operation in database
		/// </summary>
		/// <param name="amount"></param>
		/// <returns>
		/// True if the update operation affected any amount of rows, false if no rows were affected
		/// </returns>
		internal bool UpdateFromPayment(float amount)
		{
			this.ExpirationDate = DateTime.Now.AddDays(30);
			this.Amount = amount;
			this.Paid = true;

			return this.Update();
		}

		#region Database Methods

		/// <summary>
		/// Inserts the current instance of Membership into database
		/// </summary>
		/// <returns>
		/// True if insert was successful, false otherwise
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal bool InsertNew()
		{

			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			int affected = 0;

			try
			{
				string query = "INSERT INTO memberships (PostulantID) VALUES (@PostulantID);";

				conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);
				command.Parameters.AddWithValue("@PostulantID", this.PostulantID);

				affected = command.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Cannot insert new membership:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}


			return (affected > 0);
		}

		/// <summary>
		/// Selects a single record from memberships table
		/// </summary>
		/// <param name="PostulantID"></param>
		/// <returns>
		/// Membership as an instance of this class, and null if no records were found that match the requested PostulantID
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal static Membership? SelectFromPostulantID(int PostulantID)
		{
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			Membership? membership = null;

			try
			{
				string query = "SELECT * FROM memberships WHERE PostulantID = @PostulantID";

				conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);
				command.Parameters.AddWithValue("@PostulantID", PostulantID);

				MySqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					membership = Membership.MembershipFromReader(reader);
				}

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Cannot execute select membership from postulants:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}


			return membership;
		}

		/// <summary>
		///	Updates the record in database corresponding to the current instance of this class
		/// </summary>
		/// <returns>
		/// True if update operation was successful, false otherwise
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal bool Update()
		{

			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			int affected = 0;

			try
			{
				string query = "UPDATE memberships SET ExpirationDate = @ExpirationDate, Amount = @Amount, Paid = 1 WHERE PostulantID = @PostulantID;";

				conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);
				command.Parameters.AddWithValue("@ExpirationDate", this.ExpirationDate);
				command.Parameters.AddWithValue("@Amount", this.Amount);
				command.Parameters.AddWithValue("@PostulantID", this.PostulantID);

				affected = command.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Cannot update membership:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}


			return (affected > 0);
		}

		/// <summary>
		///	Receives a reader as parameter and attempts to read all the required fields from it. It'll create a new instance of
		///	Membership
		/// </summary>
		/// <param name="reader"></param>
		/// <returns>
		/// The new instance of Memmbership
		/// </returns>
		private static Membership MembershipFromReader(MySqlDataReader reader)
		{
			Membership memb = new();

			memb.ID = reader.GetInt32("ID");
			memb.PostulantID = reader.GetInt32("PostulantID");
			if (reader["ExpirationDate"] != DBNull.Value)
			{
                DateTime datetime = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                memb.ExpirationDate = datetime;
			}
			memb.Amount = reader.GetFloat("Amount");
			memb.Paid = reader.GetBoolean("Paid");

			return memb;
		}

		#endregion

	}
}
