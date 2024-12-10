using System;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class MediaMinistrySplash
	{
		private readonly string VERSION_FORMAT = "Version {0}.{1:00}.{2} Rev. {3}";
		private string Version { set => lbl_Version.Text = value; }
		private string Copyright { set => lbl_Copyright.Text = value; }

		/// <summary>
		/// 
		/// </summary>
		public MediaMinistrySplash() => InitializeComponent();

		private void SplashLoading(object sender, EventArgs e)
		{
			// Set up the dialog text at runtime according to the application's assembly information.

			// Customize the application's assembly information in the "Application" pane of the project
			// properties dialog (under the "Project" menu).

			// Format the version information using the text set into the Version control at design time as the
			// formatting String.This allows for effective localization if desired.
			// Build And revision information could be included by using the following code And changing the
			// Version Control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
			// String.Format() In Help For more information.

			Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

			// Version info
			Version = string.Format(VERSION_FORMAT, version.Major, version.Minor, version.Build, version.Revision);

			// Copyright info
			Copyright = ((System.Reflection.AssemblyCopyrightAttribute)System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCopyrightAttribute), false)[0]).Copyright;//My.MyProject.Application.Info.Copyright;
		}

		internal void UpdateProgress(int progress)
		{
			if (!progressBar1.Visible)
				progressBar1.Visible = true;

			Console.WriteLine($"Updating displayed load progress: {progress}");
			progressBar1.Value = progress;
		}
	}
}
