Imports System.Collections.ObjectModel

Public Class EmailDetails
	Property Subject As String
	'TODO: Figure out formatted messages later to not need this
	Property BodyType As String
	Property Body As String
	Property DriveFiles As GTools.Types.FileCollection
	Property LocalFiles As Collection(Of String)
	Property Recipients As Types.ListenerCollection

	'TODO: Find better way to pass between background workers
	Property CurrentIndex As Integer

	Public Sub New(currentPage As Integer)
		Subject = ""
		Body = ""
		DriveFiles = New GTools.Types.FileCollection()
		LocalFiles = New Collection(Of String)
		BodyType = "html"
		Recipients = New Types.ListenerCollection
		CurrentIndex = currentPage
	End Sub
End Class
