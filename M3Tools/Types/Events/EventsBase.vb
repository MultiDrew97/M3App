Namespace Events
	Public MustInherit Class BaseArgs
		Inherits EventArgs
		Property EventType As EventType
	End Class

	Public Enum EventType
		None
		Added
		Deleted
		Editted
	End Enum
End Namespace
