using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// A dialog box for adding new listeners to the ministry
	/// </summary>
	public partial class AddListenerDialog
	{
		/// <summary>
		/// The name of the new listener
		/// </summary>
		public string ListenerName
		{
			get => gi_Name.Text;
			set => gi_Name.Text = value;
		}

		/// <summary>
		/// The email of the new listener
		/// </summary>
		public string ListenerEmail
		{
			get => gi_Email.Text;
			set => gi_Email.Text = value;
		}

		/// <summary>
		/// The new listener
		/// </summary>
		public Types.Listener Listener => new(-1, ListenerName, ListenerEmail);

		/// <summary>
		/// 
		/// </summary>
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
			DialogResult res = MessageBox.Show("Are you sure you want to cancel listener creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

			return !string.IsNullOrWhiteSpace(ListenerEmail) && Regex.IsMatch(ListenerEmail, Properties.Resources.EmailRegex2);
		}
	}
}
