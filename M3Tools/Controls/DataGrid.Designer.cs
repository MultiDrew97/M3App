namespace SPPBC.M3Tools.Data
{
	public partial class DataGrid<T> : System.Windows.Forms.DataGridView
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
            this.chk_SelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // cms_Tools
            // 
            this.cms_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cms_Tools.Name = "cms_Tools";
            this.cms_Tools.Size = new System.Drawing.Size(133, 70);
            // 
            // DataGrid
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToOrderColumns = true;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContextMenuStrip = this.cms_Tools;
            this.Controls.Add(this.chk_SelectAll);
            this.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ReadOnly = true;
            this.RowTemplate.Height = 28;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal ToolsContextMenu cms_Tools;
		internal System.Windows.Forms.CheckBox chk_SelectAll;
	}
}
