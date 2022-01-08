Public Class PhoneNumberField
    Public Property PhoneNumber As String
        Get
            Return txt_PhoneNumber.Text
        End Get
        Set(value As String)
            txt_PhoneNumber.Text = value
        End Set
    End Property
End Class
