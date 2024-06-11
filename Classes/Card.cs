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
    internal class Card
    {
        public int ID { get; set; }
        public int PostulantID { get; set; }
        public DateTime CardDate { get; set; }
        public DateTime ExpirationCardDate { get; set; }

        public Card(int postulantID, DateTime cardDate, DateTime expirationCardDate)
        {
            this.PostulantID = postulantID;
            this.CardDate = cardDate;
            this.ExpirationCardDate = expirationCardDate;
        }

        /// <summary>
        /// Insert an instance of Card into database
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
                string query = "INSERT INTO cards(PostulantId, CardDate, ExpirationCardDate) VALUES (@postulantId, @cardDate, @expirationCardDate);";
                conn.Open();

                MySqlCommand insertCommand = new MySqlCommand(query, conn);
                insertCommand.Parameters.AddWithValue("@postulantId", this.PostulantID);
                insertCommand.Parameters.AddWithValue("@cardDate", this.CardDate);
                insertCommand.Parameters.AddWithValue("@expirationCardDate", this.ExpirationCardDate);
                affectedRows = insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to insert card into database:\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return (affectedRows > 0);
        }

    }
}
