using MySql.Data.MySqlClient;
using SportsClubProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubProject.Forms
{
    public partial class ListMembers : Form
    {
        public ListMembers()
        {
            InitializeComponent();
        }

        private void ListMembers_Load(object sender, EventArgs e)
        {
            // Call the method LoadGrid()
            LoadGrid();
        }

        private void LoadGrid()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string query;
                conn = Connection.GetInstance().CreateConnection();
                query = "select FirstName, LastName, DocumentType, Document, " +
                    "InscriptionDate, ExpirationDate from postulants";
                MySqlCommand cm = new MySqlCommand(query, conn);
                cm.CommandType = CommandType.Text;
                conn.Open();

                MySqlDataReader reader = cm.ExecuteReader();
                if(reader.HasRows) 
                {
                    while(reader.Read())
                    {
                        int row = dtgvListMemb.Rows.Add();
                        dtgvListMemb.Rows[row].Cells[0].Value = reader.GetString(0);
                        dtgvListMemb.Rows[row].Cells[1].Value = reader.GetString(1);
                        dtgvListMemb.Rows[row].Cells[2].Value = reader.GetString(2);
                        dtgvListMemb.Rows[row].Cells[3].Value = reader.GetInt32(3).ToString();
                        dtgvListMemb.Rows[row].Cells[4].Value = reader.GetDateTime(4).ToString("dd-MM-yyyy");
                        dtgvListMemb.Rows[row].Cells[5].Value = reader.GetDateTime(5).ToString("dd-MM-yyyy");
                    }
                }
                else
                {
                    MessageBox.Show("No hay usuarios inscriptos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
