using MySql.Data.MySqlClient;
using SportsClubProject.Classes;
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
                List<Postulant> postulants = Postulant.SelectAllForDisplay();

                if (postulants.Count == 0)
                {
					MessageBox.Show("No hay socios inscriptos");
                    return;
				}

                foreach (Postulant postulant in postulants)
                {
                    int row = dtgvListMemb.Rows.Add();
                    dtgvListMemb.Rows[row].Cells[0].Value = postulant.ID;
                    dtgvListMemb.Rows[row].Cells[1].Value = postulant.FirstName;
                    dtgvListMemb.Rows[row].Cells[2].Value = postulant.LastName;
                    dtgvListMemb.Rows[row].Cells[3].Value = postulant.DocumentType;
                    dtgvListMemb.Rows[row].Cells[4].Value = postulant.Document;
                    dtgvListMemb.Rows[row].Cells[5].Value = postulant.InscriptionDate.ToString("dd-MM-yyyy");
                    dtgvListMemb.Rows[row].Cells[6].Value = postulant.ExpirationDate.ToString("dd-MM-yyyy");
                    dtgvListMemb.Rows[row].Cells[7].Value = postulant.HealthCert ? "SI" : "NO";
                    dtgvListMemb.Rows[row].Cells[8].Value = postulant.IsActive ? "SI" : "NO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                return;
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
