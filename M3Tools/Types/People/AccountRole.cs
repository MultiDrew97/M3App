
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// The roles that a user may have
	/// </summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
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
