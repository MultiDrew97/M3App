using System;
using System.ComponentModel;
using System.Windows.Forms;

using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools
{

	public partial class ListenerSelectionDialog
	{
		private readonly ListenerCollection _original;

		/// <summary>
		/// The current selection of recipients
		/// </summary>
		[Browsable(false)]
		public Types.ListenerCollection Selection => ldg_Listeners.SelectedListeners;

		/// <summary>
		/// 
		/// </summary>
		public ListenerSelectionDialog(Types.ListenerCollection listeners)
		{
			InitializeComponent();

			_original = listeners;
			ldg_Listeners.Listeners = ListenerCollection.Cast(_original.Items);
		}

		private void ConfirmSelection(object sender, EventArgs e)
		{
			if (Selection.Count < 1)
			{
				_ = MessageBox.Show("You didn't select a listener. If you wish to cancel, please click the cancel button", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FilterChanged(object sender, string filter)
		{
			_original.Filter = filter;
			ldg_Listeners.Listeners = ListenerCollection.Cast(_original.Items);
		}
	}
}
