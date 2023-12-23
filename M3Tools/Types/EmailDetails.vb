Imports System.Collections.ObjectModel

Namespace Types.GTools
	Public Interface IEmailDetails
		''' <summary>
		''' The contents of the email
		''' </summary>
		''' <returns></returns>
		Property EmailContents As EmailContent

		''' <summary>
		''' The list of any drive links that may have been selected to be sent
		''' </summary>
		''' <returns></returns>
		Property DriveLinks As FileCollection

		''' <summary>
		''' The list of any local files that were selected to be sent
		''' </summary>
		''' <returns></returns>
		Property LocalFiles As Collection(Of String)

		''' <summary>
		''' The list of reciepients of the email
		''' </summary>
		''' <returns></returns>
		Property Recipients As DBEntryCollection(Of Listener)

		''' <summary>
		''' The list of links to be added to the email body
		''' </summary>
		''' <returns></returns>
		Property SendingLinks As List(Of String)

		'Public Sub New()
		'	EmailContents = New EmailContent("", "", "html")
		'	DriveLinks = New GTools.Types.FileCollection() 'List(Of String)
		'	LocalFiles = New Collection(Of String)
		'	Recipients = New ListenerCollection
		'	SendingLinks = New List(Of String)
		'End Sub
	End Interface

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
		Property BodyType As EmailType

		Public Sub New(Optional subject As String = "", Optional body As String = "", Optional type As EmailType = Nothing)
			Me.Subject = subject
			Me.Body = body
			Me.BodyType = If(type = Nothing, EmailType.HTML, type)
		End Sub
	End Class

	Public Enum EmailType
		HTML
		PLAIN
	End Enum
End Namespace
