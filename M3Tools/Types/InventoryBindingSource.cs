using System.Collections.Generic;

namespace SPPBC.M3Tools.Data
{
    public class InventoryBindingSource : BindingSource<Types.Product>
    {
		private Types.InventoryCollection _inventory;

		public InventoryBindingSource() 
		{
			_inventory = new Types.InventoryCollection();
			DataSource = _inventory;
		}

		/// <summary>
		/// List of customers in the binding source
		/// </summary>
        public new IList<Types.Product> List
        {
            get
            {
                return DataSource.Items;
            }
        }

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		public new Types.InventoryCollection DataSource
		{
			get
			{
				return (Types.InventoryCollection)base.DataSource;
			}
			private set
			{
				base.DataSource = value;
			}
		}

		public override string Filter
		{ 
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
