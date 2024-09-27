using System;
using System.Threading.Tasks;

using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The inventory based API calls
	/// </summary>
	public sealed partial class InventoryDatabase
	{
		/// <summary>
		/// Retrieve a product with the specified item ID
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public async Task<Types.Product> GetProduct(int itemID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(itemID)
				? await ExecuteWithResultAsync<Types.Product>(System.Net.Http.HttpMethod.Get, string.Join(Paths.Separator, Paths.Inventory, itemID), string.Empty, ct)
				: throw new ArgumentException();

		/// <summary>
		/// Retrieve the complete list of inventory items
		/// </summary>
		/// <returns></returns>
		public async Task<Types.InventoryCollection> GetProducts(System.Threading.CancellationToken ct = default)
			=> await ExecuteWithResultAsync<Types.InventoryCollection>(System.Net.Http.HttpMethod.Get, Paths.Inventory, string.Empty, ct);

		/// <summary>
		/// Add a new product to the database
		/// </summary>
		/// <param name="item"></param>
		/// <param name="ct"></param>
		public async Task<bool> AddInventory(Types.Product item, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Post, Paths.Inventory, JSON.ConvertToJSON(item), ct);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <param name="ct"></param>
		public async Task<bool> UpdateProduct(Types.Product item, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Put, string.Join(Paths.Separator, Paths.Inventory, item.Id), JSON.ConvertToJSON(item), ct);

		/// <summary>
		/// Remove a product from the database
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="ct"></param>
		public async void RemoveProduct(int itemID, System.Threading.CancellationToken ct = default)
			=> await ExecuteAsync(System.Net.Http.HttpMethod.Delete, string.Join(Paths.Separator, $"{itemID}?force"), string.Empty, ct);
	}
}
