using SportsClubProject.Classes;
using SportsClubProject.Forms;
using System.Threading;

namespace SportsClubProject
{
    public partial class HomeScreen : Form
    {
        private User loggedInUser;

        public HomeScreen()
        {
            {
                InitializeComponent();

                //	Handles login sequence and ensures a user is logged in
                loggedInUser = handleLogin();
            }
        }

        /// <summary>
        /// Executes the login sequence calling the Login form. Requires that a user is logged in to continue using application
        /// </summary>
        /// <returns></returns>
        private User handleLogin()
        {
            Login login_form = new Login();
            login_form.ShowDialog();

            User? user = login_form.LoggedInUser;

            if (user == null)
            {
                MessageBox.Show(
                    "Se necesita un usuario loggeado para acceder al sistema.\nCerrando la aplicacion...",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Environment.Exit(-5);
            }

            //	If property LoggedInUser is not null, the user was successfully logged in. Close form
            login_form.Close();

            lblUser.Text = $"{user.Username} ({user.UserRole})";

            return user;
        }

        #region Button Handlers

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //	TODO create sign up form and show it
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }

        private void btnListMembers_Click(object sender, EventArgs e)
        {
            ListMembers listMembers = new ListMembers();
            listMembers.ShowDialog();
        }

        private void btnPayCourse_Click(object sender, EventArgs e)
        {
            //	TODO create pay course form and show it
        }

        private void btnSendTicket_Click(object sender, EventArgs e)
        {
            //	TODO create send ticket form and show it
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loggedInUser = handleLogin();
            this.Show();
        }

        #endregion
    }
}
