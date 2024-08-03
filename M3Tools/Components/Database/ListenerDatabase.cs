using System;

using SPPBC.M3Tools.M3API;

namespace SPPBC.M3Tools.Database
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ListenerDatabase
	{
		/// <summary>
		/// Retrieves a listener based on the provided listener ID
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public Types.Listener GetListener(int listenerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(listenerID)
				? ExecuteWithResult<Types.Listener>(System.Net.Http.HttpMethod.Get, string.Join(Paths.Seperator, Paths.Listeners, listenerID), string.Empty, ct).Result
				: throw new ArgumentException($"Invalid ListenerID provided");

		/// <summary>
		/// Retrieves the complete list of listeners
		/// </summary>
		/// <returns></returns>
		public Types.ListenerCollection GetListeners(System.Threading.CancellationToken ct = default)
			=> ExecuteWithResult<Types.ListenerCollection>(System.Net.Http.HttpMethod.Get, Paths.Listeners, string.Empty, ct).Result;

		/// <summary>
		/// Add a new listener to the database
		/// </summary>
		/// <param name="listener"></param>
		/// <param name="ct"></param>
		public bool AddListener(Types.Listener listener, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Post, Paths.Listeners, JSON.ConvertToJSON(listener), ct);

		/// <summary>
		/// Remove a listener from the database
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="ct"></param>
		/// <exception cref="ArgumentException"></exception>
		public bool RemoveListener(int listenerID, System.Threading.CancellationToken ct = default)
			=> Utils.ValidID(listenerID)
				? Execute(System.Net.Http.HttpMethod.Delete, string.Join(Paths.Seperator, Paths.Listeners, listenerID), string.Empty, ct)
				: throw new ArgumentException($"Invalid ListenerID provided");

		/// <summary>
		/// Update the info for a listener
		/// </summary>
		/// <param name="listener"></param>
		/// <param name="ct"></param>
		/// <exception cref="NotImplementedException"></exception>
		public bool UpdateListener(Types.Listener listener, System.Threading.CancellationToken ct = default)
			=> Execute(System.Net.Http.HttpMethod.Put, string.Join(Paths.Seperator, Paths.Listeners, listener.Id), JSON.ConvertToJSON(listener), ct);
	}
}
