using SportsClubProject.Classes;
using System.Data;

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
            //  Create User object only from username and password to allow db select
            User newUser = new User(txtUser.Text, txtPass.Text);
            loginTable = newUser.LogUser();
            if (loginTable.Rows.Count > 0)
            {
                string? userName = loginTable.Rows[0]["NameUser"].ToString();
                string? lastName = loginTable.Rows[0]["LastName"].ToString();
                string? email = loginTable.Rows[0]["Email"].ToString();
                DateTime birthday = Convert.ToDateTime(loginTable.Rows[0]["Birthday"]);
                string? phone = loginTable.Rows[0]["Phone"].ToString();
                string? role = loginTable.Rows[0]["NameRole"].ToString();
         
                if (userName != null && lastName!=null && email != null 
                    && phone != null && role != null)
                {
                    Form homeScreen = new HomeScreen(userName, lastName, email,
                        birthday, phone, role);
                    homeScreen.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
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
