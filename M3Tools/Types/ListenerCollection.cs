using System;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A collection of listeners
	/// </summary>
    public class ListenerCollection : DBEntryCollection<Listener>
    {

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="listener"></param>
		/// <param name="index"></param>
		/// <returns></returns>
        public override bool ApplyFilter(Listener listener, int index)
        {
			if (listener == null)
			{
				return false;
			}

            return listener.Name.Contains(Filter) || listener.Email.Contains(Filter);
        }
    }
}
