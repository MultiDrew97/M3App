using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EmailBodySelection : Form
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
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.tc_EmailType = new System.Windows.Forms.TabControl();
            this.tp_Templates = new System.Windows.Forms.TabPage();
            this.ts_Template = new SPPBC.M3Tools.TemplateSelector();
            this.tp_Custom = new System.Windows.Forms.TabPage();
            this.ce_Custom = new SPPBC.M3Tools.CustomEmail();
            this.bsTemplates = new System.Windows.Forms.BindingSource(this.components);
            this.tlp_Buttons.SuspendLayout();
            this.tc_EmailType.SuspendLayout();
            this.tp_Templates.SuspendLayout();
            this.tp_Custom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Buttons.ColumnCount = 2;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Controls.Add(this.OK_Button, 1, 0);
            this.tlp_Buttons.Controls.Add(this.Cancel_Button, 0, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(352, 355);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(146, 29);
            this.tlp_Buttons.TabIndex = 1;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(76, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.ConfirmSelection);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Location = new System.Drawing.Point(3, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.CancelSelection);
            // 
            // tc_EmailType
            // 
            this.tc_EmailType.Controls.Add(this.tp_Templates);
            this.tc_EmailType.Controls.Add(this.tp_Custom);
            this.tc_EmailType.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_EmailType.Location = new System.Drawing.Point(0, 0);
            this.tc_EmailType.Name = "tc_EmailType";
            this.tc_EmailType.SelectedIndex = 0;
            this.tc_EmailType.Size = new System.Drawing.Size(510, 347);
            this.tc_EmailType.TabIndex = 0;
            // 
            // tp_Templates
            // 
            this.tp_Templates.Controls.Add(this.ts_Template);
            this.tp_Templates.Location = new System.Drawing.Point(4, 22);
            this.tp_Templates.Name = "tp_Templates";
            this.tp_Templates.Size = new System.Drawing.Size(502, 321);
            this.tp_Templates.TabIndex = 2;
            this.tp_Templates.Text = "Templates";
            this.tp_Templates.UseVisualStyleBackColor = true;
            // 
            // ts_Template
            // 
            this.ts_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Template.Location = new System.Drawing.Point(0, 0);
            this.ts_Template.MinimumSize = new System.Drawing.Size(200, 200);
            this.ts_Template.Name = "ts_Template";
            this.ts_Template.Padding = new System.Windows.Forms.Padding(5);
            this.ts_Template.Size = new System.Drawing.Size(502, 321);
            this.ts_Template.TabIndex = 0;
            // 
            // tp_Custom
            // 
            this.tp_Custom.Controls.Add(this.ce_Custom);
            this.tp_Custom.Location = new System.Drawing.Point(4, 22);
            this.tp_Custom.Name = "tp_Custom";
            this.tp_Custom.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Custom.Size = new System.Drawing.Size(502, 321);
            this.tp_Custom.TabIndex = 1;
            this.tp_Custom.Text = "Custom Email";
            this.tp_Custom.UseVisualStyleBackColor = true;
            // 
            // ce_Custom
            // 
            this.ce_Custom.AutoSize = true;
            this.ce_Custom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce_Custom.Location = new System.Drawing.Point(3, 3);
            this.ce_Custom.Margin = new System.Windows.Forms.Padding(0);
            this.ce_Custom.MinimumSize = new System.Drawing.Size(400, 300);
            this.ce_Custom.Name = "ce_Custom";
            this.ce_Custom.Size = new System.Drawing.Size(496, 315);
            this.ce_Custom.TabIndex = 0;
            // 
            // bsTemplates
            // 
            this.bsTemplates.DataSource = typeof(SPPBC.M3Tools.Types.TemplateList);
            // 
            // EmailBodySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 396);
            this.Controls.Add(this.tc_EmailType);
            this.Controls.Add(this.tlp_Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailBodySelection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Body";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reload);
            this.tlp_Buttons.ResumeLayout(false);
            this.tc_EmailType.ResumeLayout(false);
            this.tp_Templates.ResumeLayout(false);
            this.tp_Custom.ResumeLayout(false);
            this.tp_Custom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemplates)).EndInit();
            this.ResumeLayout(false);

        }
        internal TableLayoutPanel tlp_Buttons;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal TabControl tc_EmailType;
        internal BindingSource bsTemplates;
        internal TabPage tp_Custom;
        internal TabPage tp_Templates;
        internal TemplateSelector ts_Template;
        internal CustomEmail ce_Custom;
    }
}
