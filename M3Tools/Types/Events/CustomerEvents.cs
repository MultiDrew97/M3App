namespace SPPBC.M3Tools.Events.Customers
{
	/// <summary>
	/// Event handler for when a customer based data event occurs
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void CustomerEventHandler(object sender, CustomerEventArgs e);

	/// <summary>
	/// 
	/// </summary>
	sealed public class CustomerEventArgs : DataEventArgs<Types.Customer>
    {
		/// <summary>
		/// 
		/// </summary>
		public override Types.Customer Value { get; protected set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="type"></param>
		public CustomerEventArgs(Types.Customer value, EventType type = EventType.None) : base(value, type)
		{
		}
    }
}
