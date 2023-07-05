Option Strict On
Imports System.ComponentModel

Namespace Types
	Public Class Customer
		Inherits Person
		' Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
		Public Property PhoneNumber As String
		Public Property Address As Address
		Public Property EmailAddress As MimeKit.MailboxAddress
		Public Property JoinDate As Date

		Public Sub New(customerID As Integer, firstName As String, lastName As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional joinDate As String = "")
			MyBase.New(customerID, firstName, lastName)
			Me.PhoneNumber = phone
			Me.Address = New Address(street, city, state, zip)
			Me.EmailAddress = New MimeKit.MailboxAddress(Name, email)

			If Not String.IsNullOrEmpty(joinDate) Then
				Me.JoinDate = Date.Parse(joinDate)
			End If
		End Sub

		Shared Function Parse(arr As Object()) As Customer
			Return New Customer(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)), CStr(arr(3)), CStr(arr(4)), CStr(arr(5)), CStr(arr(6)), CStr(arr(7)), CStr(arr(8)), CStr(arr(9)))
		End Function

		Public Overrides Function ToString() As String
			'Name (Email)
			'Street
			'City, ST ZipCode
			'Phone Number
			Return String.Format("{0} ({1}){4}{2}{4}{3}", Me.Name, EmailAddress.Address, Me.Address.ToString, Me.PhoneNumber, vbCrLf)
		End Function
	End Class
End Namespace
