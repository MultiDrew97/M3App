Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace Types
	Public Class ListenerCollection
		Inherits DBEntryCollection(Of Listener)

		Sub New()
			MyBase.New()
		End Sub

		Sub New(listeners As IList(Of Listener))
			MyBase.New(listeners)
		End Sub

		'Default Overloads ReadOnly Property Item(listenerID As Integer) As Listener
		'	Get
		'		Return GetItem(listenerID)
		'	End Get
		'End Property


		'Overloads Function Contains(id As Integer) As Boolean
		'	For Each listener In Items
		'		If listener.Id = id Then
		'			Return True
		'		End If
		'	Next

		'	Return False
		'End Function

		'Overloads Function Contains(listenerSearch As Listener) As Boolean
		'	For Each listener In Items
		'		If listener = listenerSearch Then
		'			Return True
		'		End If
		'	Next

		'	Return False
		'End Function

		'Overrides Sub AddRange(listeners As IList(Of Listener))
		'	For Each listener In listeners
		'		Add(listener)
		'	Next
		'End Sub

		'Public Function GetItem(listenerID As Integer) As Listener
		'	For Each listener In Items
		'		If listener.Id = listenerID Then
		'			Return listener
		'		End If
		'	Next

		'	Throw New Exceptions.ListenerNotFoundException()
		'End Function
	End Class
End Namespace