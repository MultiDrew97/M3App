using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Types;
using SPPBC.M3Tools.Types.GTools;

namespace MediaMinistry
{

    public partial class SendEmailsDialog
    {
        private event EmailsSendingEventHandler EmailsSending;

        private delegate void EmailsSendingEventHandler();
        private event EmailsSentEventHandler EmailsSent;

        private delegate void EmailsSentEventHandler();
        private event EmailsCancelledEventHandler EmailsCancelled;

        private delegate void EmailsCancelledEventHandler();
        private event ProgressMadeEventHandler ProgressMade;

        private delegate void ProgressMadeEventHandler();
        private event ProgressResetEventHandler ProgressReset;

        private delegate void ProgressResetEventHandler(int total);

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
            EmailsSending?.Invoke();

            // FIXME: Verify this still works before pushing update
            IEmailDetails details = (IEmailDetails)new object();

            if (!(FileCount > 0))
            {
                var res = MessageBox.Show("Are you wanting to send an email with no attachments?", "No File Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!(res == DialogResult.Yes))
                {
                    EmailsCancelled?.Invoke();
                    return;
                }

                bw_PrepEmails.RunWorkerAsync(details);
                return;
            }

            // gather files to send
            bw_GatherFiles.RunWorkerAsync(details);
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Loading(object sender, EventArgs e)
        {
            gmt_Gmail.Authorize(My.MySettingsProperty.Settings.Username);
            gdt_Files.Load(My.MySettingsProperty.Settings.Username);
        }

        public void Reload()
        {
            UseWaitCursor = true;
            gdt_Files.Reload();
            UseWaitCursor = false;
        }

        // Private Sub NewFolder(sender As Object, e As EventArgs)
        // Using newFolder As New SPPBC.M3Tools.CreateFolderDialog()
        // Dim res = newFolder.ShowDialog()
        // If res = DialogResult.OK Then
        // Reload()
        // End If
        // End Using
        // End Sub

        // Private Sub NewUpload(sender As Object, e As EventArgs)
        // Using newUpload As New SPPBC.M3Tools.UploadFileDialog()
        // Dim res = newUpload.ShowDialog()
        // If res = DialogResult.OK Then
        // Reload()
        // End If
        // End Using
        // End Sub

        private void GatherFiles(object sender, DoWorkEventArgs e)
        {
            IEmailDetails details = (IEmailDetails)e.Argument;

            foreach (var node in gdt_Files.GetSelectedNodes())
                // TODO: Uncomment after build
                details.DriveLinks.Add(new File(node.Name, node.Text, "")); // String.Format(My.Resources.DriveShareLink, node.Name))

            foreach (File @file in fu_Receipts.Files)
                details.LocalFiles.Add(@file.Name);

            e.Result = details;
        }

        private void FilesGathered(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                EmailsCancelled?.Invoke();
                return;
            }

            bw_GatherReceipients.RunWorkerAsync(e.Result);
        }

        private void PrepEmails(object sender, DoWorkEventArgs e)
        {
            IEmailDetails details = (IEmailDetails)e.Argument;

            foreach (var @file in details.DriveLinks)
            {
                switch (details.EmailContents.BodyType)
                {
                    case var @case when @case == EmailType.PLAIN:
                        {
                            details.SendingLinks.Add(string.Format(My.Resources.Resources.DriveShareLink, @file.Id));
                            break;
                        }
                    case var case1 when case1 == EmailType.HTML:
                        {
                            details.SendingLinks.Add(string.Format(My.Resources.Resources.DriveLinkHtml, string.Format(My.Resources.Resources.DriveShareLink, @file.Id), @file.Name));
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }

            e.Result = details;
        }

        private void EmailsPrepped(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                EmailsCancelled?.Invoke();
                return;
            }

            bw_SendEmails.RunWorkerAsync(e.Result);
        }

        private void GatherReceipients(object sender, DoWorkEventArgs e)
        {
            IEmailDetails details = (IEmailDetails)e.Argument;
            var res = rsd_Selection.ShowDialog(dbListeners.GetListeners());
            if (!(res == DialogResult.OK))
            {
                e.Cancel = true;
                return;
            }

            details.Recipients = rsd_Selection.List;
            e.Result = details;
        }

        private void ReceipientsGathered(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                EmailsCancelled?.Invoke();
                return;
            }

            IEmailDetails details = (IEmailDetails)e.Result;

            // TODO: Figure out how to make this simplier
            using (var body = new EmailBodySelection() { Templates = new TemplateList() { new Template("Sermon", My.Resources.Resources.newSermon, "New Sermon"), new Template("Reciept", My.Resources.Resources.receipt, "Thank you") } })
            {
                var res = body.ShowDialog();
                if (!(res == DialogResult.OK))
                {
                    EmailsCancelled?.Invoke();
                    return;
                }

                details.EmailContents = body.Content;
            }

            bw_PrepEmails.RunWorkerAsync(details);
        }

