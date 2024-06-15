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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btn_Import = new System.Windows.Forms.Button();
            btn_Import.Click += new EventHandler(BeginImport);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            ofd_ImportFile = new System.Windows.Forms.OpenFileDialog();
            ofd_ImportFile.FileOk += new System.ComponentModel.CancelEventHandler(FilesSelected);
            btn_Browse = new System.Windows.Forms.Button();
            btn_Browse.Click += new EventHandler(RetrieveFile);
            chk_Headers = new System.Windows.Forms.CheckBox();
            bsListeners = new System.Windows.Forms.BindingSource(components);
            gi_FileName = new GenericInputPair();
            btn_Clear = new System.Windows.Forms.Button();
            btn_Clear.Click += new EventHandler(ClearList);
            ldg_Listeners = new Data.ListenersDataGrid();
            bw_ParseFiles = new System.ComponentModel.BackgroundWorker();
            bw_ParseFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(ParseFiles);
            bw_ParseFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(FilesParsed);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsListeners).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Import, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(277, 274);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Import
            // 
            btn_Import.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Import.Location = new System.Drawing.Point(76, 3);
            btn_Import.Name = "btn_Import";
            btn_Import.Size = new System.Drawing.Size(67, 23);
            btn_Import.TabIndex = 0;
            btn_Import.Text = "OK";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // ofd_ImportFile
            // 
            ofd_ImportFile.DefaultExt = "csv";
            ofd_ImportFile.Filter = "CSV files|*.csv";
            ofd_ImportFile.Multiselect = true;
            ofd_ImportFile.ShowHelp = true;
            ofd_ImportFile.Title = "Import File";
            // 
            // btn_Browse
            // 
            btn_Browse.Location = new System.Drawing.Point(345, 44);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new System.Drawing.Size(27, 23);
            btn_Browse.TabIndex = 2;
            btn_Browse.Text = "...";
            btn_Browse.UseVisualStyleBackColor = true;
            // 
            // chk_Headers
            // 
            chk_Headers.AutoSize = true;
            chk_Headers.Checked = true;
            chk_Headers.CheckState = System.Windows.Forms.CheckState.Checked;
            chk_Headers.Location = new System.Drawing.Point(66, 81);
            chk_Headers.Name = "chk_Headers";
            chk_Headers.Size = new System.Drawing.Size(110, 17);
            chk_Headers.TabIndex = 3;
            chk_Headers.Text = "Contains Headers";
            chk_Headers.UseVisualStyleBackColor = true;
            // 
            // bsListeners
            // 
            bsListeners.Filter = "";
            // 
            // gi_FileName
            // 
            gi_FileName.AutoSize = true;
            gi_FileName.Enabled = false;
            gi_FileName.Label = "Import File:";
            gi_FileName.Location = new System.Drawing.Point(39, 29);
            gi_FileName.Mask = "";
            gi_FileName.MaximumSize = new System.Drawing.Size(0, 45);
            gi_FileName.MinimumSize = new System.Drawing.Size(300, 45);
            gi_FileName.Name = "gi_FileName";
            gi_FileName.Placeholder = "Select Files...";
            gi_FileName.Size = new System.Drawing.Size(300, 45);
            gi_FileName.TabIndex = 1;
            gi_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new System.Drawing.Point(384, 128);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new System.Drawing.Size(39, 24);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // ldg_Listeners
            // 
            ldg_Listeners.CanReorder = true;
            ldg_Listeners.CanDelete = false;
            ldg_Listeners.CanEdit = false;
            ldg_Listeners.DataSource = bsListeners;
            ldg_Listeners.RowsCheckable = false;
            ldg_Listeners.Location = new System.Drawing.Point(28, 128);
            ldg_Listeners.MinimumSize = new System.Drawing.Size(350, 100);
            ldg_Listeners.Name = "ldg_Listeners";
            ldg_Listeners.Size = new System.Drawing.Size(350, 100);
            ldg_Listeners.TabIndex = 6;
            // 
            // bw_ParseFiles
            // 
            // 
            // ImportListenersDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(435, 315);
            Controls.Add(ldg_Listeners);
            Controls.Add(btn_Clear);
            Controls.Add(chk_Headers);
            Controls.Add(btn_Browse);
            Controls.Add(gi_FileName);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportListenersDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Import Listeners";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsListeners).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
