using System;

using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The inventory based API calls
	/// </summary>
	public sealed partial class InventoryDatabase
	{
		private const string basePath = "inventory";

		/// <summary>
		/// Retrieve a product with the specified item ID
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public Types.Product GetProduct(int itemID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(itemID)
				? ExecuteWithResult<Types.Product>(System.Net.Http.HttpMethod.Get, $"{basePath}/{itemID}", string.Empty, ct).Result
				: throw new ArgumentException();

		/// <summary>
		/// Retrieve the complete list of inventory items
		/// </summary>
		/// <returns></returns>
		public Types.InventoryCollection GetProducts(System.Threading.CancellationToken ct = default)
			=> ExecuteWithResult<Types.InventoryCollection>(System.Net.Http.HttpMethod.Get, basePath, string.Empty, ct).Result;

		/// <summary>
		/// Add a new product to the database
		/// </summary>
		/// <param name="item"></param>
		/// <param name="ct"></param>
		public bool AddInventory(Types.Product item, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Post, basePath, JSON.ConvertToJSON(item), ct);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <param name="ct"></param>
		public bool UpdateProduct(Types.Product item, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Put, $"{basePath}/{item.Id}", JSON.ConvertToJSON(item), ct);

		/// <summary>
		/// Remove a product from the database
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="ct"></param>
		public void RemoveProduct(int itemID, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Delete, $"{basePath}/{itemID}?force", string.Empty, ct);
	}
}
