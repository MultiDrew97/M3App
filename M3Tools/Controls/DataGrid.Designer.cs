namespace SPPBC.M3Tools.Data
{
	public partial class DataGrid<T> : System.Windows.Forms.DataGridView where T : Types.IDbEntry
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.chk_SelectAll = new System.Windows.Forms.CheckBox();
            this.dgc_Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgc_Edit = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
            this.dgc_Remove = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();
            this.cms_Tools = new SPPBC.M3Tools.ToolsContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_SelectAll
            // 
            this.chk_SelectAll.AutoSize = true;
            this.chk_SelectAll.Location = new System.Drawing.Point(46, 3);
            this.chk_SelectAll.Name = "chk_SelectAll";
            this.chk_SelectAll.Size = new System.Drawing.Size(15, 14);
            this.chk_SelectAll.TabIndex = 3;
            this.chk_SelectAll.TabStop = false;
            this.chk_SelectAll.UseVisualStyleBackColor = true;
            this.chk_SelectAll.CheckedChanged += new System.EventHandler(this.SelectAll);
            // 
            // dgc_Selection
            // 
            this.dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgc_Selection.Frozen = true;
            this.dgc_Selection.HeaderText = "";
            this.dgc_Selection.MinimumWidth = 25;
            this.dgc_Selection.Name = "dgc_Selection";
            this.dgc_Selection.ReadOnly = true;
            this.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgc_Selection.Width = 25;
            // 
            // dgc_Edit
            // 
            this.dgc_Edit.ButtonImage = null;
            this.dgc_Edit.FillWeight = 5F;
            this.dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgc_Edit.HeaderText = "";
            this.dgc_Edit.MinimumWidth = 25;
            this.dgc_Edit.Name = "dgc_Edit";
            this.dgc_Edit.ReadOnly = true;
            this.dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgc_Edit.ToolTipText = "Edit";
            this.dgc_Edit.Width = 25;
            // 
            // dgc_Remove
            // 
            this.dgc_Remove.ButtonImage = null;
            this.dgc_Remove.FillWeight = 5F;
            this.dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgc_Remove.HeaderText = "";
            this.dgc_Remove.MinimumWidth = 25;
            this.dgc_Remove.Name = "dgc_Remove";
            this.dgc_Remove.ReadOnly = true;
            this.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgc_Remove.ToolTipText = "Remove";
            this.dgc_Remove.Width = 25;
            // 
            // cms_Tools
            // 
            this.cms_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cms_Tools.Name = "cms_Tools";
            this.cms_Tools.Size = new System.Drawing.Size(133, 70);
			this.cms_Tools.EditSelected += EditSelected;
			this.cms_Tools.RemoveRows += RemoveSelectedRows;
            // 
            // DataGrid
            // 
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_Selection,
            this.dgc_Edit,
            this.dgc_Remove});
            this.Controls.Add(this.chk_SelectAll);
            this.RowTemplate.Height = 28;
            this.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            this.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteEntry);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		internal System.Windows.Forms.CheckBox chk_SelectAll;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Selection;
		protected DataGridViewImageButtonEditColumn dgc_Edit;
		protected DataGridViewImageButtonDeleteColumn dgc_Remove;
		internal ToolsContextMenu cms_Tools;

		#endregion

	}
}
