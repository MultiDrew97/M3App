using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class CustomEmailDialog
    {
        private CustomEmail Email
        {
            get
            {
                return ce_Email;
            }
        }

        public string Subject
        {
            get
            {
                return Email.Subject;
            }
        }

        public string Body
        {
            get
            {
                return Email.Body;
            }
        }

        private string RTBody
        {
            get
            {
                return Email.RichTextBody;
            }
        }

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
