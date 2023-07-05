Imports System.Text.RegularExpressions

Public Class PhoneNumberField
	Public Property PhoneNumber As String
		Get
			If txt_PhoneNumber.Text = "(   )    -" Then
				Return ""
			End If

			Return txt_PhoneNumber.Text
		End Get
		Set(value As String)
			txt_PhoneNumber.Text = value
		End Set
	End Property

	Public ReadOnly Property ValidPhone As Boolean
		Get
			Return String.IsNullOrEmpty(PhoneNumber) OrElse Regex.IsMatch(PhoneNumber, My.Resources.PhoneRegex)
		End Get
	End Property
End Class
