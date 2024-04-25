using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class UsernameField
    {
        public event EventHandler UsernameLostFocus;
        public event EventHandler UsernameTextChanged;
        /// <summary>
    /// Gets the length of text in the username control
    /// </summary>
    /// <returns>The number of characters contained in the text of the control</returns>
        public int TextLength
        {
            get
            {
                return txt_Username.TextLength;
            }
        }

        /// <summary>
	/// 	''' Gets or sets the username entered into the text box
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public string Username
        {
            get
            {
                return txt_Username.Text;
            }
            set
            {
                txt_Username.Text = value;
            }
        }

        /// <summary>
	/// 	''' Gets whether the username field has focus
	/// 	''' </summary>
	/// 	''' <returns></returns>
        public override bool Focused
        {
            get
            {
                return txt_Username.Focused;
            }
        }

        public TextBox ConfirmField
        {
            get
            {
                return txt_Username;
            }
        }

        public UsernameField()
        {
            InitializeComponent();
        }

        /// <summary>
    /// Clears all text from the username text box
    /// </summary>
        public void Clear()
        {
            txt_Username.Clear();
        }

        /// <summary>
    /// Selects a range of text in the username text box
    /// </summary>
    /// <param name="start"></param>
    /// <param name="length"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Select(int start, int length)
        {
            txt_Username.Select(start, length);
        }

        /// <summary>
    /// Selects all text in the username text box
    /// </summary>
        public void SelectAll()
        {
            txt_Username.SelectAll();
        }

        private void Txt_UsernameLostFocus(object sender, EventArgs e)
        {
            UsernameLostFocus?.Invoke(this, e);
        }

        /// <summary>
	/// 	''' Sets input focus to the username text box
	/// 	''' </summary>
	/// 	''' <returns>true if the input focus request was successful; otherwise false</returns>
        public new bool Focus()
        {
            txt_Username.Select();
            return txt_Username.Focus();
        }

        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {
            UsernameTextChanged?.Invoke(this, e);
        }
    }
}
