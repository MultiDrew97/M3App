using System;
using System.ComponentModel;
using System.Diagnostics;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using SPPBC.M3Tools.M3API;

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
		private static readonly JsonSerializerSettings options = new()
		{
			Formatting = Formatting.Indented,
			Error = new EventHandler<ErrorEventArgs>(JsonConversionError),
			ContractResolver = new DefaultContractResolver
			{
				NamingStrategy = new CamelCaseNamingStrategy()
			},
			/*PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			PropertyNameCaseInsensitive = true,
			WriteIndented = true,
			ReadCommentHandling = JsonCommentHandling.Skip,
			DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
			AllowTrailingCommas = true,
			DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
			NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals,
			UnmappedMemberHandling = System.Text.Json.Serialization.JsonUnmappedMemberHandling.Skip,
			UnknownTypeHandling = System.Text.Json.Serialization.JsonUnknownTypeHandling.JsonElement,
			PreferredObjectCreationHandling = System.Text.Json.Serialization.JsonObjectCreationHandling.Populate*/
		};

		private static void JsonConversionError(object sender, ErrorEventArgs e)
		{
			string message = e.ErrorContext.Error.Message;
			if (message.Contains("IDbEntry") && message.ToLower().Contains("abstract"))
				return;

			Console.Error.WriteLine(e.ErrorContext.Path);
			Console.Error.WriteLine(e.ErrorContext.Member);
			Console.Error.WriteLine(message);
			Console.Error.WriteLine(e.ErrorContext.Error.StackTrace);
			Console.Error.WriteLine(e.CurrentObject);
			Console.Error.WriteLine(e.ErrorContext.OriginalObject);
			_ = Utils.ShowErrorMessage("JSON Parse Error", message);
		}

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
				Debug.WriteLine($"Error: JSON Provided invalid \n\t{json}");
				return default;
			}

			return JsonConvert.DeserializeObject<T>(json, options);
		}

		/// <summary>
		/// Convert an object to a JSON string using the global serialization options
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string ConvertToJSON(object obj) =>
			JsonConvert.SerializeObject(obj, options);
	}
}

namespace SPPBC.M3Tools.Types.Converters
{
	internal class M3AppConvert<T> : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) => sourceType == typeof(string);

		public object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string value)
			=> JSON.ConvertFromJSON<T>(value);

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
			=> destinationType != typeof(string) ? base.ConvertTo(context, culture, value, destinationType) : JSON.ConvertToJSON(value);
	}
}