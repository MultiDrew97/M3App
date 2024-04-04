using System;
using System.Globalization;

namespace M3App
{

    public sealed partial class MediaMinistrySplash
    {
        public MediaMinistrySplash()
        {
            InitializeComponent();
        }
        // This form can easily be set as the splash screen for the application by going to the "Application" tab
        // of the Project Designer ("Properties" under the "Project" menu).

        private void SplashLoading(object sender, EventArgs e)
        {
            // Set up the dialog text at runtime according to the application's assembly information.

            // Customize the application's assembly information in the "Application" pane of the project
            // properties dialog (under the "Project" menu).

            // Application title
            // If My.Application.Info.Title <> "" Then
            // ApplicationTitle.Text = My.Application.Info.Title
            // Else
            // 'If the application title is missing, use the application name, without the extension
            // ApplicationTitle.Text = IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            // End If

            // Format the version information using the text set into the Version control at design time as the
            // formatting String.This allows for effective localization if desired.
            // Build And revision information could be included by using the following code And changing the
            // Version Control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
            // String.Format() In Help For more information.

            Version.Text = string.Format(CultureInfo.CurrentCulture, Version.Text, My.MyProject.Application.Info.Version.Major, My.MyProject.Application.Info.Version.Minor, My.MyProject.Application.Info.Version.Build); // , My.Application.Info.Version.Revision)

            // Copyright info
            Copyright.Text = My.MyProject.Application.Info.Copyright;
        }

    }
}