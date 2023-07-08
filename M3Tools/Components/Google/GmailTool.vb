Imports System.Threading
Imports Google.Apis.Gmail.v1
Imports MimeKit

Namespace GTools
	Public Class GmailTool
		Inherits API
		Implements IDisposable, IGoogleService(Of Data.Profile)

		Private ReadOnly __scopes As String() = {GmailService.Scope.GmailCompose}
		Private __service As GmailService


		Protected ReadOnly Property UserAccount As Data.Profile Implements IGoogleService(Of Data.Profile).UserAccount
			Get
				Return __service.Users.GetProfile("me").Execute()
			End Get
		End Property

		Private ReadOnly DefaultSender As New MailboxAddress("Elder Bryon Miller", "me")

		Overrides Sub Authorize(Optional ct As CancellationToken = Nothing)
			' Create Gmail API service
			LoadCreds("me", __scopes, If(IsNothing(ct), CancellationToken.None, ct))

			__service = New GmailService(__init)

			MyBase.Authorize(ct)
		End Sub

		''' <summary>
		''' Perform cleanup for this component
		''' </summary>
		Public Sub Close() Implements IDisposable.Dispose
			Dispose(True)
		End Sub

		Function Create([to] As MailboxAddress, content As M3Tools.Types.EmailContent, Optional from As MailboxAddress = Nothing) As MimeMessage
			Dim email As New MimeMessage() With {
				.Sender = If(from, DefaultSender),
				.Subject = content.Subject,
				.Body = New TextPart(content.BodyType) With {
					.Text = content.Body
				}
			}

			email.To.Add([to])

			Return email

		End Function

		''' <summary>
		''' Creates an email using the provided information
		''' </summary>
		''' <param name="[to]">The address to whom the email is being sent to</param>
		''' <param name="subject">The subject of the email to be sent</param>
		''' <param name="body">The body of the email to be sent</param>
		''' <param name="from">Who the email is being sent from</param>
		''' <param name="bodyType">The type of body the email will have. Default html</param>
		''' <returns></returns>
		Function Create([to] As MailboxAddress, subject As String, body As String, Optional bodyType As String = "html", Optional from As MailboxAddress = Nothing) As MimeMessage
			Return Create([to], New M3Tools.Types.EmailContent(subject, body, bodyType), from)
		End Function

		Function Create([to] As M3Tools.Types.Listener, subject As String, body As String, Optional bodyType As String = "html", Optional from As MailboxAddress = Nothing) As MimeMessage
			Return Create(New MailboxAddress([to].Name, [to].Email), subject, body, bodyType, from)
		End Function

		Function Create([to] As M3Tools.Types.Listener, content As M3Tools.Types.EmailContent, Optional from As MailboxAddress = Nothing) As MimeMessage
			Return Create(New MailboxAddress([to].Name, [to].Email), content, from)
		End Function

		Function CreateWithAttachment([to] As M3Tools.Types.Listener, subject As String, body As String, bodyType As String, files As IList(Of String), Optional from As MailboxAddress = Nothing) As MimeMessage
			Return CreateWithAttachment(New MailboxAddress([to].Name, [to].Email), New M3Tools.Types.EmailContent(subject, body, bodyType), files, from)
		End Function

		Function CreateWithAttachment([to] As M3Tools.Types.Listener, content As M3Tools.Types.EmailContent, files As IList(Of String), Optional from As MailboxAddress = Nothing) As MimeMessage
			Return CreateWithAttachment(New MailboxAddress([to].Name, [to].Email), content, files, from)
		End Function

		Function CreateWithAttachment([to] As MailboxAddress, content As M3Tools.Types.EmailContent, files As IList(Of String), Optional from As MailboxAddress = Nothing) As MimeMessage
			Dim email As MimeMessage = Create([to], content, from)

			Dim multipart As New Multipart From {
				email.Body
			}

			Dim attachments As New AttachmentCollection

			' TODO: Clean this up later to not have to loop twice
			For Each file In files
				attachments.Add(file)
			Next

			For Each attachment In attachments
				multipart.Add(attachment)
			Next

			email.Body = multipart

			Return email
		End Function

		''' <summary>
		''' Create an email that contains attachements to be sent to a email box
		''' </summary>
		''' <param name="[to]">The MailBox Address to send to</param>
		''' <param name="subject">The subject of the email to be sent</param>
		''' <param name="body">The body portion of the email to be sent</param>
		''' <param name="files">The files to attach to the email</param>
		''' <param name="from">The email address to </param>
		''' <param name="bodyType">The type of body the email will have. Default html</param>
		''' <returns>Returns an Email to be sent</returns>
		Function CreateWithAttachment([to] As MailboxAddress, subject As String, body As String, bodyType As String, files As IList(Of String), Optional from As MailboxAddress = Nothing) As MimeMessage
			Return CreateWithAttachment([to], New M3Tools.Types.EmailContent(subject, body, bodyType), files, from)
		End Function

		''' <summary>
		''' Create an Email using a premade message
		''' </summary>
		''' <param name="emailContent">The email to be created</param>
		''' <returns>Returns a message to be sent</returns>
		Private Function CreateWithEmail(emailContent As MimeMessage) As Data.Message
			Dim buffer As New NPOI.Util.ByteArrayOutputStream()
			emailContent.WriteTo(buffer)
			Dim encodedEmail As String = Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(buffer.ToByteArray())
			Dim message As New Data.Message With {
				.Raw = encodedEmail
			}

			Return message
		End Function

		' <param name="sender">The account the email will be sent from. me is default</param>
		''' <summary>
		''' Send an email using the provided email message
		''' </summary>
		''' <param name="emailContent">The email to be sent</param>
		''' <returns>The message itself after being sent</returns>
		Function Send(emailContent As MimeMessage) As Data.Message
			Return __service.Users().Messages().Send(CreateWithEmail(emailContent), emailContent.Sender.Address).Execute()
		End Function

		'Sub SendEmails(details As EmailDetails)

		'	For Each recv In details.Recipients

		'		For Each file In details.DriveFiles

		'		Next
		'	Next
		'End Sub
	End Class
End Namespace