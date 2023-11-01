Imports System.Text.RegularExpressions

Public Class PhoneNumberField
	Public Property PhoneNumber As String
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
		If Not (String.IsNullOrWhiteSpace(PhoneNumber) OrElse Regex.IsMatch(PhoneNumber, "\d{7,10}") OrElse Regex.IsMatch(PhoneNumber, My.Resources.PhoneRegex)) Then
			'  Set error provider for phone number control
			ep_InvalidPhone.SetError(txt_PhoneNumber, "Either a valid number or no number is required")
			Return False
		End If

		Return True
	End Function
End Class
