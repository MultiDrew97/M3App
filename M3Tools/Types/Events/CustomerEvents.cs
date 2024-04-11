namespace SPPBC.M3Tools.Events.Customers
{
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
