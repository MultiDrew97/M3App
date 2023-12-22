Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Types.Extensions
	Module StringExtensions
		Private ReadOnly phone As New Regex("(\d{3})(\d{3})(\d{4})")

		<Extension()>
		Public Function FormatPhone(value As String) As String
			Return phone.Replace(value, "($1) $2-$3")
		End Function

		<Extension()>
		Public Function ToBase64String(value As String) As String
			Return Convert.ToBase64String(Text.Encoding.UTF8.GetBytes(value))
		End Function

		<Extension()>
		Public Function FromBase64String(value As String) As String
			Return Text.Encoding.UTF8.GetString(Convert.FromBase64String(value))
		End Function
	End Module

	Module DoubleExtensions
		<Extension()>
		Public Function FormatPrice(value As Double) As String
			Return $"{value:c}"
		End Function
	End Module

	Module DecimalExtensions
		<Extension()>
		Public Function FormatPrice(value As Decimal) As String
			Return $"{value:c}"
		End Function
	End Module
End Namespace
