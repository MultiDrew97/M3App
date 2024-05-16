namespace SPPBC.M3Tools.Events.Customers
{
	/// <summary>
	/// Event handler for when a customer based data event occurs
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	// TODO: Try to figure out why polymorphism doesn't work for handlers
	//public delegate void CustomerEventHandler(object sender, DataEventArgs<Types.Customer> e);
	public delegate void CustomerEventHandler(object sender, CustomerEventArgs e);

	/// <inheritdoc/>
	sealed public class CustomerEventArgs : DataEventArgs<Types.Customer>
    {
		/// <inheritdoc/>
		public override Types.Customer Value { get; protected set; }

		/// <inheritdoc/>
		public CustomerEventArgs(Types.Customer value, EventType type = EventType.None) : base(value, type)
		{
		}
    }
}
