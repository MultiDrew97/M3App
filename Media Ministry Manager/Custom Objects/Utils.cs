using System;
using System.Linq;
using System.Windows.Forms;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
    public struct Utils
    {
		[STAThread]
		public static bool OpenForm(Type form, params object[] args)
		{
			try
			{
				var constructor = form.GetConstructor(args.Select(arg => arg.GetType()).ToArray());

				Form tmp = (Form)constructor.Invoke(args);
				tmp.FormClosed += (sender, e) => { if (Application.OpenForms.Count > 0) return; Application.Exit(); };
				tmp.Show();
				//WindowsFormsSynchronizationContext.Current.Post(_ => tmp.Show(), null);
				return true;
			} 
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Waits for a certain amount of time. Typically used with Async functions to wait for tasks to complete
		/// </summary>
		/// <param name="seconds">The amount of seconds to wait for</param>
        public static void Wait(int seconds)
        {
            // found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

            for (int i = 0, loopTo = seconds * 100; i <= loopTo; i++)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

		/// <summary>
		/// Attempts to close all open forms
		/// </summary>
        public static void CloseOpenForms()
        {
            // Close all open windows. Figuring this out will allow me to change from only clearing when primary form closes to when all forms close.
            // improving efficiency in memory management
            int attempts = 0;
			const int MAX_ATTEMPTS = 3;
            do
            {
                try
                {
                    Application.OpenForms[0].Close();
                    attempts = 0;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Form of name {0} falied to close", Application.OpenForms[0].Name);
					MessageBox.Show(ex.Message, "Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempts += 1;
                }
            }
            while (Application.OpenForms.Count > 0 & attempts < MAX_ATTEMPTS);
        }

		/// <summary>
		/// Logs the current user out of the application
		/// </summary>
        public static void LogOff()
        {
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.KeepLoggedIn = false;
            Properties.Settings.Default.Save();
			OpenForm(typeof(LoginForm));
        }
    }
}
