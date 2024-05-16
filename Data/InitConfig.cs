using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Data
{
	internal class InitConfig
	{
		public InitConfig()
		{
			try
			{
				Config.LoadFromJson();

				//	Reset Config.ResetDatabase to false once db reset has been executed
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
				//	Exit application with code -100
				Environment.Exit(-100);
			}
		}
	}
}
