using System;
using System.Collections;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class BulkDeletionDialog
    {
        private IEnumerable _items;

		/// <summary>
		/// The list of items
		/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
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
