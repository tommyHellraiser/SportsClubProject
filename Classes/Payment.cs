using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using SportsClubProject.Forms;

namespace SportsClubProject.Classes
{
	internal class Payment
	{
		internal int ID;
		internal int? PostulantId;
		internal int document;
		internal float amount;

		/// <summary>
		/// Creates an instance of Payment from a Bill object
		/// </summary>
		/// <param name="bill"></param>
		/// <returns>
		/// The created instance of Payment class
		/// </returns>
		internal static Payment FromBill(Bill bill)
		{
			Payment payment = new Payment();

			payment.PostulantId = bill.postulantId;
			payment.document = bill.document;
			payment.amount = bill.amount;

			return payment;
		}

		/// <summary>
		/// Inserts an instance of Payment into database
		/// </summary>
		/// <returns>
		/// True if insert was successful, false otherwise
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal bool Insert()
		{
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			int affectedRows = 0;
			try
			{
				string query = "INSERT INTO payments(PostulantId, DocumentNumber, Amount) VALUES (@postulantId, @document, @amount);";
				conn.Open();

				MySqlCommand insertCommand = new MySqlCommand(query, conn);
				insertCommand.Parameters.AddWithValue("@postulantId", this.PostulantId);
				insertCommand.Parameters.AddWithValue("@document", this.document);
				insertCommand.Parameters.AddWithValue("@amount", this.amount);
				affectedRows = insertCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Failed to insert payments into database:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}

			return (affectedRows > 0);
		}

	}
}
