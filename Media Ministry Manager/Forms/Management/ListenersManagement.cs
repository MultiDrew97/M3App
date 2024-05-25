using System;
using System.ComponentModel;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace M3App
{
	// TODO: Mimic CustomerManagement
	/// <summary>
	/// 
	/// </summary>
	public partial class ListenersManagement
    {
		/// <summary>
		/// 
		/// </summary>
        public ListenersManagement()
        {
            InitializeComponent();

            mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.LISTENERS);

            gt_Email.Authorize(My.Settings.Default.Username);
            gd_Drive.Authorize(My.Settings.Default.Username);

			ldg_Listeners.Reload += new EventHandler(Reload);
			ldg_Listeners.AddListener += new ListenerEventHandler(Add);
			ldg_Listeners.UpdateListener += new ListenerEventHandler(Update);
			ldg_Listeners.RemoveListener += new ListenerEventHandler(Remove);

			ts_Tools.ImportEntries += new EventHandler(Import);
			ts_Tools.SendEmails += new EventHandler(SendEmails);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			bsListeners.Clear();
			foreach (var listener in dbListeners.GetListeners())
				bsListeners.Add(listener);
			ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, ldg_Listeners.Listeners.Count);
			// FIXME: Determine how to no longer need this like before to have the DataGridView actually show the new data
			bsListeners.ResetBindings(false);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void DisplayClosing(object sender, CancelEventArgs e)
        {
            // TODO: Find easier way
            if (sender is null)
            {
                return;
            }

            My.MyProject.Forms.MainForm.Show();
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        protected override void Remove(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
        {
            UseWaitCursor = true;
            dbListeners.RemoveListener(e.Value.Id);
            Reload(sender, e);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        protected override void Add(object sender, EventArgs e)
        {
			using var @add = new SPPBC.M3Tools.Dialogs.AddListenerDialog();

			if (add.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}

            UseWaitCursor = true;
            dbListeners.AddListener(add.Listener);
			SendWelcome(sender, new ListenerEventArgs(add.Listener, EventType.Added));
        }

		private void Import(object sender, EventArgs e)
		{
			using var @import = new SPPBC.M3Tools.Dialogs.ImportListenersDialog();

			if (import.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}

			UseWaitCursor = true;
			foreach (var listener in import.Listeners)
			{
				dbListeners.AddListener(listener);
				SendWelcome(sender, new ListenerEventArgs(listener, EventType.Added));
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			using var @edit = new SPPBC.M3Tools.Dialogs.EditListenerDialog(e.Value);

			if (edit.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}

			UseWaitCursor = true;
			dbListeners.UpdateListener(edit.Listener);
			Reload(sender, e);
		}

		protected override void FilterChanged(object sender, string filter)
		{
			bsListeners.Filter = filter;
		}

		private void SendEmails(object sender, EventArgs e)
		{
			using var emails = new SendEmailsDialog();
			UseWaitCursor = true;
			emails.ShowDialog();
			UseWaitCursor = false;
		}

		private void SendWelcome(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;

            string subject = "Welcome to the Ministry";
            string body = string.Format(My.Resources.Resources.newListener, e.Value.Name.Trim());
			var message = gt_Email.Create(e.Value, subject, body);

#if !DEBUG
			gt_Email.Send(message);
#endif

			Reload(sender, e);
        }
    }
}
