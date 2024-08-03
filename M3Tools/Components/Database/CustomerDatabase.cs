using System;

using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The customer based API calls
	/// </summary>
	public partial class CustomerDatabase
	{
		/// <summary>
		/// Retrieves the specified customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public Types.Customer GetCustomer(int customerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(customerID)
				? ExecuteWithResult<Types.Customer>(System.Net.Http.HttpMethod.Get, string.Join(Paths.Seperator, Paths.Customers, customerID), string.Empty, ct).Result
				: throw new ArgumentException($"Invalid CustomerID provided");

		/// <summary>
		/// Retrieves all customers from the database
		/// </summary>
		/// <returns></returns>
		public Types.CustomerCollection GetCustomers(System.Threading.CancellationToken ct = default)
			=> ExecuteWithResult<Types.CustomerCollection>(System.Net.Http.HttpMethod.Get, Paths.Customers, string.Empty, ct).Result;

		/// <summary>
		/// Add a customer to the database
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="ct"></param>
		public bool AddCustomer(Types.Customer customer, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Post, Paths.Customers, JSON.ConvertToJSON(customer), ct);

		/// <summary>
		/// Updates the info for a customer in the database
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="ct"></param>
		public bool UpdateCustomer(Types.Customer customer, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(customer.Id)
				? Execute(System.Net.Http.HttpMethod.Put, string.Join(Paths.Seperator, Paths.Customers, customer.Id), JSON.ConvertToJSON(customer), ct)
				: throw new ArgumentException($"Invalid CustomerID provided");

		/// <summary>
		/// Removes a customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public bool RemoveCustomer(int customerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(customerID)
				? Execute(System.Net.Http.HttpMethod.Delete, string.Join(Paths.Seperator, Paths.Customers, customerID), string.Empty, ct)
				: throw new ArgumentException($"Invalid CustomerID provided");
	}
}
