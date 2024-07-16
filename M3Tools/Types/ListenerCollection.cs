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
		public static new ListenerCollection Cast(System.Collections.ICollection collection)
		{
			ListenerCollection list = new();
			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in collection)
					{
						list.Add((Listener)row.DataBoundItem);
					}
					break;
			}



			return list;
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
