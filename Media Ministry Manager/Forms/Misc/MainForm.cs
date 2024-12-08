using System;
using System.Windows.Forms;

namespace M3App
{
	/// <summary>
	/// Main form for all operations
	/// </summary>
	public partial class MainForm
	{
		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			// Menu Strip
			mms_Main.Manage += new SPPBC.M3Tools.Events.ManageEventHandler(Manage);
			mms_Main.ViewSettings += new EventHandler(ViewSettings);
			mms_Main.Logout += new EventHandler(Logout);

			// Management Buttons
			btn_ProductManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Inventory));
			btn_CustomerManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Customers));
			btn_ListenerManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Listeners));
			btn_OrderManagement.Click += (sender, e) => Manage(sender, new(SPPBC.M3Tools.Events.ManageType.Orders));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			// Place any custom closing behavior here
			UseWaitCursor = false;
			base.OnFormClosed(e);

			//if (Application.OpenForms.Count > 0)
			//{
			//	return;
			//}

			//Utils.Exit();
		}

		private void Manage(object sender, SPPBC.M3Tools.Events.ManageEventArgs e)
		{
			try
			{
				UseWaitCursor = true;
				Form manage = e.Manage switch
				{
					SPPBC.M3Tools.Events.ManageType.Customers => new CustomerManagement(),
					SPPBC.M3Tools.Events.ManageType.Listeners => new ListenerManagement(),
					SPPBC.M3Tools.Events.ManageType.Orders => new OrderManagement(),
					SPPBC.M3Tools.Events.ManageType.Inventory => new InventoryManagement(),
					_ => throw new ArgumentException($"Unknown manage type {e.Manage}")
				};

				manage.Show();
				Close();
			}
			finally
			{
				UseWaitCursor = false;
			}
		}

		private void Logout(object sender, EventArgs e)
		{
			Utils.Logout(this);
			Close();
		}

		private void ViewSettings(object sender, EventArgs e)
		{
			SettingsForm settings = new();
			settings.Show();
		}
	}
}
