using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPPBC.M3Tools.Events;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// A control to display a list of inventory items
	/// </summary>
	public partial class InventoryDataGrid
	{
		/// <summary>
		/// An event fired when a new product is added
		/// </summary>
		public event Events.Inventory.InventoryEventHandler AddProduct;

		/// <summary>
		/// An event fired when a product is updated
		/// </summary>
		public event Events.Inventory.InventoryEventHandler UpdateProduct;

		/// <summary>
		/// An event fired when a product is removed
		/// </summary>
		public event Events.Inventory.InventoryEventHandler RemoveProduct;


		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Description("Data Source to use for data grid.")]
		public new object DataSource
		{
			get => DesignMode ? typeof(InventoryBindingSource) : (InventoryBindingSource)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// The list of inventory items
		/// </summary>
		[Browsable(false)]
		public Types.InventoryCollection Inventory
		{
			get => Types.InventoryCollection.Cast(base.Rows);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.InventoryCollection SelectedRows
		{
			get => Types.InventoryCollection.Cast(base.SelectedRows);
		}

		/// <summary>
		/// 
		/// </summary>
		public InventoryDataGrid() : base()
		{
			InitializeComponent();

			AddEntry += (sender, e) => AddProduct?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateProduct?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveProduct?.Invoke(sender, new(e.Value, e.EventType));
		}
	}
}
