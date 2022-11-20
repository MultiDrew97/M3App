Option Strict On
Namespace Types
	Public Class DBEntry
		Property Id As Integer

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(id As Integer)
			Me.Id = id
		End Sub

		Shared Operator =(ls As DBEntry, rs As DBEntry) As Boolean
			Return ls.Id = rs.Id
		End Operator

		Shared Operator <>(ls As DBEntry, rs As DBEntry) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
