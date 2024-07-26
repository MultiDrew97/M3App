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
		private Types.Listener _original;
		private event EventHandler ListenerChanged;

		/// <summary>
		/// The original info for the listener
		/// </summary>
		public Types.Listener Original
		{
			get => _original;
			private set
			{
				_original = value;
				ListenerName = _original.Name;
				ListenerEmail = _original.Email;
				Text = string.Format(Text, _original.Name);
			}
		}

		/// <summary>
		/// The current listener info
		/// </summary>
		public Types.Listener Listener => new(Original.Id, ListenerName, ListenerEmail);

		/// <summary>
		/// The name of the listener
		/// </summary>
		public string ListenerName
		{
			get => gi_Name.Text;
			private set => gi_Name.Text = value;
		}

		/// <summary>
		/// The email of the listener
		/// </summary>
		public string ListenerEmail
		{
			get => gi_Email.Text;
			private set => gi_Email.Text = value;
		}

		private EditListenerDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="listener"></param>
		public EditListenerDialog(Types.Listener listener) : this()
		{
			// Add any initialization after the InitializeComponent() call.
			Original = listener;
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
	}
}
