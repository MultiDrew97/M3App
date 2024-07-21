using System;
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
			if (collection == null || collection.Count <= 0)
			{
				return new();
			}

			ListenerCollection result;

			switch (collection.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = new();
					foreach (DataGridViewRow row in collection)
					{
						result.Add((Listener)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
					result = new();
					foreach (Listener item in collection)
					{
						result.Add(item);
					}

					return result;
				case var @dbColl when dbColl == typeof(ListenerCollection):
					return (ListenerCollection)collection;
				default:
					throw new Exception("Unable to cast collection to ListenerCollection");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listener"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public override bool ApplyFilter(Listener listener, int index)
		{
			return listener != null && (listener.Name.Contains(Filter) || listener.Email.Contains(Filter));
		}
	}
}
