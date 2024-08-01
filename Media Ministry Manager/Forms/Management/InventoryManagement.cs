using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events.Inventory;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public partial class InventoryManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public InventoryManagement() : base()
		{
			InitializeComponent();

			idg_Inventory.Reload += new EventHandler(Reload);
			idg_Inventory.AddProduct += new InventoryEventHandler(Add);
			idg_Inventory.UpdateProduct += new InventoryEventHandler(Update);
			idg_Inventory.RemoveProduct += new InventoryEventHandler(Remove);

			_original = dbInventory.GetProducts();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			idg_Inventory.Inventory = dbInventory.GetProducts();
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, idg_Inventory.Inventory.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			using AddProductDialog @add = new();

			if (add.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			dbInventory.AddInventory(add.Product);
			_ = MessageBox.Show($"Successfully created product", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			using SPPBC.M3Tools.Dialogs.EditProductDialog @edit = new(e.Value);

			if (edit.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			dbInventory.UpdateProduct(edit.Product);
			_ = MessageBox.Show($"Successfully updated product", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Product> e)
		{
			dbInventory.RemoveProduct(e.Value.Id);
			_ = MessageBox.Show($"Successfully removed product", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			_original.Filter = filter;
			idg_Inventory.Inventory = SPPBC.M3Tools.Types.InventoryCollection.Cast(_original.Items);
		}
	}
}
