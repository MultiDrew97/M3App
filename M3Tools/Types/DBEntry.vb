Option Strict On
Imports System.ComponentModel

Namespace Types
	Public MustInherit Class DbEntry
		MustOverride Property Id As Integer

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(id As Integer)
			Me.Id = id
		End Sub

		' Public MustOverride Sub UpdateID(newID As Integer)

		Shared Operator =(ls As DbEntry, rs As DbEntry) As Boolean
			Return ls.Id = rs.Id
		End Operator

		Shared Operator <>(ls As DbEntry, rs As DbEntry) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
