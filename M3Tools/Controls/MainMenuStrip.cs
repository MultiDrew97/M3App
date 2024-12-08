﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using SPPBC.M3Tools.Dialogs;
using SPPBC.M3Tools.Events;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// The different categories contained in the menu strip
	/// </summary>
	public enum MenuItemsCategories
	{
		/// <summary>
		/// Customer based functions
		/// </summary>
		Customer,
		/// <summary>
		/// Listener based functions
		/// </summary>
		Listener,
		/// <summary>
		/// Order based functions
		/// </summary>
		Order,
		/// <summary>
		/// Inventory based function
		/// </summary>
		Inventory,
		/// <summary>
		/// No functions
		/// </summary>
		None
	}

	// TODO: Open Display forms from here and figure out to discern closing type
	/// <summary>
	/// The custom Menu strip to be used throughout the application.
	/// 
	/// This consolidates similar programming logic to prevent from restating similar code points
	/// </summary>
	public partial class MainMenuStrip
	{
		/// <summary>
		/// Occurs when the Logout menu item is clicked
		/// </summary>
		public event EventHandler Logout;

		/// <summary>
		/// Open one of the management forms
		/// </summary>
		public event ManageEventHandler Manage;

		/// <summary>
		/// Occurs when the Settings menu item is clicked
		/// </summary>
		public event EventHandler ViewSettings;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public MainMenuStrip()
		{
			InitializeComponent();

			ParentChanged += new EventHandler(UpdateView);
		}

		private void UpdateView(object sender, EventArgs e)
		{
			string parent = Parent.GetType().ToString();

			ToggleViewItem(true switch
			{
				var _ when Regex.IsMatch(parent, "Customer", RegexOptions.IgnoreCase) => MenuItemsCategories.Customer,
				var _ when Regex.IsMatch(parent, "Inventory", RegexOptions.IgnoreCase) => MenuItemsCategories.Inventory,
				var _ when Regex.IsMatch(parent, "Listener", RegexOptions.IgnoreCase) => MenuItemsCategories.Listener,
				var _ when Regex.IsMatch(parent, "Order", RegexOptions.IgnoreCase) => MenuItemsCategories.Order,
				_ => MenuItemsCategories.None,
			});
		}

		private void LogoutApplication(object sender, EventArgs e) => Logout?.Invoke(sender, e);

		private void Exit(object sender, EventArgs e) => Utils.Exit();

		private void CreateCustomer(object sender, EventArgs e)
		{
#if !DEBUG
			MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#endif
			// TODO: Determine better process to decouple this functionality from M3Tools API
			using AddCustomerDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			MessageBox.Show($"{create.Customer.Name} has been added to the customers list", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//CreateEntries(this, new Events.DataEventArgs<IDbEntry>(create.Customer, EventType.Added));
		}

		private void CreateProduct(object sender, EventArgs e)
		{
#if !DEBUG
			MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#endif
			using AddProductDialog create = new();
			DialogResult res = create.ShowDialog();

			if (!(res == DialogResult.OK))
			{
				return;
			}

			MessageBox.Show($"{create.Product.Name} has been added to the inventory list", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//AddInventory?.Invoke(this, new Events.Inventory.InventoryEventArgs(create.Product, EventType.Added));
		}

		private void CreateListener(object sender, EventArgs e)
		{
#if !DEBUG
			MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#endif
			using AddListenerDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			MessageBox.Show($"{create.Listener.Name} has been added to the email listeners list", "Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//AddListener?.Invoke(this, new Events.Listeners.ListenerEventArgs(create.Listener, EventType.Added));
		}

		private void CreateOrder(object sender, EventArgs e)
		{
#if !DEBUG
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
#endif
			using PlaceOrderDialog @create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			MessageBox.Show($"Order #{create.Order.Id} has been created", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//AddOrder?.Invoke(this, new Events.Orders.OrderEventArgs(create.Order, EventType.Added));
		}

		private async void UpdateApp(object sender, EventArgs e)
		{
			if (!await Utils.UpdateAvailable())
			{
				_ = MessageBox.Show("No updates available.", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DialogResult res = MessageBox.Show("An update is available. Would you like to update now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (res != DialogResult.Yes)
			{
				return;
			}

			_ = await Utils.Update();
		}

		private void ChangeView(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			Manage?.Invoke(this, new(item.AccessibleName.ToLower() switch
			{
				"customers" => ManageType.Customers,
				"listeners" => ManageType.Listeners,
				"orders" => ManageType.Orders,
				"inventory" => ManageType.Inventory,
				_ => throw new ArgumentException("Sender not known")
			}));
		}

		private void ShowSettings(object sender, EventArgs e) =>
#if !DEBUG
			MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
#else
			ViewSettings?.Invoke(sender, e);
#endif

		/// <summary>
		/// Toggle hiding an entry in the menu strip based on passed name
		/// </summary>
		/// <param name="cat">The category to toggle</param>
		public void ToggleViewItem(MenuItemsCategories cat)
		{
			// TODO: Make this more efficient
			switch (cat)
			{
				case MenuItemsCategories.Customer:
					tsmi_ViewCustomers.Available = !tsmi_ViewCustomers.Available;
					break;
				case MenuItemsCategories.Listener:
					tsmi_ViewListeners.Available = !tsmi_ViewListeners.Available;
					break;
				case MenuItemsCategories.Order:
					tsmi_ViewOrders.Available = !tsmi_ViewOrders.Available;
					break;
				case MenuItemsCategories.Inventory:
					tsmi_ViewInventory.Available = !tsmi_ViewInventory.Available;
					break;
				default:
					break;

			}
		}
	}
}
