Option Strict On

Namespace Types
    Public Class Customer
        Inherits Person
		'Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"

		Public Property PhoneNumber As String
		Public Property Address As Address
		Public Property Joined As Date

		Public Sub New()
			Me.New(-1, "John", "Doe", "123 Main St", "City", "ST", "00000", "123-456-7890", "johndoe@domain.ext")
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, $"{fName} {lName}", New Address(street, city, state, zip), phone, email, join)
		End Sub

		Public Sub New(id As Integer, name As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, name, New Address(street, city, state, zip), phone, email, join)
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, address As Address, phone As String, email As String, Optional join As Date = Nothing)
			Me.New(id, $"{fName} {lName}", address, phone, email, join)
		End Sub

		Public Sub New(id As Integer, name As String, address As Address, phone As String, email As String, join As Date)
			MyBase.New(id, name)
			PhoneNumber = phone
			Me.Address = address
			Me.Email = email
			Joined = join
		End Sub

		Shared Function Parse(ParamArray arr As Object()) As Customer
			Return New Customer(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)), CStr(arr(3)), CStr(arr(4)), CStr(arr(5)), CStr(arr(6)), CStr(arr(7)), CStr(arr(8)), CDate(arr(9)))
		End Function

		Public Overrides Function ToString() As String
			'Name (Email)
			'Street
			'City, ST ZipCode
			'Phone Number
			Return $"{Name} ({Email}){vbCrLf}
					{Address}{vbCrLf}
					{PhoneNumber}"
		End Function
    End Class
End Namespace
