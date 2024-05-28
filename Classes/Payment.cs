using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using SportsClubProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
	internal class Payment
	{
		internal int ID;
		internal int postulantId;
		internal float amount;

		internal static Payment FromBill(Bill bill)
		{
			Payment payment = new Payment();

			payment.postulantId = bill.postulantId;
			payment.amount = bill.amount;

			return payment;
		}

		internal bool Insert()
		{
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			int affectedRows = 0;
			try
			{
				string query = "INSERT INTO payments(PostulantId, Amount) VALUES (@postulantId, @amount);";
				conn.Open();

				MySqlCommand insertCommand = new MySqlCommand(query, conn);
				insertCommand.Parameters.AddWithValue("@postulantId", this.postulantId);
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
