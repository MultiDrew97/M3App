using System;
using System.Windows.Forms;

// TODO: Create a base class for these edit dialogs and other components I use for easier updating

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// A dialog for editing the info of a listener
	/// </summary>
    public partial class EditListenerDialog
    {
        private event EventHandler ListenerChanged;

		/// <summary>
		/// The original info for the listener
		/// </summary>
        public Types.Listener Original { get; private set; }

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

		private EditListenerDialog()
		{
			InitializeComponent();

			ListenerChanged += new EventHandler(ListenerUpdated);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="listener"></param>
        public EditListenerDialog(Types.Listener listener) : this()
        {
            // Add any initialization after the InitializeComponent() call.
            Original = listener;
            ListenerChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FinishDialog(object sender, EventArgs e)
        {
            if (Listener == Original)
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

        private void ListenerUpdated(object sender, EventArgs e)
        {
            ListenerName = Original.Name;
            ListenerEmail = Original.Email;
			Text = string.Format(Text, Original.Name);
        }
    }
}
