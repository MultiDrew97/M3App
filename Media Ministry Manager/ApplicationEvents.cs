﻿using System;
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
		private static readonly System.ComponentModel.BackgroundWorker bwLoader = new() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
		private static MediaMinistrySplash splash;

		// TODO: Create a timer to show the splash screen for 5 seconds then close and open the application. Opening the application in the background and opening after the thred is over
		// MAYBE: Background worker? Timer?
		[STAThread()]
		[DebuggerHidden()]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static void Main(string[] Args)
		{
			bwLoader.DoWork += LoadApp;
			bwLoader.RunWorkerCompleted += AppLoaded;
			Console.WriteLine(Args);

			//MinimumSplashScreenDisplayTime = 5000;

			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				splash = new MediaMinistrySplash();
				bwLoader.ProgressChanged += splash.UpdateProgress;
				splash.Show();
				bwLoader.RunWorkerAsync(Args);
			} 
			catch (Exception ex)
			{

				MessageBox.Show($"We were unable to start the application. Please reach out to your administrator.\n\nError:\n\t{ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
			}
		}

		private static void LoadApp(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Console.WriteLine("Starting application preamble...");
			System.ComponentModel.BackgroundWorker worker = sender as System.ComponentModel.BackgroundWorker;
			var args = (string[])e.Argument;

			Console.WriteLine($"Arguments passed for background worker: {args}");
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
			worker.ReportProgress(50);

			// FIXME: Use this until I find a better way to do this. Once figured out, revert settings to Application instead of User settings
#if DEBUG
			Settings.Default.BaseUrl = "http://localhost:3000/api";
			Settings.Default.ApiPassword = "password";
			Settings.Default.ApiUsername = "username";
			Settings.Default.Save();
#endif

			worker.ReportProgress(100);
		}

		private static void AppLoaded(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show($"Unable to start application. Please reach out to your administrator.\n\nError:\n\t{e.Error.Message}");
				return;
			}

			if (e.Cancelled)
			{
				Console.WriteLine("Application preamble was canceled from finishing");
				return;
			}

			splash.Close();
			splash.Dispose();
			splash = null;
			
			Console.WriteLine("Application preamble has finished loading. Starting application...");
			Application.Run(new LoginForm());
		}
	}
}
