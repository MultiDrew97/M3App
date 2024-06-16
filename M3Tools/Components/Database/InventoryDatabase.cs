using System;
using System.ComponentModel;
using System.Data.SqlClient;
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
		public Types.Product GetProduct(int itemID)
		{
			return ExecuteWithResult<Types.Product>(Method.Get, $"{path}/{itemID}").Result;
		}

		/// <summary>
		/// Retrieve the complete list of inventory items
		/// </summary>
		/// <returns></returns>
		public Types.InventoryCollection GetProducts()
		{
			return ExecuteWithResult<Types.InventoryCollection> (Method.Get, $"{path}").Result;
		}

		/// <summary>
		/// Add a new product to the database
		/// </summary>
		/// <param name="itemName"></param>
		/// <param name="stock"></param>
		/// <param name="price"></param>
		public void AddProduct(string itemName, int stock, decimal price)
		{
			AddProduct(new Types.Product(-1, itemName, stock, price, true));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public void AddProduct(Types.Product item)
		{
			Execute(Method.Post, $"{path}", JSON.ConvertToJSON(item));
		}

		/// <summary>
		/// Update an inventory item's information
		/// </summary>
		/// <param name="itemID"></param>
		/// <param name="itemName"></param>
		/// <param name="stock"></param>
		/// <param name="price"></param>
		/// <param name="available"></param>
		public void UpdateProduct(int itemID, string itemName, int stock, decimal price, bool available)
		{
			UpdateProduct(new Types.Product(itemID, itemName, stock, price, available));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public void UpdateProduct(Types.Product item)
		{
			Execute(Method.Put, $"{path}/{item.Id}", JSON.ConvertToJSON(item));
		}

		/// <summary>
		/// Remove a product from the database
		/// </summary>
		/// <param name="itemID"></param>
		public void RemoveProduct(int itemID)
		{
			Execute(Method.Put, $"{path}/{itemID}");
		}
	}
}
