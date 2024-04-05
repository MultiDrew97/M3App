namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Interface dictating what is on a database entry
	/// </summary>
	public interface IDbEntry
	{
		/// <summary>
		/// The ID of the entry
		/// </summary>
		public int Id { get; }
	}

	/// <inheritdoc/>
    public class DbEntry : IDbEntry
    {
		/// <summary>
		/// An empty entry object
		/// </summary>
		public static DbEntry None;

		/// <inheritdoc/>
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

		/// <summary>
		/// Checks if 2 DbEntry objects are equal to each other
		/// </summary>
		/// <param name="ls">The left hand side</param>
		/// <param name="rs">The right hand side</param>
		/// <returns>True if objects are equal, otherwise false</returns>
		public static bool operator ==(DbEntry ls, DbEntry rs)
		{
			return ls.GetHashCode() == rs.GetHashCode();
		}

		/// <summary>
		/// Checks if 2 DbEntry objects are not equal to each other
		/// </summary>
		/// <param name="ls">The left hand side</param>
		/// <param name="rs">The right hand side</param>
		/// <returns>True if objects are not equal, otherwise false</returns>
		public static bool operator !=(DbEntry ls, DbEntry rs)
		{
			return !(ls == rs);
		}

		/// <summary>
		/// Checks if an object is equal to the current instance
		/// </summary>
		/// <param name="obj">The referenced object to compare with</param>
		/// <returns>True if the object is the same as the current instance, otherwise false</returns>
		public override bool Equals(object obj)
		{
			return (this == (DbEntry)obj) || base.Equals(obj);
		}

		/// <summary>
		/// Gets the Hash code for the current object
		/// </summary>
		/// <returns>The hash code for the current instance</returns>
		public override int GetHashCode()
		{
			if (!Utils.ValidID(Id)) return base.GetHashCode();

			return Id;
		}
	}
}
