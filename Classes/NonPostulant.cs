using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportsClubProject.Classes
{
    internal class NonPostulant : Person
    {
        public int? ID { get; set; }
        public string? DocumentType { get; set; }
        public int Document { get; set; }
        public DateTime? VisitDateTime { get; set; }

        public NonPostulant(string FirstName, string LastName, string DocumentType, int Document)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DocumentType = DocumentType;
            this.Document = Document;
            this.VisitDateTime = DateTime.Now;
        }


        #region Database methods

		/// <summary>
		/// Inserts the current instance of this class into database
		/// </summary>
		/// <returns>
		/// True if insert was successful, false otherwise
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
        internal bool Insert()
        {
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
            int affected = 0;

			try
			{
				string query = "INSERT INTO non_postulants (FirstName, LastName, DocumentType, Document, VisitDateTime) " +
                    "VALUES (@FirstName, @LastName, @DocumentType, @Document, @VisitDateTime);";

				conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);
				command.Parameters.AddWithValue("@FirstName", this.FirstName);
				command.Parameters.AddWithValue("@LastName", this.LastName);
				command.Parameters.AddWithValue("@DocumentType", this.DocumentType);
				command.Parameters.AddWithValue("@Document", this.Document.ToString());
				command.Parameters.AddWithValue("@VisitDateTime", this.VisitDateTime!.ToString());

				affected = command.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Cannot insert new non postulant:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}


			return (affected > 0);
        }

        #endregion

    }
}
