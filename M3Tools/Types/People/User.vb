﻿Imports System.ComponentModel
Imports System.Globalization

Namespace Types
	<TypeConverter(GetType(Converters.UserConverter))>
	Public Class User
		Inherits Person

		<Text.Json.Serialization.JsonPropertyName("username")>
		Public Property Username As String

		<Text.Json.Serialization.JsonPropertyName("password")>
		<Text.Json.Serialization.JsonIgnore>
		Public Property Password As Byte()

		<Text.Json.Serialization.JsonPropertyName("salt")>
		Public Property Salt As Guid

		<Text.Json.Serialization.JsonPropertyName("accountRole")>
		Public Property AccountRole As AccountRole

		<Text.Json.Serialization.JsonIgnore>
		Public ReadOnly Property IsAdmin As Boolean
			Get
				Return AccountRole = AccountRole.Admin
			End Get
		End Property

		Public Sub New()
			' TODO: Add constructor options like other objects
			Me.New(-1, "John", "Doe", Nothing, "JohnDoe123", "JohnDoe123!", "", AccountRole.User)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As String, salt As String, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, Text.Encoding.UTF8.GetBytes(password), salt, accountRole)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As String, salt As Guid, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, Text.Encoding.UTF8.GetBytes(password), salt, accountRole)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As Byte(), salt As String, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, password, salt, accountRole)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, username As String, password As Byte(), salt As Guid, accountRole As AccountRole)
			Me.New(id, $"{fName} {lName}", email, username, password, salt, accountRole)
		End Sub

		Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As String, accountRole As AccountRole)
			Me.New(id, name, username, email, password, If(String.IsNullOrWhiteSpace(salt), Guid.NewGuid(), Guid.Parse(salt)), accountRole)
		End Sub

		Public Sub New(id As Integer, name As String, username As String, email As String, password As Byte(), salt As Guid, accountRole As AccountRole)
			MyBase.New(id, name, email)
			Me.Username = username
			Me.Password = password
			Me.Salt = salt
			Me.AccountRole = accountRole
		End Sub

		Shadows ReadOnly Property ToString() As String
			Get
				Return String.Join(";", Id, Name, Username, Email, Salt, CInt(AccountRole))
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
				Dim guid As Guid

				Dim success = Guid.TryParse(parts(4), guid)

				Dim user As New User(CInt(parts(0)), parts(1), parts(2), parts(3), Nothing, parts(4), CType(CInt(parts(5)), AccountRole))

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
