Imports System.ComponentModel

Namespace Types
	<TypeConverter(GetType(Converters.UserConverter))>
	Public Class User
		Inherits Person

		<Text.Json.Serialization.JsonPropertyName("userID")>
		Public Overrides Property Id As Integer

		<Text.Json.Serialization.JsonPropertyName("login")>
		Public Property Login As Auth

		<Text.Json.Serialization.JsonIgnore>
		Public ReadOnly Property IsAdmin As Boolean
			Get
				Return Login.Role = AccountRole.Admin
			End Get
		End Property

		<Text.Json.Serialization.JsonIgnore>
		Shadows ReadOnly Property ToString() As String
			Get
				Return String.Join(";", Id, Name, Login.Username, Email, Login.Salt, CInt(Login.Role))
			End Get
		End Property

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(userID As Integer, Optional fName As String = "John", Optional lName As String = "Doe",
					   Optional email As String = Nothing, Optional username As String = "JohnDoe123",
					   Optional password As String = Nothing, Optional salt As Guid = Nothing,
					   Optional accountRole As AccountRole = AccountRole.User)
			Me.New(userID, $"{fName} {lName}", email, New Auth(username, password, salt, accountRole))
		End Sub

		'Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As String, accountRole As AccountRole)
		'	Me.New(id, name, username, email, password, If(String.IsNullOrWhiteSpace(salt), Guid.NewGuid(), Guid.Parse(salt)), accountRole)
		'End Sub

		'Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As Guid, accountRole As AccountRole)
		'	Me.New(id, name, email, )
		'End Sub

		Private Sub New(id As Integer, name As String, email As String, login As Auth)
			MyBase.New(id, name, email)
			Me.Login = login
		End Sub

		'Public Overrides Sub UpdateID(newID As Integer)
		'	If newID = Id Then
		'		Return
		'	End If

		'	Using conn As New Database.ProductDatabase
		'		' TODO: Finish implementing updates
		'	End Using
		'End Sub
	End Class
End Namespace

Namespace Types.Converters
	Friend Class UserConverter
		Inherits TypeConverter
		'ReadOnly fields As New Dictionary(Of String, Integer) From {
		'	{"ID", 0}, {"FirstName", 1}, {"LastName", 2},
		'	{"Email", 3}, {"Username", 4}, {"Password", 5},
		'	{"Salt", 6}, {"Role", 7}
		'}

		Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
			Return sourceType = GetType(String)
		End Function

		Public Overloads Function ConvertFrom(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As String) As Object
			'If Not value.GetType = GetType(String) Then
			'	Return MyBase.ConvertFrom(context, culture, value)
			'	'Dim parts() As String = CStr(value).Split(";"c)
			'	'Dim guid As Guid

			'	'Dim success = Guid.TryParse(parts(4), guid)

			'	'' FIXME: Determine better way to parse a user from string after refactoring User constructors
			'	'Dim user As New User(CInt(parts(fields("ID"))), parts(fields("FirstName")), parts(fields("LastName")), parts(fields("Email")),
			'	'					 parts(fields("Username")), parts(fields("Password")), Guid.Parse(parts(fields("Salt"))),
			'	'					 CType(CInt(parts(fields("Role"))), AccountRole))

			'	'Return user
			'End If

			Return JSON.ConvertFromJSON(Of User)(value)
		End Function

		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As Object, destinationType As Type) As Object
			If Not destinationType = GetType(String) Then
				Return MyBase.ConvertTo(context, culture, value, destinationType)
			End If

			Return JSON.ConvertToJSON(value)
		End Function
	End Class
End Namespace
