using System.Text.Json;

namespace SPPBC.M3Tools.M3API
{
	/// <summary>
	/// 
	/// </summary>
    public class JSON
    {
        /// <summary>
		/// 		''' The options used when serializing a object to JSON string
		/// 		''' </summary>
        private static readonly JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            AllowTrailingCommas = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals
        };

        /// <summary>
		/// 		''' Converts a JSON string to the respective object type given the type parameter
		/// 		''' </summary>
		/// 		''' <typeparam name="T">The type to convert to</typeparam>
		/// 		''' <param name="json">The JSON string</param>
		/// 		''' <returns></returns>
        public static T ConvertFromJSON<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new JsonException("No JSON was present");
            }

            return JsonSerializer.Deserialize<T>(json, options);
        }

        /// <summary>
		/// 		''' Convert an object to a JSON string using the global serilization options
		/// 		''' </summary>
		/// 		''' <param name="obj"></param>
		/// 		''' <returns></returns>
        public static string ConvertToJSON(object obj)
        {
            if (obj is null)
            {
                return "";
            }

            return JsonSerializer.Serialize(obj, options);
        }
    }

	/// <summary>
	/// The type of methods associated with RESTful API calls
	/// </summary>
    public enum Method
    {
		/// <summary>
		/// A GET API request
		/// </summary>
        Get,
		/// <summary>
		/// A POST API request
		/// </summary>
        Post,
		/// <summary>
		/// A PUT API request
		/// </summary>
        Put,
		/// <summary>
		/// A DELETE API request
		/// </summary>
        Delete,
		/// <summary>
		/// A PATCH API request
		/// </summary>
        Patch,
		/// <summary>
		/// A HEAD API request
		/// </summary>
        Head
    }
}
