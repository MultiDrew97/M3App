using System;
using System.Collections.ObjectModel;

namespace MediaMinistry.My
{

    // The following events are available for MyApplication:
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    internal partial class MyApplication
    {

        // Found this code at https://stackoverflow.com/questions/8993685/winform-splash-screen-vb-net-timer to increae
        // the time that the splash screen is on screen to 5000 ms (5 seconds)
        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
            // Me.MinimumSplashScreenDisplayTime = 5000

            // TODO: Use this until I find a better way to do this. Once figured out, revert settings to Application instead of User settings
            /* TODO ERROR: Skipped IfDirectiveTrivia
            #If DEBUG Then
            */
            MySettingsProperty.Settings.BaseUrl = "http://localhost:3000/api";
            MySettingsProperty.Settings.ApiPassword = "password";
            MySettingsProperty.Settings.ApiUsername = "username";
            /* TODO ERROR: Skipped EndIfDirectiveTrivia
            #End If
            */
            // Bring in the settings from previous version
            if (MySettingsProperty.Settings.UpgradeRequired)
            {
                Console.WriteLine("Upgrade required");
                MySettingsProperty.Settings.Upgrade();
                MySettingsProperty.Settings.UpgradeRequired = false;
                MySettingsProperty.Settings.Save();
            }

            // TODO: May have to figure out a way to transfer Google API tokens

            return base.OnInitialize(commandLineArgs);
        }
    }
}