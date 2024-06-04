using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace SportsClubProject.Data
{
	internal static class Config
	{
		internal static string? Server;
		internal static string? Port;
		internal static string? Database;
		internal static string? User;
		internal static string? Pass;
		internal static bool ResetDatabase;
		internal static bool DebugMode;

		public class JsonConfig
		{
			public string? Server { get; set; }
			public string? Port { get; set; }
			public string? Database { get; set; }
			public string? DatabaseUser { get; set; }
			public string? DatabasePass { get; set; }
			public bool? ResetDatabase { get; set; }
			public bool? DebugMode { get; set; }

			public JsonConfig(string? Server, string? Port, string? Database, string? DatabaseUser, string? DatabasePass, bool? ResetDatabase, bool? DebugMode)
			{
				this.Server = Server;
				this.Port = Port;
				this.Database = Database;
				this.DatabaseUser = DatabaseUser;
				this.DatabasePass = DatabasePass;
				this.ResetDatabase = ResetDatabase;
				this.DebugMode = DebugMode;
			}


			internal bool IsConfigValid()
			{
				//	If any of the required fields are either null or false, return false (Config is not valid)
				if (this.Server == null || this.Server == "" 
					|| this.Port == null || this.Port == "" 
					|| this.Database == null || this.Database == ""
					|| this.DatabaseUser == null || this.DatabaseUser == ""
					|| this.ResetDatabase == null
					|| this.DebugMode == null)
				{
					return false;
				}

				return true;
			}
		}

		internal static void LoadFromJson()
		{
			//	Attempt to load from file
			using (StreamReader reader = new StreamReader("../../../Config/config.json"))
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
				Config.Pass = configuration.DatabasePass;
				Config.ResetDatabase = (bool)configuration.ResetDatabase!;
				Config.DebugMode = (bool)configuration.DebugMode!;
			}
		}

		internal static void WriteToJson()
		{
			JsonConfig configuration = new JsonConfig(
				Config.Server!,
				Config.Port!,
				Config.Database!,
				Config.User!,
				Config.Pass!,
				Config.ResetDatabase,
				Config.DebugMode
			);
			
			using StreamWriter writer = new StreamWriter("../../../Config/config.json");
			string config = JsonSerializer.Serialize<JsonConfig>(configuration, new JsonSerializerOptions { MaxDepth = 4, WriteIndented = true });

			writer.Write(config);

			writer.Close();
		}
	}
}
