using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Database;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Frm_DisplayOrders : Form
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
            lbl_NoOrders = new Label();
            db_Orders = new OrdersDatabase(components);
            bsOrders = new BindingSource(components);
            mms_Strip = new SPPBC.M3Tools.MainMenuStrip();
            mms_Strip.Logout += Logout;
            mms_Strip.ExitApplication += ExitApplication;
            mms_Strip.UpdateAvailable += ExitApplication;
            mms_Strip.ViewSettings += ViewSettings;
            ((System.ComponentModel.ISupportInitialize)bsOrders).BeginInit();
            SuspendLayout();
            // 
            // lbl_NoOrders
            // 
            lbl_NoOrders.AutoSize = true;
            lbl_NoOrders.BackColor = SystemColors.AppWorkspace;
            lbl_NoOrders.DataBindings.Add(new Binding("Font", global::M3App.My.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_NoOrders.Font = global::M3App.My.Settings.Default.CurrentFont;
            lbl_NoOrders.Location = new Point(257, 322);
            lbl_NoOrders.Name = "lbl_NoOrders";
            lbl_NoOrders.Size = new Size(728, 48);
            lbl_NoOrders.TabIndex = 3;
            lbl_NoOrders.Text = "There are currently no orders placed";
            lbl_NoOrders.Visible = false;
            // 
            // db_Orders
            // 
            db_Orders.BaseUrl = "Media Ministry";
            db_Orders.Password = "M3AppPassword2499";
            db_Orders.Username = "M3App";
            // 
            // mms_Strip
            // 
            mms_Strip.ImageScalingSize = new Size(32, 32);
            mms_Strip.Location = new Point(0, 0);
            mms_Strip.Name = "mms_Strip";
            mms_Strip.Padding = new Padding(3, 1, 0, 1);
            mms_Strip.Size = new Size(1248, 38);
            mms_Strip.TabIndex = 6;
            mms_Strip.Text = "Menu";
            // 
            // Frm_DisplayOrders
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1248, 683);
            Controls.Add(lbl_NoOrders);
            Controls.Add(mms_Strip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mms_Strip;
            MaximizeBox = false;
            Name = "Frm_DisplayOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            ((System.ComponentModel.ISupportInitialize)bsOrders).EndInit();
            Load += new EventHandler(ViewLoading);
            Closed += new EventHandler(ViewClosed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal DataGridViewTextBoxColumn CustomerName;
        internal DataGridViewTextBoxColumn ItemName;
        internal DataGridViewTextBoxColumn Quantity;
        internal DataGridViewTextBoxColumn OrderTotal;
        internal Label lbl_NoOrders;
        internal SPPBC.M3Tools.Database.OrdersDatabase db_Orders;
        internal BindingSource bsOrders;
        internal SPPBC.M3Tools.MainMenuStrip mms_Strip;
    }
}
