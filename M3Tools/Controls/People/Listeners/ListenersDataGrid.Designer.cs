using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ListenersDataGrid : System.Windows.Forms.UserControl
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
            chk_SelectAll = new System.Windows.Forms.CheckBox();
            chk_SelectAll.CheckedChanged += new EventHandler(SelectAllListeners);
            bsListeners = new System.Windows.Forms.BindingSource(components);
            cms_Tools = new ToolsContextMenu();
            cms_Tools.RemoveRows += new ToolsContextMenu.RemoveRowsEventHandler(RemoveSelectedListeners);
            cms_Tools.Opened += new EventHandler(ToolsOpened);
            cms_Tools.EditSelected += new ToolsContextMenu.EditSelectedEventHandler(EditPerson);
            cms_Tools.RefreshView += new ToolsContextMenu.RefreshViewEventHandler(RefreshView);
            dgc_Remove = new DataGridViewImageButtonDeleteColumn();
            dgc_Edit = new DataGridViewImageButtonEditColumn();
            dgcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgc_Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dgc_ListenerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgv_Listeners = new System.Windows.Forms.DataGridView();
            dgv_Listeners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(CellClicked);
            dgv_Listeners.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(DeleteListener);
            ((System.ComponentModel.ISupportInitialize)bsListeners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Listeners).BeginInit();
            SuspendLayout();
            // 
            // chk_SelectAll
            // 
            chk_SelectAll.AutoSize = true;
            chk_SelectAll.Location = new System.Drawing.Point(46, 3);
            chk_SelectAll.Name = "chk_SelectAll";
            chk_SelectAll.Size = new System.Drawing.Size(15, 14);
            chk_SelectAll.TabIndex = 2;
            chk_SelectAll.TabStop = false;
            chk_SelectAll.UseVisualStyleBackColor = true;
            // 
            // cms_Tools
            // 
            cms_Tools.Name = "cms_Tools";
            cms_Tools.Size = new System.Drawing.Size(133, 70);
            // 
            // dgc_Remove
            // 
            dgc_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgc_Remove.ButtonImage = null;
            dgc_Remove.FillWeight = 5.0f;
            dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgc_Remove.HeaderText = "";
            dgc_Remove.MinimumWidth = 25;
            dgc_Remove.Name = "dgc_Remove";
            dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Remove.Width = 25;
            // 
            // dgc_Edit
            // 
            dgc_Edit.ButtonImage = null;
            dgc_Edit.FillWeight = 5.0f;
            dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgc_Edit.HeaderText = "";
            dgc_Edit.MinimumWidth = 25;
            dgc_Edit.Name = "dgc_Edit";
            dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Edit.Width = 25;
            // 
            // dgcEmail
            // 
            dgcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgcEmail.DataPropertyName = "Email";
            dgcEmail.FillWeight = 50.0f;
            dgcEmail.HeaderText = "Email";
            dgcEmail.Name = "dgcEmail";
            // 
            // dgcName
            // 
            dgcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgcName.DataPropertyName = "Name";
            dgcName.FillWeight = 50.0f;
            dgcName.HeaderText = "Name";
            dgcName.Name = "dgcName";
            // 
            // dgc_Selection
            // 
            dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgc_Selection.Frozen = true;
            dgc_Selection.HeaderText = "";
            dgc_Selection.MinimumWidth = 25;
            dgc_Selection.Name = "dgc_Selection";
            dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgc_Selection.Width = 25;
            // 
            // dgc_ListenerID
            // 
            dgc_ListenerID.DataPropertyName = "ListenerID";
            dgc_ListenerID.FillWeight = 5.0f;
            dgc_ListenerID.Frozen = true;
            dgc_ListenerID.HeaderText = "ListenerID";
            dgc_ListenerID.Name = "dgc_ListenerID";
            dgc_ListenerID.ReadOnly = true;
            dgc_ListenerID.Visible = false;
            // 
            // dgv_Listeners
            // 
            dgv_Listeners.AllowUserToAddRows = false;
            dgv_Listeners.AllowUserToOrderColumns = true;
            dgv_Listeners.AutoGenerateColumns = false;
            dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Listeners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_ListenerID, dgc_Selection, dgcName, dgcEmail, dgc_Edit, dgc_Remove });
            dgv_Listeners.DataSource = bsListeners;
            dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Listeners.Location = new System.Drawing.Point(0, 0);
            dgv_Listeners.Name = "dgv_Listeners";
            dgv_Listeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_Listeners.Size = new System.Drawing.Size(450, 300);
            dgv_Listeners.TabIndex = 1;
            // 
            // ListenersDataGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ContextMenuStrip = cms_Tools;
            Controls.Add(chk_SelectAll);
            Controls.Add(dgv_Listeners);
            MinimumSize = new System.Drawing.Size(450, 300);
            Name = "ListenersDataGrid";
            Size = new System.Drawing.Size(450, 300);
            ((System.ComponentModel.ISupportInitialize)bsListeners).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Listeners).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.CheckBox chk_SelectAll;
        internal System.Windows.Forms.BindingSource bsListeners;
        internal ToolsContextMenu cms_Tools;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_Email;
        internal DataGridViewImageButtonDeleteColumn dgc_Remove;
        internal DataGridViewImageButtonEditColumn dgc_Edit;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgcEmail;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Selection;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_ListenerID;
        internal System.Windows.Forms.DataGridView dgv_Listeners;
    }
}