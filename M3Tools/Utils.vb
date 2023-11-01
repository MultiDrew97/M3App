Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Windows.Forms

Public Structure Utils
	Shared Function ToSecureString(password As String) As SecureString
		Dim secureString As New SecureString()

		For Each ch As Char In password
			secureString.AppendChar(ch)
		Next

		secureString.MakeReadOnly()

		Return secureString
	End Function

	Shared ReadOnly Property DefaultFileName(fileName As String) As String
		Get
			Return fileName.Split(CType("\\", Char()))(fileName.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy")
		End Get
	End Property

	Shared Sub Wait(Optional seconds As Integer = 5)
		'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

		For i As Integer = 0 To seconds * 100
			Threading.Thread.Sleep(10)
			Application.DoEvents()
		Next
	End Sub

	Shared Function ToUnsecureString(password As SecureString) As String
		Dim returnValue = IntPtr.Zero
		Try
			returnValue = Marshal.SecureStringToGlobalAllocUnicode(password)
			Return Marshal.PtrToStringUni(returnValue)
		Catch ex As Exception
			Marshal.ZeroFreeGlobalAllocUnicode(returnValue)
			Return String.Join(": ", {"Error", password.Length})
		End Try
	End Function

	Shared Function StateCodeToState(stateCode As String) As String
		' MAYBE: Convert to use a dictionary
		Select Case stateCode.ToUpper()
			Case "AL"
				Return "Alabama"
			Case "AK"
				Return "Alaska"
			Case "AZ"
				Return "Arizona"
			Case "AR"
				Return "Arkansas"
			Case "CA"
				Return "California"
			Case "CO"
				Return "Colorado"
			Case "CT"
				Return "Connecticut"
			Case "DE"
				Return "Delaware"
			Case "FL"
				Return "Florida"
			Case "GA"
				Return "Georgia"
			Case "HI"
				Return "Hawaii"
			Case "ID"
				Return "Idaho"
			Case "IL"
				Return "Illinois"
			Case "IN"
				Return "Indiana"
			Case "IA"
				Return "Iowa"
			Case "KS"
				Return "Kansas"
			Case "KY"
				Return "Kentucky"
			Case "LA"
				Return "Louisiana"
			Case "ME"
				Return "Maine"
			Case "MD"
				Return "Maryland"
			Case "MA"
				Return "Massachusetts"
			Case "MI"
				Return "Michigan"
			Case "MN"
				Return "Minnesota"
			Case "MS"
				Return "Mississippi"
			Case "MO"
				Return "Missouri"
			Case "MT"
				Return "Montana"
			Case "NE"
				Return "Nebraska"
			Case "NV"
				Return "Nevada"
			Case "NH"
				Return "New Hampshire"
			Case "NJ"
				Return "New Jersey"
			Case "NM"
				Return "New Mexico"
			Case "NY"
				Return "New York"
			Case "NC"
				Return "North Carolina"
			Case "ND"
				Return "North Dakota"
			Case "OH"
				Return "Ohio"
			Case "OK"
				Return "Oklahoma"
			Case "OR"
				Return "Oregon"
			Case "PA"
				Return "Pennsylvania"
			Case "RI"
				Return "Rhode Island"
			Case "SC"
				Return "South Carolina"
			Case "SD"
				Return "South Dakota"
			Case "TN"
				Return "Tennessee"
			Case "TX"
				Return "Texas"
			Case "UT"
				Return "Utah"
			Case "VT"
				Return "Vermont"
			Case "VA"
				Return "Virgina"
			Case "WA"
				Return "Washington"
			Case "WV"
				Return "West Virgina"
			Case "WI"
				Return "Wisconsin"
			Case "WY"
				Return "Wyoming"
			Case Else
				Throw New Exceptions.InvalidStateCodeException("The provided state code is invalid.")
		End Select
	End Function

	Shared Function StateToStateCode(state As String) As String
		Select Case state
			Case "alabama"
				Return "AL"
			Case "alaska"
				Return "AK"
			Case "arizona"
				Return "AZ"
			Case "arkansas"
				Return "AR"
			Case "california"
				Return "CA"
			Case "colorado"
				Return "CO"
			Case "connecticut"
				Return "CT"
			Case "delaware"
				Return "DE"
			Case "florida"
				Return "FL"
			Case "georgia"
				Return "GA"
			Case "hawaii"
				Return "HI"
			Case "idaho"
				Return "ID"
			Case "illinois"
				Return "IL"
			Case "indiana"
				Return "IN"
			Case "iowa"
				Return "IA"
			Case "kansas"
				Return "KS"
			Case "kentucky"
				Return "KY"
			Case "louisiana"
				Return "LA"
			Case "maine"
				Return "ME"
			Case "maryland"
				Return "MD"
			Case "massachusetts"
				Return "MA"
			Case "michigan"
				Return "MI"
			Case "minnesota"
				Return "MN"
			Case "mississippi"
				Return "MS"
			Case "missouri"
				Return "MO"
			Case "montana"
				Return "MT"
			Case "nebraska"
				Return "NE"
			Case "nevada"
				Return "NV"
			Case "new hampshire"
				Return "NH"
			Case "new jersey"
				Return "NJ"
			Case "new mexico"
				Return "NM"
			Case "new york"
				Return "NY"
			Case "north carolina"
				Return "NC"
			Case "north dakota"
				Return "ND"
			Case "ohio"
				Return "OH"
			Case "oklahoma"
				Return "OK"
			Case "oregon"
				Return "OR"
			Case "pennsylvania"
				Return "PA"
			Case "rhode island"
				Return "RI"
			Case "south carolina"
				Return "SC"
			Case "south dakota"
				Return "SD"
			Case "tennessee"
				Return "TN"
			Case "texas"
				Return "TX"
			Case "utah"
				Return "UT"
			Case "vermont"
				Return "VT"
			Case "virgina"
				Return "VA"
			Case "washington"
				Return "WA"
			Case "west virgina"
				Return "WV"
			Case "wisconsin"
				Return "WI"
			Case "wyoming"
				Return "WY"
			Case Else
				Throw New Exceptions.InvalidStateCodeException("The provided state is invalid")
		End Select
	End Function

	Shared Function ValidEmail(email As String) As Boolean
		Try
			Return Text.RegularExpressions.Regex.IsMatch(email, My.Resources.EmailRegex2)
		Catch ex As ArgumentNullException
			Return False
		End Try
	End Function

	Shared Function ValidID(id As Integer) As Boolean
		Return id >= My.Settings.MinID
	End Function

	Shared Function TryDateCast(value As Object) As Date
		Try
			Return CDate(value)
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	Public Shared Sub PrintConsole(title As String, value As Object)
		Console.WriteLine($"------------------------ {title} ------------------------")
		Console.WriteLine(value)
		Console.WriteLine($"---------------------------------------------------------")
	End Sub
End Structure
