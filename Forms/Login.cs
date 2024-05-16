using SportsClubProject.Classes;
using System.Data;
using System.Diagnostics;

namespace SportsClubProject.Forms
{
    public partial class Login : Form
    {
        private User? loggedInUser;

        internal User? LoggedInUser
        {
            get => loggedInUser;
            set => loggedInUser = value;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable loginTable = new DataTable();

            //  Get input data to fetch user if data matches
            string inputName = txtUser.Text;
            string inputPass = txtPass.Text;

            try
            {
                //  Save login data in instance
				this.loggedInUser = User.LogUserIn(inputName, inputPass);

                this.Hide();
			}
            catch (Exception ex)
            {
                Debug.WriteLine($"Error logging user in:\n{ex.Message}");
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
