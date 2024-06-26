using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// The dialog for creating a new email
	/// </summary>
    public partial class CustomEmailDialog
    {
        private CustomEmail Email
        {
            get
            {
                return ce_Email;
            }
        }

		/// <summary>
		/// The subject of the email
		/// </summary>
        public string Subject
        {
            get
            {
                return Email.Subject;
            }
        }

		/// <summary>
		/// The body of the email
		/// </summary>
        public string TextBody
        {
            get
            {
                return Email.Body;
            }
        }

        private string HtmlBody
        {
            get
            {

                return Email.Html;
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public CustomEmailDialog()
        {
            InitializeComponent();
        }

        private void FinishedCustom(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelCustom(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
