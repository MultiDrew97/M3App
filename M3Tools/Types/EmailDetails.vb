Imports System.Collections.ObjectModel

Public Class EmailDetails
	Property Subject As String
	'TODO: Figure out formatted messages later to not need this
	Property BodyType As String
	Property Body As String
	Property Files As Collection(Of String)
	Property Recipients As Types.ListenerCollection

	'TODO: Find better way to pass between background workers
	Property CurrentIndex As Integer

	Public Sub New(currentPage As Integer)
		Subject = ""
		Body = ""
		Files = New Collection(Of String)
		BodyType = "html"
		Recipients = New Types.ListenerCollection
		CurrentIndex = currentPage
	End Sub
End Class
