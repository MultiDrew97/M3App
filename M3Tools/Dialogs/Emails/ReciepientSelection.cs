using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class ReciepientSelection
    {

        public Types.DBEntryCollection<Types.Listener> Selection
        {
            get
            {
                return (Types.DBEntryCollection<Types.Listener>)ldg_Listeners.SelectedListeners;
            }
        }

        public BindingSource DataSource
        {
            get
            {
                return ldg_Listeners.DataSource;
            }
            set
            {
                ldg_Listeners.DataSource = value;
            }
        }

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