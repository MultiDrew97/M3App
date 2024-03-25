
namespace SPPBC.M3Tools.Types
{

    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum AccountRole
    {
        User = 1,
        Admin
    }
}