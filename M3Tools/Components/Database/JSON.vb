Imports System.Text.Json

Namespace M3API
	Public Class JSON
		<summary>
		The options used When serializing a Object To JSON String
</summary>
		Private Shared ReadOnly options As New JsonSerializerOptions(JsonSerializerDefaults.Web) With {
										   .PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
										   .PropertyNameCaseInsensitive = True,
										   .WriteIndented = True,
										   .ReadCommentHandling = JsonCommentHandling.Skip,
										   .DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
										   .AllowTrailingCommas = True,
										   .DefaultIgnoreCondition = Serialization.JsonIgnoreCondition.WhenWritingNull,
										   .NumberHandling = Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals
								}

		<summary>
		Converts a JSON String To the respective Object type given the type parameter
</summary>
<typeparam name = "T" > The type To convert To</typeparam>
<param name = "json" > The JSON String</param>
<returns></returns>
		Shared Function ConvertFromJSON(Of T)(json As String) As T
			If (String.IsNullOrWhiteSpace(json)) Then
				Throw New JsonException("No JSON was present")
			End If

			Return JsonSerializer.Deserialize(Of T)(json, options)
		End Function

		<summary>
		Convert an Object To a JSON String Using the Global serilization options
</summary>
<param name = "obj" ></param>
		<returns></returns>
		Shared Function ConvertToJSON(obj As Object) As String
			If obj Is Nothing Then
				Return ""
			End If

			Return JsonSerializer.Serialize(obj, options)
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
