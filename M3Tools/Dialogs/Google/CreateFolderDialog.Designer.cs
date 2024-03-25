using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CreateFolderDialog : System.Windows.Forms.Form
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
            btn_Create = new System.Windows.Forms.Button();
            btn_Create.Click += new EventHandler(Create);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            dt_DriveHeirarchy = new DriveTree();
            gdt_GDrive = new GTools.GdriveTool(components);
            ip_FolderName = new GenericInputPair();
            ip_FolderName.TextChanged += new EventHandler(FolderNameTextChanged);
            bw_GatherInfo = new System.ComponentModel.BackgroundWorker();
            bw_GatherInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(GatherInfo);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(184, 361);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Create
            // 
            btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Create.Location = new System.Drawing.Point(76, 3);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(67, 23);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Create";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // dt_DriveHeirarchy
            // 
            dt_DriveHeirarchy.Checkboxes = false;
            dt_DriveHeirarchy.Location = new System.Drawing.Point(12, 69);
            dt_DriveHeirarchy.Name = "dt_DriveHeirarchy";
            dt_DriveHeirarchy.Size = new System.Drawing.Size(303, 266);
            dt_DriveHeirarchy.TabIndex = 2;
            dt_DriveHeirarchy.Username = "";
            dt_DriveHeirarchy.WithChildren = false;
            // 
            // gdt_GDrive
            // 
            gdt_GDrive.Username = null;
            // 
            // ip_FolderName
            // 
            ip_FolderName.AutoSize = true;
            ip_FolderName.Label = "Folder Name";
            ip_FolderName.Location = new System.Drawing.Point(12, 12);
            ip_FolderName.Mask = "";
            ip_FolderName.Name = "ip_FolderName";
            ip_FolderName.Placeholder = null;
            ip_FolderName.Size = new System.Drawing.Size(302, 44);
            ip_FolderName.TabIndex = 3;
            ip_FolderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bw_GatherInfo
            // 
            // 
            // CreateFolderDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(342, 402);
            Controls.Add(ip_FolderName);
            Controls.Add(dt_DriveHeirarchy);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateFolderDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Folder";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(LoadDialog);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Create;
        internal System.Windows.Forms.Button btn_Cancel;
        internal DriveTree dt_DriveHeirarchy;
        internal GTools.GdriveTool gdt_GDrive;
        internal GenericInputPair ip_FolderName;
        internal System.ComponentModel.BackgroundWorker bw_GatherInfo;
    }
}