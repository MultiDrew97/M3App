Option Strict On
Namespace Types
	Public Class Address

		<Text.Json.Serialization.JsonPropertyName("street")>
		Public Property Street As String

		<Text.Json.Serialization.JsonPropertyName("city")>
		Public Property City As String

		<Text.Json.Serialization.JsonPropertyName("state")>
		Public Property State As String

		<Text.Json.Serialization.JsonPropertyName("zipCode")>
		Public Property ZipCode As String

		Public Shared ReadOnly Property None As Address
			Get
				Return New Address()
			End Get
		End Property

		<Text.Json.Serialization.JsonConstructor>
		Public Sub New(Optional street As String = "123 Main St", Optional city As String = "City", Optional state As String = "ST", Optional zipCode As String = "12345")
			Me.Street = street
			Me.City = city
			Me.State = state
			Me.ZipCode = zipCode
		End Sub

		Public Shared Function Parse(addrStr As String) As Address
			Dim addrParts = addrStr.Split(","c)

			If addrParts.Count < 4 Then
				Throw New ArgumentException($"Unable to parse an address from '{addrStr}'")
			End If

			Return Parse(addrParts(0), addrParts(1), addrParts(2), addrParts(3))
		End Function

		Public Shared Function Parse(street As Object, city As Object, state As Object, zipCode As Object) As Address
			Dim streetStr, cityStr, stateStr, zipStr As String

			streetStr = TryCast(street, String)
			cityStr = TryCast(city, String)
			stateStr = TryCast(state, String)
			zipStr = TryCast(zipCode, String)

			If Not (streetStr <> "" OrElse cityStr <> "" OrElse stateStr <> "" OrElse zipStr <> "") Then
				Return Nothing
			End If

			Return New Address(streetStr, cityStr, stateStr, zipStr)
		End Function

		Public Overrides Function ToString() As String
			Return String.Join(My.Settings.ObjectDelimiter, Street, City, State, ZipCode)
		End Function

		Public Function Display() As String
			'If there was not an address supplied, it doesn't apply the formating
			Return If(
				(String.IsNullOrEmpty(Street) Or String.IsNullOrEmpty(City) Or String.IsNullOrEmpty(State) Or String.IsNullOrEmpty(ZipCode)),
				"",
				$"{String.Join(vbCrLf, Street.Split(","c).Where(Function(currentString As String) As Boolean
																	Return Not String.IsNullOrWhiteSpace(currentString)
																End Function))}{vbCrLf}{City}, {State} {ZipCode}")
		End Function

		Shared Operator =(left As Address, right As Address) As Boolean
			If left Is Nothing AndAlso right Is Nothing Then
				Return True
			End If

			If (left Is Nothing And right IsNot Nothing) OrElse (left IsNot Nothing And right Is Nothing) Then
				Return False
			End If

			If left.Street <> right.Street Then
				Return False
			End If

			If left.City <> right.City Then
				Return False
			End If

			If left.State <> right.State Then
				Return False
			End If

			If left.ZipCode <> right.ZipCode Then
				Return False
			End If

			Return True
		End Operator

		Shared Operator <>(left As Address, right As Address) As Boolean
			Return Not left = right
		End Operator
	End Class
End Namespace
