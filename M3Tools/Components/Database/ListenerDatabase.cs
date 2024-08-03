using System;

using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ListenerDatabase
	{
		private const string path = "listeners";

		/// <summary>
		/// Add a new listener to the database
		/// </summary>
		/// <param name="listener"></param>
		public void AddListener(Types.Listener listener) => Execute(System.Net.Http.HttpMethod.Post, $"{path}", JSON.ConvertToJSON(listener));

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

			Execute(System.Net.Http.HttpMethod.Delete, $"{path}/{listenerID}");
		}

		/// <summary>
		/// Update the info for a listener
		/// </summary>
		/// <param name="listener"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void UpdateListener(Types.Listener listener) => Execute(System.Net.Http.HttpMethod.Put, $"{path}/{listener.Id}", JSON.ConvertToJSON(listener));

		/// <summary>
		/// Retrieves the complete list of listeners
		/// </summary>
		/// <returns></returns>
		public Types.ListenerCollection GetListeners() => ExecuteWithResult<Types.ListenerCollection>(System.Net.Http.HttpMethod.Get, $"{path}").Result;

		/// <summary>
		/// Retrieves a listener based on the provided listener ID
		/// </summary>
		/// <param name="listenerID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public Types.Listener GetListener(int listenerID)
		{
			return !Utils.ValidID(listenerID)
				? throw new ArgumentException($"Invalid ListenerID provided")
				: ExecuteWithResult<Types.Listener>(System.Net.Http.HttpMethod.Get, $"{path}/{listenerID}").Result;
		}
	}
}
