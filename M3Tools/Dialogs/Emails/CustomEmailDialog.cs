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
		/// <summary>
		/// The subject of the email
		/// </summary>
        public string Subject
        {
            get
            {
                return ce_Email.Subject;
            }
        }

        private string Body
        {
            get
            {

                return ce_Email.Body;
            }
        }

		/// <summary>
		/// 
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
