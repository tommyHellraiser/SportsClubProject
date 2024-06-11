using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportsClubProject.Forms
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        public string? name;
        public string? lastName;
        public int? postulantId;
        public string? docType;
        public int? document;

        /// <summary>
        /// Executes custom code on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardForm_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblLstName.Text = lastName;
            lblNMember.Text = Convert.ToString(postulantId);
            lblDocType.Text = docType;
            lblDoc.Text = Convert.ToString(document);
            lblDate.Text = DateTime.UtcNow.ToShortDateString();
            lblDateExp.Text = DateTime.UtcNow.AddYears(1).ToShortDateString();
        }

		/// <summary>
		/// Shows the CardForm form with custom content
		/// </summary>
		/// <param name="o"></param>
		/// <param name="e"></param>
		private void printForm(object o, PrintPageEventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            Rectangle bounds = new Rectangle(0, 0, width, height);
            Bitmap img = new Bitmap(width, height);
            this.DrawToBitmap(img, bounds);

            float scaleFactor = 0.8f;

            int scaledWidth = (int)(width * scaleFactor);
            int scaledHeight = (int)(height * scaleFactor);

            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            int x = (pageWidth - scaledWidth) / 2;
            int y = (pageHeight - scaledHeight) / 2;

            e.Graphics.DrawImage(img, new Rectangle(x, y, scaledWidth, scaledHeight));
        }

		#region Handlers

		private void btnPrint_Click(object sender, EventArgs e)
		{
			btnPrint.Visible = false;
			this.FormBorderStyle = FormBorderStyle.None;
			this.ControlBox = false;
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(printForm);
			pd.Print();
			btnPrint.Visible = true;
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.ControlBox = true;
			MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		#endregion

	}
}
