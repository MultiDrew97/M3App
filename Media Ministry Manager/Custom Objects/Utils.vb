Option Strict On

Imports MediaMinistry.Exceptions

Namespace Helpers
	Public Structure Utils
		Private ReadOnly Property Value As Boolean
		Shared Sub Wait(ByVal seconds As Integer)
			'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

			For i As Integer = 0 To seconds * 100
				Threading.Thread.Sleep(10)
				Application.DoEvents()
			Next
		End Sub

		Shared Function ConvertStateAbbr(stateCode As String) As String
			Select Case stateCode
				Case "al", "AL"
					Return "Alabama"
				Case "ak", "AK"
					Return "Alaska"
				Case "az", "AZ"
					Return "Arizona"
				Case "ar", "AR"
					Return "Arkansas"
				Case "ca", "CA"
					Return "California"
				Case "co", "CO"
					Return "Colorado"
				Case "ct", "CT"
					Return "Connecticut"
				Case "de", "DE"
					Return "Delaware"
				Case "fl", "FL"
					Return "Florida"
				Case "ga", "GA"
					Return "Georgia"
				Case "hi", "HI"
					Return "Hawaii"
				Case "id", "ID"
					Return "Idaho"
				Case "il", "IL"
					Return "Illinois"
				Case "in", "IN"
					Return "Indiana"
				Case "ia", "IA"
					Return "Iowa"
				Case "ks", "KS"
					Return "Kansas"
				Case "ky", "KY"
					Return "Kentucky"
				Case "la", "LA"
					Return "Louisiana"
				Case "me", "ME"
					Return "Maine"
				Case "md", "MD"
					Return "Maryland"
				Case "ma", "MA"
					Return "Massachusetts"
				Case "mi", "MI"
					Return "Michigan"
				Case "mn", "MN"
					Return "Minnesota"
				Case "ms", "MS"
					Return "Mississippi"
				Case "mo", "MO"
					Return "Missouri"
				Case "mt", "MT"
					Return "Montana"
				Case "ne", "NE"
					Return "Nebraska"
				Case "nv", "NV"
					Return "Nevada"
				Case "nh", "NH"
					Return "New Hampshire"
				Case "nj", "NJ"
					Return "New Jersey"
				Case "nm", "NM"
					Return "New Mexico"
				Case "ny", "NY"
					Return "New York"
				Case "nc", "NC"
					Return "North Carolina"
				Case "nd", "ND"
					Return "North Dakota"
				Case "oh", "OH"
					Return "Ohio"
				Case "ok", "OK"
					Return "Oklahoma"
				Case "or", "OR"
					Return "Oregon"
				Case "pa", "PA"
					Return "Pennsylvania"
				Case "ri", "RI"
					Return "Rhode Island"
				Case "sc", "SC"
					Return "South Carolina"
				Case "sd", "SD"
					Return "South Dakota"
				Case "tn", "TN"
					Return "Tennessee"
				Case "tx", "TX"
					Return "Texas"
				Case "ut", "UT"
					Return "Utah"
				Case "vt", "VT"
					Return "Vermont"
				Case "va", "VA"
					Return "Virgina"
				Case "wa", "WA"
					Return "Washington"
				Case "wv", "WV"
					Return "West Virgina"
				Case "wi", "WI"
					Return "Wisconsin"
				Case "wy", "WY"
					Return "Wyoming"
				Case Else
					Throw New InvalidStateCodeException("The provided state code is invalid.")
			End Select
		End Function

		Shared Sub CloseOpenForms()
			'Close all open windows. Figuring this out will allow me to change from only clearing when primary form closes to when all forms close.
			'improving efficiency in memory management
			Dim attempts = 0
			Do
				Try
					My.Application.OpenForms(0).Close()
					attempts = 0
				Catch ex As InvalidOperationException
					Console.WriteLine("Form of name {0} falied to close", My.Application.OpenForms(0).Name)
					attempts += 1
				End Try
			Loop While My.Application.OpenForms.Count > 0 And attempts < 3
		End Sub

		Public Overrides Function Equals(obj As Object) As Boolean
			Return False
		End Function

		'Shared Operator =(ByVal fs As Utils, ByVal ss As Utils) As Boolean
		'    Return False
		'End Operator

		'Shared Operator <>(ByVal fs As Utils, ByVal ss As Utils) As Boolean
		'    Return False
		'End Operator
	End Structure
End Namespace
