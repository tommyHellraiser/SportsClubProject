using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SportsClubProject.Data
{
	internal static class Config
	{
		internal static string? Server;
		internal static string? Port;
		internal static string? Database;
		internal static string? User;
		internal static bool ResetDatabase;

		public class JsonConfig
		{
			internal string? Server { get; set; }
			internal string? Port { get; set; }
			internal string? Database { get; set; }
			internal string? DatabaseUser { get; set; }
			//	Field not used at the moment
			//private string? DatabasePass { get; set; }
			internal bool? ResetDatabase { get; set; }

			internal bool IsConfigValid()
			{
				//	If any of the required fields are either null or false, return false (Config is not valid)
				if (this.Server == null || this.Server == "" 
					|| this.Port == null || this.Port == "" 
					|| this.Database == null || this.Database == ""
					|| this.DatabaseUser == null || this.DatabaseUser == ""
					|| this.ResetDatabase == null)
				{
					return false;
				}

				return true;
			}
		}

		internal static void LoadFromJson()
		{
			//	Attempt to load from file
			using (StreamReader reader = new StreamReader("../../../config/config.json"))
			{
				string? json = reader.ReadToEnd();
				if (json == null)
				{
					throw new NullReferenceException("No config.json was found in specified directory");
				}
				JsonConfig? configuration = JsonSerializer.Deserialize<JsonConfig>(json);
				if (configuration == null)
				{
					throw new NullReferenceException("Couldn't load configuration from config.json file");
				}

				if (!configuration.IsConfigValid())
				{
					throw new ArgumentNullException("Some of the fields in configuration json file were null or empty");
				}

				Config.Server = configuration.Server;
				Config.Port = configuration.Port;
				Config.Database = configuration.Database;
				Config.User = configuration.DatabaseUser;
				Config.ResetDatabase = (bool)configuration.ResetDatabase!;
			}
		}

	}
}
