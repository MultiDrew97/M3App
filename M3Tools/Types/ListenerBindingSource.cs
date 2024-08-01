namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source for managing listener info
	/// </summary>
	public class ListenerBindingSource : BindingSource<Types.Listener>
	{
		/// <summary>
		/// 
		/// </summary>
		public ListenerBindingSource() : base() => DataSource = new Types.ListenerCollection();

	}
}
