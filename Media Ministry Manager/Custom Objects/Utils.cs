using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPPBC.M3Tools.Types;

using static M3App.Properties.Resources;

// FIXME: Figure out how to combine the Utils of both projects
//			- Combine in one file?
//			- Merge somehow like extending the class?
namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public readonly partial struct Utils
	{
		internal static readonly EnvironmentVariableTarget API_VAR_TARGET = EnvironmentVariableTarget.Process;
		/// <summary>
		/// Waits for a certain amount of time. Typically used with Async functions to wait for tasks to complete
		/// </summary>
		/// <param name="seconds">The amount of seconds to wait for</param>
		public static void Wait(int seconds) => SPPBC.M3Tools.Utils.Wait(seconds);

		/// <summary>
		/// 
		/// </summary>
		public static string UserLocation => SPPBC.M3Tools.Utils.UserLocation;

		/// <summary>
		/// Determines if ID value is valid
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static bool ValidID(int id) => SPPBC.M3Tools.Utils.ValidID(id);

		/// <summary>
		/// Whether an update is available for the application
		/// </summary>
		public static Task<bool> UpdateAvailable() => SPPBC.M3Tools.Utils.UpdateAvailable();

		/// <summary>
		/// Update the application
		/// </summary>
		/// <returns></returns>
		public static async Task<bool> Update(bool force = false) => await SPPBC.M3Tools.Utils.Update(force);

		/// <summary>
		/// The list of templates that are part of the application
		/// </summary>
		public static TemplateList Templates => [new("Sermon", SERMON_EMAIL_TEMPLATE, "New Sermon"), new("Receipt", RECEIPT_EMAIL_TEMPLATE, "Bless you")];

		/// <summary>
		/// The location where log files are stored
		/// </summary>
		public static string LOG_LOCATION => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.ProductName);

		/// <summary>
		/// Show an error dialog. Can be set to ask for genuine input if needing to retry action
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <param name="retriable"></param>
		/// <returns></returns>
		public static DialogResult ShowErrorMessage(string subject, string message, bool retriable = false) => SPPBC.M3Tools.Utils.ShowErrorMessage(subject, message, retriable);

		/// <summary>
		/// Attempts to exit the application gracefully. Allowing them to close and handle any straggling tasks
		/// and finish executions if needed.
		/// </summary>
		public static void Exit(CancelEventArgs e = default) => Utils.Exit();

		/// <summary>
		/// Logs the current user out of the application
		/// </summary>
		public static void Logout(Control sender)
		{
			SPPBC.M3Tools.Utils.Logout(sender);
			new LoginForm().Show();
		}

		/// <summary>
		/// Goes through the number of files necessary to keep logs from previous runs
		/// </summary>
		public static void CycleLogs()
		{
			// MAYBE: Figure out a better ext to add to logs files from previous runs
			string cycleTag = ".old";

			if (File.Exists(Path.Combine(LOG_LOCATION, CONSOLE_OUTPUT_FILE)))
				File.Copy(Path.Combine(LOG_LOCATION, CONSOLE_OUTPUT_FILE), Path.Combine(LOG_LOCATION, $"{CONSOLE_OUTPUT_FILE}{cycleTag}"), true);

			if (File.Exists(Path.Combine(LOG_LOCATION, CONSOLE_ERROR_FILE)))
				File.Copy(Path.Combine(LOG_LOCATION, CONSOLE_ERROR_FILE), Path.Combine(LOG_LOCATION, $"{CONSOLE_ERROR_FILE}{cycleTag}"), true);
		}
	}
}