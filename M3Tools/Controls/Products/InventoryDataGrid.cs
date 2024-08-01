using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// A control to display a list of inventory items
	/// </summary>
	public partial class InventoryDataGrid
	{
		#region Columns
		// Columns for the inventory data grid
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name = new();
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Stock = new();
		internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Price = new();
		internal System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Available = new();
		#endregion

		#region Events
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
		#endregion

		/// <summary>
		/// The list of inventory items
		/// </summary>
		[Browsable(false)]
		public Types.InventoryCollection Inventory
		{
			get => Types.InventoryCollection.Cast(bsInventory.List);
			set
			{
				if (DesignMode)
				{
					return;
				}

				bsInventory.DataSource = value;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public Types.InventoryCollection SelectedInventory => Types.InventoryCollection.Cast(base.SelectedRows);

		/// <summary>
		/// 
		/// </summary>
		public InventoryDataGrid() : base()
		{
			InitializeComponent();

			LoadColumns();

			AddEntry += (sender, e) => AddProduct?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateProduct?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveProduct?.Invoke(sender, new(e.Value, e.EventType));
		}

		/// <inheritdoc/>
		protected override void LoadColumns()
		{
			base.LoadColumns();

			dgc_ID.HeaderText = "ItemID";

			// Name Column
			dgc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Name.DataPropertyName = "Name";
			dgc_Name.FillWeight = 40F;
			dgc_Name.HeaderText = "Name";
			dgc_Name.MinimumWidth = 50;
			dgc_Name.Name = "dgc_Name";
			dgc_Name.ReadOnly = true;

			// Stock Column
			dgc_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Stock.DataPropertyName = "Stock";
			dgc_Stock.FillWeight = 20F;
			dgc_Stock.HeaderText = "Stock";
			dgc_Stock.Name = "dgc_Stock";
			dgc_Stock.ReadOnly = true;

			// Price Column
			dgc_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Price.DataPropertyName = "Price";
			dgc_Price.DefaultCellStyle = new() { Format = "C2", NullValue = "$0.00" };
			dgc_Price.FillWeight = 20F;
			dgc_Price.HeaderText = "Price";
			dgc_Price.Name = "dgc_Price";
			dgc_Price.ReadOnly = true;

			// Availability Column
			dgc_Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_Available.DataPropertyName = "Available";
			dgc_Available.FalseValue = "False";
			dgc_Available.FillWeight = 20F;
			dgc_Available.HeaderText = "Available?";
			dgc_Available.Name = "dgc_Available";
			dgc_Available.ReadOnly = true;
			dgc_Available.TrueValue = "True";

			Columns.AddRange([
				dgc_Selection, dgc_ID,
				dgc_Name, dgc_Stock, dgc_Price, dgc_Available,
				dgc_Edit, dgc_Remove
			]);
		}
	}
}
