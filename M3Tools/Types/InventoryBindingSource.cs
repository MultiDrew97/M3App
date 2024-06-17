using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// A binding source that contains a list of inventory items
	/// </summary>
    public class InventoryBindingSource : BindingSource<Types.Product>
    {
		private readonly Types.InventoryCollection _inventory = new();

		/// <summary>
		/// 
		/// </summary>
		public InventoryBindingSource() : base()
		{
			_inventory = new Types.InventoryCollection();
			DataSource = _inventory;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		public new object DataSource { 
			get => DesignMode ? typeof(Types.InventoryCollection) : (Types.InventoryCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{ 
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
