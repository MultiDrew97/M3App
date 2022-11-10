Imports System.Collections.ObjectModel

Namespace GoogleAPI.Types
	Public Class File
		Public ReadOnly Id As String
		Public Property Name As String
		Public Property FileType As String
		Public Property Parents As IList(Of String)

		Shadows ReadOnly Property ToString As String
			Get
				Return String.Format("Name: {1} ({0}): FileType: {2} > Parent Count: {3}", Id, Name, FileType, Parents.Count)
			End Get
		End Property

		Sub New(id As String)
			Me.New(id, "Temp File", "txt")
		End Sub

		Sub New(id As String, name As String, filetype As String, Optional parents As IList(Of String) = Nothing)
			Me.Id = id
			Me.Name = name
			Me.FileType = filetype
			Me.Parents = If(parents, New Collection(Of String))
		End Sub

		Public Shared Operator =(left As File, right As File) As Boolean
			Return left.Id = right.Id And left.Name = right.Name And left.Parents.Equals(right.Parents) And left.FileType = right.FileType
		End Operator

		Public Shared Operator <>(left As File, right As File) As Boolean
			Return Not left = right
		End Operator
	End Class
End Namespace