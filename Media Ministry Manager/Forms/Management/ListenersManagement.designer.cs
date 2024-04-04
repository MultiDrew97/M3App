using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;
using SPPBC.M3Tools.Events.Listeners;
using SPPBC.M3Tools.Types;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ListenersManagement : Form
    {

        // Form overrides dispose to clean up the component list.
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
            components = new System.ComponentModel.Container();
            mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            mms_Main.Logout += Logout;
            mms_Main.ExitApplication += ExitApplication;
            mms_Main.UpdateAvailable += ExitApplication;
            mms_Main.ManageCustomers += ManageCustomers;
            mms_Main.ManageOrders += ManageOrders;
            mms_Main.ManageProducts += ManageProducts;
            mms_Main.ViewSettings += ViewSettings;
            mms_Main.AddListener += AddListener;
            dlc_Listeners = new SPPBC.M3Tools.DisplayListenersCtrl();
            dlc_Listeners.SendEmails += SendEmails;
            dlc_Listeners.RemoveListener += RemoveListener;
            dlc_Listeners.AddListener += AddListener;
            dlc_Listeners.UpdateListener += UpdateListener;
            bsListeners = new BindingSource(components);
            gt_Email = new SPPBC.M3Tools.GTools.GmailTool(components);
            dbListeners = new ListenerDatabase(components);
            gd_Drive = new SPPBC.M3Tools.GTools.GdriveTool(components);
            ss_StatusView = new StatusStrip();
            tss_StatusView = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)bsListeners).BeginInit();
            ss_StatusView.SuspendLayout();
            SuspendLayout();
            // 
            // mms_Main
            // 
            mms_Main.Location = new Point(0, 0);
            mms_Main.Name = "mms_Main";
            mms_Main.Size = new Size(784, 24);
            mms_Main.TabIndex = 0;
            mms_Main.Text = "MainMenuStrip1";
            // 
            // dlc_Listeners
            // 
            dlc_Listeners.CountTemplate = "Count: {0}";
            dlc_Listeners.DataSource = bsListeners;
            dlc_Listeners.Dock = DockStyle.Fill;
            dlc_Listeners.Location = new Point(0, 24);
            dlc_Listeners.Name = "dlc_Listeners";
            dlc_Listeners.Size = new Size(784, 437);
            dlc_Listeners.TabIndex = 1;
            // 
            // bsListeners
            // 
            bsListeners.DataSource = typeof(ListenerCollection);
            bsListeners.Filter = "";
            // 
            // gt_Email
            // 
            gt_Email.Username = global::M3App.My.Settings.Default.Username;
            // 
            // dbListeners
            // 
            dbListeners.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbListeners.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbListeners.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // gd_Drive
            // 
            gd_Drive.Username = global::M3App.My.Settings.Default.Username;
            // 
            // ss_StatusView
            // 
            ss_StatusView.BackColor = SystemColors.Control;
            ss_StatusView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ss_StatusView.ImageScalingSize = new Size(32, 32);
            ss_StatusView.Items.AddRange(new ToolStripItem[] { tss_StatusView });
            ss_StatusView.Location = new Point(0, 439);
            ss_StatusView.Name = "ss_StatusView";
            ss_StatusView.Size = new Size(784, 22);
            ss_StatusView.TabIndex = 4;
            // 
            // tss_StatusView
            // 
            tss_StatusView.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tss_StatusView.Name = "tss_StatusView";
            tss_StatusView.Size = new Size(158, 17);
            tss_StatusView.Text = "Here are the current listeners";
            // 
            // ListenersManagement
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ss_StatusView);
            Controls.Add(dlc_Listeners);
            Controls.Add(mms_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = My.Resources.Resources.App_Icon;
            MainMenuStrip = mms_Main;
            MaximizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "ListenersManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ((System.ComponentModel.ISupportInitialize)bsListeners).EndInit();
            ss_StatusView.ResumeLayout(false);
            ss_StatusView.PerformLayout();
            Load += new EventHandler(Reload);
            Closing += new System.ComponentModel.CancelEventHandler(ClosingForm);
            ListenerAdded += new ListenerEventHandler(SendWelcom);
            ListenerDBModified += new ListenerEventHandler(Reload);
            ResumeLayout(false);
            PerformLayout();

        }

        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal SPPBC.M3Tools.DisplayListenersCtrl dlc_Listeners;
        internal SPPBC.M3Tools.GTools.GmailTool gt_Email;
        internal BindingSource bsListeners;
        internal SPPBC.M3Tools.Database.ListenerDatabase dbListeners;
        internal SPPBC.M3Tools.GTools.GdriveTool gd_Drive;
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_StatusView;
    }
}
