using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
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

		private string UpdateSaveLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", "M3AppSetup.exe");

		public M3AppContext()
		{
#if DEBUG
			ShowApplication(this, EventArgs.Empty);
#else
			splash.Show();
			timer.Start();
			timer.Tick += ShowApplication;
#endif
		}

		private void ShowApplication(object sender, EventArgs e)
		{
			try
			{
				if (!LoadApp().Result)
					return;

				MainForm = new LoginForm();
				MainForm.Show();
			}
			finally
			{
				timer.Stop();
				splash.Close();
				splash.Dispose();
			}
		}

		private bool UpdateAvailable
		{
			get
			{
				using HttpClient httpClient = new();

				string text = httpClient.GetStringAsync(Properties.Resources.VERSION_FILE).Result;
				string newText = text.Trim().Replace("\r", "").Split('\n')[1];
				Debug.WriteLine($"Received version text: {newText}", "Updating");

				Debug.WriteLine("Checking if update available...");
				Version current = new(Application.ProductVersion);
				Version latest = new(newText);

				return current < latest;
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
			Environment.SetEnvironmentVariable("api_base_url", "http://localhost:3000");
			Environment.SetEnvironmentVariable("api_username", "username");
			Environment.SetEnvironmentVariable("api_password", "password");

			// TODO: Allow this to be done with a service instead
			if (Properties.Settings.Default.UpdateOnStart && UpdateAvailable)
			{
				try
				{
					return !await UpdateApplication();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error downloading file: " + ex.Message);
				}
				finally
				{
					if (File.Exists(UpdateSaveLocation))
						File.Delete(UpdateSaveLocation);
				}

			}

			splash.UpdateProgress(50);

			Debug.WriteLine("Application preamble has finished. Starting application...");
			splash.UpdateProgress(100);
			return true;
		}

		private async Task<bool> UpdateApplication()
		{
			// Perform update procedures here
			HttpClient httpClient = new();

			using HttpResponseMessage response = await httpClient.GetAsync(Properties.Resources.UPDATE_LOCATION);

			Debug.WriteLine("File has been retrieved. Starting to download...");
			_ = response.EnsureSuccessStatusCode(); // Ensure the request was successful
			byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

			// Save file to disk
			File.WriteAllBytes(UpdateSaveLocation, fileBytes);

			Console.WriteLine("File downloaded successfully to " + UpdateSaveLocation);

			Console.WriteLine("Starting update client...");
			_ = Process.Start(UpdateSaveLocation);
			Application.Exit();

			return true;
		}
	}

}
