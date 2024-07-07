using System;
using System.Collections.Generic;
using System.Threading;
using Google.Apis.Gmail.v1;
using MimeKit;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools.GTools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class GmailTool : API, IGoogleService<Google.Apis.Gmail.v1.Data.Profile>
    {

        private GmailService __service;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected Google.Apis.Gmail.v1.Data.Profile UserAccount
		{
			get
			{
				return __service.Users.GetProfile(__user).Execute();
			}
		}

		Google.Apis.Gmail.v1.Data.Profile IGoogleService<Google.Apis.Gmail.v1.Data.Profile>.UserAccount  => UserAccount;

        private MailboxAddress DefaultSender => new("Elder Bryon Miller", __user);

		/// <summary>
		/// 
		/// </summary>
		public GmailTool() : base("me", new[] { GmailService.Scope.GmailCompose })
		{
			InitializeComponent();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="ct"></param>
        public override void Authorize(CancellationToken ct = default)
        {
            base.Authorize(ct);

			if (ct.IsCancellationRequested) return;

            __service = new GmailService(__init);
        }

		/// <summary>
		/// Create an email to be sent
		/// </summary>
		/// <param name="to"></param>
		/// <param name="subject"></param>
		/// <param name="body"></param>
		/// <param name="from"></param>
		/// <returns></returns>
        public MimeMessage Create(Types.Listener to, string subject, string body, MailboxAddress @from = null)
        {
            return Create(new MailboxAddress(to.Name, to.Email), subject, body, from);
        }

		/// <summary>
		/// Creates an email using the provided information
		/// </summary>
		///<param name="to">The address to whom the email is being sent to</param>
		/// <param name="subject">The subject of the email to be sent</param>
		/// <param name="body">The body of the email to be sent</param>
		/// <param name="from">Who the email is being sent from</param>
		/// <returns></returns>
		public MimeMessage Create(MailboxAddress to, string subject, string body, MailboxAddress @from = null)
        {
            return Create(to, new EmailContent(subject, body), from);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="to"></param>
		/// <param name="content"></param>
		/// <param name="from"></param>
		/// <returns></returns>
        public MimeMessage Create(Types.Listener to, EmailContent content, MailboxAddress @from = null)
        {
            return Create(new MailboxAddress(to.Name, to.Email), content, from);
        }

        private MimeMessage Create(MailboxAddress to, EmailContent content, MailboxAddress @from)
        {

            var email = new MimeMessage()
            {
                Sender = from ?? DefaultSender,
                Subject = content.Subject,
                Body = new TextPart("html") { Text = content.Body }
            };

            email.To.Add(to);

            return email;
        }

		/// <summary>
		/// Create an email to be sent that contains attachement(s)
		/// </summary>
		/// <param name="to"></param>
		/// <param name="subject"></param>
		/// <param name="body"></param>
		/// <param name="files"></param>
		/// <param name="from"></param>
		/// <returns></returns>
        public MimeMessage CreateWithAttachment(MailboxAddress to, string subject, string body, IList<string> files, MailboxAddress @from = null)
        {
            return CreateWithAttachment(to, new EmailContent(subject, body), files, from);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="to"></param>
		/// <param name="subject"></param>
		/// <param name="body"></param>
		/// <param name="files"></param>
		/// <param name="from"></param>
		/// <returns></returns>
        public MimeMessage CreateWithAttachment(Types.Listener to, string subject, string body, IList<string> files, MailboxAddress @from = null)
        {
            return CreateWithAttachment(new MailboxAddress(to.Name, to.Email), new EmailContent(subject, body), files, from);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="to"></param>
		/// <param name="content"></param>
		/// <param name="files"></param>
		/// <param name="from"></param>
		/// <returns></returns>
        public MimeMessage CreateWithAttachment(Types.Listener to, EmailContent content, IList<string> files, MailboxAddress @from = null)
        {
            return CreateWithAttachment(new MailboxAddress(to.Name, to.Email), content, files, from);
        }

        /// <summary>
		/// 		''' Create an email that contains attachements to be sent to a email box
		/// 		''' </summary>
		/// 		''' <param name="to">The MailBox Address to send to</param>
		/// 		''' <param name="content">The content of the email to be sent</param>
		/// 		''' <param name="files">The files to attach to the email</param>
		/// 		''' <param name="from">The email address to send from</param>
		/// 		''' <returns>Returns an Email to be sent</returns>
        private MimeMessage CreateWithAttachment(MailboxAddress to, EmailContent content, IList<string> files, MailboxAddress @from = null)
        {
            var email = Create(to, content, from);

            var multipart = new Multipart() { email.Body };

            var attachments = new AttachmentCollection();

            // TODO: Clean this up later to not have to loop twice
            foreach (var @file in files)
                attachments.Add(@file);

            foreach (var attachment in attachments)
                multipart.Add(attachment);

            email.Body = multipart;

            return email;
        }

        /// <summary>
		/// 		''' Create an Email using a premade message
		/// 		''' </summary>
		/// 		''' <param name="emailContent">The email to be created</param>
		/// 		''' <returns>Returns a message to be sent</returns>
        private Google.Apis.Gmail.v1.Data.Message CreateWithEmail(MimeMessage emailContent)
        {
            var buffer = new NPOI.Util.ByteArrayOutputStream();
            emailContent.WriteTo(buffer);
            string encodedEmail = Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(buffer.ToByteArray());
            var message = new Google.Apis.Gmail.v1.Data.Message() { Raw = encodedEmail };

            return message;
        }

        /// <summary>
		///		Send an email using the provided email message
		/// </summary>
		/// <param name="emailContent">The email to be sent</param>
		/// <returns>The message itself after being sent</returns>
        public Google.Apis.Gmail.v1.Data.Message Send(MimeMessage emailContent)
        {
			return __service.Users.Messages.Send(CreateWithEmail(emailContent), emailContent.Sender.Address).Execute();
        }

        // Sub SendEmails(details As EmailDetails)

        // For Each recv In details.Recipients

        // For Each file In details.DriveFiles

        // Next
        // Next
        // End Sub
    }
}
