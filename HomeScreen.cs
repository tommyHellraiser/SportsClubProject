namespace SportsClubProject
{
	public partial class HomeScreen : Form
	{
		public HomeScreen(string userName, string lastName, string email,
			DateTime birthday, string phone, string role)
		{
			InitializeComponent();
			lblWelcome.Text = $"Bienvenido/a {userName}";
			lblName.Text = $"Nombre: {userName}";
			lblLastName.Text = $"Apellido: {lastName}";
			lblPhone.Text = $"Telefono: {phone}";
			lblEmail.Text = $"Email: {email}";
            lblBirthday.Text = $"Fecha de nac.: {birthday.ToString("dd/MM/yyyy")}";
            lblRole.Text = $"Rol: {role}";
        }
	}
}
