Option Strict On

Namespace Types
    Public Class Customer
        Inherits Person
        Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
        Private __email As MimeKit.MailboxAddress
        Private __joinDate As Date

        Public Property PhoneNumber As String
        Public Property Address As Address
        'Public Property Address As String
        '    Get
        '        Return __address.ToString
        '    End Get
        '    Set(value As String)
        '        Dim addressParts As String() = value.Split(","c)
        '        __address = New Address() With {
        '            .Street = addressParts(0),
        '            .City = addressParts(1),
        '            .State = addressParts(2),
        '            .ZipCode = addressParts(3)}
        '    End Set
        'End Property
        Public Property EmailAddress As String
            Get
                Return __email.Address
            End Get
			Set(value As String)
				If value Is Nothing Then
					Exit Property
				End If
				__email = New MimeKit.MailboxAddress(Name, If(ValidEmail(value), value, __email.Address))
			End Set
		End Property
        Public Property JoinDate As String
            Get
                Return __joinDate.ToShortDateString()
            End Get
            Set(value As String)
                __joinDate = Date.Parse(If(String.IsNullOrWhiteSpace(value), "1/1/1970", value))
            End Set
        End Property

        Public Sub New()
            Me.New(-1, "John Doe", "123 Main St", "City", "ST", "00000", "123-456-7890", "johndoe@domain.ext")
        End Sub

        Public Sub New(customerID As Integer, name As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As String = "")
            MyBase.New(customerID, name)
            Address = New Address(street, city, state, zip)
            PhoneNumber = phone
            EmailAddress = email
            JoinDate = join
        End Sub

        Public Sub New(customerID As Integer, firstName As String, lastName As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional join As String = "")
            MyBase.New(customerID, firstName, lastName)
            PhoneNumber = phone
            Address = New Address(street, city, state, zip)

            If ValidEmail(email) Then
                EmailAddress = email
            Else
                EmailAddress = Nothing
            End If

            If Not String.IsNullOrEmpty(JoinDate) Then
                JoinDate = join
            End If
        End Sub

        Private Function ValidEmail(email As String) As Boolean
            Try
                Return Text.RegularExpressions.Regex.IsMatch(email, EmailPattern)
            Catch ex As ArgumentNullException
                Return False
            End Try

        End Function

        Shared Function Parse(arr As Object()) As Customer
            Return New Customer(CInt(arr(0)), CStr(arr(1)), CStr(arr(2)), CStr(arr(3)), CStr(arr(4)), CStr(arr(5)), CStr(arr(6)), CStr(arr(7)), CStr(arr(8)), CStr(arr(9)))
        End Function

        Public Overrides Function ToString() As String
            'Name (Email)
            'Street
            'City, ST ZipCode
            'Phone Number
            Return String.Format("{0} ({1}){4}{2}{4}{3}", Name, EmailAddress, Address.ToString, PhoneNumber, vbCrLf)
        End Function
    End Class
End Namespace
