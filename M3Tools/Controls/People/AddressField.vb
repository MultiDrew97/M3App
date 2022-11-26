Public Class AddressField
	Public ReadOnly Property Address As Types.Address
		Get
			Return Types.Address.Parse(Street, City, State, ZipCode)
		End Get
	End Property

	Public Property Street As String
		Get
			If String.IsNullOrWhiteSpace(if_Address1.Text) And String.IsNullOrWhiteSpace(if_Address2.Text) Then
				' No values present
				Return ""
			End If

			If String.IsNullOrWhiteSpace(if_Address2.Text) Then
				' Only Address1 is filled
				Return if_Address1.Text
			End If

			' Both fields present
			Return String.Join(",", if_Address1.Text, if_Address2.Text)
		End Get
		Set(value As String)
			If value.Contains(",") Then
				Dim parts = value.Split(","c)
				if_Address1.Text = parts(0)
				if_Address2.Text = parts(1)
				Return
			End If

			if_Address1.Text = value
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
			If value?.Length >= 2 Then
				value = value.Substring(0, 2)
			End If

			ssf_State.StateCode = value
		End Set
	End Property

	Public Property ZipCode As String
		Get
			Return if_ZipCode.Text
		End Get
		Set(value As String)
			If value.Length > 5 Then
				value = value.Substring(0, 5)
			End If

			if_ZipCode.Text = value
		End Set
	End Property

	Public ReadOnly Property IsValidAddress As Boolean
		Get
			Return (Street <> "" AndAlso City <> "" AndAlso State <> "" AndAlso ZipCode <> "") OrElse (String.IsNullOrEmpty(Street) AndAlso String.IsNullOrEmpty(City) AndAlso String.IsNullOrEmpty(State) AndAlso String.IsNullOrEmpty(ZipCode))
		End Get
	End Property
End Class
