Namespace Types
	Public Class Auth
		<Text.Json.Serialization.JsonPropertyName("username")>
		Property Username As String

		<Text.Json.Serialization.JsonPropertyName("password")>
		Property Password As String

		Public Sub New(Optional username As String = "", Optional password As String = "")
			Me.Username = username
			Me.Password = password
		End Sub
	End Class
End Namespace