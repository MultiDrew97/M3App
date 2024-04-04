using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CreateFolderDialog : Form
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
            TableLayoutPanel1 = new TableLayoutPanel();
            btn_Create = new Button();
            btn_Create.Click += new EventHandler(Create);
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            dt_DriveHeirarchy = new SPPBC.M3Tools.DriveTree();
            gdt_GDrive = new SPPBC.M3Tools.GTools.GdriveTool(components);
            ip_FolderName = new SPPBC.M3Tools.GenericInputPair();
            ip_FolderName.TextChanged += FolderNameTextChanged;
            bw_GatherInfo = new System.ComponentModel.BackgroundWorker();
            bw_GatherInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(GatherInfo);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new Point(184, 361);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Create
            // 
            btn_Create.Anchor = AnchorStyles.None;
            btn_Create.Location = new Point(76, 3);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(67, 23);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Create";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.None;
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // dt_DriveHeirarchy
            // 
            dt_DriveHeirarchy.Checkboxes = false;
            dt_DriveHeirarchy.DataBindings.Add(new Binding("Username", global::M3App.My.Settings.Default, "Username", true, DataSourceUpdateMode.OnPropertyChanged));
            dt_DriveHeirarchy.Location = new Point(12, 69);
            dt_DriveHeirarchy.Name = "dt_DriveHeirarchy";
            dt_DriveHeirarchy.Size = new Size(303, 266);
            dt_DriveHeirarchy.TabIndex = 2;
            dt_DriveHeirarchy.Username = global::M3App.My.Settings.Default.Username;
            dt_DriveHeirarchy.WithChildren = false;
            // 
            // ip_FolderName
            // 
            ip_FolderName.AutoSize = true;
            ip_FolderName.Label = "Folder Name";
            ip_FolderName.Location = new Point(12, 12);
            ip_FolderName.Mask = "";
            ip_FolderName.Name = "ip_FolderName";
            ip_FolderName.Placeholder = null;
            ip_FolderName.Size = new Size(302, 44);
            ip_FolderName.TabIndex = 3;
            ip_FolderName.TextAlign = HorizontalAlignment.Left;
            // 
            // bw_GatherInfo
            // 
            // 
            // CreateFolderDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(342, 402);
            Controls.Add(ip_FolderName);
            Controls.Add(dt_DriveHeirarchy);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateFolderDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Folder";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(LoadDialog);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button btn_Create;
        internal Button btn_Cancel;
        internal SPPBC.M3Tools.DriveTree dt_DriveHeirarchy;
        internal SPPBC.M3Tools.GTools.GdriveTool gdt_GDrive;
        internal SPPBC.M3Tools.GenericInputPair ip_FolderName;
        internal System.ComponentModel.BackgroundWorker bw_GatherInfo;
    }
}
