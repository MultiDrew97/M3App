using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

using MimeKit;

using SPPBC.M3Tools.API.GTools;
using SPPBC.M3Tools.Types.Extensions;
using SPPBC.M3Tools.Types.GTools;

namespace SPPBC.M3Tools.GTools
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Gmail : GoogleBase, IGoogleService<Google.Apis.Gmail.v1.Data.Profile>
	{

		private GmailService __service;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public Google.Apis.Gmail.v1.Data.Profile GetUser() => __service?.Users.GetProfile(__user).Execute() ?? null;

		//Google.Apis.Gmail.v1.Data.Profile IGoogleService<Google.Apis.Gmail.v1.Data.Profile>.UserAccount => __service.Users.GetProfile(__user).Execute();

		private MailboxAddress DefaultSender => new("Elder Bryon Miller", __user);

		/// <summary>
		/// 
		/// </summary>
		public Gmail() : base(GoogleUserType.MAIL, [GmailService.Scope.GmailCompose]) => InitializeComponent();

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="ct"></param>
		protected override async Task Authorize(CancellationToken ct = default)
		{
			try
			{
				await base.Authorize(ct);

				if (ct.IsCancellationRequested)
					return;

				__service = new GmailService(__init);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				throw ex;
			}
		}

		/// <summary>
		/// Create an email to be sent
		/// </summary>
		/// <param name="to"></param>
		/// <param name="subject"></param>
		/// <param name="body"></param>
		/// <param name="from"></param>
		/// <returns></returns>
		public MimeMessage Create(Types.Listener to, string subject, string body, MailboxAddress @from = null) => Create(to, new EmailContent(subject, body), from);

		/*/// <summary>
		/// Creates an email using the provided information
		/// </summary>
		///<param name="to">The address to whom the email is being sent to</param>
		/// <param name="subject">The subject of the email to be sent</param>
		/// <param name="body">The body of the email to be sent</param>
		/// <param name="from">Who the email is being sent from</param>
		/// <returns></returns>
		public MimeMessage Create(Types.Listener to, string subject, string body, MailboxAddress from = null) => Create(to, new EmailContent(subject, body), from);*/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="to"></param>
		/// <param name="content"></param>
		/// <param name="from"></param>
		/// <returns></returns>
		public MimeMessage Create(Types.Listener to, EmailContent content, MailboxAddress from = null) => Create(new MailboxAddress(to.Name, to.Email), content, from);

		private MimeMessage Create(MailboxAddress to, EmailContent content, MailboxAddress from)
		{
			// FIXME: Add CSS into templates natively to boost load time in emails
			MimeMessage email = new()
			{
				Sender = from ?? DefaultSender,
				Subject = content.Subject,
				Body = new TextPart("html") { Text = content.Body }
			};

			email.To.Add(to);

			return email;
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
		public MimeMessage CreateWithAttachment(Types.Listener to, string subject, string body, IList<string> files, MailboxAddress @from = null) => CreateWithAttachment(to, new EmailContent(subject, body), files, from);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="to"></param>
		/// <param name="content"></param>
		/// <param name="files"></param>
		/// <param name="from"></param>
		/// <returns></returns>
		public MimeMessage CreateWithAttachment(Types.Listener to, EmailContent content, IList<string> files, MailboxAddress @from = null) => CreateWithAttachment(new MailboxAddress(to.Name, to.Email), content, files, from);

		/// <summary>
		/// Create an email that contains attachments to be sent to a email box
		/// </summary>
		/// <param name="to">The MailBox Address to send to</param>
		/// <param name="content">The content of the email to be sent</param>
		/// <param name="files">The files to attach to the email</param>
		/// <param name="from">The email address to send from</param>
		/// <returns>Returns an Email to be sent</returns>
		private MimeMessage CreateWithAttachment(MailboxAddress to, EmailContent content, IList<string> files, MailboxAddress @from = null)
		{
			MimeMessage email = Create(to, content, from);
			Multipart multipart = [email.Body,
				..files.Select<string, MimeEntity>(file => new MimePart(MediaTypeNames.Application.Octet) { Content = new MimeContent(new MemoryStream(System.IO.File.ReadAllBytes(file))), FileName = Path.GetFileName(file), IsAttachment = true, ContentTransferEncoding = ContentEncoding.Base64 })];
			email.Body = multipart;
			return email;
		}

		/// <summary>
		///		Send an email using the provided email message
		/// </summary>
		/// <param name="emailContent">The email to be sent</param>
		/// <param name="ct"></param>
		/// <returns>The message itself after being sent</returns>
		public async Task<Message> Send(MimeMessage emailContent, CancellationToken ct = default)
		{
			await Authorize(ct);

			ct.ThrowIfCancellationRequested();

			Message body = new() { Raw = emailContent.ToString().ToBase64String() };

			return await __service.Users.Messages.Send(body, emailContent.Sender.Address).ExecuteAsync(ct);
		}
	}
}
