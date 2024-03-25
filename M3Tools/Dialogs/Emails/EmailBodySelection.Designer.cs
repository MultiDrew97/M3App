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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new TableLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(FinishDialog);
            Cancel_Button = new Button();
            Cancel_Button.Click += new EventHandler(CancelDialog);
            TabControl1 = new TabControl();
            tp_Templates = new TabPage();
            ts_Templates = new TemplateSelector();
            bsTemplates = new BindingSource(components);
            tp_Custom = new TabPage();
            CustomEmail1 = new CustomEmail();
            TableLayoutPanel1.SuspendLayout();
            TabControl1.SuspendLayout();
            tp_Templates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTemplates).BeginInit();
            tp_Custom.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 1, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(175, 267);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.None;
            OK_Button.Location = new System.Drawing.Point(76, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new System.Drawing.Size(67, 23);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = AnchorStyles.None;
            Cancel_Button.Location = new System.Drawing.Point(3, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new System.Drawing.Size(67, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tp_Templates);
            TabControl1.Controls.Add(tp_Custom);
            TabControl1.Dock = DockStyle.Top;
            TabControl1.Location = new System.Drawing.Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new System.Drawing.Size(333, 261);
            TabControl1.TabIndex = 1;
            // 
            // tp_Templates
            // 
            tp_Templates.Controls.Add(ts_Templates);
            tp_Templates.Location = new System.Drawing.Point(4, 22);
            tp_Templates.Name = "tp_Templates";
            tp_Templates.Size = new System.Drawing.Size(325, 235);
            tp_Templates.TabIndex = 2;
            tp_Templates.Text = "Templates";
            tp_Templates.UseVisualStyleBackColor = true;
            // 
            // ts_Templates
            // 
            ts_Templates.Dock = DockStyle.Fill;
            ts_Templates.Location = new System.Drawing.Point(0, 0);
            ts_Templates.MinimumSize = new System.Drawing.Size(200, 200);
            ts_Templates.Name = "ts_Templates";
            ts_Templates.Padding = new Padding(5);
            ts_Templates.Size = new System.Drawing.Size(325, 235);
            ts_Templates.TabIndex = 0;
            // 
            // bsTemplates
            // 
            bsTemplates.DataSource = typeof(Types.TemplateList);
            // 
            // tp_Custom
            // 
            tp_Custom.Controls.Add(CustomEmail1);
            tp_Custom.Location = new System.Drawing.Point(4, 22);
            tp_Custom.Name = "tp_Custom";
            tp_Custom.Padding = new Padding(3);
            tp_Custom.Size = new System.Drawing.Size(325, 235);
            tp_Custom.TabIndex = 1;
            tp_Custom.Text = "Custom Email";
            tp_Custom.UseVisualStyleBackColor = true;
            // 
            // CustomEmail1
            // 
            CustomEmail1.AutoSize = true;
            CustomEmail1.Body = "Email Body...";
            CustomEmail1.Dock = DockStyle.Fill;
            CustomEmail1.Location = new System.Drawing.Point(3, 3);
            CustomEmail1.Margin = new Padding(0);
            CustomEmail1.MaximumSize = new System.Drawing.Size(400, 300);
            CustomEmail1.MinimumSize = new System.Drawing.Size(200, 200);
            CustomEmail1.Name = "CustomEmail1";
            CustomEmail1.Size = new System.Drawing.Size(319, 229);
            CustomEmail1.Subject = "Subject...";
            CustomEmail1.TabIndex = 0;
            // 
            // EmailBodySelection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(333, 308);
            Controls.Add(TabControl1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmailBodySelection";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Email Body";
            TopMost = true;
            TableLayoutPanel1.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            tp_Templates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsTemplates).EndInit();
            tp_Custom.ResumeLayout(false);
            tp_Custom.PerformLayout();
            Load += new EventHandler(Reload);
            ResumeLayout(false);

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal TabControl TabControl1;
        internal BindingSource bsTemplates;
        internal TabPage tp_Custom;
        internal TabPage tp_Templates;
        internal TemplateSelector ts_Templates;
        internal CustomEmail CustomEmail1;
    }
}