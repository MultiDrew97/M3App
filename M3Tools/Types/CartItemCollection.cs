using System;
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
				return new();
			}

			CartItemCollection result;

			switch (source.GetType())
			{
				case var @rows when @rows == typeof(DataGridViewSelectedRowCollection):
				case var @selected when @selected == typeof(DataGridViewRowCollection):
					result = new();
					foreach (DataGridViewRow row in source)
					{
						result.Add((CartItem)row.DataBoundItem);
					}

					return result;
				case var @list when list == typeof(System.Collections.IList):
					result = new();
					foreach (CartItem item in source)
					{
						result.Add(item);
					}

					return result;
				default:
					throw new ArgumentException("Unable to cast to CartItemCollection");
			}
		}
	}
}
