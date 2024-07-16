using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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
		CUSTOMERS,
		/// <summary>
		/// Listener based functions
		/// </summary>
		LISTENERS,
		/// <summary>
		/// Order based functions
		/// </summary>
		ORDERS,
		/// <summary>
		/// Inventory based function
		/// </summary>
		INVENTORY
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
		/// Open one of the managment forms
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
		public event Events.Inventory.InventoryEventHandler AddProduct;

		/// <summary>
		/// Occurs when an order is successfully added
		/// </summary>
		public event Events.Orders.OrderEventHandler AddOrder;

		// TODO: Create the Orders based events here as well

		/// <summary>
		/// The location to save the installer for the application when updating
		/// </summary>
		private readonly string _DownloadLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Temp", "M3");

		private readonly Uri _VersionUri = new(My.Resources.Resources.LatestAppVersionUri);
		private readonly Uri _UpdateUri = new(My.Resources.Resources.AppUpdateUri);

		private bool IsUpdateAvailable
		{
			get
			{
				return false;
				// ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
				// TODO: Make this so that it just reads the value off the page instead of downloading it to read it
				string versionFileLocation = Path.Combine(_DownloadLocation, "version.txt");

				// Dim latestVersion As Version = Nothing
				// While latestVersion Is Nothing
				// wb_Updater.Url = New Uri(My.Resources.LatestAppVersionUri)
				// wb_Updater.Refresh()
				// versionString = wb_Updater.DocumentText.Replace("Version", String.Empty).Replace(vbCrLf, String.Empty).Trim
				// Try
				// latestVersion = New Version(versionString)
				// Catch
				// Continue While
				// End Try
				// End While
				if (File.Exists(versionFileLocation))
				{
					File.Delete(versionFileLocation);
				}

				while (!File.Exists(versionFileLocation))
				{
					try
					{
						My.MyProject.Computer.Network.DownloadFile(My.Resources.Resources.LatestAppVersionUri, versionFileLocation);

						var latestVersion = new Version(File.ReadAllText(versionFileLocation).Replace("Version", string.Empty).Replace(Constants.vbCrLf, string.Empty).Trim());
						// 
						// CompareTo
						// -1 = Referenced Version is older
						// 0 = Referenced Version is the same
						// 1 = Referenced Version is newer
						// 
						Console.WriteLine("Latest: {0}", latestVersion);
						Console.WriteLine("Current: {0}", My.MyProject.Application.Info.Version);
						Console.WriteLine("Comparison: {0}", My.MyProject.Application.Info.Version.CompareTo(latestVersion));

						return My.MyProject.Application.Info.Version.CompareTo(latestVersion) == -1;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
					}
				}

				return false;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public MainMenuStrip()
		{
			InitializeComponent();
		}

		private void LogoutApplication(object sender, EventArgs e)
		{
			Logout?.Invoke(sender, e);
		}

		private void Exit(object sender, EventArgs e)
		{
			ExitApplication?.Invoke(sender, e);
		}

		private void CreateCustomer(object sender, EventArgs e)
		{
			// TODO: Determine better process to decouple this functionality from M3Tools API
			using var create = new Dialogs.AddCustomerDialog();

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
			using var create = new Dialogs.AddListenerDialog();

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

		private void UpdateApp(object sender, EventArgs e)
		{

			if (!IsUpdateAvailable) return;
			// Dim updateLocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
			// Dim updateCheck As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

			// Dim request As HttpWebRequest = WebRequest.CreateHttp(updateCheck)
			// Dim responce As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

			// Dim sr As StreamReader = New StreamReader(responce.GetResponseStream)

			// Dim latestVersion As String = sr.ReadToEnd()
			// Dim currentVersion As String = Application.ProductVersion

			// If Not latestVersion.Contains(currentVersion) Then
			// wb_Updater.Navigate(updateLocation)
			// End If
			MessageBox.Show("This feature is currently under construction.", "Out of Order", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			// lsd_Loading.LoadText = "Checking for updates..."
			// lsd_Loading.ShowDialog()

			// If IsUpdateAvailable() Then
			// 'RaiseEvent UpdateAvailable()
			// 'wb_Updater.Url = New Uri(My.Resources.AppUpdateUri)
			// bw_Update.RunWorkerAsync(wb_Updater)
			// Else
			// 'MessageBox.Show("Software is up to date", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
			// lsd_Loading.LoadText = "Software is up to date"
			// End If
		}

		private void ChangeView(object sender, EventArgs e)
		{
			var obj = (ToolStripMenuItem)sender;

			switch(obj.AccessibleName.ToLower())
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

		private void ShowSettings(object sender, EventArgs e)
		{
			ViewSettings?.Invoke(sender, e);
		}

		private void UpdateAppBW(object sender, DoWorkEventArgs e)
		{
			// Dim wb = CType(e.Argument, WebBrowser)
			// wb.Url = _UpdateUri
			string setupFileLocation = Path.Combine(_DownloadLocation, "M3Setup.exe");
			if (File.Exists(setupFileLocation))
			{
				File.Delete(setupFileLocation);
			}

			My.MyProject.Computer.Network.DownloadFile(My.Resources.Resources.AppUpdateUri, setupFileLocation);
			try
			{
				Process.Start(setupFileLocation);
				UpdateAvailable?.Invoke(this, e);
			}
			catch
			{
				e.Cancel = true;
			}
		}

		/// <summary>
		/// Toggle hiding an entry in the menu strip based on passed name
		/// </summary>
		/// <param name="cat">The category to toggle</param>
		/// <param name="viewOnly">Whether to only hide the view buttons or all buttons related to category</param>
		public void ToggleViewItem(MenuItemsCategories cat, bool viewOnly = true)
		{
			// TODO: Make this more efficient
			switch (cat)
			{
				case MenuItemsCategories.CUSTOMERS:
					tsmi_ViewCustomers.Available = !tsmi_ViewCustomers.Available;

					if (!viewOnly) {
						tsmi_NewCustomer.Available = !tsmi_NewCustomer.Available;
					}

					break;
				case MenuItemsCategories.LISTENERS:
					tsmi_ViewListeners.Available = !tsmi_ViewListeners.Available;

					if (!viewOnly)
					{
						tsmi_NewListeners.Available = !tsmi_NewListeners.Available;
					}

					break;
				case MenuItemsCategories.ORDERS:
					tsmi_ViewOrders.Available = !tsmi_ViewOrders.Available;

					if (!viewOnly)
					{
						tsmi_NewOrder.Available = !tsmi_NewOrder.Available;
					}

					break;
				case MenuItemsCategories.INVENTORY:
					tsmi_ViewInventory.Available = !tsmi_ViewInventory.Available;

					if (!viewOnly)
					{
						tsmi_NewProduct.Available = !tsmi_NewProduct.Available;
					}

					break;
				default:
					break;

			}
		}
	}
}
