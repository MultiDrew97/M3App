using System;

namespace M3App
{
    public partial class PasswordField
    {
        public PasswordField()
        {
            InitializeComponent();
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                btnShow.Image = Properties.Resources.HidePasswordIcon;
            }
            else
            {
                btnShow.Image = Properties.Resources.ShowPasswordIcon;
            }

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
