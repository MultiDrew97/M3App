using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Types.Extensions;
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

		private readonly CancellationTokenSource _tokenSource = new();

		/// <summary>
		/// 
		/// </summary>
		public SendEmailsDialog()
		{
			InitializeComponent();

			EmailsCancelled += new EventHandler(Cancelled);
			EmailsSent += new EventHandler(Sent);
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
			gdt_Files.Reload(this, e);
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

		private async Task<ListenerCollection> GatherRecipientsAsync()
		{
			using SPPBC.M3Tools.ListenerSelectionDialog recipients = new(await dbListeners.GetListeners());

			if (recipients.ShowDialog(this) != DialogResult.OK)
			{
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
				return null;
			}

			return recipients.Listeners;
		}

		private (string Subject, string Body) PrepBody()
		{
			using EmailBodySelection bodySelection = new(Utils.Templates);

			DialogResult res = bodySelection.ShowDialog(this);
			return res != DialogResult.OK
				? throw res switch
				{
					DialogResult.Cancel => new OperationCanceledException(),
					_ => new Exception()
				}
				: (bodySelection.Content.Subject, bodySelection.Content.Body);
		}

		private async void PrepEmails(EmailDetails details)
		{
			try
			{
				if (details is null)
				{
					EmailsCancelled?.Invoke(this, EventArgs.Empty);
					return;
				}

				details.Recipients = await GatherRecipientsAsync();
				// TODO: Make a class or provider of some sort to store and pull the template data for the user
				(string subject, string body) = PrepBody();
				// FIXME: Doesn't like the style input being in the base template. Might have to make a separate setting for now to get it to work
				//string body = string.Format(Properties.Resources.BASE_EMAIL_TEMPLATE, Properties.Resources.BASE_EMAIL_STYLE, bodySelection.Content.Body);

				foreach (File @file in details.DriveLinks)
				{
					details.SendingLinks.Add(string.Format(Properties.Resources.DRIVE_LINK_HTML, string.Format(Properties.Resources.DRIVE_SHARE_LINK_TEMPLATE, @file.Id), @file.Name));
				}

				tsp_Progress.Value = 0;
				tsp_Progress.Maximum = details.Recipients.Count;
				tsp_Progress.Step = (int)Math.Floor(1d / details.Recipients.Count);

				foreach (Listener listener in details.Recipients)
				{
					try
					{
						MimeKit.MimeMessage email = await gmt_Gmail.CreateWithAttachment(listener, subject, string.Format(body, listener.Name, string.Join(HTMLTags.LineBreak, details.SendingLinks)), details.LocalFiles);
						Google.Apis.Gmail.v1.Data.Message message = await gmt_Gmail.Send(email);

						Console.WriteLine($"Message to {listener.Name} ({message.Id}) has been sent");
					}
					catch (OperationCanceledException) { }
					catch (Google.GoogleApiException ex)
					{
						Console.Error.WriteLine($"Unable to send email to {listener.Name}");
						Console.Error.WriteLine(ex.Message);
						Console.Error.WriteLine(ex.StackTrace);
					}
					finally
					{
						tsp_Progress.PerformStep();
					}
				}

				EmailsSent?.Invoke(this, EventArgs.Empty);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				EmailsCancelled?.Invoke(this, EventArgs.Empty);
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
