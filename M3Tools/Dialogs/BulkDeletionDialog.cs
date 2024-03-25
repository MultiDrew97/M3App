using System;
using System.Collections;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class BulkDeletionDialog
    {
        private IEnumerable _items;

        public IEnumerable List
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public BulkDeletionDialog()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}