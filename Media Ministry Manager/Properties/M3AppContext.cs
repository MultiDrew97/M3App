using System;
using System.Windows.Forms;

namespace M3App
{
	// The following events are available for MyApplication:
	// Startup: Raised when the application starts, before the startup form is created.
	// Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	// UnhandledException: Raised if the application encounters an unhandled exception.
	// StartupNextInstance: Raised when launching a single-instance application and the application is already active.
	// NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	internal partial class M3AppContext : ApplicationContext
	{
		private readonly MediaMinistrySplash splash = new();
		private readonly Timer timer = new() { Interval = int.Parse(Properties.Resources.SPLASH_TIMER) * 1000 };

		public M3AppContext()
		{
			splash.Show();
			timer.Start();
			timer.Tick += ShowApplication;
		}

		private void ShowApplication(object sender, EventArgs e)
		{
			LoadApp(new string[] { });
			timer.Stop();
			splash.Close();
			splash.Dispose();
			MainForm = new LoginForm();
			MainForm.Show();
		}

		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0)
			{
				// TODO: Figure out how to no longer need this
				return;
			}

			base.OnMainFormClosed(sender, e);
		}

		protected override void ExitThreadCore()
		{
			// Perform any application clean up that may be necessary
			base.ExitThreadCore();
		}

		private void LoadApp(string[] args)
		{
			Console.WriteLine("Checking for previous settings...");
			if (Properties.Settings.Default.UpgradeRequired)
			{
				try
				{
					// Bring in the settings from previous version
					Console.WriteLine("Previous settings found. Importing previous settings...");
					Properties.Settings.Default.KeepLoggedIn = false;
					Properties.Settings.Default.Upgrade();
					Properties.Settings.Default.UpgradeRequired = false;
					Properties.Settings.Default.Save();
				}
				catch
				{
					Console.WriteLine("Unable to import previous settings. Using defaults");
				}
			}

			splash.UpdateProgress(50);

			// FIXME: Use this until I find a better way to do this. Once figured out, revert settings to Application instead of User settings
#if DEBUG
			Console.WriteLine("DEBUG: Changing API settings for debug settings");
			Properties.Settings.Default.BaseUrl = "http://localhost:3000/api";
			Properties.Settings.Default.ApiPassword = "password";
			Properties.Settings.Default.ApiUsername = "username";
			Properties.Settings.Default.Save();
#endif

			Console.WriteLine("Application preamble has finished. Starting application...");
			splash.UpdateProgress(100);
		}
	}
}
