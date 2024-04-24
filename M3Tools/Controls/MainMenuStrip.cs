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

	public enum MenuItemsCategories
	{
		CUSTOMERS,
		LISTENERS,
		ORDERS,
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
		private const string toolStripPrefix = "tsmi_";

		/// <summary>
		/// Occurs when the Logout menu item is clicked
		/// </summary>
		public event LogoutEventHandler Logout;

		/// <summary>
		/// The event that occurs when the user wishes to logout the application
		/// </summary>
		public delegate void LogoutEventHandler();

		/// <summary>
		/// Occurs when the ViewCustomer menu item is clicked
		/// </summary>
		public event EventHandler ManageCustomers;

		/// <summary>
		/// Occurs when the ViewListener menu item is clicked
		/// </summary>
		public event EventHandler ManageListeners;

		/// <summary>
		/// Occurs when the ViewProducts menu item is clicked
		/// </summary>
		public event EventHandler ManageProducts;

		/// <summary>
		/// Occurs when the ViewOrders menu item is clicked
		/// </summary>
		public event EventHandler ManageOrders;

		/// <summary>
		/// Occurs when the Settings menu item is clicked
		/// </summary>
		public event ViewSettingsEventHandler ViewSettings;

		/// <summary>
		/// The handler for when the user wants to look at the application settings
		/// </summary>
		public delegate void ViewSettingsEventHandler();

		/// <summary>
		/// Occurs when the Exit menu item is clicked
		/// </summary>
		public event ExitApplicationEventHandler ExitApplication;

		/// <summary>
		/// The handler for when the user wishes to exit the application entirely
		/// </summary>
		public delegate void ExitApplicationEventHandler();

		/// <summary>
		/// Occurs when the Update menu item is clicked, and an update is available
		/// </summary>
		public event UpdateAvailableEventHandler UpdateAvailable;

		/// <summary>
		/// The handler for when the user wants to manually check for an update
		/// </summary>
		public delegate void UpdateAvailableEventHandler();

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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public MainMenuStrip()
		{
			InitializeComponent();
		}

		private void LogoutApplication(object sender, EventArgs e)
		{
			Logout?.Invoke();
		}

		private void Exit(object sender, EventArgs e)
		{
			ExitApplication?.Invoke();
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

		private void ViewCustomers(object sender, EventArgs e)
		{
			ManageCustomers?.Invoke(this, e);
		}

		private void ViewProducts(object sender, EventArgs e)
		{
			ManageProducts?.Invoke(this, e);
		}

		private void ViewOrders(object sender, EventArgs e)
		{
			ManageOrders?.Invoke(this, e);
		}

		private void ViewListeners(object sender, EventArgs e)
		{
			ManageListeners?.Invoke(this, e);
		}

		private void ShowSettings(object sender, EventArgs e)
		{
			ViewSettings?.Invoke();
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
				UpdateAvailable?.Invoke();
			}
			catch
			{
				e.Cancel = true;
			}
		}

		private bool IsUpdateAvailable()
		{
			// ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
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
				finally
				{
					lsd_Loading.Closable = true;
				}
			}

			return false;
		}

		private void ToggleItem(params string[] path)
		{
			if (string.IsNullOrWhiteSpace(path[0]))
			{
				throw new Exceptions.MenuException("Initial path must be passed");
			}
			string parentItemName = path[0].Contains(toolStripPrefix) ? path[0] : $"{toolStripPrefix}{path[0]}";
			ToolStripMenuItem parentItem = (ToolStripMenuItem)Items[parentItemName];

			if (parentItem is null)
			{
				throw new Exceptions.MenuException($"Menu item with name {path[0]} not found");
			}

			ToggleItem(parentItem, path.Skip(1).ToArray());
		}

		private void ToggleItem(ToolStripMenuItem parent, params string[] path)
		{
			// TODO: Figure out how to simplify this
			ToolStripMenuItem currentItem;

			switch (path.Length)
			{
				case 0:
					{
						currentItem = parent;
						break;
					}
				case 1:
					{
						currentItem = GetChildItem(parent, path[0]);
						break;
					}

				default:
					{
						currentItem = parent;
						foreach (string child in path)
							currentItem = GetChildItem(currentItem, child);
						break;
					}
			}

			currentItem.Available = !currentItem.Available;
		}

		private ToolStripMenuItem GetChildItem(ToolStripMenuItem parent, string name)
		{
			foreach (ToolStripMenuItem item in parent.DropDownItems)
			{
				if (item.AccessibleName.Equals(name) | item.Name.Contains(name))
				{
					// The current child has the name that is being looked for
					return item;
				}
			}

			throw new Exceptions.MenuException($"Menu item {name} under the parent of {parent.AccessibleName} not found");
		}

		/*public void ToggleViewItem(string itemName)
		{
			ToggleItem(new[] { "view", itemName });
		}*/

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
					tsmi_ViewProducts.Available = !tsmi_ViewProducts.Available;

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
