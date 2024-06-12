using SportsClubProject.Classes;
using System.Drawing.Printing;

namespace SportsClubProject.Forms
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        public string? fullName;
        public string? formPay;
        public int? postulantId;
        public int document;
        public float amount;
        public DateTime date;
        
        
        private void printForm (object o, PrintPageEventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            Rectangle bounds = new Rectangle(0, 0, width, height);
            Bitmap img = new Bitmap(width, height);
            this.DrawToBitmap(img, bounds);

            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            int x = (pageWidth - width) / 2;
            int y = (pageHeight - height) / 2;

            Point p = new Point(x, y);
            e.Graphics.DrawImage(img, p);
        }

        /// <summary>
        /// Creates an instance of the Bill class from a Postulant class, a payment method and the paid amount
        /// </summary>
        /// <param name="post"></param>
        /// <param name="paymentMethod"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        internal static Bill FromPostulant(Postulant post, string paymentMethod, float amount)
        {
            Bill bill = new Bill();

            bill.fullName = $"{post.FirstName} {post.LastName}";
            bill.formPay = paymentMethod;
            bill.postulantId = post.ID;
            bill.document = post.Document;
            bill.amount = amount;
            //  Set date of user's inscription and add a timespan of NOW hours from midnight
            bill.date = post.InscriptionDate + DateTime.Now.TimeOfDay;

            return bill;
        }

		/// <summary>
		/// Creates an instance of the Bill class from a NonPostulant class, a payment method and the paid amount
		/// </summary>
		/// <param name="post"></param>
		/// <param name="paymentMethod"></param>
		/// <param name="amount"></param>
		/// <returns></returns>
		internal static Bill FromNonPostulant(NonPostulant post, string paymentMethod, float amount)
		{
			Bill bill = new Bill();

			bill.fullName = $"{post.FirstName} {post.LastName}";
			bill.formPay = paymentMethod;
            bill.document = post.Document;
			bill.amount = amount;
			bill.date = (DateTime)post.VisitDateTime!;

			return bill;
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
		private void Bill_Load(object sender, EventArgs e)
		{
			lblDateToday.Text = DateTime.UtcNow.ToShortDateString();
			lblNameInBill.Text = fullName;
			lblStartDate.Text = Convert.ToString(date);
			lblAmount.Text = Convert.ToString(amount);
			lblFormPay.Text = formPay;
		}

		#endregion

	}
}
