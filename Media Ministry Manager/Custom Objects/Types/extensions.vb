Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Types.Extensions
	Module StringExtensions
		Private ReadOnly phone As New Regex("(\d{3})(\d{3})(\d{4})")

		<Extension()>
		Public Function FormatPhone(value As String) As String
			Return phone.Replace(value, "({0}) {1}-{2}")
		End Function
	End Module
End Namespace
