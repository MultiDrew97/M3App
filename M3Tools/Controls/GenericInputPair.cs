using System;
using System.ComponentModel;

namespace SPPBC.M3Tools
{

    public partial class GenericInputPair
    {
        public new event EventHandler TextChanged;

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

        public int TextLength
        {
            get
            {
                return txt_Input.TextLength;
            }
        }

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

        [RefreshProperties(RefreshProperties.Repaint)]
        public override string Text
        {
            get
            {
                return (txt_Input.Text ?? "") != (Placeholder ?? "") ? txt_Input.Text : "";
            }
            set
            {
                txt_Input.Text = (value ?? "") != (Placeholder ?? "") && !string.IsNullOrEmpty(value) ? value : Placeholder;
            }
        }

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

        [DefaultValue("Input...")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public string Placeholder { get; set; }

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
            if ((txt_Input.Text ?? "") != (Placeholder ?? ""))
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
