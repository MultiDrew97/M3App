Option Strict On
Namespace Types
    Public Class Address
        Public Property Street As String
        Public Property City As String
        Public Property State As String
        Public Property ZipCode As String

        Public Sub New(street As String, city As String, state As String, zipCode As String)
            Me.Street = street
            Me.City = city
            Me.State = state
            Me.ZipCode = zipCode
        End Sub

        Public Sub New()
        End Sub

        Public Overrides Function ToString() As String
            'If there was not an address supplied, it doesn't apply the formating
            Return If(
                (String.IsNullOrEmpty(Street) Or String.IsNullOrEmpty(City) Or String.IsNullOrEmpty(State) Or String.IsNullOrEmpty(ZipCode)),
                "",
                String.Format("{0}{4}{1}, {2} {3}", Street, City, State, ZipCode, vbCrLf))
        End Function
    End Class
End Namespace
