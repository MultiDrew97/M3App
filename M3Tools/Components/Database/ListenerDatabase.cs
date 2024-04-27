using System;
using System.ComponentModel;
using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
    // TODO: Revamp this area as well
    public sealed partial class ListenerDatabase
    {
        private const string path = "listeners";

		/// <summary>
		/// Add a new listener to the database
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="email"></param>
        public void AddListener(string firstName, string lastName, string email)
        {
            AddListener($"{firstName} {lastName}", email);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
        public void AddListener(string name, string email)
        {
            AddListener(new Types.Listener(-1, name, email));
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listener"></param>
        public void AddListener(Types.Listener listener)
        {
            Execute(Method.Post, $"{path}", JSON.ConvertToJSON(listener));
        }

		/// <summary>
		/// Remove a listener from the database
		/// </summary>
		/// <param name="listenerID"></param>
		/// <exception cref="ArgumentException"></exception>
        public void RemoveListener(int listenerID)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            Execute(Method.Delete, $"{path}/{listenerID}");
        }

		/// <summary>
		/// Update the info for a listener
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="email"></param>
        public void UpdateListener(int listenerID, string fName, string lName, string email)
        {
            UpdateListener(listenerID, $"{fName} {lName}", email);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="name"></param>
		/// <param name="email"></param>
		/// <exception cref="ArgumentException"></exception>
        public void UpdateListener(int listenerID, string name, string email)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            UpdateListener(new Types.Listener(listenerID, name, email));
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listener"></param>
		/// <exception cref="NotImplementedException"></exception>
        public void UpdateListener(Types.Listener listener)
        {
            throw new NotImplementedException("UpdateListener");
        }

		/// <summary>
		/// Retrieves the complete list of listeners
		/// </summary>
		/// <returns></returns>
        public Types.ListenerCollection GetListeners()
        {
            return ExecuteWithResult<Types.ListenerCollection>(Method.Get, $"{path}").Result;
        }

		/// <summary>
		/// Retrieves a listener based on the provided listener ID
		/// </summary>
		/// <param name="listenerID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
        public Types.Listener GetListener(int listenerID)
        {
            if (!Utils.ValidID(listenerID))
            {
                throw new ArgumentException($"Invalid ListenerID provided");
            }

            return ExecuteWithResult<Types.Listener>(Method.Get, $"{path}/{listenerID}").Result;
        }
    }
}
