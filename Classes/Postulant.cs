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
    internal class Postulant
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DocumentType { get; set; }
        public int Document { get; set; }
        public DateTime InscriptionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool HealthCert {  get; set; }
        public bool IsActive { get; set; }

		#region Database methods

		/// <summary>
		/// Selects all the records existing in postulants table without filtering
		/// </summary>
		/// <returns>
		/// A list of Postulants instances
		/// </returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal static List<Postulant> SelectAllForDisplay()
        {
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
			List<Postulant> postulant = new();

			try
			{
				string query = "SELECT * FROM postulants;";

				conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);

				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					postulant.Add(Postulant.PostulantFromReader(reader));
				}

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Cannot execute select all from postulants:\n{ex.Message}");
			}
			finally
			{
				conn.Close();
			}


			return postulant;
		}

        /// <summary>
        /// Selects a single record from postulants table filtering by document
        /// </summary>
        /// <param name="document"></param>
        /// <returns>
        /// The instance of Postulant if record was found, null otherwise
        /// </returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal static Postulant? SelectFromDocument(int document)
        {
			MySqlConnection conn = Connection.GetInstance().CreateConnection();
            Postulant? postulant = null;

			try
            {
				string query = "SELECT * FROM postulants WHERE Document = @document";

                conn.Open();
				MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@document", document);

				MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    postulant = Postulant.PostulantFromReader(reader);
                }

			}
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Cannot execute select from postulants:\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            

            return postulant;
        }

        /// <summary>
        /// Updates a record in database that corresponds to the current instance of the Postulant class
        /// </summary>
        /// <returns>
        /// True if update was successful, false otherwise
        /// </returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal bool Update()
        {

            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            int affected = 0;

            try
            {
                string query = "UPDATE postulants SET isActive = 1 WHERE Document = @Document;";

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Document", this.Document);

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
		/// Creates an instance of Postulant from a reader, reading a single record from said object
		/// </summary>
		/// <param name="reader"></param>
		/// <returns>
		/// The instance of current class
		/// </returns>
		static Postulant PostulantFromReader(MySqlDataReader reader)
		{
			Postulant post = new Postulant();

			post.ID = reader.GetInt16("ID");
			post.FirstName = reader.GetString("FirstName");
			post.LastName = reader.GetString("LastName");
			post.DocumentType = reader.GetString("DocumentType");
			post.Document = reader.GetInt32("Document");
			post.InscriptionDate = reader.GetDateTime("InscriptionDate");
			post.ExpirationDate = reader.GetDateTime("ExpirationDate");
			post.HealthCert = reader.GetBoolean("HealthCert");
			post.IsActive = reader.GetBoolean("IsActive");

			return post;
		}

		#endregion

	}
}
