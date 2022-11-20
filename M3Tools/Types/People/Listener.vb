Option Strict On

Namespace Types
    Public Class Listener
		Inherits Person

		Public Sub New()
			Me.New(-1, "John Doe")
		End Sub

		Public Sub New(listenerID As Integer, fName As String, lName As String, Optional email As String = "")
			Me.New(listenerID, $"{fName} {lName}", email)
		End Sub

		Public Sub New(listenerID As Integer, name As String, Optional email As String = "")
			MyBase.New(listenerID, name, email)
		End Sub

		Shared Function ParseName(name As String) As String()
			' TODO: May not need anymore
			'Parse the name given into seperate first and last name parts and return the string array with supplied name
			Dim nameParts As String()
			nameParts = name.Split(" "c)

			If nameParts.Length = 3 Then
				nameParts = {nameParts(0), nameParts(1) & " " & nameParts(2)}
			ElseIf nameParts.Length = 1 Then
				nameParts = {nameParts(0), ""}
			ElseIf nameParts.Length = 0 Then
				nameParts = {"", ""}
			End If

			Return nameParts
		End Function

		Public Overrides Function ToString() As String
			Return $"{Id}) {Name} <{Email}>"
		End Function

		Shared Function Parse(arr As Object()) As Listener
			Return New Listener(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)))
		End Function
	End Class
End Namespace