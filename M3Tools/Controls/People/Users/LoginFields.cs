using System;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public enum Field
	{
		/// <summary>
		/// The username field
		/// </summary>
		Username,
		/// <summary>
		/// The password field
		/// </summary>
		Password,
		/// <summary>
		/// Both fields
		/// </summary>
		Both
	}

	/// <summary>
	/// 
	/// </summary>
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
                return string.IsNullOrWhiteSpace(uf_Username.Username) ? string.Empty : uf_Username.Username;
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
                return string.IsNullOrWhiteSpace(pf_Password.Password) ? string.Empty : pf_Password.Password;
            }
            set
            {
                pf_Password.Password = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public LoginFields()
        {
            InitializeComponent();
        }

        /// <summary>
	/// 	''' Clears all text from the username and password fields
	/// 	''' </summary>
        public void Clear(Field field = Field.Both)
        {
			switch (field)
			{
				case Field.Username:
					uf_Username.Clear();
					break;
				case Field.Password:
					pf_Password.Clear();
					break;
				default:
					uf_Username.Clear();
					pf_Password.Clear();
					break;
			}
        }

		/// <summary>
		/// Focus on one of the fields
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
        public bool Focus(Field @field = Field.Username)
        {
            switch (@field)
            {
                case Field.Username: return uf_Username.Focus();
                case Field.Password: return pf_Password.Focus();
				case Field.Both:
				default: throw new ArgumentException($"'${field}' is not a valid value");
            }
        }

        private void PasswordGotFocus(object sender, EventArgs e)
        {
            pf_Password.SelectAll();
        }
    }
}
