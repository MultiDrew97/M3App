Imports System.Collections.ObjectModel

Namespace Types.GoogleAPI
	Public Class Folder
		Inherits File
		Public Property Children As FileCollection

		Sub New(id As String)
			Me.New(id, "Temp Folder")
		End Sub

		Sub New(id As String, name As String, Optional parents As String() = Nothing, Optional children As FileCollection = Nothing)
			MyBase.New(id, name, "folder", parents)
			Me.Children = If(children, New FileCollection)
		End Sub
	End Class
End Namespace
