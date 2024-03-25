using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DisplayListenersCtrl : System.Windows.Forms.UserControl
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
            components = new System.ComponentModel.Container();
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ldg_Listeners = new ListenersDataGrid();
            ldg_Listeners.RefreshDisplay += new ListenersDataGrid.RefreshDisplayEventHandler(Reload);
            ldg_Listeners.RemoveListener += new Events.Listeners.ListenerEventHandler(DeleteListener);
            ldg_Listeners.EditListener += new Events.Listeners.ListenerEventHandler(EditListener);
            ts_Tools = new System.Windows.Forms.ToolStrip();
            tbtn_AddListener = new System.Windows.Forms.ToolStripButton();
            tbtn_AddListener.Click += new EventHandler(NewListener);
            tbtn_Import = new System.Windows.Forms.ToolStripButton();
            tbtn_Import.Click += new EventHandler(ImportListeners);
            tbtn_Email = new System.Windows.Forms.ToolStripButton();
            tbtn_Email.Click += new EventHandler(OpenEmails);
            ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsl_Count = new System.Windows.Forms.ToolStripLabel();
            txt_Filter = new System.Windows.Forms.ToolStripTextBox();
            txt_Filter.TextChanged += new EventHandler(FilterUpdated);
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ts_Tools.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripContainer1
            // 
            ToolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(ldg_Listeners);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(517, 370);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.LeftToolStripPanelVisible = false;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.RightToolStripPanelVisible = false;
            ToolStripContainer1.Size = new System.Drawing.Size(517, 395);
            ToolStripContainer1.TabIndex = 1;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_Tools);
            // 
            // ldg_Listeners
            // 
            ldg_Listeners.AllowColumnReordering = true;
            ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Fill;
            ldg_Listeners.Filter = null;
            ldg_Listeners.ListenersSelectable = false;
            ldg_Listeners.Location = new System.Drawing.Point(0, 0);
            ldg_Listeners.MinimumSize = new System.Drawing.Size(400, 200);
            ldg_Listeners.Name = "ldg_Listeners";
            ldg_Listeners.Size = new System.Drawing.Size(517, 370);
            ldg_Listeners.TabIndex = 1;
            // 
            // ts_Tools
            // 
            ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbtn_AddListener, tbtn_Import, tbtn_Email, ToolStripSeparator2, tsl_Count, txt_Filter });
            ts_Tools.Location = new System.Drawing.Point(3, 0);
            ts_Tools.Name = "ts_Tools";
            ts_Tools.Size = new System.Drawing.Size(298, 25);
            ts_Tools.TabIndex = 1;
            // 
            // tbtn_AddListener
            // 
            tbtn_AddListener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_AddListener.Image = My.Resources.Resources.NewDocumentOption;
            tbtn_AddListener.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_AddListener.Name = "tbtn_AddListener";
            tbtn_AddListener.Size = new System.Drawing.Size(23, 22);
            tbtn_AddListener.Text = "Add Listener";
            // 
            // tbtn_Import
            // 
            tbtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_Import.Image = My.Resources.Resources.import;
            tbtn_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_Import.Name = "tbtn_Import";
            tbtn_Import.Size = new System.Drawing.Size(23, 22);
            tbtn_Import.Text = "Import Listeners";
            // 
            // tbtn_Email
            // 
            tbtn_Email.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_Email.Image = My.Resources.Resources.send_email;
            tbtn_Email.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_Email.Name = "tbtn_Email";
            tbtn_Email.Size = new System.Drawing.Size(23, 22);
            tbtn_Email.Text = "Send Emails";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsl_Count
            // 
            tsl_Count.Name = "tsl_Count";
            tsl_Count.Size = new System.Drawing.Size(87, 22);
            tsl_Count.Text = "ToolStripLabel1";
            tsl_Count.ToolTipText = "Number of listeners currently subscribed";
            // 
            // txt_Filter
            // 
            txt_Filter.Font = new System.Drawing.Font("Segoe UI", 9.0f);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new System.Drawing.Size(100, 25);
            // 
            // DisplayListenersCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ToolStripContainer1);
            Name = "DisplayListenersCtrl";
            Size = new System.Drawing.Size(517, 395);
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ts_Tools.ResumeLayout(false);
            ts_Tools.PerformLayout();
            ResumeLayout(false);

        }
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.ToolStrip ts_Tools;
        internal System.Windows.Forms.ToolStripButton tbtn_AddListener;
        internal System.Windows.Forms.ToolStripTextBox txt_Filter;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tbtn_Import;
        internal System.Windows.Forms.ToolStripButton tbtn_Email;
        internal ListenersDataGrid ldg_Listeners;
        internal System.Windows.Forms.ToolStripLabel tsl_Count;
    }
}
