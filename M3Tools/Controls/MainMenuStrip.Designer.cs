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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuStrip));
            tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_New = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_NewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_NewCustomer.Click += new EventHandler(CreateCustomer);
            tsmi_NewProduct = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_NewProduct.Click += new EventHandler(CreateProduct);
            tsmi_NewListeners = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_NewListeners.Click += new EventHandler(CreateListener);
            tsmi_Settings = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_Settings.Click += new EventHandler(ShowSettings);
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsmi_Logout = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_Logout.Click += new EventHandler(LogoutApplication);
            tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_Exit.Click += new EventHandler(Exit);
            tsmi_View = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_ViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_ViewCustomers.Click += new EventHandler(ViewCustomers);
            tsmi_ViewOrders = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_ViewOrders.Click += new EventHandler(ViewOrders);
            tsmi_ViewProducts = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_ViewProducts.Click += new EventHandler(ViewProducts);
            tsmi_ViewListeners = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_ViewListeners.Click += new EventHandler(ViewListeners);
            tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_Update = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_Update.Click += new EventHandler(UpdateApp);
            bw_Update = new System.ComponentModel.BackgroundWorker();
            bw_Update.DoWork += new System.ComponentModel.DoWorkEventHandler(UpdateAppBW);
            wb_Updater = new System.Windows.Forms.WebBrowser();
            lsd_Loading = new LoadScreenDialog();
            SuspendLayout();
            // 
            // tsmi_File
            // 
            tsmi_File.AccessibleDescription = "File Menu Item";
            tsmi_File.AccessibleName = "File";
            tsmi_File.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_New, tsmi_Settings, toolStripSeparator1, tsmi_Logout, tsmi_Exit });
            tsmi_File.Name = "tsmi_File";
            tsmi_File.Size = new System.Drawing.Size(37, 20);
            tsmi_File.Text = "&File";
            // 
            // tsmi_New
            // 
            tsmi_New.AccessibleName = "New";
            tsmi_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_NewCustomer, tsmi_NewProduct, tsmi_NewListeners });
            tsmi_New.Image = (System.Drawing.Image)resources.GetObject("tsmi_New.Image");
            tsmi_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsmi_New.Name = "tsmi_New";
            tsmi_New.Size = new System.Drawing.Size(132, 38);
            tsmi_New.Text = "&New...";
            // 
            // tsmi_NewCustomer
            // 
            tsmi_NewCustomer.Name = "tsmi_NewCustomer";
            tsmi_NewCustomer.Size = new System.Drawing.Size(126, 22);
            tsmi_NewCustomer.Text = "Customer";
            // 
            // tsmi_NewProduct
            // 
            tsmi_NewProduct.Name = "tsmi_NewProduct";
            tsmi_NewProduct.Size = new System.Drawing.Size(126, 22);
            tsmi_NewProduct.Text = "Product";
            // 
            // tsmi_NewListeners
            // 
            tsmi_NewListeners.Name = "tsmi_NewListeners";
            tsmi_NewListeners.Size = new System.Drawing.Size(126, 22);
            tsmi_NewListeners.Text = "Listener";
            // 
            // tsmi_Settings
            // 
            tsmi_Settings.AccessibleName = "Settings";
            tsmi_Settings.Name = "tsmi_Settings";
            tsmi_Settings.Size = new System.Drawing.Size(132, 38);
            tsmi_Settings.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AccessibleName = "Separator";
            toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // tsmi_Logout
            // 
            tsmi_Logout.AccessibleName = "Logout";
            tsmi_Logout.Image = My.Resources.Resources.Logout;
            tsmi_Logout.Name = "tsmi_Logout";
            tsmi_Logout.Size = new System.Drawing.Size(132, 38);
            tsmi_Logout.Text = "&Logout";
            // 
            // tsmi_Exit
            // 
            tsmi_Exit.AccessibleName = "Exit";
            tsmi_Exit.Name = "tsmi_Exit";
            tsmi_Exit.Size = new System.Drawing.Size(132, 38);
            tsmi_Exit.Text = "E&xit";
            // 
            // tsmi_View
            // 
            tsmi_View.AccessibleDescription = "View Menu Item";
            tsmi_View.AccessibleName = "View";
            tsmi_View.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            tsmi_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_ViewCustomers, tsmi_ViewOrders, tsmi_ViewProducts, tsmi_ViewListeners });
            tsmi_View.Name = "tsmi_View";
            tsmi_View.Size = new System.Drawing.Size(44, 20);
            tsmi_View.Text = "&View";
            // 
            // tsmi_ViewCustomers
            // 
            tsmi_ViewCustomers.AccessibleDescription = "Display all customers";
            tsmi_ViewCustomers.AccessibleName = "Customers";
            tsmi_ViewCustomers.Name = "tsmi_ViewCustomers";
            tsmi_ViewCustomers.Size = new System.Drawing.Size(131, 22);
            tsmi_ViewCustomers.Text = "Customers";
            // 
            // tsmi_ViewOrders
            // 
            tsmi_ViewOrders.AccessibleDescription = "View all in progress and completed orders";
            tsmi_ViewOrders.AccessibleName = "Orders";
            tsmi_ViewOrders.Name = "tsmi_ViewOrders";
            tsmi_ViewOrders.Size = new System.Drawing.Size(131, 22);
            tsmi_ViewOrders.Text = "Orders";
            // 
            // tsmi_ViewProducts
            // 
            tsmi_ViewProducts.AccessibleDescription = "View all inventory";
            tsmi_ViewProducts.AccessibleName = "Products";
            tsmi_ViewProducts.Name = "tsmi_ViewProducts";
            tsmi_ViewProducts.Size = new System.Drawing.Size(131, 22);
            tsmi_ViewProducts.Text = "Products";
            // 
            // tsmi_ViewListeners
            // 
            tsmi_ViewListeners.AccessibleDescription = "Manage email ministry listeners";
            tsmi_ViewListeners.AccessibleName = "Listeners";
            tsmi_ViewListeners.Name = "tsmi_ViewListeners";
            tsmi_ViewListeners.Size = new System.Drawing.Size(131, 22);
            tsmi_ViewListeners.Text = "Listeners";
            // 
            // tsmi_Tools
            // 
            tsmi_Tools.AccessibleDescription = "Tools Menu Item";
            tsmi_Tools.AccessibleName = "Tools";
            tsmi_Tools.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            tsmi_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_Update });
            tsmi_Tools.Name = "tsmi_Tools";
            tsmi_Tools.Size = new System.Drawing.Size(46, 20);
            tsmi_Tools.Text = "&Tools";
            // 
            // tsmi_Update
            // 
            tsmi_Update.AccessibleDescription = "Check for updates";
            tsmi_Update.AccessibleName = "Update";
            tsmi_Update.Name = "tsmi_Update";
            tsmi_Update.Size = new System.Drawing.Size(166, 22);
            tsmi_Update.Text = "Check for Update";
            // 
            // bw_Update
            // 
            // 
            // wb_Updater
            // 
            wb_Updater.Location = new System.Drawing.Point(0, 0);
            wb_Updater.MinimumSize = new System.Drawing.Size(20, 20);
            wb_Updater.Name = "wb_Updater";
            wb_Updater.ScrollBarsEnabled = false;
            wb_Updater.Size = new System.Drawing.Size(250, 250);
            wb_Updater.TabIndex = 0;
            wb_Updater.Visible = false;
            // 
            // lsd_Loading
            // 
            lsd_Loading.Image = (System.Drawing.Bitmap)resources.GetObject("lsd_Loading.Image");
            lsd_Loading.LoadText = "";
            // 
            // MainMenuStrip
            // 
            ImageScalingSize = new System.Drawing.Size(16, 16);
            Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_File, tsmi_View, tsmi_Tools });
            ResumeLayout(false);

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
    }
}