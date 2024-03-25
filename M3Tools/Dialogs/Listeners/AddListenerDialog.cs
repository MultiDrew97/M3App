using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
    public partial class AddListenerDialog
    {

        public event Events.Listeners.ListenerEventHandler ListenerAdded;

        public string ListenerName
        {
            get
            {
                return gi_Name.Text;
            }
            set
            {
                gi_Name.Text = value;
            }
        }

        public string ListenerEmail
        {
            get
            {
                return gi_Email.Text;
            }
            set
            {
                gi_Email.Text = value;
            }
        }

        public Types.Listener Listener
        {
            get
            {
                return new Types.Listener(-1, ListenerName, ListenerEmail);
            }
        }

        public AddListenerDialog()
        {
            InitializeComponent();
        }

        private void AddListener(object sender, EventArgs e)
        {
            if (!ValidInputs())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to cancel listener creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidInputs()
        {
            if (string.IsNullOrWhiteSpace(ListenerName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(ListenerEmail) || !Regex.IsMatch(ListenerEmail, My.Resources.Resources.EmailRegex2))
            {
                return false;
            }

            return true;
        }
    }
}