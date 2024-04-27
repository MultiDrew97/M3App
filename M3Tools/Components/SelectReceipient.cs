using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	/// <summary>
	/// 
	/// </summary>
    public partial class SelectReceipient
    {
        private ReciepientSelection __dialog;

        private ReciepientSelection RecipientSelection
        {
            get
            {
                if (__dialog is null)
                {
                    __dialog = new ReciepientSelection();
                }
                else if (__dialog.IsDisposed)
                {
                    __dialog = new ReciepientSelection();
                }

                return __dialog;
            }
        }

		/// <summary>
		/// Shows the selection dialog
		/// </summary>
		/// <returns></returns>
        public DialogResult ShowDialog()
        {
            return RecipientSelection.ShowDialog();
        }
    }
}
