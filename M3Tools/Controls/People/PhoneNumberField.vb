Imports System.Text.RegularExpressions

Public Class PhoneNumberField
	Public Overrides Property Text As String
		Get
			Return txt_PhoneNumber.Text
		End Get
		Set(value As String)
			txt_PhoneNumber.Text = value
		End Set
	End Property

	Public ReadOnly Property ValidPhone As Boolean
		Get
			Return ValidatePhone()
		End Get
	End Property

	Private Function ValidatePhone() As Boolean
		If Not (String.IsNullOrWhiteSpace(Text) OrElse Regex.IsMatch(Text, "\d{7,10}") OrElse Not txt_PhoneNumber.MaskCompleted) Then
			'  Set error provider for phone number control
			ep_InvalidPhone.SetError(txt_PhoneNumber, "Invalid phone number")
			Return False
		End If

		Return True
	End Function
End Class
