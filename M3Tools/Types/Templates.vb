Namespace Types
	Public Class Template
		Property Name As String
		Property Text As String
		Property Subject As String

		Public Sub New(Optional name As String = "", Optional text As String = "", Optional subject As String = "")
			Me.Name = name
			Me.Text = text
			Me.Subject = subject
		End Sub

		Shared Operator =(left As Template, right As Template) As Boolean
			Return left.Name = right.Name
		End Operator

		Shared Operator <>(left As Template, right As Template) As Boolean
			Return Not left = right
		End Operator
	End Class

	Public Class TemplateList
		Inherits List(Of Template)
	End Class
End Namespace
