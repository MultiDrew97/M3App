using System;
using System.Threading;
using System.Windows.Forms;

using SPPBC.M3Tools.Events.Customers;
using SPPBC.M3Tools.Types;

namespace M3App
{
	// TODO: Figure out how to allow to be abstract and still have designer privileges
	/// <summary>
	/// 
	/// </summary>
	public abstract partial class ManagementForm<T> where T : IDbEntry
	{
		/// <summary>
		/// 
		/// </summary>
		protected internal DbEntryCollection<T> _original;

		protected CancellationTokenSource tokenSource;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public ManagementForm()
		{
			InitializeComponent();

			Init();

			mms_Main.ExitApplication += new EventHandler(Exit);
			mms_Main.Logout += new EventHandler(LogOff);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.AddCustomer += new CustomerEventHandler(Add);
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);

			ts_Tools.AddEntry += new EventHandler(Add);
			ts_Tools.ImportEntries += new EventHandler(Import);
			ts_Tools.SendEmails += new EventHandler(SendEmails);
			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
		}

		private void Init()
		{
			SPPBC.M3Tools.ToolButtons[] toolButtons;

			SPPBC.M3Tools.MenuItemsCategories menuItem;
			switch (typeof(T))
			{
				case var customer when customer == typeof(Customer):
					toolButtons = [SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT];
					menuItem = SPPBC.M3Tools.MenuItemsCategories.Customer;
					break;
				case var listener when listener == typeof(Listener):
					toolButtons = [];
					menuItem = SPPBC.M3Tools.MenuItemsCategories.Listener;
					break;
				case var order when order == typeof(Order):
					toolButtons = [SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT];
					menuItem = SPPBC.M3Tools.MenuItemsCategories.Order;
					break;
				case var inventory when inventory == typeof(Product):
					toolButtons = [SPPBC.M3Tools.ToolButtons.EMAIL];
					menuItem = SPPBC.M3Tools.MenuItemsCategories.Inventory;
					break;
				default:
					throw new NotSupportedException($"Type '{typeof(T)}' not supported by form");
			}

			ts_Tools.ToggleButton(toolButtons);
			mms_Main.ToggleViewItem(menuItem);

			tokenSource = new();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void DisplayClosing(object sender, FormClosingEventArgs e)
		{
			tokenSource.Cancel();

			// FIXME: Figure out why I can't get this to be sent from the MainStrip
			if (sender is SPPBC.M3Tools.MainMenuStrip)
			{
				return;
			}

			Utils.OpenForm(typeof(MainForm));
		}

		/// <summary>
		/// Reloads the display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Reload(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Add a new entry to the database 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Add(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Update an entry in the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		protected virtual void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<T> e)
		{
		}

		/// <summary>
		/// Remove an entry from the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		protected virtual void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<T> e)
		{
		}

		/// <summary>
		/// Import data into the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Import(object sender, EventArgs e) { }

		/// <summary>
		/// Send emails out using current user's email credentials
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void SendEmails(object sender, EventArgs e) { }

		/// <summary>
		/// Called when the filter is changed in the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected virtual void FilterChanged(object sender, string filter) => _original.Filter = filter;

		private void LogOff(object sender, EventArgs e)
		{
			Close();
			Utils.LogOff();
		}

		private void Exit(object sender, EventArgs e) => Utils.CloseApplication();

		private void ViewSettings(object sender, EventArgs e)
		{
			using SettingsForm settings = new();
			settings.Show();
		}

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			switch (e.Manage)
			{
				case SPPBC.M3Tools.Events.ManageType.Listeners:
					new ListenerManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Inventory:
					new InventoryManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Orders:
					new OrderManagement().Show();
					break;
				case SPPBC.M3Tools.Events.ManageType.Customers:
					new CustomerManagement().Show();
					break;
				default:
					return;
			}

			_ = ((SPPBC.M3Tools.MainMenuStrip)sender).Invoke(Close);
		}
	}
}
