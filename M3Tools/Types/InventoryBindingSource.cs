namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source for managing inventory info
	/// </summary>
	public class InventoryBindingSource : BindingSource<Types.Product>
	{
		/// <summary>
		/// 
		/// </summary>
		public InventoryBindingSource() : base() => DataSource = new Types.InventoryCollection();
	}
}
