Imports System.Collections.ObjectModel

Namespace GoogleAPI.Types
	Public Class FileCollection
		Inherits Collection(Of File)

		Default Overloads ReadOnly Property Item(fileID As String) As File
			Get
				Return GetItem(fileID)
			End Get
		End Property

		Sub New()
			MyBase.New()
		End Sub

		Sub New(folders As IList(Of File))
			MyBase.New(folders)
		End Sub

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
