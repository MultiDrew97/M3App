using System;

namespace SPPBC.M3Tools
{

	public partial class ConfirmPasswordField
	{
		/// <summary>
		/// The event that occurs when the confirm field has lost focus
		/// </summary>
		public event EventHandler ConfirmLostFocus;

		/// <summary>
		/// The event that occurs when the confirm field has been changed
		/// </summary>
		public event EventHandler ConfirmTextChanged;

		/// <summary>
		/// The value of the confirm field
		/// </summary>
		public new string Text
		{
			get => txt_ConfirmPassword.Text;
			set => txt_ConfirmPassword.Text = value;
		}

		/// <summary>
		/// Gets the length of text in text control.
		/// </summary>
		/// <returns>The number of characters contained in the text of the control.</returns>
		public int TextLength => txt_ConfirmPassword.TextLength;

		/// <summary>
		/// Whether the control is focused
		/// </summary>
		public override bool Focused => txt_ConfirmPassword.Focused;

		/// <summary>
		/// 
		/// </summary>
		public ConfirmPasswordField()
		{
			InitializeComponent();
		}

		private void Btn_Show_Click(object sender, EventArgs e)
		{
			// Switch between password icon image for the button
			btn_Show.Image = txt_ConfirmPassword.UseSystemPasswordChar ? Properties.Resources.HidePasswordIcon : Properties.Resources.ShowPasswordIcon;

			// Invert the use system password char property
			txt_ConfirmPassword.UseSystemPasswordChar = !txt_ConfirmPassword.UseSystemPasswordChar;
		}

		/// <summary>
		/// 	''' Clears all text from the text box control.
		/// 	''' </summary>
		public void Clear()
		{
			txt_ConfirmPassword.Clear();
		}

		/// <summary>
		/// 	''' Selects a range of text in the text box.
		/// 	''' </summary>
		/// 	''' <param name="start"></param>
		/// 	''' <param name="length"></param>
		/// 	''' <exception cref="ArgumentOutOfRangeException"></exception>
		public void Select(int start, int length)
		{
			txt_ConfirmPassword.Select(start, length);
		}

		/// <summary>
		/// 	''' Selects all text in the text box.
		/// 	''' </summary>
		public void SelectAll()
		{
			txt_ConfirmPassword.SelectAll();
			// txtPassword.Select(0, TextLength)
		}

		/// <summary>
		/// Focus on the confirm field
		/// </summary>
		/// <returns></returns>
		public new bool Focus()
		{
			return txt_ConfirmPassword.Focus();
		}

		private void Txt_ConfirmPassword_LostFocus(object sender, EventArgs e)
		{
			ConfirmLostFocus?.Invoke(this, e);
		}

		private void Txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
		{
			ConfirmTextChanged?.Invoke(this, e);
		}
	}
}
