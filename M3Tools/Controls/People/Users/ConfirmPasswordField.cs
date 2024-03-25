using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class ConfirmPasswordField
    {
        public event EventHandler ConfirmLostFocus;
        public event EventHandler ConfirmTextChanged;
        public new string Text
        {
            get
            {
                return txt_ConfirmPassword.Text;
            }
            set
            {
                txt_ConfirmPassword.Text = value;
            }
        }

        /// <summary>
    /// Gets the length of text in text control.
    /// </summary>
    /// <returns>The number of characters contained in the text of the control.</returns>
        public int TextLength
        {
            get
            {
                return txt_ConfirmPassword.TextLength;
            }
        }

        public override bool Focused
        {
            get
            {
                return txt_ConfirmPassword.Focused;
            }
        }

        public TextBox ConfirmField
        {
            get
            {
                return txt_ConfirmPassword;
            }
        }

        public ConfirmPasswordField()
        {
            InitializeComponent();
        }


        private void Btn_Show_Click(object sender, EventArgs e)
        {
            // Switch between password icon image for the button
            btn_Show.Image = txt_ConfirmPassword.UseSystemPasswordChar ? My.Resources.Resources.HidePasswordIcon : My.Resources.Resources.ShowPasswordIcon;

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
        public new void Select(int start, int length)
        {
            txt_ConfirmPassword.Select(start, length);
        }

        /// <summary>
	/// 	''' Selects all text in the text box.
	/// 	''' </summary>
        public new void SelectAll()
        {
            txt_ConfirmPassword.SelectAll();
            // txtPassword.Select(0, TextLength)
        }

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
