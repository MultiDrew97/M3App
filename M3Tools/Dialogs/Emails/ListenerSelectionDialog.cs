using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class ListenerSelectionDialog
    {

		/// <summary>
		/// The current selection of recipients
		/// </summary>
		[System.ComponentModel.Browsable(false)]
	    public Types.ListenerCollection Selection
        {
            get
            {
                return (Types.ListenerCollection)ldg_Listeners.SelectedRows;
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
    }
}
