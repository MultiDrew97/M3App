Option Strict On
Namespace Types
	Public MustInherit Class Person
		Inherits DbEntry
		Private __email As MimeKit.MailboxAddress

		<ComponentModel.Category("Basics")>
		<Text.Json.Serialization.JsonPropertyName("firstName")>
		Public Property FirstName As String

		<ComponentModel.Category("Basics")>
		<Text.Json.Serialization.JsonPropertyName("lastName")>
		Public Property LastName As String

		<ComponentModel.Category("Contact")>
		<Text.Json.Serialization.JsonPropertyName("email")>
		Public Property Email As String
			Get
				Return If(String.IsNullOrWhiteSpace(__email.Address), Nothing, __email.Address)
			End Get
			Set(value As String)
				__email = New MimeKit.MailboxAddress(Name, If(value, ""))
			End Set
		End Property

		'<ComponentModel.Browsable(False)>
		<Text.Json.Serialization.JsonPropertyName("name")>
		Public Property Name As String
			Get
				Return String.Join(" "c, FirstName, LastName).Trim()
			End Get
			Set(name As String)
				ParseName(name)
			End Set
		End Property

		Protected Friend Sub New(Optional id As Integer = -1, Optional name As String = "John Doe", Optional email As String = "JohnDoe@domain.ext")
			MyBase.New(id)
			ParseName(name)
			Me.Email = If(email, String.Empty).Trim()
		End Sub

		Private Sub ParseName(name As String)
			' TODO: Look into better parsing name data
			Dim parts = name.Trim().Split(" "c)
			FirstName = parts(0)

			Try
				LastName = parts(1)
			Catch
				LastName = Nothing
			End Try
		End Sub

		Overloads Shared Operator =(ls As Person, rs As Person) As Boolean
			Return ls.Id = rs.Id And ls.Name.Equals(rs.Name) And ls.Email.Equals(rs.Email)
		End Operator

		Overloads Shared Operator <>(ls As Person, rs As Person) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
