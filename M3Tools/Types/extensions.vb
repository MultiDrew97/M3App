﻿Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Types.Extensions
	Module StringExtensions
		Dim phone As New Regex("(\d{3})(\d{3})(\d{4})")
		<Extension()>
		Public Function FormatPhone(value As String) As String
			Return phone.Replace(value, "($1) $2-$3")
		End Function

		<Extension()>
		Public Function ToBase64String(value As String) As String
			Dim temp = Convert.ToBase64String(Text.Encoding.UTF8.GetBytes(value))
			Console.WriteLine(temp)
			Return temp
		End Function

		<Extension()>
		Public Function FromBase64String(value As String) As String
			Dim temp = Text.Encoding.UTF8.GetString(Convert.FromBase64String(value))
			Console.WriteLine(temp)
			Return temp
		End Function
	End Module
End Namespace
