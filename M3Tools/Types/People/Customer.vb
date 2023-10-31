Option Strict On
Imports SPPBC.M3Tools.Types.Extensions

Namespace Types
	Public Class Customer
		Inherits Person
		'Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
		Private __joined As Date
		Private __phone As String

		<Text.Json.Serialization.JsonPropertyName("customerID")>
		Overrides Property Id As Integer

		<Text.Json.Serialization.JsonPropertyName("phoneNumber")>
		Public Property PhoneNumber As String
			Get
				Return __phone
			End Get
			Set(value As String)
				__phone = value.FormatPhone()
			End Set
		End Property

		<Text.Json.Serialization.JsonPropertyName("address")>
		Public Property Address As Address

		<Text.Json.Serialization.JsonPropertyName("joined")>
		Public Property Joined As Object
			Get
				If __joined.Year < 1950 OrElse IsNothing(__joined) Then
					Return Nothing
				End If

				Return __joined
			End Get
			Set(value As Object)
				Try
					__joined = CDate(value)
				Catch ex As Exception
					__joined = Nothing
				End Try
			End Set
		End Property

		Public Sub New()
			Me.New(-1, "John", "Doe", "123 Main St", "City", "ST", "00000", "123-456-7890", "johndoe@domain.ext")
		End Sub

		Public Sub New(id As Integer, fName As String, lName As String, email As String, join As Date)
			Me.New(id, fName, lName, Nothing, Nothing, email, join)
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

		Public Sub New(id As Integer, name As String, address As Address, phone As String, email As String, Optional join As Date = Nothing)
			MyBase.New(id, name, email)
			PhoneNumber = phone
			Me.Address = address
			Joined = join
		End Sub

		Shared Function Parse(ParamArray arr As Object()) As Customer
			Return New Customer(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)), Address.Parse(CStr(arr(3))),
								CStr(arr(4)), CStr(arr(5)), CDate(arr(6)))
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

		Public Function Display() As String
			'ID) Name (Email)
			'Street
			'City, ST ZipCode
			'Phone Number
			Return $"{Id}) {Name} (e: {Email} p: {PhoneNumber}){vbCrLf}{vbCrLf}{Address.Display}{vbCrLf}"
		End Function

		'Public Overrides Sub UpdateID(newID As Integer)
		'	If newID = Id Then
		'		Return
		'	End If

		'	Using conn As New Database.ProductDatabase
		'		Dim newProduct = conn.GetProduct(newID)

		'		' TODO: Finish implementing updates
		'	End Using
		'End Sub

		Public Function Clone() As Customer
			Return New Customer(Me.Id, Me.FirstName, Me.LastName, Me.Address, Me.PhoneNumber, Me.Email, CDate(Me.Joined))
		End Function
	End Class
End Namespace