using System.Windows.Forms;

namespace SPPBC.M3Tools
{

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

        public DialogResult ShowDialog()
        {
            return RecipientSelection.ShowDialog();
        }
    }
}