using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TemplateSelector : System.Windows.Forms.UserControl
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
            this.wb_TemplateDisplay = new System.Windows.Forms.WebBrowser();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbx_TemplateSelection = new System.Windows.Forms.ComboBox();
            this.bsTemplates = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // wb_TemplateDisplay
            // 
            this.wb_TemplateDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_TemplateDisplay.IsWebBrowserContextMenuEnabled = false;
            this.wb_TemplateDisplay.Location = new System.Drawing.Point(0, 0);
            this.wb_TemplateDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_TemplateDisplay.Name = "wb_TemplateDisplay";
            this.wb_TemplateDisplay.Size = new System.Drawing.Size(200, 174);
            this.wb_TemplateDisplay.TabIndex = 0;
            this.wb_TemplateDisplay.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.wb_TemplateDisplay.WebBrowserShortcutsEnabled = false;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.cbx_TemplateSelection);
            this.SplitContainer1.Panel1MinSize = 21;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.wb_TemplateDisplay);
            this.SplitContainer1.Size = new System.Drawing.Size(200, 200);
            this.SplitContainer1.SplitterDistance = 25;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            this.SplitContainer1.TabStop = false;
            // 
            // cbx_TemplateSelection
            // 
            this.cbx_TemplateSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_TemplateSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_TemplateSelection.DataSource = this.bsTemplates;
            this.cbx_TemplateSelection.DisplayMember = "Name";
            this.cbx_TemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_TemplateSelection.FormattingEnabled = true;
            this.cbx_TemplateSelection.Location = new System.Drawing.Point(0, 0);
            this.cbx_TemplateSelection.Name = "cbx_TemplateSelection";
            this.cbx_TemplateSelection.Size = new System.Drawing.Size(200, 21);
            this.cbx_TemplateSelection.TabIndex = 0;
            this.cbx_TemplateSelection.ValueMember = "Text";
            this.cbx_TemplateSelection.SelectedIndexChanged += new System.EventHandler(this.TemplateSelectionChanged);
            // 
            // bsTemplates
            // 
            this.bsTemplates.DataSource = typeof(SPPBC.M3Tools.Types.TemplateList);
            // 
            // TemplateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "TemplateSelector";
            this.Size = new System.Drawing.Size(200, 200);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.WebBrowser wb_TemplateDisplay;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ComboBox cbx_TemplateSelection;
        internal System.Windows.Forms.BindingSource bsTemplates;
    }
}
