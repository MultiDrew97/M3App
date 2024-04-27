using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class LoginDialog
    {
        /// <summary>
	/// 	''' Gets or sets the username
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public string Username
        {
            get
            {
                return LoginFields1.Username;
            }
            set
            {
                LoginFields1.Username = value;
            }
        }

        /// <summary>
	/// 	''' Gets or sets the password
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public string Password
        {
            get
            {
                return LoginFields1.Password;
            }
            set
            {
                LoginFields1.Password = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void SubmitCredentials(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelRequest(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
