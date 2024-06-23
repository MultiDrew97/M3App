using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ImportListenersDialog : System.Windows.Forms.Form
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ofd_ImportFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.chk_Headers = new System.Windows.Forms.CheckBox();
            this.bsListeners = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Clear = new System.Windows.Forms.Button();
            this.bw_ParseFiles = new System.ComponentModel.BackgroundWorker();
            this.ldg_Listeners = new SPPBC.M3Tools.Data.ListenersDataGrid();
            this.gi_FileName = new SPPBC.M3Tools.GenericInputPair();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Import, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(274, 329);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Import.Location = new System.Drawing.Point(76, 3);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(67, 23);
            this.btn_Import.TabIndex = 0;
            this.btn_Import.Text = "OK";
            this.btn_Import.Click += new System.EventHandler(this.BeginImport);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // ofd_ImportFile
            // 
            this.ofd_ImportFile.DefaultExt = "csv";
            this.ofd_ImportFile.Filter = "CSV files|*.csv";
            this.ofd_ImportFile.Multiselect = true;
            this.ofd_ImportFile.ShowHelp = true;
            this.ofd_ImportFile.Title = "Import File";
            this.ofd_ImportFile.FileOk += new System.ComponentModel.CancelEventHandler(this.FilesSelected);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(356, 36);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(27, 23);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.RetrieveFile);
            // 
            // chk_Headers
            // 
            this.chk_Headers.AutoSize = true;
            this.chk_Headers.Checked = true;
            this.chk_Headers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Headers.Location = new System.Drawing.Point(161, 70);
            this.chk_Headers.Name = "chk_Headers";
            this.chk_Headers.Size = new System.Drawing.Size(110, 17);
            this.chk_Headers.TabIndex = 3;
            this.chk_Headers.Text = "Contains Headers";
            this.chk_Headers.UseVisualStyleBackColor = true;
            // 
            // bsListeners
            // 
            this.bsListeners.Filter = "";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(378, 104);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(39, 24);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.ClearList);
            // 
            // bw_ParseFiles
            // 
            this.bw_ParseFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ParseFiles);
            this.bw_ParseFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FilesParsed);
            // 
            // ldg_Listeners
            // 
            this.ldg_Listeners.AllowUserToAddRows = false;
            this.ldg_Listeners.AllowUserToOrderColumns = true;
            this.ldg_Listeners.AutoGenerateColumns = false;
            this.ldg_Listeners.CanDelete = false;
            this.ldg_Listeners.CanEdit = false;
            this.ldg_Listeners.CanReorder = true;
            this.ldg_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldg_Listeners.DataSource = this.bsListeners;
            this.ldg_Listeners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ldg_Listeners.Location = new System.Drawing.Point(16, 104);
            this.ldg_Listeners.MinimumSize = new System.Drawing.Size(350, 100);
            this.ldg_Listeners.Name = "ldg_Listeners";
            this.ldg_Listeners.ReadOnly = true;
            this.ldg_Listeners.RowHeadersWidth = 82;
            this.ldg_Listeners.RowsCheckable = false;
            this.ldg_Listeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ldg_Listeners.Size = new System.Drawing.Size(350, 207);
            this.ldg_Listeners.TabIndex = 6;
            // 
            // gi_FileName
            // 
            this.gi_FileName.AutoSize = true;
            this.gi_FileName.Enabled = false;
            this.gi_FileName.Label = "Import File:";
            this.gi_FileName.Location = new System.Drawing.Point(50, 12);
            this.gi_FileName.Mask = "";
            this.gi_FileName.MaximumSize = new System.Drawing.Size(0, 45);
            this.gi_FileName.MinimumSize = new System.Drawing.Size(300, 45);
            this.gi_FileName.Name = "gi_FileName";
            this.gi_FileName.Placeholder = "Select Files...";
            this.gi_FileName.Size = new System.Drawing.Size(300, 45);
            this.gi_FileName.TabIndex = 1;
            this.gi_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ImportListenersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 370);
            this.Controls.Add(this.ldg_Listeners);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.chk_Headers);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.gi_FileName);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportListenersDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Listeners";
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsListeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldg_Listeners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Import;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.OpenFileDialog ofd_ImportFile;
        internal GenericInputPair gi_FileName;
        internal System.Windows.Forms.Button btn_Browse;
        internal System.Windows.Forms.CheckBox chk_Headers;
        internal System.Windows.Forms.BindingSource bsListeners;
        internal System.Windows.Forms.Button btn_Clear;
        internal Data.ListenersDataGrid ldg_Listeners;
        internal System.ComponentModel.BackgroundWorker bw_ParseFiles;
	}
}
