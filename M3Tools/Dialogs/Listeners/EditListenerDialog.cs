using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
    public partial class EditListenerDialog
    {
        private event ListenerChangedEventHandler ListenerChanged;

        private delegate void ListenerChangedEventHandler();
        // Private _newInfo As Types.Listener

        public Types.Listener Original { get; set; }

        public Types.Listener Listener
        {
            get
            {
                return new Types.Listener(Original.Id, ListenerName, ListenerEmail);
            }
        }

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

        public EditListenerDialog(Types.Listener listener)
        {
            // This call is required by the designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            Original = listener;
            ListenerChanged?.Invoke();
        }

        private void FinishDialog(object sender, EventArgs e)
        {
            if (!ChangeDetected())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelDialog(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ListenerUpdated()
        {
            ListenerName = Original.Name;
            ListenerEmail = Original.Email;
        }

        private bool ChangeDetected()
        {
            if ((ListenerName ?? "") != (Original.Name ?? ""))
            {
                return true;
            }

            if ((ListenerEmail ?? "") != (Original.Email ?? ""))
            {
                return true;
            }

            return false;
        }
    }
}