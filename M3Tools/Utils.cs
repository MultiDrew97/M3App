using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	// FIXME: Figure out how to combine the Utils of both projects
	//			- Combine in one file?
	//			- Merge somehow like extending the class?
	/// <summary>
	/// General utils struct for general application function.
	/// Was made partial to encourage extending the struct for other potential uses
	/// </summary>
	public readonly partial struct Utils
	{
		/// <summary>
		/// The location where the file to update the app is downloaded to
		/// </summary>
		public static string UpdateSaveLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", $"{Application.ProductName}.exe");

		/// <summary>
		/// The location where the current user's settings are stored
		/// </summary>
		public static string UserLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);

		private static ProcessStartInfo UpdateProcess => new(UpdateSaveLocation, "/qn") { CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden/*, UseShellExecute = true*/ };

		// TODO: Move this logic to a service instead so that the app can update itself autonomously
		/// <summary>
		/// Whether an update is available for the application
		/// </summary>
		public static async Task<bool> UpdateAvailable()
		{
			string text = await new HttpClient().GetStringAsync(Properties.Resources.VERSION_URI);
			Debug.WriteLine($"Received version text: {text.Trim()}", "Updating");

			Debug.WriteLine("Checking if update available...", "Updating");
			Version current = new(Application.ProductVersion);
			Version latest = new(text.Trim());

			Debug.WriteLine($"Current Version: {current}", "Updating");
			Debug.WriteLine($"Latest Version: {latest}", "Updating");
			return current < latest;
		}

		/// <summary>
		/// Update the application
		/// </summary>
		/// <returns></returns>
		public static async Task<bool> Update(bool confirm = true)
		{
			if (confirm)
			{
				DialogResult confirmed = MessageBox.Show($"Would you like to update the application right now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (confirmed != DialogResult.Yes)
				{
					throw new OperationCanceledException();
				}
			}

			// Perform update procedures here
			HttpClient httpClient = new();

			using HttpResponseMessage response = await httpClient.GetAsync(Properties.Resources.UDPATE_LOCATION);

			Debug.WriteLine("File has been retrieved. Starting to download...");
			_ = response.EnsureSuccessStatusCode(); // Ensure the request was successful
			byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

			// Save file to disk
			File.WriteAllBytes(UpdateSaveLocation, fileBytes);

			Console.WriteLine($"File downloaded successfully to {UpdateSaveLocation}");

			Console.WriteLine("Starting update client...");

			Application.Exit();

			Process updateProc = Process.Start(UpdateProcess);

			updateProc.WaitForExit();

			if (File.Exists(UpdateSaveLocation))
				File.Delete(UpdateSaveLocation);

			return updateProc.ExitCode switch
			{
				_ => true
			};

		}

		/// <summary>
		/// Dictionary of states to sift through for state code conversions
		/// </summary>
		public static readonly System.Collections.Generic.Dictionary<string, string> States = new(comparer: StringComparer.OrdinalIgnoreCase)
		{
			// TODO: Find better way to do this
			{ "AL", "Alabama" },
			{ "AK", "Alaska" },
			{ "AZ","Arizona" },
				{ "AR","Arkansas"
},
{ "CA",  "California"
},
				{ "CO", "Colorado"
},
				{ "CT", "Connecticut"
},
				{ "DE",  "Delaware"
},
				{ "FL",  "Florida"
},
				{ "GA", "Georgia"
},
				{ "HI", "Hawaii"
},
				{ "ID",  "Idaho"
},
				{ "IL", "Illinois"
},
				{ "IN",  "Indiana"
},
				{ "IA",  "Iowa"
},
				{ "KS", "Kansas"
},
				{ "KY", "Kentucky"
},
				{ "LA", "Louisiana"
},
				{ "ME", "Maine"
},
				{ "MD", "Maryland"
},
				{ "MA", "Massachusetts"
},
				{ "MI", "Michigan"
},
				{ "MN", "Minnesota"
},
				{ "MS", "Mississippi"
},
				{ "MO", "Missouri"
},
				{ "MT", "Montana"
},
				{ "NE",  "Nebraska"
},
				{ "NV", "Nevada"
},
				{ "NH", "New Hampshire"
},
				{ "NJ", "New Jersey"
},
				{ "NM", "New Mexico"
},
				{ "NY", "New York"
},
				{ "NC", "North Carolina"
},
				{ "ND", "North Dakota"
},
				{ "OH", "Ohio"
},
				{ "OK", "Oklahoma"
},
				{ "OR", "Oregon"
},
				{ "PA", "Pennsylvania"
},
				{ "RI", "Rhode Island"
},
				{ "SC", "South Carolina"
},
				{ "SD", "South Dakota"
},
				{ "TN",  "Tennessee"
},
				{ "TX",  "Texas"
},
				{ "UT", "Utah"
},
				{ "VT", "Vermont"
},
				{ "VA", "Virginia"
},
				{ "WA", "Washington"
},
				{ "WV", "West Virginia"
},
				{ "WI", "Wisconsin"
},
				{ "WY", "Wyoming"
},

			};

		/// <summary>
		/// Parses for a file's default upload name
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public static string DefaultFileName(string fileName) => fileName.Split(@"\\".ToCharArray())[fileName.Split(@"\\".ToCharArray()).Length - 1].Split(".".ToCharArray())[0] + " " + System.DateTime.UtcNow.ToString("MM/dd/yyyy");

		/// <summary>
		/// Waits for executions for a given amount of seconds
		/// </summary>
		/// <param name="seconds">The number of seconds to wait. Defaults to 5 seconds.</param>
		public static void Wait(int seconds = 5)
		{
			// found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

			for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
			{
				System.Threading.Thread.Sleep(10);
				Application.DoEvents();
			}
		}

		/// <summary>
		/// Converts 2 character state code to it's full state name
		/// </summary>
		/// <param name="stateCode"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static string StateCodeToState(string stateCode)
		{
			try
			{
				return States[stateCode.Trim()];
			}
			catch
			{
				throw new ArgumentException($"'{stateCode}' not a valid state code");
			}
		}

		/// <summary>
		/// Converts a state's full name to it's 2 character state code
		/// </summary>
		/// <param name="state"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static string StateToStateCode(string state)
		{
			foreach (System.Collections.Generic.KeyValuePair<string, string> statePair in States)
			{
				if (StringComparer.OrdinalIgnoreCase.Compare(state, statePair.Value) != 0)
				{ continue; }

				return statePair.Key;
			}

			throw new ArgumentException($"'{state}' not a valid state");
		}

		/// <summary>
		/// Checks whether the provided value is a valid email address
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public static bool ValidEmail(string email)
		{
			try
			{
				return System.Text.RegularExpressions.Regex.IsMatch(email, Properties.Resources.EmailRegex2);
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Checks whether the provided value is a valid database entry ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static bool ValidID(int id) => id >= 1;

		/// <summary>
		/// Tries to cast the provided value as an instance of a DateTime object
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static DateTime TryDateCast(object value)
		{
			try
			{
				return Conversions.ToDate(value);
			}
			catch
			{
				return default;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="title"></param>
		/// <param name="value"></param>
		public static void PrintConsole(string title, object value)
		{
			Console.WriteLine($"------------------------ {title} ------------------------");
			Console.WriteLine(value);
			Console.WriteLine($"---------------------------------------------------------");
		}
	}
}
