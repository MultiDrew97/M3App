Imports System.ComponentModel
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
			Me.New(-1, "JohnDoe123", Nothing, Nothing, AccountRole.User)
		End Sub

		Public Sub New(id As Integer, username As String, password As Byte(), salt As Guid, accountRole As AccountRole)
			Me.Id = id
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
	End Class
End Namespace
