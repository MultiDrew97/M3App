Imports System.Collections.ObjectModel

Namespace Types
	Public Class EmailDetails
		''' <summary>
		''' The contents of the email
		''' </summary>
		''' <returns></returns>
		Property EmailContents As New EmailContent("", "", "html")

		''' <summary>
		''' The list of any drive links that may have been selected to be sent
		''' </summary>
		''' <returns></returns>
		Property DriveLinks As GTools.Types.FileCollection 'List(Of String)

		''' <summary>
		''' The list of any local files that were selected to be sent
		''' </summary>
		''' <returns></returns>
		Property LocalFiles As New Collection(Of String)

		''' <summary>
		''' The list of reciepients of the email
		''' </summary>
		''' <returns></returns>
		Property Recipients As New ListenerCollection

		''' <summary>
		''' The list of links to be added to the email body
		''' </summary>
		''' <returns></returns>
		Property SendingLinks As New List(Of String)

		'Public Sub New()
		'	EmailContents = New EmailContent("", "", "html")
		'	DriveLinks = New GTools.Types.FileCollection() 'List(Of String)
		'	LocalFiles = New Collection(Of String)
		'	Recipients = New ListenerCollection
		'	SendingLinks = New List(Of String)
		'End Sub
	End Class

	Public Class EmailContent
		''' <summary>
		''' The subject of the email
		''' </summary>
		''' <returns></returns>
		Property Subject As String

		''' <summary>
		''' The body content of the email
		''' </summary>
		''' <returns></returns>
		Property Body As String

		''' <summary>
		''' The text type of the email body. Typically 'html' or 'plain'
		''' </summary>
		''' <returns></returns>
		Property BodyType As String

		Public Sub New(subject As String, body As String, type As String)
			Me.Subject = subject
			Me.Body = body
			Me.BodyType = type
		End Sub
	End Class
End Namespace