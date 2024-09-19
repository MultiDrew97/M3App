using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Types.GTools;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SendEmailsDialog
	{
		internal event EventHandler EmailsSent;
		internal event EventHandler EmailsCancelled;

		private readonly EmailDetails details = new();

		private int FileCount => fu_Receipts.Files.Count + gdt_Files.GetSelectedNodes().Count;

		/// <summary>
		/// 
		/// </summary>
		public SendEmailsDialog()
		{
			InitializeComponent();

			EmailsCancelled += new EventHandler(Cancelled);
			EmailsSent += new EventHandler(Sent);

			gmt_Gmail.Authorize();
		}

		private void BeginSending(object sender, EventArgs e)
		{
			btn_Send.Enabled = false;

			if (FileCount > 0)
			{
				// gather files to send
				bw_GatherFiles.RunWorkerAsync();
				return;
			}

			DialogResult res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
			{
				EmailsCancelled?.Invoke(this, e);
				return;
			}

			bw_PrepEmails.RunWorkerAsync();
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			gdt_Files.Reload();
			UseWaitCursor = false;
		}

		private void GatherFiles(object sender, DoWorkEventArgs e)
		{
			foreach (TreeNode node in gdt_Files.GetSelectedNodes())
				details.DriveLinks.Add(new File(node.Name, node.Text));

			foreach (File @file in fu_Receipts.Files)
				details.LocalFiles.Add(@file.Name);
		}

		private void FilesGathered(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is not null)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			bw_GatherReceipients.RunWorkerAsync();
		}

		private void PrepEmails(object sender, DoWorkEventArgs e)
		{
			foreach (File @file in details.DriveLinks)
			{
				details.SendingLinks.Add(string.Format(Properties.Resources.DRIVE_LINK_HTML, string.Format(Properties.Resources.DRIVE_SHARE_LINK_TEMPLATE, @file.Id), @file.Name));
			}
		}

		private void EmailsPrepped(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is not null)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			bw_SendEmails.RunWorkerAsync();
		}

		private void GatherRecipients(object sender, DoWorkEventArgs e)
		{
			using SPPBC.M3Tools.ListenerSelectionDialog recipients = new(dbListeners.GetListeners());

			if (recipients.ShowDialog() != DialogResult.OK)
			{
				e.Cancel = true;
				return;
			}

			details.Recipients = recipients.Selection;
		}

		private void RecipientsGathered(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			// TODO: Make a class or provider of some sort to store and pull the template data for the user
			using EmailBodySelection body = new([new("Sermon", Properties.Resources.SERMON_EMAIL_TEMPLATE, "New Sermon"), new("Receipt", Properties.Resources.RECEIPT_EMAIL, "Bless you")]);

			if (body.ShowDialog() != DialogResult.OK)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			details.EmailContents = body.Content;

			bw_PrepEmails.RunWorkerAsync();
		}

		private void SendEmails(object sender, DoWorkEventArgs e)
		{
			List<MimeKit.MimeMessage> messages = [];
			foreach (Listener listener in details.Recipients)
			{
				string body = string.Format(details.EmailContents.Body, listener.Name, string.Join("<br>", details.SendingLinks));
				messages.Add(gmt_Gmail.CreateWithAttachment(listener, details.EmailContents.Subject, body, details.LocalFiles));
			}

			e.Result = messages;
		}

		private void EmailsDone(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is not null)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			List<MimeKit.MimeMessage> messages = (List<MimeKit.MimeMessage>)e.Result;

			tsp_Progress.Value = 0;
			tsp_Progress.Maximum = messages.Count;
			tsp_Progress.Step = (int)Math.Floor(1d / messages.Count);

			foreach (MimeKit.MimeMessage message in messages)
			{
				_ = gmt_Gmail.Send(message);
				tsp_Progress.PerformStep();
			}

			EmailsSent?.Invoke(this, EventArgs.Empty);
		}

		private void Sent(object sender, EventArgs e)
		{
			btn_Send.Enabled = true;
			_ = MessageBox.Show("Emails have been sent", "Send Emails", MessageBoxButtons.OK, MessageBoxIcon.Information);
			tsp_Progress.Value = 0;
		}

		private void Cancelled(object sender, EventArgs e)
		{
			btn_Send.Enabled = true;
			_ = MessageBox.Show("Unsent emails have been cancelled", "Send Emails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			tsp_Progress.Value = 0;
		}
	}
}
