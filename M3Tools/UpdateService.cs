using System;

namespace SPPBC.M3Tools
{

    public partial class UpdateService
    {
        public UpdateService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Add code here to start your service. This method should set things
            // in motion so your service can do its work.
            if (UpdateAvailable())
            {
                wb_Updater.Url = new Uri(My.Resources.Resources.AppUpdateUri);
            }
        }

        protected override void OnStop()
        {
            // Add code here to perform any tear-down necessary to stop your service.
        }

        private bool UpdateAvailable()
        {
            wb_Updater.Url = new Uri(My.Resources.Resources.LatestAppVersionUri);
            Console.WriteLine(wb_Updater.DocumentText);
            return false;
        }
    }
}