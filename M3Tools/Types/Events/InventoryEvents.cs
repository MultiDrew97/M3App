namespace SPPBC.M3Tools.Events.Inventory
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void InventoryEventHandler(object sender, InventoryEventArgs e);

	/// <inheritdoc/>
	public class InventoryEventArgs : DataEventArgs<Types.Product>
	{
		/// <inheritdoc/>
		public override Types.Product Value { get; protected set; }

		/// <inheritdoc/>
		public InventoryEventArgs(Types.Product value, EventType type = EventType.None) : base(value, type)
		{
		}
	}
}
