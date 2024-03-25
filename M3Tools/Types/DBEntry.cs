
namespace SPPBC.M3Tools.Types
{
    public abstract class DbEntry
    {

        [System.Text.Json.Serialization.JsonIgnore]
        public abstract int Id { get; set; }

        public DbEntry(int id = -1)
        {
            Id = id;
        }

        public static bool operator ==(DbEntry ls, DbEntry rs)
        {
            return ls.Id == rs.Id;
        }

        public static bool operator !=(DbEntry ls, DbEntry rs)
        {
            return !(ls == rs);
        }
    }
}