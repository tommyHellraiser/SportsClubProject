using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubProject.Classes
{
	internal class Membership
	{
		internal int ID { get; set; }
		internal int PostulantID { get; set; }
		internal DateTime ExpirationDate { get; set; }
		internal float Amount { get; set; }
		internal bool Paid { get; set; }


		#region Database Methods



		#endregion

	}
}
