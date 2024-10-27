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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Drive");
			this.tv_DriveFiles = new System.Windows.Forms.TreeView();
			this.gdt_GDrive = new SPPBC.M3Tools.GTools.GDrive(this.components);
			this.ts_Tools = new System.Windows.Forms.ToolStrip();
			this.tss_NewItem = new System.Windows.Forms.ToolStripSplitButton();
			this.tsmi_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_NewUpload = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.cms_Tools = new SPPBC.M3Tools.ToolsContextMenu();
			this.ts_Tools.SuspendLayout();
			this.ToolStripContainer1.ContentPanel.SuspendLayout();
			this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.ToolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv_DriveFiles
			// 
			this.tv_DriveFiles.CheckBoxes = true;
			this.tv_DriveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_DriveFiles.Location = new System.Drawing.Point(0, 0);
			this.tv_DriveFiles.Name = "tv_DriveFiles";
			treeNode1.Name = "tn_Root";
			treeNode1.Text = "My Drive";
			this.tv_DriveFiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.tv_DriveFiles.ShowLines = false;
			this.tv_DriveFiles.Size = new System.Drawing.Size(625, 475);
			this.tv_DriveFiles.TabIndex = 2;
			// 
			// ts_Tools
			// 
			this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
			this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_NewItem});
			this.ts_Tools.Location = new System.Drawing.Point(0, 0);
			this.ts_Tools.Name = "ts_Tools";
			this.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ts_Tools.Size = new System.Drawing.Size(625, 25);
			this.ts_Tools.Stretch = true;
			this.ts_Tools.TabIndex = 3;
			// 
			// tss_NewItem
			// 
			this.tss_NewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tss_NewItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NewFolder,
            this.tsmi_NewUpload});
			this.tss_NewItem.Image = global::SPPBC.M3Tools.Properties.Resources.NewDocumentOption;
			this.tss_NewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tss_NewItem.Name = "tss_NewItem";
			this.tss_NewItem.Size = new System.Drawing.Size(32, 22);
			this.tss_NewItem.Text = "New";
			// 
			// tsmi_NewFolder
			// 
			this.tsmi_NewFolder.Name = "tsmi_NewFolder";
			this.tsmi_NewFolder.Size = new System.Drawing.Size(139, 22);
			this.tsmi_NewFolder.Text = "New Folder";
			this.tsmi_NewFolder.Click += new System.EventHandler(this.NewFolder);
			// 
			// tsmi_NewUpload
			// 
			this.tsmi_NewUpload.Name = "tsmi_NewUpload";
			this.tsmi_NewUpload.Size = new System.Drawing.Size(139, 22);
			this.tsmi_NewUpload.Text = "New Upload";
			// 
			// ToolStripContainer1
			// 
			// 
			// ToolStripContainer1.ContentPanel
			// 
			this.ToolStripContainer1.ContentPanel.Controls.Add(this.tv_DriveFiles);
			this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(625, 475);
			this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer1.Name = "ToolStripContainer1";
			this.ToolStripContainer1.Size = new System.Drawing.Size(625, 500);
			this.ToolStripContainer1.TabIndex = 4;
			this.ToolStripContainer1.Text = "ToolStripContainer1";
			// 
			// ToolStripContainer1.TopToolStripPanel
			// 
			this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ts_Tools);
			// 
			// cms_Tools
			// 
			this.cms_Tools.Name = "cms_Tools";
			this.cms_Tools.Size = new System.Drawing.Size(133, 70);
			// 
			// DriveTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.cms_Tools;
			this.Controls.Add(this.ToolStripContainer1);
			this.Name = "DriveTree";
			this.Size = new System.Drawing.Size(625, 500);
			this.ts_Tools.ResumeLayout(false);
			this.ts_Tools.PerformLayout();
			this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
			this.ToolStripContainer1.ResumeLayout(false);
			this.ToolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

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
