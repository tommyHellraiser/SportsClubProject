using SportsClubProject.Data;
using SportsClubProject.Forms;

namespace SportsClubProject
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			new InitConfig();
			Application.Run(new HomeScreen());
		}
	}
}