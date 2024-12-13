using System;

namespace M3App
{
	// TODO: Make sure to update timer to be an actual amount of time instead of every second
	public partial class UpdateService
	{
		/// <summary>
		/// 
		/// </summary>
		public UpdateService() => InitializeComponent();

		/// <inheritdoc/>
		protected override void OnStart(string[] args)
		{
			// Add code here to start your service. This method should set things
			// in motion so your service can do its work.
			EventLog.WriteEntry("Starting M3App update service...");
			tmr_updateTimer.Start();
		}

		/// <inheritdoc/>
		protected override void OnStop()
		{
			// Add code here to perform any tear-down necessary to stop your service.
			EventLog.WriteEntry("Stopping M3App update service...");
			tmr_updateTimer.Stop();
			base.OnStop();
		}

		/// <inheritdoc/>
		protected override void OnPause()
		{
			EventLog.WriteEntry("Pausing M3App update service...");
			tmr_updateTimer.Stop();
			base.OnPause();
		}

		/// <inheritdoc/>
		protected override void OnContinue()
		{
			EventLog.WriteEntry("Continuing M3App update service...");
			tmr_updateTimer.Start();
			base.OnContinue();
		}

		private void OnTick(object sender, EventArgs e)
		{
			// Check if update available
			/*if (!await Utils.UpdateAvailable())
			{
				Environment.SetEnvironmentVariable("update-available", string.Empty, EnvironmentVariableTarget.Process);
				return;
			}*/

			// TODO: Verify this is accessible in the M3AppContext area from the service
			//Environment.SetEnvironmentVariable("update-available", await Utils.UpdateAvailable() ? UpdateStatus.Available : UpdateStatus.NotAvailable, EnvironmentVariableTarget.Process);
		}
	}
}