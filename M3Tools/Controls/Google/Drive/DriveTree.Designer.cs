using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DriveTree : System.Windows.Forms.UserControl
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
            var TreeNode1 = new System.Windows.Forms.TreeNode("My Drive Folder");
            tv_DriveFiles = new System.Windows.Forms.TreeView();
            gdt_GDrive = new GTools.GDrive(components);
            ts_Tools = new System.Windows.Forms.ToolStrip();
            tss_NewItem = new System.Windows.Forms.ToolStripSplitButton();
            tsmi_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            tsmi_NewFolder.Click += new EventHandler(NewFolder);
            tsmi_NewUpload = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            cms_Tools = new ToolsContextMenu();
            ts_Tools.SuspendLayout();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tv_DriveFiles
            // 
            tv_DriveFiles.CheckBoxes = true;
            tv_DriveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tv_DriveFiles.Location = new System.Drawing.Point(0, 0);
            tv_DriveFiles.Name = "tv_DriveFiles";
            TreeNode1.Name = "main";
            TreeNode1.Text = "My Drive Folder";
            tv_DriveFiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { TreeNode1 });
            tv_DriveFiles.Size = new System.Drawing.Size(625, 475);
            tv_DriveFiles.TabIndex = 2;
            // 
            // gdt_GDrive
            // 
            gdt_GDrive.Username = "";
            // 
            // ts_Tools
            // 
            ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tss_NewItem });
            ts_Tools.Location = new System.Drawing.Point(0, 0);
            ts_Tools.Name = "ts_Tools";
            ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            ts_Tools.Size = new System.Drawing.Size(625, 25);
            ts_Tools.Stretch = true;
            ts_Tools.TabIndex = 3;
            // 
            // tss_NewItem
            // 
            tss_NewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tss_NewItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmi_NewFolder, tsmi_NewUpload });
            tss_NewItem.Image = Properties.Resources.NewDocumentOption;
            tss_NewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tss_NewItem.Name = "tss_NewItem";
            tss_NewItem.Size = new System.Drawing.Size(32, 22);
            tss_NewItem.Text = "New";
            // 
            // tsmi_NewFolder
            // 
            tsmi_NewFolder.Name = "tsmi_NewFolder";
            tsmi_NewFolder.Size = new System.Drawing.Size(139, 22);
            tsmi_NewFolder.Text = "New Folder";
            // 
            // tsmi_NewUpload
            // 
            tsmi_NewUpload.Name = "tsmi_NewUpload";
            tsmi_NewUpload.Size = new System.Drawing.Size(139, 22);
            tsmi_NewUpload.Text = "New Upload";
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(tv_DriveFiles);
            ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(625, 475);
            ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.Size = new System.Drawing.Size(625, 500);
            ToolStripContainer1.TabIndex = 4;
            ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // ToolStripContainer1.TopToolStripPanel
            // 
            ToolStripContainer1.TopToolStripPanel.Controls.Add(ts_Tools);
            // 
            // cms_Tools
            // 
            cms_Tools.Name = "cms_Tools";
            cms_Tools.Size = new System.Drawing.Size(133, 70);
            // 
            // DriveTree
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ContextMenuStrip = cms_Tools;
            Controls.Add(ToolStripContainer1);
            Name = "DriveTree";
            Size = new System.Drawing.Size(625, 500);
            ts_Tools.ResumeLayout(false);
            ts_Tools.PerformLayout();
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.TopToolStripPanel.PerformLayout();
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TreeView tv_DriveFiles;
        internal GTools.GDrive gdt_GDrive;
        internal System.Windows.Forms.ToolStrip ts_Tools;
        internal System.Windows.Forms.ToolStripSplitButton tss_NewItem;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_NewFolder;
        internal System.Windows.Forms.ToolStripMenuItem tsmi_NewUpload;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal ToolsContextMenu cms_Tools;
    }
}
