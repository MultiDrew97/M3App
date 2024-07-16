using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class ChangePasswordDialog
    {
		/// <summary>
		/// 
		/// </summary>
        public ChangePasswordDialog()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            // Reset the user's password
            using (var login = new LoginDialog())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    db_Users.ChangePassword(login.Username, login.Password, pf_Password.Password);
                }
            }

            // TODO: How to ensure you don't reset someone else's password
            // TODO: Create a token system; Create a 2FA type deal
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
