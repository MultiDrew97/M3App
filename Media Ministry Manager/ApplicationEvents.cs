using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace M3App
{

    // The following events are available for MyApplication:
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    internal partial class MyApplication : ApplicationContext
    {
		// TODO: Create a timer to show the splash screen for 5 seconds then close and open the application. Opening the application in the background and opening after the thred is over
		// MAYBE: Background worker? Timer?
		[STAThread()]
		[DebuggerHidden()]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static void Main(string[] Args)
		{
			(new MediaMinistrySplash()).Show();
			Console.WriteLine(Args);
			try
			{
				Application.SetCompatibleTextRenderingDefault(true);
			}
			finally
			{
			}
			Application.Run(new LoginForm());
		}

		// Found this code at https://stackoverflow.com/questions/8993685/winform-splash-screen-vb-net-timer to increae
		// the time that the splash screen is on screen to 5000 ms (5 seconds)
		protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
			MinimumSplashScreenDisplayTime = 5000;


			if (Settings.Default.UpgradeRequired)
            {
				// Bring in the settings from previous version
				try
				{
					Console.WriteLine("Upgrade required");
					Settings.Default.KeepLoggedIn = false;
					Settings.Default.Upgrade();
					Settings.Default.UpgradeRequired = false;
					Settings.Default.Save();
				}
				catch
				{
					Console.WriteLine("Unable to import settings");
				}
            }

			// FIXME: Use this until I find a better way to do this. Once figured out, revert settings to Application instead of User settings
#if DEBUG
			Settings.Default.BaseUrl = "http://localhost:3000/api";
			Settings.Default.ApiPassword = "password";
			Settings.Default.ApiUsername = "username";
			Settings.Default.Save();
#endif

            // MAYBE: May have to figure out a way to transfer Google API tokens

            return base.OnInitialize(commandLineArgs);
        }
    }
}
