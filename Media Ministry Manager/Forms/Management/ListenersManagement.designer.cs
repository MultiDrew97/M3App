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
    public partial class ListenerManagement : ManagementForm<SPPBC.M3Tools.Types.Listener>
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
            this.bsListeners = new SPPBC.M3Tools.Data.ListenerBindingSource();
            this.gt_Email = new SPPBC.M3Tools.GTools.GmailTool(this.components);
            this.dbListeners = new SPPBC.M3Tools.Database.ListenerDatabase(this.components);
            this.gd_Drive = new SPPBC.M3Tools.GTools.GdriveTool(this.components);
            this.ldg_Listeners = new SPPBC.M3Tools.Data.ListenersDataGrid();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = true;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ldg_Listeners);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(775, 345);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.TopToolStripPanelVisible = true;
            // 
            // bsListeners
            // 
            this.bsListeners.Filter = "";
            // 
            // gt_Email
            // 
            this.gt_Email.Username = global::M3App.Properties.Settings.Default.Username;
            // 
            // dbListeners
            // 
            this.dbListeners.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbListeners.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbListeners.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // gd_Drive
            // 
            this.gd_Drive.Username = global::M3App.Properties.Settings.Default.Username;
            // 
            // ldg_Listeners
            // 
            this.ldg_Listeners.AllowUserToAddRows = false;
            this.ldg_Listeners.AllowUserToOrderColumns = true;
            this.ldg_Listeners.CanReorder = true;
            this.ldg_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldg_Listeners.DataSource = this.bsListeners;
            this.ldg_Listeners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldg_Listeners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ldg_Listeners.Location = new System.Drawing.Point(0, 0);
            this.ldg_Listeners.Name = "ldg_Listeners";
            this.ldg_Listeners.ReadOnly = true;
            this.ldg_Listeners.RowsCheckable = false;
            this.ldg_Listeners.RowTemplate.Height = 28;
            this.ldg_Listeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ldg_Listeners.Size = new System.Drawing.Size(775, 345);
            this.ldg_Listeners.TabIndex = 0;
            // 
            // ListenerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Name = "ListenerManagement";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SPPBC.M3Tools.GTools.GmailTool gt_Email;
        private SPPBC.M3Tools.Data.ListenerBindingSource bsListeners;
        private SPPBC.M3Tools.Database.ListenerDatabase dbListeners;
        private SPPBC.M3Tools.GTools.GdriveTool gd_Drive;
		private SPPBC.M3Tools.Data.ListenersDataGrid ldg_Listeners;
	}
}
