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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        public string? fullName;
        public string? formPay;
        public float amount;
        public DateTime date;
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //traer con query amount de payment
        }
    }
}
