Option Strict On
Namespace Types
    Public Class Address
        Public Property Street As String
        Public Property City As String
        Public Property State As String
		Public Property ZipCode As String

		Public Sub New()
			Me.New("123 Main St", "City", "ST", "12345")
		End Sub

		Public Sub New(street As String, city As String, state As String, zipCode As String)
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

			If Not (streetStr <> "" Or cityStr <> "" Or stateStr <> "" Or zipStr <> "") Then
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
	End Class
End Namespace
