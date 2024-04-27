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
                _dialog ??= new ReciepientSelection() { DataSource = (Data.ListenerBindingSource)bsListeners };

                return _dialog;
            }
        }

		/// <summary>
		/// The list of recipients selected
		/// </summary>
        public Types.DBEntryCollection<Types.Listener> List
        {
            get
            {
                return _dialog.Selection;
            }
        }

		/// <summary>
		/// Shows the selection dialog to the user
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
        public DialogResult ShowDialog(Types.DBEntryCollection<Types.Listener> list)
        {
            bsListeners.Clear();
            foreach (var item in list)
                bsListeners.Add(item);
            return Dialog.ShowDialog();
        }
    }
}
