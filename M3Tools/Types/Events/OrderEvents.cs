namespace SPPBC.M3Tools.Events.Orders
{
	/// <summary>
	/// Event handler for when an order based data event occurs
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	// TODO: Try to figure out why polymorphism doesn't work for handlers
	public delegate void OrderEventHandler(object sender, OrderEventArgs e);

	/// <inheritdoc/>
	public sealed class OrderEventArgs : DataEventArgs<Types.Order>
	{
		/// <inheritdoc/>
		public override Types.Order Value { get; protected set; }

		/// <inheritdoc/>
		public OrderEventArgs(Types.Order value, EventType type = EventType.None) : base(value, type)
		{
		}
	}
}
