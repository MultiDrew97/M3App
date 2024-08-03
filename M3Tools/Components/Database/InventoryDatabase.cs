using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	public sealed partial class InventoryDatabase
	{
		private const string path = "inventory";

		/// <summary>
		/// Retrieve a product with the specified item ID
		/// </summary>
		/// <param name="itemID"></param>
		/// <returns></returns>
		public Types.Product GetProduct(int itemID) => ExecuteWithResult<Types.Product>(System.Net.Http.HttpMethod.Get, $"{path}/{itemID}").Result;

		/// <summary>
		/// Retrieve the complete list of inventory items
		/// </summary>
		/// <returns></returns>
		public Types.InventoryCollection GetProducts() => ExecuteWithResult<Types.InventoryCollection>(System.Net.Http.HttpMethod.Get, $"{path}").Result;

		/// <summary>
		/// Add a new product to the database
		/// </summary>
		/// <param name="itemName"></param>
		/// <param name="stock"></param>
		/// <param name="price"></param>
		public void AddProduct(string itemName, int stock, decimal price) => AddInventory(new Types.Product(-1, itemName, stock, price, true));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public void AddInventory(Types.Product item) => Execute(System.Net.Http.HttpMethod.Post, $"{path}", JSON.ConvertToJSON(item));

		/// <summary>
		/// Update an inventory item's information
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="itemName"></param>
		/// <param name="stock"></param>
		/// <param name="price"></param>
		/// <param name="available"></param>
		public void UpdateProduct(int itemID, string itemName, int stock, decimal price, bool available) => UpdateProduct(new Types.Product(itemID, itemName, stock, price, available));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public void UpdateProduct(Types.Product item) => Execute(System.Net.Http.HttpMethod.Put, $"{path}/{item.Id}", JSON.ConvertToJSON(item));

		/// <summary>
		/// Remove a product from the database
		/// </summary>
		/// <param name="itemID"></param>
		public void RemoveProduct(int itemID) => Execute(System.Net.Http.HttpMethod.Delete, $"{path}/{itemID}?force");
	}
}
