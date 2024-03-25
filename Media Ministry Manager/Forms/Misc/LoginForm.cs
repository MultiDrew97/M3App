using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Exceptions;

namespace MediaMinistry
{

    public partial class LoginForm
    {
        private event BeginLoginEventHandler BeginLogin;

        private delegate void BeginLoginEventHandler();
        private event EndLoginEventHandler EndLogin;

        private delegate void EndLoginEventHandler();

        private string Username
        {
            get
            {
                return lf_Login.Username;
            }
            set
            {
                lf_Login.Username = value;
            }
        }

        private string Password
        {
            get
            {
                return lf_Login.Password;
            }
            set
            {
                lf_Login.Password = value;
            }
        }

        private bool KeepLoggedIn
        {
            get
            {
                return chk_KeepLoggedIn.Checked;
            }
            set
            {
                chk_KeepLoggedIn.Checked = value;
            }
        }

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
            Username = My.MySettingsProperty.Settings.Username;

            if (!My.MySettingsProperty.Settings.KeepLoggedIn)
            {
                Reset();
                return;
            }

            btn_Login.PerformClick();
        }

        private void TimerTicking(object sender, EventArgs e)
        {
            lsd_LoadScreen.LoadText = "Failed to connect to server in time. Please try again or contact system support.";
            lsd_LoadScreen.Closable = true;
            lf_Login.PasswordField.Clear();
        }

        private void Reset()
        {
            KeepLoggedIn = false;
            lf_Login.Clear();
            tss_UserFeedback.Text = "Please enter your log-in information";
            tss_UserFeedback.ForeColor = Color.Black;
            lf_Login.UsernameField.Focus();
        }

        private void SaveSettings(object sender, DoWorkEventArgs e)
        {
            // TODO: Determine better way to handle this
            My.MySettingsProperty.Settings.KeepLoggedIn = !KeepLoggedIn ? My.MySettingsProperty.Settings.KeepLoggedIn : KeepLoggedIn;
            My.MySettingsProperty.Settings.Username = lf_Login.Username ?? My.MySettingsProperty.Settings.Username;
            // FIXME: Prevent this from saving password as plain text
            My.MySettingsProperty.Settings.Password = lf_Login.Password ?? My.MySettingsProperty.Settings.Password;
            My.MySettingsProperty.Settings.Save();
        }

        private void SettingsSaved(object sender, RunWorkerCompletedEventArgs e)
        {
            UseWaitCursor = false;
            Close();
        }

        private void NewUser(object sender, LinkLabelLinkClickedEventArgs e)
        {
			using var create = new CreateAccountDialog();
			if (create.ShowDialog() == DialogResult.OK)
			{
				Reset();
			}
		}

        private void PerformLogin(object sender, EventArgs e)
        {
            try
            {
                BeginLogin?.Invoke();
                My.MySettingsProperty.Settings.User = dbUsers.Login(Username ?? My.MySettingsProperty.Settings.Username, Password ?? My.MySettingsProperty.Settings.Password);

                bw_SaveSettings.RunWorkerAsync();
                My.MyProject.Forms.MainForm.Show();
            }
            catch (RoleException)
            {
                lsd_LoadScreen.ShowError("Only admins can use this application. If this is an error, please contact support");
                lf_Login.ClearPassword();
                lf_Login.Focus("p");
            }
            catch (UsernameException)
            {
                lsd_LoadScreen.ShowError("We couldn't find an account with that username. Please try again or contact support.");
                lf_Login.Clear();
                lf_Login.Focus();
            }
            catch (PasswordException)
            {
                lf_Login.ClearPassword();
                lsd_LoadScreen.ShowError("Incorrect password provided. Please try again or reset your password");
                lf_Login.Focus("p");
            }
            catch (DatabaseException)
            {
                lsd_LoadScreen.ShowError("Unknown database error. Please try again or contact support.");
                lf_Login.ClearPassword();
                lf_Login.Focus("p");
            }
            catch (Exception)
            {
                lsd_LoadScreen.ShowError("Unknown error occurred. Please try again or contact support.");
                lf_Login.ClearPassword();
                lf_Login.Focus("p");
            }
            finally
            {
                EndLogin?.Invoke();
            }
        }

        private void ForgotPassword(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var forgot = new ChangePasswordDialog())
            {
                if (forgot.ShowDialog() == DialogResult.OK)
                {
                    Reset();
                }
            }
        }

        private void CreateAccount(object sender, LinkLabelLinkClickedEventArgs e)
        {
			using var create = new CreateAccountDialog();
			if (create.ShowDialog() == DialogResult.OK)
			{
				Reset();
			}
		}

        private void LoginClosing(object sender, CancelEventArgs e)
        {
			Console.WriteLine("Closing Login form");
            lsd_LoadScreen.Dispose();
        }

        private void LoginBegin()
        {
            lsd_LoadScreen.LoadText = "Attempting to login...";
            lsd_LoadScreen.ShowDialog();
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
