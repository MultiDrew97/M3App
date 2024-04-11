using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class ToolsContextMenu
    {
        public event Events.RefreshViewEventHandler RefreshView;

        public event Events.RemoveRowsEventHandler RemoveRows;

        public event Events.SendEmailsEventHandler SendEmails;

        public event Events.EditSelectedEventHandler EditSelected;


        public ToolsContextMenu()
        {
            InitializeComponent();
        }

        private void RemoveRowByToolStrip(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            RemoveRows?.Invoke();
        }

        private void Reload(object sender, EventArgs e)
        {
            RefreshView?.Invoke(Parent, e);
        }

        private void MenuClosed(object sender, EventArgs e)
        {
            ts_Remove.Enabled = false;
        }

        public void ToggleRemove(bool enable)
        {
            ts_Remove.Enabled = enable;
        }

        public void ToggleSend(bool enable)
        {
            if (!ts_Send.Visible)
            {
                return;
            }

            ts_Send.Enabled = enable;
        }

        public void ToggleEdit(bool enable)
        {
            ts_Edit.Enabled = enable;
        }

        private void EmailFunctions(object sender, EventArgs e)
        {
            SendEmails?.Invoke();
        }

        private void EditClicked(object sender, EventArgs e)
        {
            EditSelected?.Invoke();
        }
    }
}
