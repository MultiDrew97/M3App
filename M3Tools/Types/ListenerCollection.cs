using System;
using System.Linq;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A collection of listeners
	/// </summary>
    public class ListenerCollection : DbEntryCollection<Listener>
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static new ListenerCollection Cast(System.Collections.IList collection)
		{
			ListenerCollection coll = new();
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in collection)
					{
						coll.Add((Listener)row.DataBoundItem);
					}
					break;
			}



			return coll;
		}

		/// <summary>
		/// 
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
