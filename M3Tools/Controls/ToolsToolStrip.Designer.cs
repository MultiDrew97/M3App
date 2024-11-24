﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools
{
    public partial class ToolsToolStrip : System.Windows.Forms.ToolStrip
    {

        [DebuggerNonUserCode()]
        public ToolsToolStrip(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        // Component overrides dispose to clean up the component list.
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

        // Required by the Component Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Component Designer
        // It can be modified using the Component Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.tsb_Add = new System.Windows.Forms.ToolStripButton();
            this.tsb_Import = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tst_Filter = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_Send = new System.Windows.Forms.ToolStripButton();
            this.tsl_Count = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SuspendLayout();
            // 
            // tsb_Add
            // 
            this.tsb_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Add.Image = global::SPPBC.M3Tools.Properties.Resources.New_Entry;
            this.tsb_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Add.Name = "tsb_Add";
            this.tsb_Add.Size = new System.Drawing.Size(23, 22);
            this.tsb_Add.Text = "New";
            this.tsb_Add.ToolTipText = "Add";
            this.tsb_Add.Click += new System.EventHandler(this.Add);
            // 
            // tsb_Import
            // 
            this.tsb_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Import.Image = global::SPPBC.M3Tools.Properties.Resources.Import;
            this.tsb_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Import.Name = "tsb_Import";
            this.tsb_Import.Size = new System.Drawing.Size(23, 22);
            this.tsb_Import.Text = "Import";
            this.tsb_Import.ToolTipText = "Import";
            this.tsb_Import.Click += new System.EventHandler(this.Import);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tst_Filter
            // 
            this.tst_Filter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_Filter.Name = "tst_Filter";
            this.tst_Filter.Size = new System.Drawing.Size(100, 23);
            this.tst_Filter.ToolTipText = "Filter entries";
            this.tst_Filter.TextChanged += new System.EventHandler(this.Filtered);
            // 
            // tsb_Send
            // 
            this.tsb_Send.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Send.Image = global::SPPBC.M3Tools.Properties.Resources.SEND_EMAIL;
            this.tsb_Send.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Send.Name = "tsb_Send";
            this.tsb_Send.Size = new System.Drawing.Size(23, 22);
            this.tsb_Send.Text = "Send Emails";
            this.tsb_Send.Click += new System.EventHandler(this.Emails);
            // 
            // tsl_Count
            // 
            this.tsl_Count.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_Count.Name = "tsl_Count";
            this.tsl_Count.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolsToolStrip
            // 
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Add,
            this.tsb_Import,
            this.tsb_Send,
            this.ToolStripSeparator1,
            this.tst_Filter,
            this.ToolStripSeparator2,
            this.tsl_Count});
            this.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Stretch = true;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripButton tsb_Add;
        private System.Windows.Forms.ToolStripButton tsb_Import;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tst_Filter;
        private System.Windows.Forms.ToolStripButton tsb_Send;
        private System.Windows.Forms.ToolStripLabel tsl_Count;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    }
}
