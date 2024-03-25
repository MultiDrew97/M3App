using System;
using System.Windows.Forms;
using SPPBC.M3Tools;

namespace MediaMinistry.Helpers
{
    public struct Utils
    {
        public static void Wait(int seconds)
        {
            // found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

            for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        public static void CloseOpenForms()
        {
            // Close all open windows. Figuring this out will allow me to change from only clearing when primary form closes to when all forms close.
            // improving efficiency in memory management
            int attempts = 0;
            do
            {
                try
                {
                    My.MyProject.Application.OpenForms[0].Close();
                    attempts = 0;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Form of name {0} falied to close", My.MyProject.Application.OpenForms[0].Name);
                    attempts += 1;
                }
            }
            while (My.MyProject.Application.OpenForms.Count > 0 & attempts < 3);
        }

        public static void LogOff()
        {
            My.MySettingsProperty.Settings.Username = "";
            My.MySettingsProperty.Settings.Password = "";
            My.MySettingsProperty.Settings.KeepLoggedIn = false;
            My.MySettingsProperty.Settings.Save();
            My.MyProject.Forms.LogOnForm.Show();
        }

        public static void SpecialClose(object sender)
        {
            // TODO: Figure out better way to do this
            if (sender is null || sender.GetType() == typeof(MainMenuStrip))
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }
    }
}