using System;
using System.ComponentModel;
using System.Diagnostics;
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

		//private readonly EmailDetails details = new();

		private int FileCount => fu_Receipts.Files.Count + gdt_Files.GetSelectedNodes().Count;

		/// <summary>
		/// 
		/// </summary>
		public SendEmailsDialog()
		{
			InitializeComponent();

			EmailsCancelled += new EventHandler(Cancelled);
			EmailsSent += new EventHandler(Sent);

			_ = gmt_Gmail.Authorize();
		}

		private void BeginSending(object sender, EventArgs e)
		{
			btn_Send.Enabled = false;
			EmailDetails details = new();

			if (FileCount > 0)
			{
				// gather files to send
				bw_GatherFiles.RunWorkerAsync(details);
				return;
			}

			DialogResult res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
			{
				EmailsCancelled?.Invoke(this, e);
				return;
			}

			PrepEmails(details);
		}

		private void Cancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			tsl_Status.Text = "Refreshing drive list...";
			gdt_Files.Reload();
			tsl_Status.Text = "Test";
			UseWaitCursor = false;
		}

		private void GatherFiles(object sender, DoWorkEventArgs e)
		{
			if (e.Argument is not EmailDetails details)
			{
				e.Cancel = true;
				return;
			}

			foreach (TreeNode node in gdt_Files.GetSelectedNodes())
				details.DriveLinks.Add(new File(node.Name, node.Text));

			foreach (File @file in fu_Receipts.Files)
				details.LocalFiles.Add(@file.Name);

			e.Result = details;
		}

		private void FilesGathered(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is not null)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			PrepEmails(e.Result as EmailDetails);
		}

		private async void PrepEmails(EmailDetails details)
		{
			if (details is null)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			using SPPBC.M3Tools.ListenerSelectionDialog recipients = new(await dbListeners.GetListeners());

			if (recipients.ShowDialog(this) != DialogResult.OK)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			details.Recipients = recipients.Selection;

			// TODO: Make a class or provider of some sort to store and pull the template data for the user
			using EmailBodySelection bodySelection = new([new("Sermon", Properties.Resources.SERMON_EMAIL_TEMPLATE, "New Sermon"), new("Receipt", Properties.Resources.RECEIPT_EMAIL, "Bless you")]);

			if (bodySelection.ShowDialog(this) != DialogResult.OK)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

			details.EmailContents = bodySelection.Content;

			foreach (File @file in details.DriveLinks)
			{
				details.SendingLinks.Add(string.Format(Properties.Resources.DRIVE_LINK_HTML, string.Format(Properties.Resources.DRIVE_SHARE_LINK_TEMPLATE, @file.Id), @file.Name));
			}

			tsp_Progress.Value = 0;
			tsp_Progress.Maximum = details.Recipients.Count;
			tsp_Progress.Step = (int)Math.Floor(1d / details.Recipients.Count);
			foreach (Listener listener in details.Recipients)
			{
				string body = string.Format(details.EmailContents.Body, listener.Name, string.Join("<br>", details.SendingLinks));
				try
				{
					_ = await gmt_Gmail.Send(gmt_Gmail.CreateWithAttachment(listener, details.EmailContents.Subject, body, details.LocalFiles));
				}
				catch (Google.GoogleApiException ex)
				{
					Debug.WriteLine(ex.Message);
					Debug.WriteLine(ex.StackTrace);
					Console.WriteLine($"Unable to send email to {listener.Name}");
				}
				finally
				{
					tsp_Progress.PerformStep();
				}
			}

			EmailsSent?.Invoke(this, EventArgs.Empty);
		}

		private void EmailsPrepped(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is not null || e.Result is not EmailDetails details)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return;
			}

		}

		// TODO: Make it so these can distinguish between a cancel and a failure
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
