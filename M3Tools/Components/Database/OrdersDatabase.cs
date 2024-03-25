using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Database
{
    public sealed partial class OrdersDatabase
    {
        private const string path = "orders";

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
        [Description("The url to use for the database connection")]
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

        public DBEntryCollection<Order> GetOrders()
        {
            return dbConnection.Consume<DBEntryCollection<Order>>(Method.Get, $"/{path}").Result;
        }

        public DBEntryCollection<Order> GetCompletedOrders()
        {
            // TODO: Test this to make sure it works properly
            throw new NotImplementedException("GetCompletedOrders");
            // Return CType(GetOrders().Where(Function(order As Order) As Boolean
            // Return order.CompletedDate.Year > 2000
            // End Function), DBEntryCollection(Of Order))
        }

        public void AddOrder(int customerID, int itemID, int quantity)
        {
            if (!Utils.ValidID(customerID) | !Utils.ValidID(itemID))
            {
                throw new ArgumentException($"Invalid OrderID provided");
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity values must be greater than or equal to 1");
            }

            AddOrder(new Order(-1, customerID, itemID, quantity));
        }

        public void AddOrder(Order order)
        {
            dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(order));
        }

        public void UpdateOrder(int orderID, int customerID, int itemID, int quantity)
        {
            if (!Utils.ValidID(orderID) || !Utils.ValidID(itemID))
            {
                throw new ArgumentException($"Invalid OrderID provided");
            }

            if (quantity < 1)
            {
                throw new ArgumentException($"Quantity values must be greater than or equal to 1");
            }

            UpdateOrder(new Order(orderID, customerID, itemID, quantity));
        }

        public void UpdateOrder(Order order)
        {
            dbConnection.Consume(Method.Put, $"/{path}/{order.Id}", JSON.ConvertToJSON(order));
        }

        public void CancelOrder(int orderID)
        {
            if (!Utils.ValidID(orderID))
            {
                throw new ArgumentException($"Invalid OrderID provided");
            }

            RemoveOrder(orderID, false);
        }

        public void CompleteOrder(int orderID)
        {
            if (orderID < 0)
            {
                throw new ArgumentException("ID values must be greater than or equal to 0");
            }

            RemoveOrder(orderID, true);
        }

        private void RemoveOrder(int orderID, bool completed)
        {
            dbConnection.Consume(Method.Put, $"/{path}/{orderID}?force={completed}");
        }

        public Order GetOrderById(int orderID)
        {
            if (!Utils.ValidID(orderID))
            {
                throw new ArgumentException("ID values must be greater than or equal to 0");
            }

            return dbConnection.Consume<Order>(Method.Get, $"/orders/{orderID}").Result;
        }

        // TODO: Likely create a custom API path to search by customerID instead of orderID
        public DBEntryCollection<Order> GetOrderByCustomer(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentException("ID values must be greater than or equal to 0");
            }
            throw new NotImplementedException("GetOrderByCustomer");
            // Return CType(GetOrders().Where(Function(order As Order)
            // Return order.Customer.Id = customerID
            // End Function), DBEntryCollection(Of Order))
        }
    }
}