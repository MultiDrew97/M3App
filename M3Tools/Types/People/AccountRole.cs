
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// The roles that a user may have
	/// </summary>
	[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public enum AccountRole
	{
		/// <summary>
		/// A normal user
		/// </summary>
		User = 1,
		/// <summary>
		/// An administrator
		/// </summary>
		Admin
	}
}
