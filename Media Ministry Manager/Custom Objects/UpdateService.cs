using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;

using SPPBC.M3Tools;

namespace M3App
{
	// TODO: Make sure to update timer to be an actual amount of time instead of every second
	public partial class UpdateService
	{
		/// <summary>
		/// 
		/// </summary>
		public UpdateService() => InitializeComponent();

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="args"></param>
		protected override void OnStart(string[] args)
		{
			// Add code here to start your service. This method should set things
			// in motion so your service can do its work.
			Console.WriteLine("Starting M3App updating service...");
			tmr_updateTimer.Start();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected override void OnStop()
		{
			// Add code here to perform any tear-down necessary to stop your service.
			Console.WriteLine("Stopping M3App updating service...");
			tmr_updateTimer.Stop();
		}

		private async void OnTick(object sender, EventArgs e)
		{
			// Perform update procedures here
			if (!Utils.UpdateAvailable)
			{
				return;
			}

			HttpClient httpClient = new();
			string UpdateSaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", "M3AppSetup.exe");

			using HttpResponseMessage response = await httpClient.GetAsync(Properties.Resources.UPDATE_LOCATION);

			Debug.WriteLine("File has been retrieved. Starting to download...");
			_ = response.EnsureSuccessStatusCode(); // Ensure the request was successful
			byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

			// Save file to disk
			File.WriteAllBytes(UpdateSaveLocation, fileBytes);

			Console.WriteLine("File downloaded successfully to " + UpdateSaveLocation);

			Console.WriteLine("Starting update client...");
			_ = Process.Start(UpdateSaveLocation);
			//Application.Exit();
		}
	}
}
