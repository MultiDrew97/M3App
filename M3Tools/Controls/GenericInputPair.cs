using System;
using System.ComponentModel;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class GenericInputPair
    {
		/// <summary>
		/// 
		/// </summary>
        public new event EventHandler TextChanged;

		/// <summary>
		/// The text that should be shown in the label
		/// </summary>
        [DefaultValue("Label1")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public string Label
        {
            get
            {
                return lbl_InputLabel.Text;
            }
            set
            {
                lbl_InputLabel.Text = value;
            }
        }

		/// <summary>
		/// The length of the text in the textbox
		/// </summary>
        public int TextLength
        {
            get
            {
                return txt_Input.TextLength;
            }
        }

		/// <summary>
		/// The mask that should be applied to the textbox
		/// </summary>
        public string Mask
        {
            get
            {
                return txt_Input.Mask;
            }
            set
            {
                txt_Input.Mask = value;
            }
        }

		/// <summary>
		/// Whether to use the password character to obfuscate the text
		/// </summary>
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get
            {
                return txt_Input.UseSystemPasswordChar;
            }
            set
            {
                txt_Input.UseSystemPasswordChar = value;
            }
        }

		/// <summary>
		/// The text within the textbox
		/// </summary>
        [RefreshProperties(RefreshProperties.Repaint)]
        public override string Text
        {
            get
            {
                return txt_Input.Text != Placeholder ? txt_Input.Text : "";
            }
            set
            {
				if (string.IsNullOrEmpty(value) || value == Placeholder)
				{
					txt_Input.Text = Placeholder;
					return;
				}

                txt_Input.Text = value;
            }
        }

		/// <summary>
		/// How the text in the textbox should be aligned
		/// </summary>
        [RefreshProperties(RefreshProperties.Repaint)]
        public System.Windows.Forms.HorizontalAlignment TextAlign
        {
            get
            {
                return txt_Input.TextAlign;
            }
            set
            {
                txt_Input.TextAlign = value;
                Refresh();
            }
        }

		/// <summary>
		/// Whether the textbox is readonly
		/// </summary>
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get
            {
                return txt_Input.ReadOnly;
            }
            set
            {
                txt_Input.ReadOnly = value;
            }
        }

		/// <summary>
		/// The placeholder that should be shown in the textbox when empty
		/// </summary>
        [DefaultValue("Input...")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public string Placeholder { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public GenericInputPair()
        {
            InitializeComponent();
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            // TODO: Potentially move placeholder/color logic here?

            TextChanged?.Invoke(this, e);
        }

        private void InputGotFocus(object sender, EventArgs e)
        {
            if (txt_Input.Text != Placeholder)
            {
                txt_Input.Select(txt_Input.Text.Length, 0);
                txt_Input.ScrollToCaret();
                return;
            }

            txt_Input.Text = "";
            txt_Input.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void InputLostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Input.Text))
            {
                return;
            }

            txt_Input.Text = Placeholder;
            txt_Input.ForeColor = System.Drawing.SystemColors.ControlDark;
        }

        private void Loading(object sender, EventArgs e)
        {
            Text = !string.IsNullOrEmpty(Text) ? Text : Placeholder;
            txt_Input.ForeColor = !string.IsNullOrEmpty(Text) ? System.Drawing.SystemColors.WindowText : System.Drawing.SystemColors.ControlDark;
        }
    }
}
