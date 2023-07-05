Imports System.ComponentModel
Imports System.Globalization

Namespace Types
	<TypeConverter(GetType(Converters.UserConverter))>
	Public Class User
		Inherits Person

		Public Property Username As String
		Public Property Password As Byte()
		Public Property Salt As Guid
		Public Property AccountRole As AccountRole

		Public ReadOnly Property IsAdmin As Boolean
			Get
				Return AccountRole = AccountRole.Admin
			End Get
		End Property

		Public Sub New()
			' TODO: Add constructor options like other objects
			Me.New(-1, "John", "Doe", Nothing, "JohnDoe123", "JohnDoe123!", Nothing, AccountRole.User)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As String, salt As Guid, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, Text.Encoding.UTF8.GetBytes(password), salt, accountRole)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As Byte(), salt As Guid, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, password, salt, accountRole)
		End Sub

		Public Sub New(id As Integer, name As String, email As String, username As String, password As Byte(), salt As Guid, accountRole As AccountRole)
			MyBase.New(id, name, email)
			Me.Username = username
			Me.Password = password
			Me.Salt = salt
			Me.AccountRole = accountRole
		End Sub

		Shadows ReadOnly Property ToString() As String
			Get
				Return String.Join(";", Id, Username, Salt, CInt(AccountRole))
			End Get
		End Property

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

		Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
			Return sourceType = GetType(String)
		End Function

		Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, value As Object) As Object
			If value.GetType = GetType(String) Then
				Dim parts() As String = CStr(value).Split(";"c)
				Dim user As New User With {
					.Id = CInt(parts(0)),
					.Username = parts(1),
					.Salt = Guid.Parse(parts(2)),
					.AccountRole = CType(CInt(parts(3)), AccountRole)
				}

				Return user
			End If

			Return MyBase.ConvertFrom(context, culture, value)
		End Function

		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
			If destinationType = GetType(String) Then
				Dim user = CType(value, User)
				Return user.ToString
			End If

			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function
	End Class
End Namespace
