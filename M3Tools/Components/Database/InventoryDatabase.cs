using System;
using System.ComponentModel;
using System.Data.SqlClient;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
	public sealed partial class InventoryDatabase
	{
		private const string path = "inventory";

		[Description("The username to use for the database connection")]
		[SettingsBindable(true)]
		public string Username
		{
			get
			{
				return dbConnection.Username;
			}
			set
			{
				dbConnection.Username = value;
			}
		}

		// The password to use for the database connection
		[PasswordPropertyText(true)]
		[SettingsBindable(true)]
		[Description("The password to use for the database connection")]
		public string Password
		{
			get
			{
				return dbConnection.Password;
			}
			set
			{
				dbConnection.Password = value;
			}
		}

		// The initial catalog to use for the database connection
		[Bindable(true)]
		[Description("The initial catalog to use for the database connection")]
		[SettingsBindable(true)]
		public string BaseUrl
		{
			get
			{
				return dbConnection.BaseUrl;
			}
			set
			{
				dbConnection.BaseUrl = value;
			}
		}

		public Product GetProduct(int itemID)
		{
			return dbConnection.Consume<Product>(Method.Get, $"/{path}/{itemID}").Result;
		}

		public DBEntryCollection<Product> GetProducts()
		{
			return dbConnection.Consume<DBEntryCollection<Product>>(Method.Get, $"/{path}").Result;
		}

		public void AddProduct(string itemName, int stock, decimal price)
		{
			AddProduct(new Product(-1, itemName, stock, price, true));
		}

		public void AddProduct(Product item)
		{
			dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(item));
		}

		public void UpdateProduct(int itemID, string itemName, int stock, decimal price, bool available)
		{
			UpdateProduct(new Product(itemID, itemName, stock, price, available));
		}

		public void UpdateProduct(Product item)
		{
			dbConnection.Consume(Method.Put, $"/{path}/{item.Id}", JSON.ConvertToJSON(item));
		}

		public void RemoveProduct(int itemID)
		{
			dbConnection.Consume(Method.Put, $"/{path}/{itemID}");
		}

		private void ChangeAvailability(params SqlParameter[] @params)
		{
			throw new NotImplementedException("ChangeAvailablity");
		}
	}
}
