using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace SPPBC.M3Tools
{

    public partial class ListenerSelectionDialog
    {

		/// <summary>
		/// The current selection of recipients
		/// </summary>
		[Browsable(false)]
	    public Types.ListenerCollection Selection
        {
            get
            {
				return ldg_Listeners.SelectedListeners;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public ListenerSelectionDialog(Types.ListenerCollection listeners)
        {
            InitializeComponent();

			bsListeners.DataSource = listeners;
        }


        private void ConfirmSelection(object sender, EventArgs e)
        {
            if (Selection.Count < 1)
            {
                MessageBox.Show("You didn't select a listener. If you wish to cancel, please click the cancel button", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			bsListeners.Filter = filter;
		}
	}
}
