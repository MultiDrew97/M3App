using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Exceptions;
using SPPBC.M3Tools.Types.Extensions;

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

		private CancellationTokenSource _tokenSource;

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

		private bool SaveCredentials
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
		}

		private void LogInFinished(object sender, RunWorkerCompletedEventArgs e)
		{

		}

		// TODO: Potentially consolidate these function
		// TODO: Figure out more secure way to store login info
		private void Showing(object sender, EventArgs e)
		{
#if DEBUG
			Username = "username";
			Password = "password";
			btn_Login.PerformClick();
			return;
#endif
			// MAYBE: Implement a token system to verify logins instead of credentials
			if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("password", EnvironmentVariableTarget.User).Decrypt()))
			{
				Reset();
				return;
			}

			Username = Environment.GetEnvironmentVariable("username", EnvironmentVariableTarget.User);
			Password = Environment.GetEnvironmentVariable("password", EnvironmentVariableTarget.User).Decrypt();

			btn_Login.PerformClick();
		}

		private void Reset()
		{
			_tokenSource?.Cancel();

			SaveCredentials = false;
			lf_Login.Clear();
			tss_UserFeedback.Text = "Please enter your log-in information";
			tss_UserFeedback.ForeColor = Color.Black;
			_ = lf_Login.Focus();
		}

		private void NewUser(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using CreateAccountDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
				return;

			Reset();
		}

		private void UserLoggedIn(object sender, DoWorkEventArgs e)
		{
			Environment.SetEnvironmentVariable("username", Username, EnvironmentVariableTarget.User);

			if (SaveCredentials)
			{
				Environment.SetEnvironmentVariable("password", Password.Encrypt(), EnvironmentVariableTarget.User);
			}
		}

		private async void PerformLogin(object sender, EventArgs e)
		{
			try
			{
				BeginLogin?.Invoke();
				_tokenSource = new();

				_tokenSource.CancelAfter(TimeSpan.FromSeconds(int.Parse(Properties.Resources.LOGIN_TIMEOUT)));
				SPPBC.M3Tools.Types.User user = await dbUsers.Login(Username, Password, _tokenSource.Token);

				if (user.Login.Role != SPPBC.M3Tools.Types.AccountRole.Admin)
				{
					throw new RoleException("User not an admin");
				}

				//backgroundWorker1.RunWorkerAsync(user);

				new MainForm().Show(this);

				//Utils.OpenForm(typeof(MainForm));
				Close();
			}
			catch (RoleException)
			{
				_ = Utils.ShowErrorMessage("Login Error", "Only admins can use this application. If this is an error, please contact support");
				lf_Login.Clear(SPPBC.M3Tools.Field.Password);
				_ = lf_Login.Focus(SPPBC.M3Tools.Field.Password);
			}
			catch (UsernameException)
			{
				_ = Utils.ShowErrorMessage("Login Error", "We couldn't find an account with that username. Please try again or contact support.");
				lf_Login.Clear();
				_ = lf_Login.Focus();
			}
			catch (PasswordException)
			{
				lf_Login.Clear(SPPBC.M3Tools.Field.Password);
				_ = Utils.ShowErrorMessage("Login Error", "Incorrect password provided. Please try again or reset your password");
				_ = lf_Login.Focus(SPPBC.M3Tools.Field.Password);
			}
			catch (OperationCanceledException)
			{
				Console.WriteLine("Login attempt was cancelled");
			}
			catch (Exception ex)
			{
				_ = Utils.ShowErrorMessage("Login Error", $"General Login Error Occurred:\n {ex.Message}");
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
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

		private void LoginBegin()
		{
			UseWaitCursor = pnl_Loading.Visible = true;
			btn_Login.Enabled = false;
			Opacity = 50d;
		}

		private void LoginEnd()
		{
			Opacity = 100d;
			btn_Login.Enabled = true;
			pnl_Loading.Visible = UseWaitCursor = false;
		}

		private void CancelLogin(object sender, EventArgs e) => _tokenSource?.Cancel();
	}
}
