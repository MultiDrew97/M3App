Imports System.ComponentModel
Imports System.Globalization

Namespace Types.Converters
	Public Class UserConverter
		Inherits TypeConverter

		Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
			Return sourceType = GetType(String)
		End Function

		Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, value As Object) As Object
			If value.GetType = GetType(String) Then
				Dim parts() As String = CStr(value).Split(";"c)
				Dim user As New User With {
					.Id = CInt(parts(0)),
					.Username = parts(1),
					.Password = Text.Encoding.Unicode.GetBytes(parts(2)),
					.Salt = Guid.Parse(parts(3)),
					.AccountRole = CType(CInt(parts(4)), AccountRole)
				}

				Return user
			End If

			Return MyBase.ConvertFrom(context, culture, value)
		End Function

		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
			If destinationType = GetType(String) Then
				Dim user = CType(value, User)
				Return user.ToString
			End If

			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function
	End Class
End Namespace
