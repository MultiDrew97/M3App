using System.Collections;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom binding source to be used with the M3 Application
	/// </summary>
	/// <typeparam name="T">Data type for the data being used for binding</typeparam>
	public partial class BindingSource<T> where T : Types.IDbEntry
	{
		/// <summary>
		/// The binding source supports filtering
		/// </summary>
		public readonly new bool SupportsFiltering = true;

		///// <summary>
		///// List of customers in the binding source
		///// </summary>
		//[EditorBrowsable(EditorBrowsableState.Advanced)]
		//public new IList List
		//{
		//	get => base.List;
		//}

		/// <summary>
		/// The datasource being used for the binding source
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		// MAYBE: Look into using the TypeDescriptionProviderAttribute and similar to make dev potentially easier
		protected new object DataSource
		{
			get => DesignMode ? typeof(Types.DbEntryCollection<T>) : (Types.DbEntryCollection<T>)base.DataSource;
			set => base.DataSource = value;
		}
	}
}
