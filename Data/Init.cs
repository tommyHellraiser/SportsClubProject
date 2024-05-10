using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Data
{
	internal class Init
	{
		public Init()
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
	}
}
