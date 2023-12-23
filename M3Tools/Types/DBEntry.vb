Option Strict On

Namespace Types
	Public MustInherit Class DbEntry

		<Text.Json.Serialization.JsonIgnore>
		MustOverride Property Id As Integer

		Public Sub New(Optional id As Integer = -1)
			Me.Id = id
		End Sub

		Shared Operator =(ls As DbEntry, rs As DbEntry) As Boolean
			Return ls.Id = rs.Id
		End Operator

		Shared Operator <>(ls As DbEntry, rs As DbEntry) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
