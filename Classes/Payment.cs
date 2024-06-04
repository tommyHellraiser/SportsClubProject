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

		internal static Payment FromBill(Bill bill)
		{
			Payment payment = new Payment();

			payment.PostulantId = bill.postulantId;
			payment.document = bill.document;
			payment.amount = bill.amount;

			return payment;
		}

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
