Option Strict On
Imports System.ComponentModel

Namespace Types
	Public Class Person
		Public Property Id As Integer
		Public Property FirstName As String
		Public Property LastName As String
		Public ReadOnly Property Name() As String
			Get
				Return CType(IIf(IsNothing(LastName), FirstName, FirstName & " " & LastName), String)
			End Get
		End Property

		Public Sub New(id As Integer, firstName As String, lastName As String)
			Me.Id = id
			Me.FirstName = firstName
			Me.LastName = lastName
		End Sub
	End Class
End Namespace
