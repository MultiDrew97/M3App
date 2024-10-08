using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPPBC.M3Tools.Types.Extensions;

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
		private readonly Timer timer = new() { Interval = (int)TimeSpan.FromSeconds(int.Parse(Properties.Resources.SPLASH_TIMER)).TotalMilliseconds };

		public M3AppContext()
		{
#if !DEBUG
			splash.Show();
			timer.Tick += ShowApplication;
			timer.Start();
#else
			ShowApplication(this, EventArgs.Empty);
#endif
		}

		private async void ShowApplication(object sender, EventArgs e)
		{
			timer.Stop();
			try
			{
				if (!await LoadApp())
					return;

				MainForm = new LoginForm();
				MainForm.Show();
			}
			finally
			{
				splash.Close();
				splash.Dispose();
			}
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

		protected override void ExitThreadCore() =>
			// Perform any application clean up that may be necessary
			base.ExitThreadCore();

		private async Task<bool> LoadApp()
		{
			Debug.WriteLine("Application preamble has begun...");
			splash.UpdateProgress(0);

			// TODO: Perform any startup/loading logic here
#if DEBUG
			Environment.SetEnvironmentVariable("api_base_url", "http://localhost:3000".Encrypt());
			Environment.SetEnvironmentVariable("api_username", "username".Encrypt());
			Environment.SetEnvironmentVariable("api_password", "password".Encrypt());
#else
			Environment.SetEnvironmentVariable("api_base_url", "https://sppbc.herbivore.site".Encrypt());
			Environment.SetEnvironmentVariable("api_username", "Preachy2034".Encrypt());
			Environment.SetEnvironmentVariable("api_password", "Wz^8Ne3f3jnkX#456BTd^$#mJqBE!G".Encrypt());
#endif

			// TODO: Allow this to be done with a service instead
			if (Properties.Settings.Default.UpdateOnStart && await Utils.UpdateAvailable())
			{
				try
				{
					return !await Utils.Update();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error downloading file: " + ex.Message);
				}
				finally
				{
					if (File.Exists(Utils.UpdateSaveLocation))
						File.Delete(Utils.UpdateSaveLocation);
				}

			}

			splash.UpdateProgress(50);

			Debug.WriteLine("Application preamble has finished. Starting application...");
			splash.UpdateProgress(100);
			return true;
		}
	}
}
