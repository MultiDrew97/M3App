Public Class AddressField
    Public Property Street As String
        Get
            Return String.Join(",", {if_Address1.Text, if_Address2.Text})
        End Get
        Set(value As String)
            If value.Contains(",") Then
                Dim parts = value.Split(","c)
                if_Address1.Text = parts(0)
                if_Address2.Text = parts(1)
            Else
                if_Address1.Text = value
            End If
        End Set
    End Property

    Public Property City As String
        Get
            Return if_City.Text
        End Get
        Set(value As String)
            if_City.Text = value
        End Set
    End Property

    Property State As String
        Get
            Return ssf_State.StateCode
        End Get
        Set(value As String)
            If value.Length >= 2 Then
                ssf_State.StateCode = value.Substring(0, 2)
            End If
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return if_ZipCode.Text
        End Get
        Set(value As String)
            If value.Length >= 5 Then
                if_ZipCode.Text = value.Substring(0, 5)
            End If
        End Set
    End Property

    Public ReadOnly Property IsValidAddress As Boolean
        Get
            Return (Street <> "" And City <> "" And State <> "" And ZipCode <> "") Or (String.IsNullOrEmpty(Street) And String.IsNullOrEmpty(City) And String.IsNullOrEmpty(State) And String.IsNullOrEmpty(ZipCode))
        End Get
    End Property
End Class
