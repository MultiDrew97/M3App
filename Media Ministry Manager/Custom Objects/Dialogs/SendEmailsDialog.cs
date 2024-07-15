using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Types.GTools;

namespace M3App
{

    public partial class SendEmailsDialog
    {
        internal event EventHandler EmailsSent;
        internal event EventHandler EmailsCancelled;

		private readonly EmailDetails details = new();

		// TODO: Make email sending more straight forward
		// Const DriveLinkHtml = "<a href=""{0}"" class=""drive-link"">{1}</a>"

		private int FileCount
        {
            get
            {
                return fu_Receipts.Files.Count + gdt_Files.GetSelectedNodes().Count;
            }
        }

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

			if (FileCount > 0)
			{
				// gather files to send
				bw_GatherFiles.RunWorkerAsync();
				return;
            }

			var res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void Loading(object sender, EventArgs e)
        {
            gmt_Gmail.Authorize();
            gdt_Files.Load();
        }

        public void Reload(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            gdt_Files.Reload();
            UseWaitCursor = false;
        }

        private void GatherFiles(object sender, DoWorkEventArgs e)
        {
            foreach (var node in gdt_Files.GetSelectedNodes())
                // TODO: Uncomment after build
                details.DriveLinks.Add(new File(node.Name, node.Text, "")); // String.Format(My.Resources.DriveShareLink, node.Name))

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
            foreach (var @file in details.DriveLinks)
            {
				details.SendingLinks.Add(string.Format(Properties.Resources.DriveLinkHtml, string.Format(Properties.Resources.DriveShareLink, @file.Id), @file.Name));
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

        private void GatherReceipients(object sender, DoWorkEventArgs e)
        {
			using var recipients = new SPPBC.M3Tools.ListenerSelectionDialog(dbListeners.GetListeners());

            if (recipients.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }

            details.Recipients = recipients.Selection;
        }

        private void ReceipientsGathered(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                EmailsCancelled?.Invoke(this, EventArgs.Empty);
                return;
            }

			// TODO: Figure out how to make this simplier
			using var body = new EmailBodySelection(new() { new("Sermon", Properties.Resources.newSermon, "New Sermon"), new("Reciept", Properties.Resources.receipt, "Bless you") });
            
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
            var messages = new List<MimeKit.MimeMessage>();
            foreach (Listener listener in details.Recipients)
            {
				var body = string.Format(details.EmailContents.Body, listener.Name, string.Join("<br>", details.SendingLinks));
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

			foreach (var message in messages)
            {
                gmt_Gmail.Send(message);
				tsp_Progress.PerformStep();
			}

			EmailsSent?.Invoke(this, EventArgs.Empty);
		}

		private void Sent(object sender, EventArgs e)
		{
			btn_Send.Enabled = true;
			MessageBox.Show("Emails have been sent", "Send Emails", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void Cancelled(object sender, EventArgs e)
        {
            btn_Send.Enabled = true;
			MessageBox.Show("Unsent emails have been cancelled", "Send Emails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
    }
}
