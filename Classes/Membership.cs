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

		internal static Membership FromPostulant(Postulant post)
		{
			Membership membership = new();
			membership.PostulantID = post.ID;
			membership.Paid = false;

			return membership;
		}

		internal bool UpdateFromPayment(float amount)
		{
			this.ExpirationDate = DateTime.Now.AddDays(10);
			this.Amount = amount;
			this.Paid = true;

			return this.Update();
		}

		#region Database Methods

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

		private static Membership MembershipFromReader(MySqlDataReader reader)
		{
			Membership memb = new();

			memb.ID = reader.GetInt32("ID");
			memb.PostulantID = reader.GetInt32("PostulantID");
			if (reader["ExpirationDate"] != DBNull.Value)
			{
				if (DateTime.TryParse(reader.GetString("ExpirationDate"), out DateTime datetime))
				{
					memb.ExpirationDate = datetime;
				}
			}
			memb.Amount = reader.GetFloat("Amount");
			memb.Paid = reader.GetBoolean("Paid");

			return memb;
		}

		#endregion

	}
}