        private void SendEmails(object sender, DoWorkEventArgs e)
        {
            var messages = new List<MimeKit.MimeMessage>();
            IEmailDetails details = (IEmailDetails)e.Argument;

            foreach (Listener listener in details.Recipients)
            {
                string body;
                switch (details.EmailContents.BodyType)
                {
                    case var @case when @case == EmailType.PLAIN:
                        {
                            body = $"Hello {listener.Name}, {Constants.vbCrLf}{Constants.vbCrLf}{details.EmailContents.Body}{Constants.vbCrLf}{Constants.vbCrLf}{string.Join(Constants.vbCrLf, details.SendingLinks)}";
                            break;
                        }
                    case var case1 when case1 == EmailType.HTML:
                        {
                            body = string.Format(details.EmailContents.Body, listener.Name, string.Join("<br />", details.SendingLinks));
                            break;
                        }

                    default:
                        {
                            e.Cancel = true;
                            return;
                        }
                }

                // TODO: Make login screen store the user info instead of just username and password to use for sender info
                var message = gmt_Gmail.CreateWithAttachment(listener, details.EmailContents, details.LocalFiles);
                messages.Add(message);
            }
            e.Result = messages;

            // Dim message As MimeKit.MimeMessage
            // For Each listener In details.Recipients
            // Console.WriteLine($"Name - {listener.Name}{vbNewLine}Email - {listener.Email}")
            // Next

            // tsl_Status.Text = "Prepping any attachments..."
            // RaiseEvent ProgressReset(details.DriveFiles.Count)
            // If details.DriveFiles.Count > 0 Then
            // details.Content.Body &= $"{vbNewLine}{vbNewLine}Attachements:{vbNewLine}{vbNewLine}"

            // For Each file In details.DriveFiles
            // details.Content.Body &= String.Format($"{My.Resources.DriveShareLink}{vbNewLine}", file.Id)
            // RaiseEvent ProgressMade()
            // Next

            // tsl_Status.Text = "Sending emails now..."
            // RaiseEvent ProgressReset(details.Recipients.Count)
            // End If

            // For Each listener In details.Recipients
            // message = gmt_Gmail.CreateWithAttachment(New MimeKit.MailboxAddress(listener.Name, listener.Email), details.Content, details.LocalFiles.ToArray)
            // gmt_Gmail.Send(message)
            // RaiseEvent ProgressMade()
            // Next
        }

        private void EmailsDone(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error is not null)
            {
                EmailsCancelled?.Invoke();
                Console.Out.WriteLine("Worker was cancelled");
                return;
            }

            List<MimeKit.MimeMessage> messages = (List<MimeKit.MimeMessage>)e.Result;
            ProgressReset?.Invoke(messages.Count);
            foreach (var message in messages)
            {
                gmt_Gmail.Send(message);
                ProgressMade?.Invoke();
            }

            EmailsSent?.Invoke();
        }

        private void Cancelled()
        {
            btn_Send.Enabled = true;
        }

        private void Sending()
        {
            btn_Send.Enabled = false;
        }

        private void Sent()
        {
            btn_Send.Enabled = true;
        }

        private void ResetProgress(int total)
        {
            tsp_Progress.Value = 0;
            tsp_Progress.Step = (int)Math.Round(Math.Floor(1d / total));
        }

        private void UpdateProgress()
        {
            tsp_Progress.PerformStep();
        }

        private void Reload(object sender, EventArgs e) => Reload();
    }
}