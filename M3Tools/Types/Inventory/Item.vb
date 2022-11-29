Option Strict On
Namespace Types
	Public Class Item
		Inherits DBEntry

		Public Property Name As String

		Public Sub New()
			Me.New(-1, "New Item")
		End Sub

		Public Sub New(id As Integer, name As String)
			MyBase.New(id)
			Me.Name = name
		End Sub
	End Class
End Namespace