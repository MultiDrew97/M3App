using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A collection of different cart items
	/// </summary>
	public class CartItemCollection : Collection<CartItem>
	{
		// TODO: Add overriding function to prevent multiples of the same
		// item from being added and update the quantity of the current item
		/// <summary>
		/// Cast a collection to the <see cref="CartItemCollection"/> type
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static CartItemCollection Cast(System.Collections.IList source)
		{
			if (source is null || source.Count < 1)
			{
				return [];
			}

			CartItemCollection result = [];

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					foreach (DataGridViewRow row in source)
					{
						result.Add((CartItem)row.DataBoundItem);
					}

					return result;
				case var @list when list == typeof(System.Collections.IList):
					result.AddRange(source);
					return result;
				default:
					throw new ArgumentException("Unable to cast to CartItemCollection");
			}
		}

		/// <summary>
		/// Add a range of items to the collection
		/// </summary>
		/// <param name="source"></param>
		public void AddRange(IList source)
		{
			foreach (CartItem item in source)
			{
				Add(item);
			}
		}
	}
}
