using System.Collections.Generic;
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
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.InventoryCollection DataSource { 
			get => (Types.InventoryCollection)base.DataSource;
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
