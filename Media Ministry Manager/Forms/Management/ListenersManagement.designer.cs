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
            this.components = new System.ComponentModel.Container();
            this.mms_Main = new SPPBC.M3Tools.MainMenuStrip();
            this.bsListeners = new SPPBC.M3Tools.Data.ListenerBindingSource();
            this.gt_Email = new SPPBC.M3Tools.GTools.GmailTool(this.components);
            this.dbListeners = new SPPBC.M3Tools.Database.ListenerDatabase(this.components);
            this.gd_Drive = new SPPBC.M3Tools.GTools.GdriveTool(this.components);
            this.ss_StatusView = new System.Windows.Forms.StatusStrip();
            this.tss_StatusView = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ldg_Listeners = new SPPBC.M3Tools.ListenersDataGrid();
            this.ts_Tools = new SPPBC.M3Tools.ToolsToolStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).BeginInit();
            this.ss_StatusView.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // mms_Main
            // 
            this.mms_Main.Location = new System.Drawing.Point(0, 0);
            this.mms_Main.Name = "mms_Main";
            this.mms_Main.Size = new System.Drawing.Size(784, 24);
            this.mms_Main.TabIndex = 0;
            this.mms_Main.Text = "mms_Main";
            // 
            // bsListeners
            // 
            this.bsListeners.Filter = "";
            // 
            // gt_Email
            // 
            this.gt_Email.Username = global::M3App.My.Settings.Default.Username;
            // 
            // dbListeners
            // 
            this.dbListeners.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
			this.dbListeners.Username = global::M3App.My.Settings.Default.ApiUsername;
			this.dbListeners.Password = global::M3App.My.Settings.Default.ApiPassword;
            // 
            // gd_Drive
            // 
            this.gd_Drive.Username = global::M3App.My.Settings.Default.Username;
            // 
            // ss_StatusView
            // 
            this.ss_StatusView.BackColor = System.Drawing.SystemColors.Control;
            this.ss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss_StatusView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_StatusView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_StatusView});
            this.ss_StatusView.Location = new System.Drawing.Point(0, 439);
            this.ss_StatusView.Name = "ss_StatusView";
            this.ss_StatusView.Size = new System.Drawing.Size(784, 22);
            this.ss_StatusView.TabIndex = 4;
            // 
            // tss_StatusView
            // 
            this.tss_StatusView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_StatusView.Name = "tss_StatusView";
            this.tss_StatusView.Size = new System.Drawing.Size(158, 17);
            this.tss_StatusView.Text = "Here are the current listeners";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ldg_Listeners);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 390);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 415);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ts_Tools);
            // 
            // ldg_Listeners
            // 
            this.ldg_Listeners.AllowUserToAddRows = false;
            this.ldg_Listeners.AllowUserToOrderColumns = true;
            this.ldg_Listeners.AutoGenerateColumns = false;
            this.ldg_Listeners.CanReorder = true;
            this.ldg_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldg_Listeners.DataSource = this.bsListeners;
            this.ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldg_Listeners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ldg_Listeners.Location = new System.Drawing.Point(0, 0);
            this.ldg_Listeners.Name = "ldg_Listeners";
            this.ldg_Listeners.RowTemplate.Height = 28;
            this.ldg_Listeners.Size = new System.Drawing.Size(784, 390);
            this.ldg_Listeners.TabIndex = 0;
			this.ldg_Listeners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // ts_Tools
            // 
            this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Tools.ListType = null;
            this.ts_Tools.Location = new System.Drawing.Point(0, 0);
            this.ts_Tools.Name = "ts_Tools";
            this.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_Tools.Size = new System.Drawing.Size(784, 25);
            this.ts_Tools.Stretch = true;
            this.ts_Tools.TabIndex = 0;
            // 
            // ListenersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.ss_StatusView);
            this.Controls.Add(this.mms_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::M3App.My.Resources.Resources.App_Icon;
            this.MainMenuStrip = this.mms_Main;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ListenersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ministry Manager";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DisplayClosing);
            this.Load += new System.EventHandler(this.Reload);
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).EndInit();
            this.ss_StatusView.ResumeLayout(false);
            this.ss_StatusView.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal SPPBC.M3Tools.MainMenuStrip mms_Main;
        internal SPPBC.M3Tools.GTools.GmailTool gt_Email;
        internal SPPBC.M3Tools.Data.ListenerBindingSource bsListeners;
        internal SPPBC.M3Tools.Database.ListenerDatabase dbListeners;
        internal SPPBC.M3Tools.GTools.GdriveTool gd_Drive;
        internal StatusStrip ss_StatusView;
        internal ToolStripStatusLabel tss_StatusView;
		private ToolStripContainer toolStripContainer1;
		private SPPBC.M3Tools.ListenersDataGrid ldg_Listeners;
		private SPPBC.M3Tools.ToolsToolStrip ts_Tools;
	}
}
