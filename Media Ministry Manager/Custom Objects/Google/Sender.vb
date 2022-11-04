Option Strict On

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports Microsoft.IdentityModel.Tokens
Imports MimeKit
Imports NPOI.Util
Imports System.IO
Imports System.Threading


Namespace GoogleAPI
    Public Class Sender
        Inherits Service
        Implements IDisposable

        Private ReadOnly Scopes As String() = {GmailService.Scope.GmailCompose}
        Private ReadOnly ApplicationName As String = "Media Ministry Manager"
        Private Property Credential As UserCredential
        Private Property Service As GmailService

        Overrides ReadOnly Property Info As Object
            Get
                Return Service.Users.GetProfile("me").Execute()
            End Get
        End Property

        Sub New(Optional ct As CancellationToken = Nothing)
            Dim credPath As String = "Gmail Token"
			Using stream As New MemoryStream(My.Resources.credentials)
				Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CType(IIf(IsNothing(ct), CancellationToken.None, ct), CancellationToken), New FileDataStore(credPath, True)).Result
			End Using

			Service = New GmailService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = Credential,
                .ApplicationName = ApplicationName
            })
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub

        Private Sub Dispose(value As Boolean)
            If value Then
            Else
            End If
        End Sub

        Function Create([to] As MailboxAddress, subject As String, body As String, Optional from As String = "me") As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress("Elder Bryon Miller", from),
                .Subject = subject,
                .Body = New TextPart("html") With {
                    .Text = body
                }
            }

            email.To.Add([to])

            Return email
        End Function

        Function CreateWithEmail(emailContent As MimeMessage) As Message
			Dim buffer As New ByteArrayOutputStream()
			emailContent.WriteTo(buffer)
            Dim bytes As Byte() = buffer.ToByteArray()
            Dim encodedEmail As String = Base64UrlEncoder.Encode(bytes)
            Dim message As New Message With {
                .Raw = encodedEmail
            }

            Return message
        End Function

        Function CreateWithAttachment([to] As MailboxAddress, subject As String, body As String, file As String, Optional from As String = "me") As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress(from, from),
                .Subject = subject
            }

            email.To.Add([to])

            Dim mimeBodyPart As MimePart = New TextPart("html") With {
                .Text = body
            }

            'mimeBodyPart.setContent(bodyText, "text/plain")

            Dim multipart As New Multipart From {
                mimeBodyPart
            }

            Dim attachments As New AttachmentCollection From {
                file
            }

            For Each attachment In attachments
                multipart.Add(attachment)
            Next


            email.Body = multipart

            Return email

        End Function
        Function Send(emailContent As MimeMessage, Optional userId As String = "me") As Message
            Dim message As Message = CreateWithEmail(emailContent)
            message = Service.Users().Messages().Send(message, userId).Execute()

            Console.WriteLine("Message id: " + message.Id)
            Return message
        End Function
    End Class
End Namespace
