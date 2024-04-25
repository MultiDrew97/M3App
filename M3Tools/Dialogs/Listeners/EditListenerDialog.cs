using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// A dialog for editing the info of a listener
	/// </summary>
    public partial class EditListenerDialog
    {
        private event ListenerChangedEventHandler ListenerChanged;

        private delegate void ListenerChangedEventHandler();
        // Private _newInfo As Types.Listener

		/// <summary>
		/// The original info for the listener
		/// </summary>
        public Types.Listener Original { get; set; }

		/// <summary>
		/// The current listener info
		/// </summary>
        public Types.Listener Listener
        {
            get
            {
                return new Types.Listener(Original.Id, ListenerName, ListenerEmail);
            }
        }

		/// <summary>
		/// The name of the listener
		/// </summary>
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

		/// <summary>
		/// The email of the listener
		/// </summary>
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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="listener"></param>
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
