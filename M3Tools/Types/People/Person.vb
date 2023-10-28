Option Strict On
Namespace Types
	' TODO: Potentially return to MustInherit
	Public MustInherit Class Person
		Inherits DBEntry

		Private __email As MimeKit.MailboxAddress

		<Text.Json.Serialization.JsonPropertyName("firstName")>
		Public Property FirstName As String

		<Text.Json.Serialization.JsonPropertyName("lastName")>
		Public Property LastName As String

		<Text.Json.Serialization.JsonPropertyName("email")>
		Public Property Email As String
			Get
				Return If(String.IsNullOrWhiteSpace(__email.Address), Nothing, __email.Address)
			End Get
			Set(value As String)
				__email = New MimeKit.MailboxAddress(Name, If(Not String.IsNullOrWhiteSpace(value), value, ""))
			End Set
		End Property

		<Text.Json.Serialization.JsonPropertyName("name")>
		Public Property Name As String
			Get
				Return CType(IIf(IsNothing(LastName), FirstName, String.Join(" "c, {FirstName, LastName})), String)
			End Get
			Set(name As String)
				' TODO: Look into better parsing name data
				Dim parts = name.Split(" "c)
				FirstName = parts(0)
				LastName = String.Join(" ", parts.Skip(1))
			End Set
		End Property

		Public Sub New()
			Me.New(-1, "John", "Doe", "johndoe@domain.ext")
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, Optional email As String = Nothing)
			Me.New(id, $"{fName} {lName}", email)
		End Sub

		Public Sub New(id As Integer, name As String, Optional email As String = Nothing)
			MyBase.New(id)
			Me.Name = name.Trim()
			Me.Email = email.Trim()
		End Sub

		'Public Overrides Sub UpdateID(newID As Integer)
		'	' TODO: Verify this
		'	If newID = Id Then
		'		Return
		'	End If

		'	Using conn As New Database.ProductDatabase
		'		Dim newProduct = conn.GetProduct(newID)

		'		' TODO: Finish implementing updates
		'	End Using
		'End Sub

		Overloads Shared Operator =(ls As Person, rs As Person) As Boolean
			Return ls.Id = rs.Id And ls.Name.Equals(rs.Name) And ls.Email.Equals(rs.Email)
		End Operator

		Overloads Shared Operator <>(ls As Person, rs As Person) As Boolean
			Return Not ls = rs
		End Operator
	End Class
End Namespace
