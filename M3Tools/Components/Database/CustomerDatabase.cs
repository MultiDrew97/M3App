using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// The customer based database API calls
	/// </summary>
    public partial class CustomerDatabase
    {
        private const string path = "customers";

		/// <summary>
		/// Add a customer to the database
		/// </summary>
		/// <param name="fName">The first name of the customer</param>
		/// <param name="lName">The last name of the customer</param>
		/// <param name="addrStreet">The street portion of their address</param>
		/// <param name="addrCity">The city portion of their address</param>
		/// <param name="addrState">The state portion of their address</param>
		/// <param name="addrZip">The zip code portion of their address</param>
		/// <param name="phone">The phone number of the customer</param>
		/// <param name="email">The email address of the customer</param>
        public void AddCustomer(string fName, string lName, string addrStreet = null, string addrCity = null, string addrState = null, string addrZip = null, string phone = null, string email = null)
        {
            AddCustomer(fName, lName, new Address(addrStreet, addrCity, addrState, addrZip), phone, email);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="address"></param>
		/// <param name="phone"></param>
		/// <param name="email"></param>
        public void AddCustomer(string fName, string lName, Address address = null, string phone = null, string email = null)
        {
            AddCustomer(new Customer(-1, fName, lName, address, phone, email));
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            Execute(Method.Post, $"{path}", JSON.ConvertToJSON(customer));
        }

		/// <summary>
		/// Retrieves all customers from the database
		/// </summary>
		/// <returns></returns>
        public CustomerCollection GetCustomers()
        {
            return ExecuteWithResult<CustomerCollection>(Method.Get, $"{path}").Result;
        }

		/// <summary>
		/// Retrieves the specified customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
        public Customer GetCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            return ExecuteWithResult<Customer>(Method.Get, $"{path}/{customerID}").Result;
        }

		/// <summary>
		/// Updates the info for a customer in the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <param name="state"></param>
		/// <param name="zipCode"></param>
		/// <param name="email"></param>
		/// <param name="phone"></param>
        public void UpdateCustomer(int customerID, string fName, string lName, string street, string city, string state, string zipCode, string email, string phone)
        {
            UpdateCustomer(customerID, fName, lName, new Address(street, city, state, zipCode), email, phone);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="addr"></param>
		/// <param name="email"></param>
		/// <param name="phone"></param>
        public void UpdateCustomer(int customerID, string fName, string lName, Address addr, string email, string phone)
        {
            UpdateCustomer(new Customer(customerID, fName, lName, addr, email, phone));
        }

        private void UpdateCustomer(Customer customer)
        {
            if (!Utils.ValidID(customer.Id))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            Execute(Method.Put, $"{path}/{customer.Id}", JSON.ConvertToJSON(customer));
        }

		/// <summary>
		/// Removes a customer from the database
		/// </summary>
		/// <param name="customerID"></param>
		/// <exception cref="ArgumentException"></exception>
        public void RemoveCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            Execute(Method.Delete, $"{path}/{customerID}");
        }
    }
}
