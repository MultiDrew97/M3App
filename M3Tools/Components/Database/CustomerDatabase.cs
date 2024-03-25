using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
    public sealed partial class CustomerDatabase
    {
        private const string path = "customers";

        [SettingsBindable(true)]
        [Description("The username to use for the database connection")]
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

        [Bindable(true)]
        [SettingsBindable(true)]
        [Description("The initial catalog to use for the database connection")]
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

        public void AddCustomer(string fName, string lName, string addrStreet = null, string addrCity = null, string addrState = null, string addrZip = null, string phone = null, string email = null)
        {
            AddCustomer(fName, lName, new Address(addrStreet, addrCity, addrState, addrZip), phone, email);
        }


        public void AddCustomer(string fName, string lName, Address address = null, string phone = null, string email = null)
        {
            AddCustomer(new Customer(-1, fName, lName, address, phone, email));
        }

        public void AddCustomer(Customer customer)
        {
            dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(customer));
        }

        public CustomersCollection GetCustomers()
        {
            return dbConnection.Consume<CustomersCollection>(Method.Get, $"/{path}").Result;
        }

        public Customer GetCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            return dbConnection.Consume<Customer>(Method.Get, $"/{path}/{customerID}").Result;
        }

        public void UpdateCustomer(int customerID, string fName, string lName, string street, string city, string state, string zipCode, string email, string phone)
        {
            UpdateCustomer(customerID, fName, lName, new Address(street, city, state, zipCode), email, phone);
        }

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

            dbConnection.Consume(Method.Put, $"/{path}/{customer.Id}", JSON.ConvertToJSON(customer));
        }

        public void RemoveCustomer(int customerID)
        {
            if (!Utils.ValidID(customerID))
            {
                throw new ArgumentException($"Invalid CustomerID provided");
            }

            dbConnection.Consume(Method.Delete, $"/{path}/{customerID}");
        }
    }
}