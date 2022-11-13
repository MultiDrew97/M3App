Option Strict On
Namespace Types
	' TODO: Potentially return to MustInherit
	Public Class Person
		Public Property Id As Integer
		Public Property FirstName As String
		Public Property LastName As String

		Public Property Name As String
			Get
				Return CType(IIf(IsNothing(LastName), FirstName, String.Join(" "c, {FirstName, LastName})), String)
			End Get
			Set(name As String)
				Dim parts = name.Split(" "c)
				FirstName = parts(0)

				Try
					LastName = parts(1)
				Catch ex As Exception
					LastName = ""
				End Try
			End Set
		End Property

		Public Sub New()
			Me.New(-1, "John Doe")
		End Sub

		Public Sub New(id As Integer, name As String)
			Me.Id = id
			Me.Name = name
		End Sub

		Public Sub New(id As Integer, firstName As String, lastName As String)
			Me.Id = id
			Me.FirstName = firstName
			Me.LastName = lastName
		End Sub
	End Class
End Namespace
