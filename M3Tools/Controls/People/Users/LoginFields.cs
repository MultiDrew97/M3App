using System;

namespace SPPBC.M3Tools
{
    public partial class LoginFields
    {
        /// <summary>
    /// Gets or sets the username
    /// </summary>
    /// <returns></returns>
        public string Username
        {
            get
            {
                return string.IsNullOrWhiteSpace(uf_Username.Username) ? null : uf_Username.Username;
            }
            set
            {
                uf_Username.Username = value;
            }
        }

        /// <summary>
    /// Gets or sets the password
    /// </summary>
    /// <returns></returns>
        public string Password
        {
            get
            {
                return string.IsNullOrWhiteSpace(pf_Password.Password) ? null : pf_Password.Password;
            }
            set
            {
                pf_Password.Password = value;
            }
        }

        public UsernameField UsernameField
        {
            get
            {
                return uf_Username;
            }
        }

        public PasswordFieldType PasswordField
        {
            get
            {
                return pf_Password;
            }
        }

        public LoginFields()
        {
            InitializeComponent();
        }

        /// <summary>
	/// 	''' Clears all text from the username and password fields
	/// 	''' </summary>
        public void Clear()
        {
            ClearUsername();
            ClearPassword();
        }

        public void ClearUsername()
        {
            uf_Username.Clear();
        }

        public void ClearPassword()
        {
            pf_Password.Clear();
        }

        public new bool Focus(string @field = "u")
        {
            switch (@field ?? "")
            {
                case "u":
                    {
                        return UsernameField.Focus();
                    }
                case "p":
                    {
                        return PasswordField.Focus();
                    }
            }

            return default;
        }

        private void PasswordGotFocus(object sender, EventArgs e)
        {
            PasswordField.SelectAll();
        }
    }
}
