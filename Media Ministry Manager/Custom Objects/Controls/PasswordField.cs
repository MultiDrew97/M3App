using System;

namespace M3App
{
	public partial class PasswordField
	{
		public PasswordField() => InitializeComponent();
		private void BtnShow_Click(object sender, EventArgs e)
		{
			btnShow.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.Hide_Password : (System.Drawing.Image)Properties.Resources.Show_Password;

			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
		}
	}
}
