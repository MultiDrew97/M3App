using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainMenuStrip : System.Windows.Forms.MenuStrip
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuStrip));
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewListeners = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_View = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ViewOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ViewProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ViewListeners = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.bw_Update = new System.ComponentModel.BackgroundWorker();
            this.wb_Updater = new System.Windows.Forms.WebBrowser();
            this.lsd_Loading = new SPPBC.M3Tools.LoadScreenDialog();
            this.tsmi_NewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // tsmi_File
            // 
            this.tsmi_File.AccessibleDescription = "File Menu Item";
            this.tsmi_File.AccessibleName = "File";
            this.tsmi_File.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_New,
            this.tsmi_Settings,
            this.toolStripSeparator1,
            this.tsmi_Logout,
            this.tsmi_Exit});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(37, 20);
            this.tsmi_File.Text = "&File";
            // 
            // tsmi_New
            // 
            this.tsmi_New.AccessibleName = "New";
            this.tsmi_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NewCustomer,
            this.tsmi_NewProduct,
            this.tsmi_NewListeners,
            this.tsmi_NewOrder});
            this.tsmi_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_New.Image")));
            this.tsmi_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_New.Name = "tsmi_New";
            this.tsmi_New.Size = new System.Drawing.Size(116, 22);
            this.tsmi_New.Text = "&New...";
            // 
            // tsmi_NewCustomer
            // 
            this.tsmi_NewCustomer.Name = "tsmi_NewCustomer";
            this.tsmi_NewCustomer.Size = new System.Drawing.Size(126, 22);
            this.tsmi_NewCustomer.Text = "Customer";
            this.tsmi_NewCustomer.Click += new System.EventHandler(this.CreateCustomer);
            // 
            // tsmi_NewProduct
            // 
            this.tsmi_NewProduct.Name = "tsmi_NewProduct";
            this.tsmi_NewProduct.Size = new System.Drawing.Size(126, 22);
            this.tsmi_NewProduct.Text = "Product";
            this.tsmi_NewProduct.Click += new System.EventHandler(this.CreateProduct);
            // 
            // tsmi_NewListeners
            // 
            this.tsmi_NewListeners.Name = "tsmi_NewListeners";
            this.tsmi_NewListeners.Size = new System.Drawing.Size(126, 22);
            this.tsmi_NewListeners.Text = "Listener";
            this.tsmi_NewListeners.Click += new System.EventHandler(this.CreateListener);
            // 
            // tsmi_Settings
            // 
            this.tsmi_Settings.AccessibleName = "Settings";
            this.tsmi_Settings.Name = "tsmi_Settings";
            this.tsmi_Settings.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Settings.Text = "Settings";
            this.tsmi_Settings.Click += new System.EventHandler(this.ShowSettings);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleName = "Separator";
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmi_Logout
            // 
            this.tsmi_Logout.AccessibleName = "Logout";
            this.tsmi_Logout.Image = global::SPPBC.M3Tools.My.Resources.Resources.Logout;
            this.tsmi_Logout.Name = "tsmi_Logout";
            this.tsmi_Logout.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Logout.Text = "&Logout";
            this.tsmi_Logout.Click += new System.EventHandler(this.LogoutApplication);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.AccessibleName = "Exit";
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Exit.Text = "E&xit";
            this.tsmi_Exit.Click += new System.EventHandler(this.Exit);
            // 
            // tsmi_View
            // 
            this.tsmi_View.AccessibleDescription = "View Menu Item";
            this.tsmi_View.AccessibleName = "View";
            this.tsmi_View.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.tsmi_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ViewCustomers,
            this.tsmi_ViewOrders,
            this.tsmi_ViewProducts,
            this.tsmi_ViewListeners});
            this.tsmi_View.Name = "tsmi_View";
            this.tsmi_View.Size = new System.Drawing.Size(44, 20);
            this.tsmi_View.Text = "&View";
            // 
            // tsmi_ViewCustomers
            // 
            this.tsmi_ViewCustomers.AccessibleDescription = "Display all customers";
            this.tsmi_ViewCustomers.AccessibleName = "Customers";
            this.tsmi_ViewCustomers.Name = "tsmi_ViewCustomers";
            this.tsmi_ViewCustomers.Size = new System.Drawing.Size(131, 22);
            this.tsmi_ViewCustomers.Text = "Customers";
            this.tsmi_ViewCustomers.Click += new System.EventHandler(this.ChangeView);
            // 
            // tsmi_ViewOrders
            // 
            this.tsmi_ViewOrders.AccessibleDescription = "View all in progress and completed orders";
            this.tsmi_ViewOrders.AccessibleName = "Orders";
            this.tsmi_ViewOrders.Name = "tsmi_ViewOrders";
            this.tsmi_ViewOrders.Size = new System.Drawing.Size(131, 22);
            this.tsmi_ViewOrders.Text = "Orders";
            this.tsmi_ViewOrders.Click += new System.EventHandler(this.ChangeView);
            // 
            // tsmi_ViewProducts
            // 
            this.tsmi_ViewProducts.AccessibleDescription = "View all inventory";
            this.tsmi_ViewProducts.AccessibleName = "Products";
            this.tsmi_ViewProducts.Name = "tsmi_ViewProducts";
            this.tsmi_ViewProducts.Size = new System.Drawing.Size(131, 22);
            this.tsmi_ViewProducts.Text = "Products";
            this.tsmi_ViewProducts.Click += new System.EventHandler(this.ChangeView);
            // 
            // tsmi_ViewListeners
            // 
            this.tsmi_ViewListeners.AccessibleDescription = "Manage email ministry listeners";
            this.tsmi_ViewListeners.AccessibleName = "Listeners";
            this.tsmi_ViewListeners.Name = "tsmi_ViewListeners";
            this.tsmi_ViewListeners.Size = new System.Drawing.Size(131, 22);
            this.tsmi_ViewListeners.Text = "Listeners";
            this.tsmi_ViewListeners.Click += new System.EventHandler(this.ChangeView);
            // 
            // tsmi_Tools
            // 
            this.tsmi_Tools.AccessibleDescription = "Tools Menu Item";
            this.tsmi_Tools.AccessibleName = "Tools";
            this.tsmi_Tools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.tsmi_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Update});
            this.tsmi_Tools.Name = "tsmi_Tools";
            this.tsmi_Tools.Size = new System.Drawing.Size(46, 20);
            this.tsmi_Tools.Text = "&Tools";
            // 
            // tsmi_Update
            // 
            this.tsmi_Update.AccessibleDescription = "Check for updates";
            this.tsmi_Update.AccessibleName = "Update";
            this.tsmi_Update.Name = "tsmi_Update";
            this.tsmi_Update.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Update.Text = "Check for Update";
            this.tsmi_Update.Click += new System.EventHandler(this.UpdateApp);
            // 
            // bw_Update
            // 
            this.bw_Update.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateAppBW);
            // 
            // wb_Updater
            // 
            this.wb_Updater.Location = new System.Drawing.Point(0, 0);
            this.wb_Updater.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Updater.Name = "wb_Updater";
            this.wb_Updater.ScrollBarsEnabled = false;
            this.wb_Updater.Size = new System.Drawing.Size(250, 250);
            this.wb_Updater.TabIndex = 0;
            this.wb_Updater.Visible = false;
            // 
            // lsd_Loading
            // 
            this.lsd_Loading.Image = ((System.Drawing.Bitmap)(resources.GetObject("lsd_Loading.Image")));
            this.lsd_Loading.LoadText = "";
            this.lsd_Loading.TopMost = true;
            // 
            // tsmi_NewOrder
            // 
            this.tsmi_NewOrder.Name = "tsmi_NewOrder";
            this.tsmi_NewOrder.Size = new System.Drawing.Size(126, 22);
            this.tsmi_NewOrder.Text = "Order";
			this.tsmi_NewOrder.Click += new System.EventHandler(this.CreateOrder);
            // 
            // MainMenuStrip
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_View,
            this.tsmi_Tools});
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.ToolStripMenuItem tsmi_File;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_New;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_NewCustomer;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_NewProduct;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_NewListeners;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_Settings;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_Logout;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_View;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_ViewCustomers;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_ViewOrders;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_ViewProducts;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_ViewListeners;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_Tools;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_Update;
        internal System.ComponentModel.BackgroundWorker bw_Update;
        internal System.Windows.Forms.WebBrowser wb_Updater;
        internal LoadScreenDialog lsd_Loading;
		internal System.Windows.Forms.ToolStripMenuItem tsmi_NewOrder;
	}
}
