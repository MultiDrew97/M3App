using System.Text.Json;

namespace SPPBC.M3Tools.M3API
{
	/// <summary>
	/// 
	/// </summary>
	public class JSON
	{
		/// <summary>
		/// The options used when serializing a object to JSON string
		/// </summary>
		private static readonly JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			PropertyNameCaseInsensitive = true,
			WriteIndented = true,
			ReadCommentHandling = JsonCommentHandling.Skip,
			DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
			AllowTrailingCommas = true,
			DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
			NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals,
			UnmappedMemberHandling = System.Text.Json.Serialization.JsonUnmappedMemberHandling.Skip,
			UnknownTypeHandling = System.Text.Json.Serialization.JsonUnknownTypeHandling.JsonElement,
			PreferredObjectCreationHandling = System.Text.Json.Serialization.JsonObjectCreationHandling.Populate
		};

		/// <summary>
		/// Converts a JSON string to the respective object type given the type parameter
		/// </summary>
		/// <typeparam name="T">The type to convert to</typeparam>
		/// <param name="json">The JSON string</param>
		/// <returns></returns>
		public static T ConvertFromJSON<T>(string json)
		{
			if (string.IsNullOrWhiteSpace(json) || !(json.Contains("{") && json.Contains("}")))
			{
				System.Console.WriteLine($"Error: JSON Provided invalid \n\t{json}");
				return default;
			}

			return JsonSerializer.Deserialize<T>(json, options);
		}

		/// <summary>
		/// Convert an object to a JSON string using the global serilization options
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string ConvertToJSON(object obj) => obj is null ? "" : JsonSerializer.Serialize(obj, options);
	}
}
