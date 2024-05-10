using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Data
{
	internal class Init
	{
		public Init()
		{
			try
			{
				Config.LoadFromJson();

				//	Reset Config.ResetDatabase to false once reset has been executed
				if (Config.ResetDatabase)
				{
					Connection.ResetDatabase();
					Config.ResetDatabase = false;
					Config.WriteToJson();
				}
			} 
			catch (Exception ex)
			{
				string msg = $"Failed to initialize application:\n{ex.Message}";
				Debug.WriteLine(msg);
				MessageBox.Show(
					msg,
					"Fatal Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				Environment.Exit(-100);
			}
		}
	}
}
