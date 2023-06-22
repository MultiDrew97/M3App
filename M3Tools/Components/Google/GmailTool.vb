Imports System.Threading
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Services
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

		''' <summary>
		''' Creates an email using the provided information
		''' </summary>
		''' <param name="[to]">The address to whom the email is being sent to</param>
		''' <param name="subject">The subject of the email to be sent</param>
		''' <param name="body">The body of the email to be sent</param>
		''' <param name="from">Who the email is being sent from</param>
		''' <param name="bodyType">The type of body the email will have. Default html</param>
		''' <returns></returns>
		Function Create([to] As MailboxAddress, subject As String, body As String, Optional from As MailboxAddress = Nothing, Optional bodyType As String = "html") As MimeMessage
			Dim email As New MimeMessage() With {
				.Sender = If(from, New MailboxAddress("Elder Bryon Miller", "me")),
				.Subject = subject,
				.Body = New TextPart(bodyType) With {
					.Text = body
				}
			}

			email.To.Add([to])

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
		Function CreateWithAttachment([to] As MailboxAddress, subject As String, body As String, files As String(), Optional from As MailboxAddress = Nothing, Optional bodyType As String = "html") As MimeMessage
			Dim email As MimeMessage = Create([to], subject, body, from, bodyType)
			'Dim email As New MimeMessage() With {
			'	.Sender = If(from, New MailboxAddress("Edler Bryon Miller", "me")),
			'	.Subject = subject
			'}

			'email.To.Add([to])

			'Dim mimeBodyPart As MimePart = New TextPart(bodyType) With {
			'	.Text = body
			'}

			'mimeBodyPart.setContent(bodyText, "text/plain")

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
		''' Create an Email using a premade message
		''' </summary>
		''' <param name="emailContent">The email to be created</param>
		''' <returns>Returns a message to be sent</returns>
		Function CreateWithEmail(emailContent As MimeMessage) As Data.Message
			Dim buffer As New NPOI.Util.ByteArrayOutputStream()
			emailContent.WriteTo(buffer)
			Dim encodedEmail As String = Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(buffer.ToByteArray())
			Dim message As New Data.Message With {
				.Raw = encodedEmail
			}

			Return message
		End Function

		''' <summary>
		''' Send an email using the provided email message
		''' </summary>
		''' <param name="emailContent">The email to be sent</param>
		''' <param name="sender">The account the email will be sent from. me is default</param>
		''' <returns>The message itself after being sent</returns>
		Function Send(emailContent As MimeMessage, Optional sender As String = "me") As Data.Message
			Return __service.Users().Messages().Send(CreateWithEmail(emailContent), sender).Execute()
		End Function
	End Class
End Namespace