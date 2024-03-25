using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
    // TODO: Revamp this area as well
    public sealed partial class ListenerDatabase
    {
        private const string path = "listeners";

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

        public void AddListener(string firstName, string lastName, string email)
        {
            AddListener($"{firstName} {lastName}", email);
        }

        public void AddListener(string name, string email)
        {
            AddListener(new Types.Listener(-1, name, email));
        }

        public void AddListener(Types.Listener listener)
        {
            dbConnection.Consume(Method.Post, $"/{path}", JSON.ConvertToJSON(listener));
        }

        public void RemoveListener(int listenerID)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            dbConnection.Consume(Method.Delete, $"/{path}/{listenerID}");
        }

        public void UpdateListener(int listenerID, string fName, string lName, string email)
        {
            UpdateListener(listenerID, $"{fName} {lName}", email);
        }

        public void UpdateListener(int listenerID, string name, string email)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            UpdateListener(new Types.Listener(listenerID, name, email));
        }

        public void UpdateListener(Types.Listener listener)
        {
            throw new NotImplementedException("UpdateListener");
        }

        public Types.DBEntryCollection<Types.Listener> GetListeners()
        {
            return dbConnection.Consume<Types.DBEntryCollection<Types.Listener>>(Method.Get, $"/{path}").Result;
        }

        public Types.Listener GetListener(int listenerID)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            return dbConnection.Consume<Types.Listener>(Method.Get, $"/{path}/{listenerID}").Result;
        }
    }
}