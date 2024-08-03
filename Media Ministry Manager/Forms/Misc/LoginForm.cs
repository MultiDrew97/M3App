using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Exceptions;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LoginForm
	{
		private event BeginLoginEventHandler BeginLogin;

		private delegate void BeginLoginEventHandler();
		private event EndLoginEventHandler EndLogin;

		private delegate void EndLoginEventHandler();

		private string Username
		{
			get => lf_Login.Username;
			set => lf_Login.Username = value;
		}

		private string Password
		{
			get => lf_Login.Password;
			set => lf_Login.Password = value;
		}

		private bool KeepLoggedIn
		{
			get => chk_KeepLoggedIn.Checked;
			set => chk_KeepLoggedIn.Checked = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();

			Shown += Showing;
			BeginLogin += LoginBegin;
			EndLogin += LoginEnd;
			FormClosing += LoginClosing;
		}

		// TODO: Potentially consolidate these function
		// TODO: Figure out more secure way to store login info
		private void Showing(object sender, EventArgs e)
		{
			// MAYBE: Implement a token system to verify logins instead of crendentials
			if (!Properties.Settings.Default.KeepLoggedIn)
			{
				Reset();
				return;
			}

			Username = Properties.Settings.Default.Username;
			Password = Properties.Settings.Default.Password;
#if !DEBUG
			KeepLoggedIn = Properties.Settings.Default.KeepLoggedIn;
#endif

			btn_Login.PerformClick();
		}

		private void TimerTicking(object sender, EventArgs e)
		{
			lsd_LoadScreen.LoadText = "Failed to connect to server in time. Please try again or contact system support.";
			lsd_LoadScreen.Closable = true;
			lf_Login.Clear(SPPBC.M3Tools.Field.Password);
		}

		private void Reset()
		{
			KeepLoggedIn = false;
			lf_Login.Clear();
			tss_UserFeedback.Text = "Please enter your log-in information";
			tss_UserFeedback.ForeColor = Color.Black;
			_ = lf_Login.Focus();
		}

		private void SaveSettings(object sender, DoWorkEventArgs e)
		{
			// TODO: Determine better way to handle this
			Properties.Settings.Default.KeepLoggedIn = KeepLoggedIn;
			Properties.Settings.Default.Save();
		}

		private void SettingsSaved(object sender, RunWorkerCompletedEventArgs e)
		{
			UseWaitCursor = false;
			Utils.OpenForm(typeof(MainForm));
			Close();
		}

		private void NewUser(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using CreateAccountDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
				return;

			Reset();
		}

		private void PerformLogin(object sender, EventArgs e)
		{
			try
			{
				BeginLogin?.Invoke();
				SPPBC.M3Tools.Types.User user = dbUsers.Login(Username, Password);

				if (KeepLoggedIn)
				{
					Properties.Settings.Default.User = user;
				}

				bw_SaveSettings.RunWorkerAsync();
			}
			catch (RoleException)
			{
				lsd_LoadScreen.ShowError("Only admins can use this application. If this is an error, please contact support");
				lf_Login.Clear(SPPBC.M3Tools.Field.Password);
				_ = lf_Login.Focus(SPPBC.M3Tools.Field.Password);
			}
			catch (UsernameException)
			{
				lsd_LoadScreen.ShowError("We couldn't find an account with that username. Please try again or contact support.");
				lf_Login.Clear();
				_ = lf_Login.Focus();
			}
			catch (PasswordException)
			{
				lf_Login.Clear(SPPBC.M3Tools.Field.Password);
				lsd_LoadScreen.ShowError("Incorrect password provided. Please try again or reset your password");
				_ = lf_Login.Focus(SPPBC.M3Tools.Field.Password);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
				lsd_LoadScreen.ShowError($"Login Error Occurred:\n {ex.Message}");
				lf_Login.Clear(SPPBC.M3Tools.Field.Password);
				_ = lf_Login.Focus(SPPBC.M3Tools.Field.Password);
			}
			finally
			{
				EndLogin?.Invoke();
			}
		}

		private void ForgotPassword(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using ChangePasswordDialog forgot = new();

			if (forgot.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			Reset();
		}

		private void CreateAccount(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using CreateAccountDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			Reset();
		}

		private void LoginClosing(object sender, CancelEventArgs e)
		{
			Console.WriteLine("Closing Login form");
			lsd_LoadScreen.Dispose();
		}

		private void LoginBegin()
		{
			lsd_LoadScreen.LoadText = "Attempting to login...";
			_ = lsd_LoadScreen.ShowDialog();
			UseWaitCursor = true;
			Enabled = false;
			Opacity = 50d;
			tmr_LoginTimer.Start();
		}

		private void LoginEnd()
		{
			tmr_LoginTimer.Stop();
			Opacity = 100d;
			Enabled = true;
			UseWaitCursor = false;
			lsd_LoadScreen.Closable = true;
		}
	}
}
