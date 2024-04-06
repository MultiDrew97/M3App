using System.Collections.Generic;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Data
{
    public class InventoryBindingSource : BindingSource<Types.Product>
    {
		private readonly Types.InventoryCollection _inventory;

		public InventoryBindingSource() 
		{
			_inventory = new Types.InventoryCollection();
			DataSource = _inventory;
		}

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		public new Types.DBEntryCollection<Types.Product> DataSource
		{
			get
			{
				return _inventory;
			}
			protected set
			{
				_inventory.Clear();
				_inventory.AddRange(value);
			}
		}

		public override string Filter
		{ 
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
