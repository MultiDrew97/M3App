namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source for managing customer info
	/// </summary>
	public class CustomerBindingSource : BindingSource<Types.Customer>
	{
		/// <summary>
		/// 
		/// </summary>
		public CustomerBindingSource() : base() => DataSource = new Types.CustomerCollection();
	}
}
