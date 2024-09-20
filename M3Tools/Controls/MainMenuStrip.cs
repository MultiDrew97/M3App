﻿using System;
using System.IO;
using System.Windows.Forms;

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
		Inventory
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
		/// Occurs when the Exit menu item is clicked
		/// </summary>
		public event EventHandler ExitApplication;

		/// <summary>
		/// Occurs when the Update menu item is clicked, and an update is available
		/// </summary>
		public event EventHandler UpdateAvailable;

		/// <summary>
		/// Occurs when a customer is successfully added
		/// </summary>
		public event Events.Customers.CustomerEventHandler AddCustomer;

		/// <summary>
		/// Occurs when a listener is successfully added
		/// </summary>
		public event Events.Listeners.ListenerEventHandler AddListener;

		/// <summary>
		/// Occurs when a product is successfully added
		/// </summary>
		public event Events.Inventory.InventoryEventHandler AddInventory;

		/// <summary>
		/// Occurs when an order is successfully added
		/// </summary>
		public event Events.Orders.OrderEventHandler AddOrder;

		// TODO: Create the Orders based events here as well

		/// <summary>
		/// The location to save the installer for the application when updating
		/// </summary>
		private string DownloadLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", "M3AppSetup.exe");

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public MainMenuStrip() => InitializeComponent();

		private void LogoutApplication(object sender, EventArgs e) => Logout?.Invoke(sender, e);

		private void Exit(object sender, EventArgs e) => ExitApplication?.Invoke(sender, e);

		private void CreateCustomer(object sender, EventArgs e)
		{
			// TODO: Determine better process to decouple this functionality from M3Tools API
			using Dialogs.AddCustomerDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			AddCustomer?.Invoke(this, new Events.Customers.CustomerEventArgs(create.Customer, EventType.Added));
		}

		private void CreateProduct(object sender, EventArgs e)
		{
			//using (var create = new Dialogs.AddProductDialog())
			//{
			//	var res = create.ShowDialog();

			//	if (!(res == DialogResult.OK))
			//	{
			//		return;
			//	}

			//	AddProduct?.Invoke(this, new Events.Inventory.InventoryEventArgs(create.Product, EventType.Added));
			//}
		}

		private void CreateListener(object sender, EventArgs e)
		{
			using Dialogs.AddListenerDialog create = new();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			AddListener?.Invoke(this, new Events.Listeners.ListenerEventArgs(create.Listener, EventType.Added));
		}

		private void CreateOrder(object sender, EventArgs e)
		{
			/*using var @create = new NewOrderDialog();

			if (create.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			AddOrder?.Invoke(this, new Events.Orders.OrderEventArgs(create.Order, EventType.Added));*/
		}

		private async void UpdateApp(object sender, EventArgs e)
		{
			if (!Utils.UpdateAvailable)
			{
				return;
			}

			_ = await Utils.Update(Properties.Resources.AppUpdateUri, DownloadLocation);
		}

		private void ChangeView(object sender, EventArgs e)
		{
			ToolStripMenuItem obj = (ToolStripMenuItem)sender;

			switch (obj.AccessibleName.ToLower())
			{
				case "customers":
					Manage?.Invoke(this, new(ManageType.Customers));
					break;
				case "listeners":
					Manage?.Invoke(this, new(ManageType.Listeners));
					break;
				case "orders":
					Manage?.Invoke(this, new(ManageType.Orders));
					break;
				case "inventory":
					Manage?.Invoke(this, new(ManageType.Inventory));
					break;
				default:
					Console.WriteLine(obj.AccessibleName.ToLower());
					throw new ArgumentException("Sender not known");
			}
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
