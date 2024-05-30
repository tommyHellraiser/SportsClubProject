using MySql.Data.MySqlClient;
using SportsClubProject.Classes;
using SportsClubProject.Data;
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
        public int postulantId;
        public float amount;
        public DateTime date;
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


        private void Bill_Load(object sender, EventArgs e)
        {
            lblDateToday.Text = DateTime.UtcNow.ToShortDateString();
            lblNameInBill.Text = fullName;
            lblStartDate.Text = Convert.ToString(date);
            lblAmount.Text = Convert.ToString(amount);
            lblFormPay.Text = formPay;
        }

        internal static Bill FromPostulant(Postulant post, string paymentMethod, float amount)
        {
            Bill bill = new Bill();

            bill.fullName = $"{post.FirstName} {post.LastName}";
            bill.formPay = paymentMethod;
            bill.postulantId = post.ID;
            bill.amount = amount;
            bill.date = post.InscriptionDate;

            return bill;
        }
    }
}
