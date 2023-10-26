Imports System.Collections.ObjectModel

Namespace Types.GTools
	Public Class File
		Public ReadOnly Id As String
		Public Property Name As String
		Public Property FileType As String
		Public Property Parents As IList(Of String)

		Shadows ReadOnly Property ToString As String
			Get
				Return $"Name: {Name} ({Id}): FileType: {FileType} > Parent Count: {Parents.Count}"
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
			Return left.Id = right.Id 'AndAlso left.Name = right.Name AndAlso left.Parents.Equals(right.Parents) AndAlso left.FileType = right.FileType
		End Operator

		Public Shared Operator <>(left As File, right As File) As Boolean
			Return Not left = right
		End Operator
	End Class

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

	Public Class FileCollection
		Inherits Collection(Of File)

		Default Overloads ReadOnly Property Item(fileID As String) As File
			Get
				Return GetItem(fileID)
			End Get
		End Property

		Overloads Function Contains(id As String) As Boolean
			For Each file In Items
				If file.Id = id Then
					Return True
				End If
			Next

			Return False
		End Function

		Overloads Function Contains(fileSearch As File) As Boolean
			For Each file In Items
				If file = fileSearch Then
					Return True
				End If
			Next

			Return False
		End Function

		Function GetItem(id As String) As File
			For Each file In Items
				If file.Id = id Then
					Return file
				End If
			Next

			Return Nothing
		End Function

		Sub AddRange(files As IList(Of File))
			For Each file In files
				Add(file)
			Next
		End Sub
	End Class
End Namespace
