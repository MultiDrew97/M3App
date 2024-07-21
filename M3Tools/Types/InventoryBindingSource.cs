using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// A binding source that contains a list of inventory items
	/// </summary>
	public class InventoryBindingSource : BindingSource<Types.Product>
	{
		private readonly string InventoryFilter = "[ItemName] LIKE '%{0}%'";
		/// <summary>
		/// 
		/// </summary>
		public InventoryBindingSource() : base()
		{
			DataSource = new();
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public new object DataSource
		{
			get => DesignMode ? typeof(Types.InventoryCollection) : (Types.InventoryCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = value == string.Empty ? value : string.Format(InventoryFilter, value);
		}
	}
}
