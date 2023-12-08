Option Strict On

Namespace Types
	Public Class Customer
		Inherits Person
		'Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
		Private __phone As String

		<ComponentModel.Browsable(False)>
		<Text.Json.Serialization.JsonPropertyName("customerID")>
		Overrides Property Id As Integer

		<ComponentModel.Category("Contact")>
		<Text.Json.Serialization.JsonPropertyName("phoneNumber")>
		Public Property PhoneNumber As String
			Get
				Return __phone
			End Get
			Set(value As String)
				__phone = value.FormatPhone()
			End Set
		End Property

		<ComponentModel.Category("Contact")>
		<ComponentModel.TypeConverter(GetType(ComponentModel.ExpandableObjectConverter))>
		<Text.Json.Serialization.JsonPropertyName("address")>
		Public Property Address As Address

		<ComponentModel.Browsable(False)>
		<Text.Json.Serialization.JsonPropertyName("joined")>
		Public Property Joined As Date
		'	Get
		'		If __joined.Year < 1950 OrElse IsNothing(__joined) Then
		'			Return Nothing
		'		End If

		'		Return __joined
		'	End Get
		'	Set(value As Date)
		'		If value.Year < 1950 Then
		'			__joined = Nothing
		'		End If
		'	End Set
		'End Property

		Public Sub New()
			Me.New(-1, "John", "Doe", Nothing, "johndoe@domain.ext", "123-456-7890", Date.Now.ToLongDateString)
		End Sub

		Public Sub New(Optional customerID As Integer = -1, Optional firstName As String = "John", Optional lastName As String = "Doe",
					   Optional address As Address = Nothing, Optional email As String = "johndoe@domain.ext", Optional phoneNumber As String = "1234567890",
					   Optional joined As String = Nothing)
			Me.New(customerID, $"{firstName} {lastName}", address, phoneNumber, email, If(String.IsNullOrWhiteSpace(joined), Nothing, Date.Parse(joined)))
		End Sub

		Private Sub New(id As Integer, name As String, address As Address, phone As String, email As String, join As Date)
			MyBase.New(id, name, email)
			Me.PhoneNumber = phone
			Me.Address = If(address, Address.None)
			Me.Joined = join
		End Sub

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
	End Class
End Namespace
