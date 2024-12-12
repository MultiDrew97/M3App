using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
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
		private static readonly string _updateSaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", $"{Application.ProductName}.exe");

		/// <summary>
		/// The location where the current user's settings are stored
		/// </summary>
		public static string UserLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);

		/// <summary>
		/// Show an error dialog. Can be set to ask for genuine input if needing to retry action
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <param name="retriable"></param>
		public static DialogResult ShowErrorMessage(string subject, string message, bool retriable = false) => MessageBox.Show(message, subject, retriable ? MessageBoxButtons.YesNo : MessageBoxButtons.OK, MessageBoxIcon.Error);

		/// <summary>
		/// Attempts to exit the application gracefully. Allowing them to close and handle any straggling tasks
		/// and finish executions if needed.
		/// </summary>
		public static void Exit() => Application.Exit();

		/// <summary>
		/// Logs the current user
		/// </summary>
		public static void Logout(Control sender)
		{
			// TODO: Find a way to speed up the logout process
			//			The Environment variables are taking a long time to actually complete
			sender.UseWaitCursor = true;

			Environment.SetEnvironmentVariable("username", string.Empty, EnvironmentVariableTarget.User);
			Environment.SetEnvironmentVariable("password", string.Empty, EnvironmentVariableTarget.User);

		}

		/// <summary>
		/// Whether an update is available for the application
		/// </summary>
		public static async Task<bool> UpdateAvailable()
		{
			Debug.WriteLine("Checking if update available...", "Updating");

			string text = await new HttpClient().GetStringAsync(Properties.Resources.VERSION_URI);
			Debug.WriteLine($"Received version text: {text.Trim()}", "Updating");

			Version current = new(Application.ProductVersion);
			Version latest = new(text.Trim());

			Console.WriteLine($"Current Version: {current}");
			Console.WriteLine($"Latest Version: {latest}");
			return current < latest;
		}

		/// <summary>
		/// Update the application
		/// </summary>
		public static async Task Update(bool silent = false, bool confirm = true, CancellationToken ct = default)
		{
			try
			{
				ct.ThrowIfCancellationRequested();

				if (!await UpdateAvailable())
				{
					//_ = MessageBox.Show("No updates available", "M3App Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
					throw new OperationCanceledException("No updates available");
				}

				if (confirm)
				{
					DialogResult confirmed = MessageBox.Show($"Would you like to update the application right now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

					if (confirmed != DialogResult.Yes)
						throw new OperationCanceledException();
				}

				// Download update client
				// TODO: See if I can make it complete when the headers are read to speed this up a bit if needed
				using HttpResponseMessage response = await new HttpClient().GetAsync(Properties.Resources.UDPATE_LOCATION, HttpCompletionOption.ResponseContentRead, ct);

				// Ensure the request was successful then Save file to disk
				Console.WriteLine("File has been retrieved. Starting to download...");
				File.WriteAllBytes(_updateSaveLocation, await response.EnsureSuccessStatusCode().Content.ReadAsByteArrayAsync());
				Console.WriteLine($"File downloaded successfully to {_updateSaveLocation}");

				Console.WriteLine("Starting update client...");
				Exit();

				Process.Start(new ProcessStartInfo(_updateSaveLocation)
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					Verb = "runas",
					UseShellExecute = true,
					RedirectStandardOutput = false,
					RedirectStandardError = false,
					// FIXME: Verify this doesn't mess up updating
					ErrorDialog = true,
				}).Exited += new((_, _) =>
				// FIXME: Figure out how to properly start the app back up once installed.
				//			Figure out how to open after install in installer?
				Process.Start(new ProcessStartInfo(Application.ProductName)
				{
					WorkingDirectory = Application.StartupPath
				}));

				//updateProc.Exited += new((_, _) =>
				//// FIXME: Figure out how to properly start the app back up once installed.
				////			Figure out how to open after install in installer?
				//Process.Start(new ProcessStartInfo(Application.ProductName)
				//{
				//	WorkingDirectory = Application.StartupPath
				//}));
			}
			catch (OperationCanceledException ex)
			{
				Console.Error.WriteLine($"Update cancelled. Starting current version - {Application.ProductVersion}...");
				if (silent)
					return;
				_ = MessageBox.Show(ex.Message ?? "Update has been cancelled", "M3App Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exceptions.UpdateException ex)
			{
				Console.Error.WriteLine(ex.InnerException.Message);
				Console.Error.WriteLine(ex.InnerException.StackTrace);
				if (silent)
					return;
				_ = MessageBox.Show("Failed to update application. Please try again or notify your administrator.", "Updates");
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				if (silent)
					return;
				_ = MessageBox.Show($"We were unable to update the application\n\nError:\n{ex.Message}", "M3App", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
					continue;

				Debug.WriteLine($"Found State? {state == statePair.Value}", "Utils");
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
				return !string.IsNullOrEmpty(email) && System.Text.RegularExpressions.Regex.IsMatch(email, Properties.Resources.EMAIL_REGEX_2);
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
