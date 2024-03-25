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
            components = new System.ComponentModel.Container();
            wb_TemplateDisplay = new System.Windows.Forms.WebBrowser();
            SplitContainer1 = new System.Windows.Forms.SplitContainer();
            cbx_TemplateSelection = new System.Windows.Forms.ComboBox();
            cbx_TemplateSelection.SelectedIndexChanged += new EventHandler(TemplateSelectionChanged);
            bsTemplates = new System.Windows.Forms.BindingSource(components);
            bsTemplates.ListChanged += new System.ComponentModel.ListChangedEventHandler(TemplateListUpdated);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTemplates).BeginInit();
            SuspendLayout();
            // 
            // wb_TemplateDisplay
            // 
            wb_TemplateDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            wb_TemplateDisplay.IsWebBrowserContextMenuEnabled = false;
            wb_TemplateDisplay.Location = new System.Drawing.Point(0, 0);
            wb_TemplateDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            wb_TemplateDisplay.Name = "wb_TemplateDisplay";
            wb_TemplateDisplay.Size = new System.Drawing.Size(200, 174);
            wb_TemplateDisplay.TabIndex = 0;
            wb_TemplateDisplay.Url = new Uri("about:blank", UriKind.Absolute);
            wb_TemplateDisplay.WebBrowserShortcutsEnabled = false;
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
            SplitContainer1.Panel1.Controls.Add(cbx_TemplateSelection);
            SplitContainer1.Panel1MinSize = 21;
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(wb_TemplateDisplay);
            SplitContainer1.Size = new System.Drawing.Size(200, 200);
            SplitContainer1.SplitterDistance = 25;
            SplitContainer1.SplitterWidth = 1;
            SplitContainer1.TabIndex = 1;
            SplitContainer1.TabStop = false;
            // 
            // cbx_TemplateSelection
            // 
            cbx_TemplateSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cbx_TemplateSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbx_TemplateSelection.DataSource = bsTemplates;
            cbx_TemplateSelection.DisplayMember = "Name";
            cbx_TemplateSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            cbx_TemplateSelection.FormattingEnabled = true;
            cbx_TemplateSelection.Location = new System.Drawing.Point(0, 0);
            cbx_TemplateSelection.Name = "cbx_TemplateSelection";
            cbx_TemplateSelection.Size = new System.Drawing.Size(200, 21);
            cbx_TemplateSelection.TabIndex = 0;
            cbx_TemplateSelection.ValueMember = "Text";
            // 
            // bsTemplates
            // 
            bsTemplates.DataSource = typeof(Types.TemplateList);
            // 
            // TemplateSelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(SplitContainer1);
            MinimumSize = new System.Drawing.Size(200, 200);
            Name = "TemplateSelector";
            Size = new System.Drawing.Size(200, 200);
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsTemplates).EndInit();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.WebBrowser wb_TemplateDisplay;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ComboBox cbx_TemplateSelection;
        internal System.Windows.Forms.BindingSource bsTemplates;
    }
}