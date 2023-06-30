Option Strict On

Namespace Types
	Public MustInherit Class DBEntry
		Private _id As Integer
		Property Id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				' TODO: Figure out what to do for id checking if at all
				'If Not Utils.ValidID(value) Then
				'	Throw New ArgumentException($"ID Values must be greater than or equal to {My.Settings.MinID}")
				'End If

				_id = value
			End Set
		End Property

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(id As Integer)
			Me.Id = id
		End Sub

		Public MustOverride Sub UpdateID(newID As Integer)

		Shared Operator =(ls As DBEntry, rs As DBEntry) As Boolean
			Return ls.Id = rs.Id
		End Operator

		Shared Operator <>(ls As DBEntry, rs As DBEntry) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
