using System;
using System.ComponentModel;
using System.Windows.Forms;
using SPPBC.M3Tools.Types.Extensions;

// TODO: Make this have all the RTF functionality, then create a seperate view in the body selector dialog to display the RTF in HTML for 'debugging'

namespace SPPBC.M3Tools
{
	/// <summary>
	/// Holds the information for a custom email that is being sent
	/// </summary>
    public partial class CustomEmail
    {
		private readonly System.Drawing.Color _placeholderColor = System.Drawing.SystemColors.ControlDark;
		private readonly System.Drawing.Color _normalColor = System.Drawing.SystemColors.WindowText;
		private string _subjectPlaceholder = "Subject...";
		private string _bodyPlaceholder = "Body...";

        private struct Shortcuts
        {
            public static string Bold = "Bold";
            public static string Underline = "Underline";
            public static string Italics = "Italics";
        }

		/// <summary>
		/// 
		/// </summary>
		[DefaultValue("Subject...")]
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Design")]
		public string SubejctPlaceholder
		{
			get => _subjectPlaceholder;
			set => _subjectPlaceholder = value;
		}

		/// <summary>
		/// The subject of the email
		/// </summary>
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Email")]
		public string Subject
        {
            get
            {
				if (txt_Subject.Text == _subjectPlaceholder) return string.Empty;

                return txt_Subject.Text;
            }
			set
			{
				if (value == _bodyPlaceholder) txt_Subject.ForeColor = _placeholderColor;
				else txt_Subject.ForeColor = _normalColor;

				txt_Subject.Text = value;
			}
        }

		/// <summary>
		/// The placeholder to use for the body control
		/// </summary>
		[DefaultValue("Body...")]
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Design")]
		public string BodyPlaceholder
		{
			get => _bodyPlaceholder;
			set => _bodyPlaceholder = value;
		}

		/// <summary>
		/// The body of the email in Rich-Text form
		/// </summary>
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Email")]
		public string Body
        {
            get
            {
				if (rtb_Body.Text == _bodyPlaceholder) return string.Empty;
                return rtb_Body.Rtf.FromRtfToHtml();
            }
			set 
			{
				if (value == _bodyPlaceholder) rtb_Body.ForeColor = _placeholderColor;
				else rtb_Body.ForeColor = _normalColor;

				rtb_Body.Text = value;
			}
        }

		/// <summary>
		/// 
		/// </summary>
        public CustomEmail()
        {
            InitializeComponent();

			rtb_Body.KeyDown += BodyShortcutPressed;
        }

		private void BodyShortcutPressed(object sender, KeyEventArgs e)
		{
			if (!e.Control) return;

			if (e.KeyCode == Keys.B)
			{
				BoldText(sender, EventArgs.Empty);
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.I)
			{
				ItalicizeText(sender, EventArgs.Empty);
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.U)
			{
				UnderlineText(sender, EventArgs.Empty);
				e.SuppressKeyPress = true;
			}
		}

		private void BoldText(object sender, EventArgs e)
        {
            rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, rtb_Body.SelectionFont.Style ^ System.Drawing.FontStyle.Bold);
			btn_Bold.Checked = rtb_Body.SelectionFont.Bold;
        }

        private void UnderlineText(object sender, EventArgs e)
        {
			rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, rtb_Body.SelectionFont.Style ^ System.Drawing.FontStyle.Underline);
			btn_Underline.Checked = rtb_Body.SelectionFont.Underline;
        }

        private void ItalicizeText(object sender, EventArgs e)
        {
			rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, rtb_Body.SelectionFont.Style ^ System.Drawing.FontStyle.Italic);
			btn_Italics.Checked = rtb_Body.SelectionFont.Italic;
		}

        private void Loading(object sender, EventArgs e)
        {            
			Subject = _subjectPlaceholder;
			Body = _bodyPlaceholder;
		}

        private void TextGotFocus(object sender, EventArgs e)
        {
			Control txtBox = sender as Control;
            string placeholder = txtBox.Name == "txt_Subject" ? _subjectPlaceholder : _bodyPlaceholder;

            if (txtBox.Text != placeholder)
            {
				// No actual text present
                return;
            }

            txtBox.Text = "";
            txtBox.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void TextLostFocus(object sender, EventArgs e)
        {
            Control txtBox = sender as Control;
            string placeholder = txtBox.Name == "txt_Subject" ? _subjectPlaceholder : _bodyPlaceholder;

            if (!string.IsNullOrEmpty(txtBox.Text))
            {
				// Actual text present
                return;
            }

			txtBox.Text = placeholder;
			txtBox.ForeColor = System.Drawing.SystemColors.ControlDark;
        }
	}
}
