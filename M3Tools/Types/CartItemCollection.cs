using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A collection of different cart items
	/// </summary>
	public class CartItemCollection : Collection<CartItem>
	{
		// TODO: Add overriding function to prevent multiples of the same
		// item from being added and update the quantity of the current item
	}
}
