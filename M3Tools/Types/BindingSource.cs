namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom binding source to be used with the M3 Application
	/// </summary>
	/// <typeparam name="T">Data type for the data being used for binding</typeparam>
	public abstract partial class BindingSource<T> : System.Windows.Forms.BindingSource where T : Types.IDbEntry
	{
		/// <summary>
		/// The binding source supports filtering
		/// </summary>
		public readonly new bool SupportsFiltering = true;

		/// <summary>
		/// The data source to use for this binding source
		/// </summary>
		public virtual new Types.DBEntryCollection<T> DataSource { get; set; }
	}
}
