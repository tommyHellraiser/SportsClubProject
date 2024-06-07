using SportsClubProject.Classes;
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
    public partial class DocInput : Form
    {
        public DocInput()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Postulant? postulant = Postulant.SelectFromDocument(Convert.ToInt32(txtDocN.Text));

            if (postulant != null)
            {
                CardForm cardForm = new()
                {
                    name = postulant.FirstName,
                    lastName = postulant.LastName,
                    docType = postulant.DocumentType,
                    document = postulant.Document,
                    postulantId = postulant.ID
                };

                Card card = new Card(postulantID: postulant.ID, cardDate: DateTime.Now, 
                    expirationCardDate: DateTime.Now.AddYears(1));

                // Insert card data in db
                card.Insert();

                this.Hide();
                cardForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El socio no esta inscripto, reintente de nuevo");
            }
        }
    }
}
