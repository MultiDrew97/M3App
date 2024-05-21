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
			ldg_Listeners.AddListener += new ListenerEventHandler(AddListener);
			ldg_Listeners.UpdateListener += new ListenerEventHandler(UpdateListener);
			ldg_Listeners.RemoveListener += new ListenerEventHandler(RemoveListener);

			mms_Main.AddListener += new ListenerEventHandler(AddListener);

			ts_Tools.AddEntry += new EventHandler(AddListener);
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

        private void SendEmails(object sender, EventArgs e)
        {
			using var emails = new SendEmailsDialog();
			UseWaitCursor = true;
			emails.ShowDialog();
			UseWaitCursor = false;
		}

        private void RemoveListener(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
        {
            UseWaitCursor = true;
            dbListeners.RemoveListener(e.Value.Id);
            Reload(sender, e);
        }

        private void AddListener(object sender, EventArgs e)
        {
			using var @add = new SPPBC.M3Tools.Dialogs.AddListenerDialog();

			if (add.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}

            UseWaitCursor = true;
            dbListeners.AddListener(add.Listener);
			SendWelcome(sender, new ListenerEventArgs(add.Listener, SPPBC.M3Tools.Events.EventType.Added));
        }

        private void SendWelcome(object sender, ListenerEventArgs e)
        {
            UseWaitCursor = true;
#if !DEBUG
            string subject = "Welcome to the Ministry";
            string body = string.Format(My.Resources.Resources.newListener, e.Listener.Name.Trim());
			var message = gt_Email.Create(e.Listener, subject, body);
			gt_Email.Send(message);
#endif
			Reload(sender, e);
        }

        private void UpdateListener(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
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
    }
}
