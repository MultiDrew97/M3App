using System;
using System.Linq;
using System.Windows.Forms;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public struct Utils
	{
		/// <summary>
		/// Opens forms of the application, automatically attaching that when the last form is
		/// closed, the application will be exited completely
		/// </summary>
		/// <param name="form"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static void OpenForm(Type form, params object[] args)
		{
			// TODO: Find if there is a better way to handle this
			try
			{
				System.Reflection.ConstructorInfo constructor = form.GetConstructor(args.Select(arg => arg.GetType()).ToArray());

				Form tmp = (Form)constructor.Invoke(args);
				tmp.FormClosed += (sender, e) => { if (Application.OpenForms.Count > 0) { return; } Application.Exit(); };
				tmp.Show();
			}
			catch (Exception ex)
			{
				throw new ApplicationException($"Failed to open form of type {form.Name}.\n\nError:\n{ex.Message}");
			}
		}

		/// <summary>
		/// Waits for a certain amount of time. Typically used with Async functions to wait for tasks to complete
		/// </summary>
		/// <param name="seconds">The amount of seconds to wait for</param>
		public static void Wait(int seconds)
		{
			// found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

			for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
			{
				System.Threading.Thread.Sleep(10);
				// Allows the application thread to continue while waiting
				Application.DoEvents();
			}
		}

		/// <summary>
		/// Attempts to close all open forms gracefully. Allowing them to close and handle any straggling tasks
		/// and finish executions if needed.
		/// </summary>
		public static void CloseApplication()
		{
			int attempts = 0;
			const int MAX_ATTEMPTS = 3;
			do
			{
				try
				{
					Application.OpenForms[0].Close();
					attempts = 0;
				}
				catch (InvalidOperationException ex)
				{
					Console.WriteLine("Form of name {0} falied to close", Application.OpenForms[0].Name);
					_ = MessageBox.Show(ex.Message, "Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					attempts += 1;
				}
			}
			while (Application.OpenForms.Count > 0 & attempts < MAX_ATTEMPTS);
		}

		/// <summary>
		/// Logs the current user out of the application
		/// </summary>
		public static void LogOff()
		{
			Properties.Settings.Default.Username = "";
			Properties.Settings.Default.Password = "";
			Properties.Settings.Default.User = null;
			Properties.Settings.Default.KeepLoggedIn = false;
			Properties.Settings.Default.Save();
			OpenForm(typeof(LoginForm));
		}

		/// <summary>
		/// Determines if ID value is valid
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static bool ValidID(int id) => id > -1;
	}
}
