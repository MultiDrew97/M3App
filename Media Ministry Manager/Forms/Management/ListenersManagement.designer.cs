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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageButtonEditColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn();
            this.dataGridViewImageButtonDeleteColumn1 = new SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn();
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
            this.ldg_Listeners.AutoGenerateColumns = false;
            this.ldg_Listeners.CanReorder = true;
            this.ldg_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldg_Listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageButtonEditColumn1,
            this.dataGridViewImageButtonDeleteColumn1});
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 25;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 5F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ListenerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageButtonEditColumn1
            // 
            this.dataGridViewImageButtonEditColumn1.ButtonImage = null;
            this.dataGridViewImageButtonEditColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonEditColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonEditColumn1.HeaderText = "";
            this.dataGridViewImageButtonEditColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonEditColumn1.Name = "dataGridViewImageButtonEditColumn1";
            this.dataGridViewImageButtonEditColumn1.ReadOnly = true;
            this.dataGridViewImageButtonEditColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonEditColumn1.ToolTipText = "Edit";
            this.dataGridViewImageButtonEditColumn1.Width = 25;
            // 
            // dataGridViewImageButtonDeleteColumn1
            // 
            this.dataGridViewImageButtonDeleteColumn1.ButtonImage = null;
            this.dataGridViewImageButtonDeleteColumn1.FillWeight = 5F;
            this.dataGridViewImageButtonDeleteColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewImageButtonDeleteColumn1.HeaderText = "";
            this.dataGridViewImageButtonDeleteColumn1.MinimumWidth = 25;
            this.dataGridViewImageButtonDeleteColumn1.Name = "dataGridViewImageButtonDeleteColumn1";
            this.dataGridViewImageButtonDeleteColumn1.ReadOnly = true;
            this.dataGridViewImageButtonDeleteColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageButtonDeleteColumn1.ToolTipText = "Remove";
            this.dataGridViewImageButtonDeleteColumn1.Width = 25;
            // 
            // ListenerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Icon = global::M3App.Properties.Resources.App_Icon;
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
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonEditColumn dataGridViewImageButtonEditColumn1;
		private SPPBC.M3Tools.Data.DataGridViewImageButtonDeleteColumn dataGridViewImageButtonDeleteColumn1;
	}
}
