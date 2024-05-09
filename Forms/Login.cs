using Org.BouncyCastle.Pqc.Crypto.Lms;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportsClubProject.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable loginTable = new DataTable();
            User newUser = new User(txtUser.Text, "Lopez", txtPass.Text, 5465465, "ml@jaja.com", "Admin", new DateTime(2024, 5, 8));
            loginTable = newUser.LogUser();
            if (loginTable.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
