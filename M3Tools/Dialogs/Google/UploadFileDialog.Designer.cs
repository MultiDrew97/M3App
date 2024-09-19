using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UploadFileDialog : System.Windows.Forms.Form
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
            btn_Upload = new System.Windows.Forms.Button();
            btn_Upload.Click += new EventHandler(Upload);
            Cancel_Button = new System.Windows.Forms.Button();
            Cancel_Button.Click += new EventHandler(Cancel);
            SplitContainer1 = new System.Windows.Forms.SplitContainer();
            chk_DefaultPermissions = new System.Windows.Forms.CheckBox();
            fu_FileUpload = new FileUpload();
            bsFiles = new System.Windows.Forms.BindingSource(components);
            dt_DriveHeirarchy = new DriveTree();
            bw_LoadDialog = new System.ComponentModel.BackgroundWorker();
            bw_LoadDialog.DoWork += new System.ComponentModel.DoWorkEventHandler(DialogLoad);
            bw_LoadDialog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(DialogLoadFinished);
            Panel1 = new System.Windows.Forms.Panel();
            bw_LoadFiles = new System.ComponentModel.BackgroundWorker();
            bw_LoadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadFiles);
            bw_LoadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(SetParents);
            bw_UploadFiles = new System.ComponentModel.BackgroundWorker();
            bw_UploadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(UploadFiles);
            bw_UploadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(UploadCompleted);
            gdt_GDrive = new GTools.GDrive(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsFiles).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Upload, 1, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(229, 311);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Upload
            // 
            btn_Upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Upload.Location = new System.Drawing.Point(76, 3);
            btn_Upload.Name = "btn_Upload";
            btn_Upload.Size = new System.Drawing.Size(67, 23);
            btn_Upload.TabIndex = 0;
            btn_Upload.Text = "Upload";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Cancel_Button.Location = new System.Drawing.Point(3, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new System.Drawing.Size(67, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            SplitContainer1.Location = new System.Drawing.Point(0, 0);
            SplitContainer1.Name = "SplitContainer1";
            SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(chk_DefaultPermissions);
            SplitContainer1.Panel1.Controls.Add(fu_FileUpload);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(dt_DriveHeirarchy);
            SplitContainer1.Size = new System.Drawing.Size(363, 286);
            SplitContainer1.SplitterDistance = 113;
            SplitContainer1.TabIndex = 2;
            // 
            // chk_DefaultPermissions
            // 
            chk_DefaultPermissions.Checked = true;
            chk_DefaultPermissions.CheckState = System.Windows.Forms.CheckState.Checked;
            chk_DefaultPermissions.Dock = System.Windows.Forms.DockStyle.Right;
            chk_DefaultPermissions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chk_DefaultPermissions.Location = new System.Drawing.Point(263, 0);
            chk_DefaultPermissions.Name = "chk_DefaultPermissions";
            chk_DefaultPermissions.Size = new System.Drawing.Size(100, 113);
            chk_DefaultPermissions.TabIndex = 1;
            chk_DefaultPermissions.Text = "Default Permissions?";
            chk_DefaultPermissions.UseVisualStyleBackColor = true;
            // 
            // fu_FileUpload
            // 
            fu_FileUpload.DataSource = bsFiles;
            fu_FileUpload.Dock = System.Windows.Forms.DockStyle.Left;
            fu_FileUpload.Location = new System.Drawing.Point(0, 0);
            fu_FileUpload.Name = "fu_FileUpload";
            fu_FileUpload.Size = new System.Drawing.Size(257, 113);
            fu_FileUpload.TabIndex = 0;
            // 
            // bsFiles
            // 
            bsFiles.DataSource = typeof(Types.GTools.FileCollection);
            // 
            // dt_DriveHeirarchy
            // 
            dt_DriveHeirarchy.Checkboxes = false;
            dt_DriveHeirarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            dt_DriveHeirarchy.Location = new System.Drawing.Point(0, 0);
            dt_DriveHeirarchy.Name = "dt_DriveHeirarchy";
            dt_DriveHeirarchy.Size = new System.Drawing.Size(363, 169);
            dt_DriveHeirarchy.TabIndex = 1;
            dt_DriveHeirarchy.WithChildren = false;
            // 
            // bw_LoadDialog
            // 
            // 
            // Panel1
            // 
            Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            Panel1.Controls.Add(SplitContainer1);
            Panel1.Location = new System.Drawing.Point(12, 12);
            Panel1.Name = "Panel1";
            Panel1.Size = new System.Drawing.Size(363, 286);
            Panel1.TabIndex = 3;
            // 
            // bw_LoadFiles
            // 
            // 
            // bw_UploadFiles
            // 
            // 
            // gdt_GDrive
            // 
            gdt_GDrive.Username = null;
            // 
            // UploadFileDialog
            // 
            AcceptButton = btn_Upload;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = Cancel_Button;
            ClientSize = new System.Drawing.Size(387, 352);
            Controls.Add(Panel1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UploadFileDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New File Upload";
            TableLayoutPanel1.ResumeLayout(false);
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsFiles).EndInit();
            Panel1.ResumeLayout(false);
            Load += new EventHandler(Loading);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Upload;
        internal System.Windows.Forms.Button Cancel_Button;
        internal DriveTree dt_DriveHeirarchy;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal GTools.GDrive gdt_GDrive;
        internal System.ComponentModel.BackgroundWorker bw_LoadDialog;
        internal FileUpload fu_FileUpload;
        internal System.Windows.Forms.Panel Panel1;
        internal System.ComponentModel.BackgroundWorker bw_LoadFiles;
        internal System.ComponentModel.BackgroundWorker bw_UploadFiles;
        internal System.Windows.Forms.CheckBox chk_DefaultPermissions;
        internal System.Windows.Forms.BindingSource bsFiles;
    }
}
