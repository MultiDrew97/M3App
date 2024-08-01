using System;

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
	public class DbEntry : IDbEntry, ICloneable
	{
		/// <summary>
		/// An empty entry object
		/// </summary>
		public static DbEntry None;

		/// <summary>
		/// Create a clone of the object
		/// </summary>
		/// <returns></returns>
		public virtual object Clone() => MemberwiseClone();

		/// <inheritdoc/>
		public virtual int Id { get; set; }

		/// <inheritdoc/>
		protected DbEntry(int id)
		{
			if (!Utils.ValidID(id))
			{
				id = -1;
				//throw new System.ArgumentException($"'{id}' is not a valid ID value");
			}

			Id = id;
		}

		/// <summary>
		/// Checks if 2 DbEntry objects are equal to each other
		/// </summary>
		/// <param name="ls">The left hand side</param>
		/// <param name="rs">The right hand side</param>
		/// <returns>True if objects are equal, otherwise false</returns>
		public static bool operator ==(DbEntry ls, DbEntry rs) => !(ls is null ^ rs is null) && ls.GetHashCode() == rs.GetHashCode();

		/// <summary>
		/// Checks if 2 DbEntry objects are not equal to each other
		/// </summary>
		/// <param name="ls">The left hand side</param>
		/// <param name="rs">The right hand side</param>
		/// <returns>True if objects are not equal, otherwise false</returns>
		public static bool operator !=(DbEntry ls, DbEntry rs) => !(ls == rs);

		/// <summary>
		/// Checks if an object is equal to the current instance
		/// </summary>
		/// <param name="obj">The referenced object to compare with</param>
		/// <returns>True if the object is the same as the current instance, otherwise false</returns>
		public override bool Equals(object obj) => !(this is null ^ obj is null) && obj is not System.DBNull && ((this == (DbEntry)obj) || base.Equals(obj));

		/// <summary>
		/// Gets the Hash code for the current object
		/// </summary>
		/// <returns>The hash code for the current instance</returns>
		public override int GetHashCode() => !Utils.ValidID(Id) ? base.GetHashCode() : Id;
	}
}
