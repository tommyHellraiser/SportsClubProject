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

				//	TODO continue here

				lblWelcome.Text = $"Bienvenido/a {loggedInUser.Username}";
				lblName.Text = $"Nombre: {loggedInUser.FirstName}";
				lblLastName.Text = $"Apellido: {loggedInUser.LastName}";
				lblPhone.Text = $"Telefono: {loggedInUser.Phone}";
				lblEmail.Text = $"Email: {loggedInUser.Email}";
				lblBirthday.Text = $"Fecha de nac.: {loggedInUser.BirthDate:dd/MM/yyyy}";
				lblRole.Text = $"Rol: {loggedInUser.UserRole}";
			}
		}

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

			return user;
		}
	}
}
