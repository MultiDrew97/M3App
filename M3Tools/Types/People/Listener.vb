Option Strict On

Namespace Types
	Public Class Listener
		Inherits Person

		<Text.Json.Serialization.JsonPropertyName("listenerID")>
		Overrides Property Id As Integer

		Public Sub New()
			Me.New(-1)
		End Sub

		Public Sub New(listenerID As Integer, Optional fName As String = "Test", Optional lName As String = "Listener", Optional email As String = "TestListener@domain.tst")
			Me.New(listenerID, $"{fName} {lName}", email)
		End Sub

		Public Sub New(listenerID As Integer, name As String, email As String)
			MyBase.New(listenerID, name, email)
		End Sub

		Public Overrides Function ToString() As String
			Return $"{Id}) {Name} <{Email}>"
		End Function

		Shared Function Parse(arr As Object()) As Listener
			Return New Listener(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)))
		End Function

		Public Function Clone() As Listener
			Return New Listener(Me.Id, Me.Name, Me.Email)
		End Function
	End Class
End Namespace
