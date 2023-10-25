Imports System.Text.Json

Namespace M3API
	Public Class JSON
		''' <summary>
		''' The options used when serializing a object to JSON string
		''' </summary>
		Private Shared ReadOnly serializationOptions As New JsonSerializerOptions With {
										   .PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
										   .WriteIndented = True,
										   .ReadCommentHandling = JsonCommentHandling.Skip,
										   .DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
										   .IgnoreNullValues = True,
										   .PropertyNameCaseInsensitive = True
	}

		''' <summary>
		''' Converts a JSON string to the respective object type given the type parameter
		''' </summary>
		''' <typeparam name="T">The type to convert to</typeparam>
		''' <param name="json">The JSON string</param>
		''' <returns></returns>
		Shared Function ConvertFromJSON(Of T)(json As String) As T
			If (String.IsNullOrWhiteSpace(json)) Then
				Return Nothing
			End If

			Return JsonSerializer.Deserialize(Of T)(json, serializationOptions)
		End Function

		''' <summary>
		''' Convert an object to a JSON string using the global serilization options
		''' </summary>
		''' <param name="obj"></param>
		''' <returns></returns>
		Shared Function ConvertToJSON(obj As Object) As String
			If obj Is Nothing Then
				Return ""
			End If

			Return JsonSerializer.Serialize(obj, serializationOptions)
		End Function
	End Class

	Public Enum Method
		[Get]
		Post
		Put
		Delete
		Patch
		Head
	End Enum
End Namespace