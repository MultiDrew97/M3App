Namespace Types
	Public Class Template
		Property Name As String
		Property Text As String
		Property Subject As String

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
