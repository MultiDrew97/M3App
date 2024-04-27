using System;

namespace SPPBC.M3Tools
{
	// TODO: Make sure to update timer to be an actual amount of time instead of every second
    public partial class UpdateService
    {
		/// <summary>
		/// 
		/// </summary>
        public UpdateService()
        {
            InitializeComponent();
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            // Add code here to start your service. This method should set things
            // in motion so your service can do its work.
            tmr_updateTimer.Start();
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        protected override void OnStop()
        {
            // Add code here to perform any tear-down necessary to stop your service.
			tmr_updateTimer.Stop();
        }

        private bool UpdateAvailable()
        {
            wb_Updater.Url = new Uri(My.Resources.Resources.LatestAppVersionUri);
            Console.WriteLine(wb_Updater.DocumentText);
            return false;
        }

		private void OnTick(object sender, EventArgs e)
		{
			if (!UpdateAvailable())
			{
				return;
			}

			wb_Updater.Url = new Uri(My.Resources.Resources.AppUpdateUri);
		}
	}
}
