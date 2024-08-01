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
		/// <param name="source"></param>
		/// <returns></returns>
		public static new ListenerCollection Cast(System.Collections.IEnumerable source)
		{
			if (source == null)
			{
				return [];
			}

			ListenerCollection result;

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = [];
					foreach (DataGridViewRow row in source)
					{
						result.Add((Listener)row.DataBoundItem);
					}

					return result;
				case var @list when @list == typeof(System.Collections.IList):
				case var @genList when @genList == typeof(System.Collections.Generic.List<Listener>):
				case var @genIList when @genIList == typeof(System.Collections.Generic.IList<Listener>):
				case var @collection when collection == typeof(System.Collections.ICollection):
				case var @enum when @enum == typeof(System.Collections.IEnumerable):
					result = [.. source.Cast<Listener>().ToList()];

					return result;
				case var @dbColl when dbColl == typeof(ListenerCollection):
					return (ListenerCollection)source;
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
		public override bool ApplyFilter(Listener listener, int index) => listener != null && (listener.Name.Contains(Filter) || listener.Email.Contains(Filter));
	}
}
