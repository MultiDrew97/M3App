using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ToolsContextMenu
	{
		/// <summary>
		/// An event fired when the view should be refreshed
		/// </summary>
		public event EventHandler RefreshView;

		/// <summary>
		/// An event fired when an entry should be removed
		/// </summary>
		public event Events.RemoveRowsEventHandler RemoveSelected;

		/// <summary>
		/// An event fired when an email should be sent out
		/// </summary>
		public event Events.SendEmailsEventHandler SendEmails;

		/// <summary>
		/// An event fired when an entry should be editted
		/// </summary>
		public event Events.EditSelectedEventHandler EditSelected;

		/// <summary>
		/// Set whether the remove button is enabled
		/// </summary>
		public bool RemoveEnabled { set => ts_Remove.Enabled = value; }

		/// <summary>
		/// Set whether the send emails button is enabled
		/// </summary>
		public bool SendEnabled { set => ts_Send.Enabled = value; }

		/// <summary>
		/// Set whether the edit button should be enabled
		/// </summary>
		public bool EditEnabled { set => ts_Edit.Enabled = value; }

		/// <summary>
		/// 
		/// </summary>
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

            RemoveSelected?.Invoke();
        }

        private void Reload(object sender, EventArgs e)
        {
            RefreshView?.Invoke(Parent, e);
        }

        private void MenuClosed(object sender, EventArgs e)
        {
            ts_Remove.Enabled = false;
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
