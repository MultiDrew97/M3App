using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// A binding source that contains a list of inventory items
	/// </summary>
    public class InventoryBindingSource : BindingSource<Types.Product>
    {
		/// <summary>
		/// 
		/// </summary>
		public InventoryBindingSource() : base()
		{
			DataSource = new();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.InventoryCollection DataSource { 
			get => (Types.InventoryCollection)base.DataSource;
			set => base.DataSource = value;
		}
	}
}
