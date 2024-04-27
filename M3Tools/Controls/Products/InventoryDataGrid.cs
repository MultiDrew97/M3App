using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Inventory;

namespace SPPBC.M3Tools
{

	/// <summary>
	/// A control to display a list of inventory items
	/// </summary>
	public partial class InventoryDataGrid : Data.DataGrid<Types.Product>
	{
		/// <summary>
		/// An event fired when a new product is added
		/// </summary>
		public event InventoryEventHandler AddProduct;

		/// <summary>
		/// An event fired when a product is updated
		/// </summary>
		public event InventoryEventHandler UpdateProduct;

		/// <summary>
		/// An event fired when a product is removed
		/// </summary>
		public event InventoryEventHandler RemoveProduct;

		/// <summary>
		/// 
		/// </summary>
		public delegate void RefreshDisplayEventHandler();

		/// <summary>
		/// The list of inventory items
		/// </summary>
		public IList Products
		{
			get
			{
				return base.Rows;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Description("Data Source to use for data grid.")]
		public new Data.BindingSource<Types.Product> DataSource
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

		/// <summary>
		/// The filter to apply to the list of inventory items
		/// </summary>
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

		/// <summary>
		/// Whether to allow editing the items. If set to false, the edit column will be hidden
		/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
		public InventoryDataGrid()
		{
			InitializeComponent();

			//AddEntry += new DataEventHandler<Types.Product>(AddProduct.Invoke);
			UpdateEntry += new DataEventHandler<Types.Product>(UpdateProduct.Invoke);
			RemoveEntry += new DataEventHandler<Types.Product>(RemoveProduct.Invoke);
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Product> e)
		{
			switch (e.EventType)
			{
				case EventType.Added: { AddProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				case EventType.Removed: { UpdateProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				case EventType.Updated: { RemoveProduct?.Invoke(sender, (InventoryEventArgs)e); break; }
				default: { throw new ArgumentException($""); }
			}
		}
	}
}
