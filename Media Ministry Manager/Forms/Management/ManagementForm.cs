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
	public partial class ManagementForm<T> where T : IDbEntry
	{
		private readonly CancellationTokenSource _tokenSource;

		/// <summary>
		/// 
		/// </summary>
		protected internal DbEntryCollection<T> _original;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		protected ManagementForm()
		{
			InitializeComponent();

			ts_Tools.ToggleButton(typeof(T) switch
			{
				var c when c == typeof(Customer) => [SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT],
				var l when l == typeof(Listener) => [],
				var o when o == typeof(Order) => [SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT],
				var p when p == typeof(Product) => [SPPBC.M3Tools.ToolButtons.EMAIL],
				_ => []
			});

			_tokenSource = new();

			mms_Main.Logout += new EventHandler(Logout);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.AddCustomer += new CustomerEventHandler(Add);
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);

			ts_Tools.AddEntry += new EventHandler(Add);
			ts_Tools.ImportEntries += new EventHandler(Import);
			ts_Tools.SendEmails += new EventHandler(SendEmails);
			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void DisplayClosing(object sender, FormClosingEventArgs e)
		{
			_tokenSource.Cancel();

			// FIXME: Figure out why I can't get this to be sent from the MainStrip
			if (sender is SPPBC.M3Tools.MainMenuStrip)
			{
				return;
			}

			new MainForm().Show();
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

		private void Logout(object sender, EventArgs e)
		{
			Utils.Logout(this);
			Close();
		}

		private void Exit(object sender, EventArgs e) => Utils.Exit();

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
