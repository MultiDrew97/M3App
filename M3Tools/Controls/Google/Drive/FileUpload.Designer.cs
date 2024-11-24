using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FileUpload : System.Windows.Forms.UserControl
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
            ofd_FileDialog = new System.Windows.Forms.OpenFileDialog();
            ofd_FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(LoadFiles);
            dgv_Files = new System.Windows.Forms.DataGridView();
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ts_Tools = new System.Windows.Forms.ToolStrip();
            ts_Tools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(SelectFiles);
            tbtn_Select = new System.Windows.Forms.ToolStripButton();
            _bsFiles = new System.Windows.Forms.BindingSource(components);
            _bsFiles.ListChanged += new System.ComponentModel.ListChangedEventHandler(DataSourceUpdated);
            dgc_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FileTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ToStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Files).BeginInit();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ts_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_bsFiles).BeginInit();
            SuspendLayout();
            // 
            // ofd_FileDialog
            // 
            ofd_FileDialog.Multiselect = true;
            ofd_FileDialog.Title = "Upload New File(s)";
            // 
            // dgv_Files
            // 
            dgv_Files.AllowUserToAddRows = false;
            dgv_Files.AutoGenerateColumns = false;
            dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgc_File, NameDataGridViewTextBoxColumn, FileTypeDataGridViewTextBoxColumn, ParentsDataGridViewTextBoxColumn, ToStringDataGridViewTextBoxColumn });
            dgv_Files.DataSource = _bsFiles;
            dgv_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Files.Location = new System.Drawing.Point(10, 10);
            dgv_Files.Name = "dgv_Files";
            dgv_Files.ReadOnly = true;
            dgv_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_Files.Size = new System.Drawing.Size(394, 313);
            dgv_Files.TabIndex = 1;
            // 
            // ToolStripContainer1
            // 
            ToolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(dgv_Files);
            ToolStripContainer1.ContentPanel.Padding = new System.Windows.Forms.Padding(10);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(414, 333);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.LeftToolStripPanelVisible = false;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.RightToolStripPanelVisible = false;
            ToolStripContainer1.Size = new System.Drawing.Size(414, 358);
            ToolStripContainer1.TabIndex = 2;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_Tools);
            // 
            // ts_Tools
            // 
            ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbtn_Select });
            ts_Tools.Location = new System.Drawing.Point(5, 0);
            ts_Tools.Name = "ts_Tools";
            ts_Tools.Size = new System.Drawing.Size(26, 25);
            ts_Tools.TabIndex = 0;
            // 
            // tbtn_Select
            // 
            tbtn_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tbtn_Select.Image = Properties.Resources.Import;
            tbtn_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbtn_Select.Margin = new System.Windows.Forms.Padding(0);
            tbtn_Select.Name = "tbtn_Select";
            tbtn_Select.Size = new System.Drawing.Size(23, 25);
            tbtn_Select.Text = "Select";
            // 
            // bsFiles
            // 
            _bsFiles.AllowNew = true;
            _bsFiles.DataSource = typeof(Types.GTools.FileCollection);
            // 
            // dgc_File
            // 
            dgc_File.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgc_File.DataPropertyName = "Name";
            dgc_File.HeaderText = "File";
            dgc_File.MinimumWidth = 300;
            dgc_File.Name = "dgc_File";
            dgc_File.ReadOnly = true;
            dgc_File.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NameDataGridViewTextBoxColumn
            // 
            NameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            NameDataGridViewTextBoxColumn.HeaderText = "Name";
            NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn";
            NameDataGridViewTextBoxColumn.ReadOnly = true;
            NameDataGridViewTextBoxColumn.Visible = false;
            // 
            // FileTypeDataGridViewTextBoxColumn
            // 
            FileTypeDataGridViewTextBoxColumn.DataPropertyName = "FileType";
            FileTypeDataGridViewTextBoxColumn.HeaderText = "FileType";
            FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn";
            FileTypeDataGridViewTextBoxColumn.ReadOnly = true;
            FileTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ParentsDataGridViewTextBoxColumn
            // 
            ParentsDataGridViewTextBoxColumn.DataPropertyName = "Parents";
            ParentsDataGridViewTextBoxColumn.HeaderText = "Parents";
            ParentsDataGridViewTextBoxColumn.Name = "ParentsDataGridViewTextBoxColumn";
            ParentsDataGridViewTextBoxColumn.ReadOnly = true;
            ParentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // ToStringDataGridViewTextBoxColumn
            // 
            ToStringDataGridViewTextBoxColumn.DataPropertyName = "ToString";
            ToStringDataGridViewTextBoxColumn.HeaderText = "ToString";
            ToStringDataGridViewTextBoxColumn.Name = "ToStringDataGridViewTextBoxColumn";
            ToStringDataGridViewTextBoxColumn.ReadOnly = true;
            ToStringDataGridViewTextBoxColumn.Visible = false;
            // 
            // FileUpload
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ToolStripContainer1);
            Name = "FileUpload";
            Size = new System.Drawing.Size(414, 358);
            ((System.ComponentModel.ISupportInitialize)dgv_Files).EndInit();
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ts_Tools.ResumeLayout(false);
            ts_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_bsFiles).EndInit();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.OpenFileDialog ofd_FileDialog;
        internal System.Windows.Forms.DataGridView dgv_Files;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.ToolStrip ts_Tools;
        internal System.Windows.Forms.ToolStripButton tbtn_Select;
        private System.Windows.Forms.BindingSource _bsFiles;

        internal virtual System.Windows.Forms.BindingSource bsFiles
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bsFiles;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bsFiles != null)
                {
                    _bsFiles.ListChanged -= DataSourceUpdated;
                }

                _bsFiles = value;
                if (_bsFiles != null)
                {
                    _bsFiles.ListChanged += DataSourceUpdated;
                }
            }
        }
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgc_File;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FileTypeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ParentsDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ToStringDataGridViewTextBoxColumn;
    }
}
