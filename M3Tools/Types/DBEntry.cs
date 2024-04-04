namespace SPPBC.M3Tools.Types
{
	public interface IDbEntry
	{
		public int Id { get; }
	}

	/// <summary>
	/// Interface dictating what is on a database entry
	/// </summary>
    public class DbEntry : IDbEntry
    {
		public static DbEntry None;

		/// <summary>
		/// The database ID
		/// </summary>
        public virtual int Id { get; private set; }

		/// <inheritdoc/>
		protected DbEntry(int id)
		{
			if (!Utils.ValidID(id))
			{
				// TODO: Determine how to handle invalid ID values
				Id = -1;
				return;
				throw new System.ArgumentException();
			}

			Id = id;
		}

		public static bool operator ==(DbEntry ls, DbEntry rs)
		{
			return ls.GetHashCode() == rs.GetHashCode();
		}

		public static bool operator !=(DbEntry ls, DbEntry rs)
		{
			return !(ls == rs);
		}

		public override bool Equals(object obj)
		{
			return this == (DbEntry)obj || base.Equals(obj);
		}

		public override int GetHashCode()
		{
			if (!Utils.ValidID(Id)) return base.GetHashCode();

			return Id;
		}
	}
}
