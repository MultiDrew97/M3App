namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source for managing order info
	/// </summary>
	public partial class OrderBindingSource
	{
		/// <summary>
		/// 
		/// </summary>
		public OrderBindingSource() : base() => DataSource = new Types.OrderCollection();
	}
}
