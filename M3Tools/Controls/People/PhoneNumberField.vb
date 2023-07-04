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
			Return Regex.IsMatch(txt_PhoneNumber.Text, My.Resources.PhoneRegex)
		End Get
	End Property
End Class
