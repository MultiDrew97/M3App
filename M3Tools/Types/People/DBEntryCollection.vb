Imports System.Collections.ObjectModel

Namespace Types
	Public Class DBEntryCollection(Of T As DBEntry)
		Inherits Collection(Of T)

		Default Overloads ReadOnly Property Item(id As Integer) As T
			Get
				Return GetItem(id)
			End Get
		End Property

		Sub New()
			MyBase.New()
		End Sub

		Sub New(list As IList(Of T))
			MyBase.New(list)
		End Sub

		Overloads Function Contains(id As Integer) As Boolean
			For Each curr In Items
				If curr.Id = id Then
					Return True
				End If
			Next

			Return False
		End Function

		Overloads Function Contains(search As T) As Boolean
			For Each curr In Items
				If curr = search Then
					Return True
				End If
			Next

			Return False
		End Function

		Sub AddRange(ParamArray params As T())
			For Each param In params
				Add(param)
			Next
		End Sub

		Public Function GetItem(id As Integer) As T
			For Each curr In Items
				If curr.Id = id Then
					Return curr
				End If
			Next

			Throw New Exceptions.ListenerNotFoundException()
		End Function
	End Class
End Namespace