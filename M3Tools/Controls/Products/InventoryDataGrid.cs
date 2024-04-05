using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Inventory;

namespace SPPBC.M3Tools
{

	public partial class InventoryDataGrid : Data.DataGrid<Types.Product>
	{
		public event InventoryEventHandler AddProduct;
		public event InventoryEventHandler UpdateProduct;
		public event InventoryEventHandler RemoveProduct;
		public event RefreshDisplayEventHandler RefreshDisplay;

		public delegate void RefreshDisplayEventHandler();

		public IList Products
		{
			get
			{
				return base.Rows;
			}
		}

		[Description("Data Source to use for data grid.")]
		public override Data.BindingSource<Types.Product> DataSource
		{
			get
			{
				return (Data.InventoryBindingSource)bsInventory.DataSource;
			}
			set
			{
				bsInventory.DataSource = value;
			}
		}

		[DefaultValue("")]
		public string Filter
		{
			get
			{
				return DataSource.Filter;
			}
			set
			{
				// TODO: Fix bug and flesh out
				if (!string.IsNullOrEmpty(value))
				{
					DataSource.Filter = $"([FirstName] like '%{value}%') OR ([LastName] like '%${value}%') OR ([Email] like '%{value}%')";
					return;
				}

				DataSource.Filter = value;
			}
		}

		[DefaultValue(true)]
		public bool AllowEditting
		{
			get
			{
				return dgc_Edit.Visible;
			}
			set
			{
				dgc_Edit.Visible = value;
			}
		}

		public InventoryDataGrid()
		{
			InitializeComponent();

			this.cms_Tools.RefreshView += Refresh;

			Add += ParseEvents;
			Update += ParseEvents;
			Remove += ParseEvents;
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Product> e)
		{
			switch (e.EventType)
			{
				case EventType.Added: { AddProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				case EventType.Deleted: { UpdateProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				case EventType.Updated: { RemoveProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				default: { throw new ArgumentException($""); }
			}
		}

		private void RefreshView()
		{
			RefreshDisplay?.Invoke();
		}
	}
}
