using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class ReciepientSelection
    {

		/// <summary>
		/// The current selection of recipients
		/// </summary>
        public Types.DBEntryCollection<Types.Listener> Selection
        {
            get
            {
                return (Types.DBEntryCollection<Types.Listener>)ldg_Listeners.SelectedRows;
            }
        }

		/// <summary>
		/// The data source for the control
		/// </summary>
        public Data.ListenerBindingSource DataSource
        {
            get
            {
                return ldg_Listeners.DataSource as Data.ListenerBindingSource;
            }
            set
            {
                ldg_Listeners.DataSource = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public ReciepientSelection()
        {
            InitializeComponent();
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
