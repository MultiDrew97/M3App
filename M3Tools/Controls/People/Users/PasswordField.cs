using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class PasswordFieldType
    {
        public event EventHandler PasswordGotFocus;
        public event EventHandler PasswordLostFocus;
        public event EventHandler PasswordTextChanged;

        /// <summary>
	/// 	''' Gets or sets the password field
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public string Password
        {
            get
            {
                return txt_Password.Text;
            }
            set
            {
                txt_Password.Text = value;
            }
        }

        /// <summary>
	/// 	''' Gets the length of text in text control.
	/// 	''' </summary>
	/// 	''' <returns>The number of characters contained in the text of the control.</returns>
        public int TextLength
        {
            get
            {
                return txt_Password.TextLength;
            }
        }

        /// <summary>
	/// 	''' Gets whether the field has input focus
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public override bool Focused
        {
            get
            {
                return txt_Password.Focused;
            }
        }

        /// <summary>
	/// 	''' Gets the field for the password control
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public TextBox PasswordField
        {
            get
            {
                return txt_Password;
            }
        }

        public PasswordFieldType()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            // Invert the use system password char property
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            // Switch between password icon image for the button
            btn_Show.Image = txt_Password.UseSystemPasswordChar ? My.Resources.Resources.ShowPasswordIcon : My.Resources.Resources.HidePasswordIcon;
        }

        /// <summary>
	/// 	''' Clears all text from the text box control.
	/// 	''' </summary>
        public void Clear()
        {
            txt_Password.Clear();
        }

        /// <summary>
	/// 	''' Selects a range of text in the text box.
	/// 	''' </summary>
	/// 	''' <param name="start"></param>
	/// 	''' <param name="length"></param>
	/// 	''' <exception cref="ArgumentOutOfRangeException"></exception>
        public void Select(int start, int length)
        {
            txt_Password.Select(start, length);
        }

        /// <summary>
	/// 	''' Selects all text in the text box.
	/// 	''' </summary>
        public void SelectAll()
        {
            // txt_Password.SelectAll()
            Select(0, TextLength);
        }

        public new bool Focus()
        {
            return txt_Password.Focus();
        }

        private void LostPasswordFocus(object sender, EventArgs e)
        {
            PasswordLostFocus?.Invoke(this, e);
        }

        private void PasswordChanged(object sender, EventArgs e)
        {
            PasswordTextChanged?.Invoke(this, e);
        }

        private void PasswordFocused(object sender, EventArgs e)
        {
            PasswordGotFocus?.Invoke(this, new EventArgs());
        }
    }
}
