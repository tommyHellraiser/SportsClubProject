using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        #region Database methods

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

                if (reader.HasRows)
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

        static Postulant PostulantFromReader(MySqlDataReader reader)
        {
            Postulant post = new Postulant();

            reader.Read();
            post.ID = reader.GetInt16("ID");
            post.FirstName = reader.GetString("FirstName");
			post.LastName = reader.GetString("LastName");
			post.DocumentType = reader.GetString("DocumentType");
            post.Document = reader.GetInt32("Document");
            post.InscriptionDate = reader.GetDateTime("InscriptionDate");
			post.ExpirationDate = reader.GetDateTime("ExpirationDate");

            return post;
		}

        #endregion

    }
}
