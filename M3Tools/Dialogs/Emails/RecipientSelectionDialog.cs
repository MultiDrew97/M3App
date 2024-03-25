using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class RecipientSelectionDialog
    {
        private ReciepientSelection _dialog;

        private ReciepientSelection Dialog
        {
            get
            {
                if (_dialog is null)
                {
                    _dialog = new ReciepientSelection() { DataSource = bsListeners };
                }

                return _dialog;
            }
        }

        public Types.DBEntryCollection<Types.Listener> List
        {
            get
            {
                return _dialog.Selection;
            }
        }

        // Public Property DataSource As BindingSource
        // Get
        // Return Dialog.DataSource
        // End Get
        // Set(value As BindingSource)
        // Dialog.DataSource = value
        // End Set
        // End Property

        public DialogResult ShowDialog(Types.DBEntryCollection<Types.Listener> list)
        {
            bsListeners.Clear();
            foreach (var item in list)
                bsListeners.Add(item);
            return Dialog.ShowDialog();
        }
    }
}