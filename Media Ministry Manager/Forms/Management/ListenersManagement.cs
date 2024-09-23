using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace M3App
{
	/// <summary>
	/// Form for managing email listeners
	/// </summary>
	public partial class ListenerManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public ListenerManagement()
		{
			InitializeComponent();

			gt_Email.Authorize(tokenSource.Token);
			gd_Drive.Authorize(tokenSource.Token);

			ldg_Listeners.Reload += new EventHandler(Reload);
			ldg_Listeners.AddListener += new ListenerEventHandler(Add);
			ldg_Listeners.UpdateListener += new ListenerEventHandler(Update);
			ldg_Listeners.RemoveListener += new ListenerEventHandler(Remove);

			_original = dbListeners.GetListeners();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			ldg_Listeners.Listeners = SPPBC.M3Tools.Types.ListenerCollection.Cast(_original.Items);
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, ldg_Listeners.Listeners.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			UseWaitCursor = true;
			_ = dbListeners.RemoveListener(e.Value.Id);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			using SPPBC.M3Tools.Dialogs.AddListenerDialog @add = new();

			if (add.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			UseWaitCursor = true;
			AddToDB(sender, add.Listener);
			UseWaitCursor = false;
		}

		/// <inheritdoc/>
		protected override void Import(object sender, EventArgs e)
		{
			using SPPBC.M3Tools.Dialogs.ImportListenersDialog @import = new();

			if (import.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			UseWaitCursor = true;
			foreach (SPPBC.M3Tools.Types.Listener listener in import.Listeners)
			{
				AddToDB(sender, listener);
			}

			UseWaitCursor = false;
		}

		private void AddToDB(object sender, SPPBC.M3Tools.Types.Listener listener)
		{
			try
			{
				_ = dbListeners.AddListener(listener);
				SendWelcome(sender, new ListenerEventArgs(listener, EventType.Added));

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Unable to add listener {listener.Name} to database\nError:\n{ex.Message}");
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, DataEventArgs<SPPBC.M3Tools.Types.Listener> e)
		{
			try
			{
				UseWaitCursor = true;
				using SPPBC.M3Tools.Dialogs.EditListenerDialog @edit = new(e.Value);

				if (edit.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				_ = dbListeners.UpdateListener(edit.Listener);
				Reload(sender, e);
			}
			catch
			{
				_ = MessageBox.Show($"We were unable to update the info for {e.Value.Name}");
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		/// <inheritdoc/>
		protected override void FilterChanged(object sender, string filter)
		{
			base.FilterChanged(sender, filter);

			ldg_Listeners.Listeners = SPPBC.M3Tools.Types.ListenerCollection.Cast(_original.Items);
		}

		/// <inheritdoc />
		protected override void SendEmails(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			using SendEmailsDialog emails = new();
			_ = emails.ShowDialog(this);
			UseWaitCursor = false;
		}

		private void SendWelcome(object sender, ListenerEventArgs e)
		{
			UseWaitCursor = true;

#if !DEBUG
			string subject = "Welcome to the Ministry";
			string body = string.Format(Properties.Resources.NEW_LISTENER_EMAIL_TEMPLATE, e.Value.Name.Trim());
			MimeKit.MimeMessage message = gt_Email.Create(e.Value, subject, body);
			gt_Email.Send(message);
#else
			MessageBox.Show($"Listener {e.Value.Name} has been added to the database", "Listener Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif

			Reload(sender, e);
		}
	}
}
