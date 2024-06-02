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

		private readonly EmailDetails details = new EmailDetails();

		// TODO: Make email sending more straight forward
		// Const DriveLinkHtml = "<a href=""{0}"" class=""drive-link"">{1}</a>"

		public int FileCount
        {
            get
            {
                return fu_Receipts.Files.Count + gdt_Files.GetSelectedNodes().Count;
            }
        }

        public SendEmailsDialog()
        {
            InitializeComponent();
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
            gmt_Gmail.Authorize(My.Settings.Default.Username);
            gdt_Files.Load(My.Settings.Default.Username);
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
                switch (details.EmailContents.BodyType)
                {
                    case EmailType.PLAIN:
                        {
                            details.SendingLinks.Add(string.Format(My.Resources.Resources.DriveShareLink, @file.Id));
                            break;
                        }
                    case EmailType.HTML:
                        {
                            details.SendingLinks.Add(string.Format(My.Resources.Resources.DriveLinkHtml, string.Format(My.Resources.Resources.DriveShareLink, @file.Id), @file.Name));
                            break;
                        }

                    default:
                        {
							throw new ArgumentException($"Unknown email body type: {details.EmailContents.BodyType}");
                        }
                }
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
            if (rsd_Selection.ShowDialog(dbListeners.GetListeners()) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }

            details.Recipients = rsd_Selection.List;
        }

        private void ReceipientsGathered(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                EmailsCancelled?.Invoke(this, EventArgs.Empty);
                return;
            }

            // TODO: Figure out how to make this simplier
            using (var body = new EmailBodySelection() { Templates = new TemplateList() { new Template("Sermon", My.Resources.Resources.newSermon, "New Sermon"), new Template("Reciept", My.Resources.Resources.receipt, "Thank you") } })
            {
                if (body.ShowDialog() != DialogResult.OK)
                {
                    EmailsCancelled?.Invoke(this, EventArgs.Empty);
                    return;
                }

                details.EmailContents = body.Content;
            }

            bw_PrepEmails.RunWorkerAsync();
        }

        private void SendEmails(object sender, DoWorkEventArgs e)
        {
            var messages = new List<MimeKit.MimeMessage>();

            foreach (Listener listener in details.Recipients)
            {
                switch (details.EmailContents.BodyType)
                {
                    case EmailType.PLAIN:
                        {
                            details.EmailContents.Body = $"Blessings {listener.Name}, {Constants.vbCrLf}{Constants.vbCrLf}{details.EmailContents.Body}{Constants.vbCrLf}{Constants.vbCrLf}{string.Join(Constants.vbCrLf, details.SendingLinks)}";
                            break;
                        }
                    case EmailType.HTML:
                        {
							details.EmailContents.Body = string.Format(details.EmailContents.Body, listener.Name, string.Join("<br />", details.SendingLinks));
                            break;
                        }

                    default:
                        {
							throw new ArgumentException($"Unknown Email body type {details.EmailContents.BodyType}");
						}
                }

                // TODO: Make login screen store the user info instead of just username and password to use for sender info
                messages.Add(gmt_Gmail.CreateWithAttachment(listener, details.EmailContents, details.LocalFiles));
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
