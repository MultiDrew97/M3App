using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomEmail : System.Windows.Forms.UserControl
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
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.sc_CustomComp = new System.Windows.Forms.SplitContainer();
            this.tsc_BodyContainer = new System.Windows.Forms.ToolStripContainer();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.ts_TextButtons = new System.Windows.Forms.ToolStrip();
            this.btn_Bold = new System.Windows.Forms.ToolStripButton();
            this.btn_Underline = new System.Windows.Forms.ToolStripButton();
            this.btn_Italics = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ChangeFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fd_Font = new System.Windows.Forms.FontDialog();
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.Italics = new System.Windows.Forms.ToolStripMenuItem();
            this.ShortcutKeyStrip = new System.Windows.Forms.MenuStrip();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sc_CustomComp)).BeginInit();
            this.sc_CustomComp.Panel1.SuspendLayout();
            this.sc_CustomComp.Panel2.SuspendLayout();
            this.sc_CustomComp.SuspendLayout();
            this.tsc_BodyContainer.ContentPanel.SuspendLayout();
            this.tsc_BodyContainer.TopToolStripPanel.SuspendLayout();
            this.tsc_BodyContainer.SuspendLayout();
            this.ts_TextButtons.SuspendLayout();
            this.ShortcutKeyStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Subject
            // 
            this.txt_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Subject.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Subject.Location = new System.Drawing.Point(10, 10);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(380, 20);
            this.txt_Subject.TabIndex = 0;
            this.txt_Subject.Text = "Subject...";
            this.txt_Subject.GotFocus += new System.EventHandler(this.TextGotFocus);
            this.txt_Subject.LostFocus += new System.EventHandler(this.TextLostFocus);
            // 
            // sc_CustomComp
            // 
            this.sc_CustomComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_CustomComp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc_CustomComp.IsSplitterFixed = true;
            this.sc_CustomComp.Location = new System.Drawing.Point(0, 0);
            this.sc_CustomComp.Name = "sc_CustomComp";
            this.sc_CustomComp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_CustomComp.Panel1
            // 
            this.sc_CustomComp.Panel1.Controls.Add(this.txt_Subject);
            this.sc_CustomComp.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.sc_CustomComp.Panel1MinSize = 40;
            // 
            // sc_CustomComp.Panel2
            // 
            this.sc_CustomComp.Panel2.Controls.Add(this.tsc_BodyContainer);
            this.sc_CustomComp.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.sc_CustomComp.Size = new System.Drawing.Size(400, 300);
            this.sc_CustomComp.SplitterDistance = 40;
            this.sc_CustomComp.SplitterIncrement = 5;
            this.sc_CustomComp.TabIndex = 0;
            this.sc_CustomComp.TabStop = false;
            // 
            // tsc_BodyContainer
            // 
            this.tsc_BodyContainer.BottomToolStripPanelVisible = false;
            // 
            // tsc_BodyContainer.ContentPanel
            // 
            this.tsc_BodyContainer.ContentPanel.Controls.Add(this.txt_Body);
            this.tsc_BodyContainer.ContentPanel.Controls.Add(this.rtb_Body);
            this.tsc_BodyContainer.ContentPanel.Size = new System.Drawing.Size(380, 236);
            this.tsc_BodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_BodyContainer.LeftToolStripPanelVisible = false;
            this.tsc_BodyContainer.Location = new System.Drawing.Point(10, 10);
            this.tsc_BodyContainer.Name = "tsc_BodyContainer";
            this.tsc_BodyContainer.RightToolStripPanelVisible = false;
            this.tsc_BodyContainer.Size = new System.Drawing.Size(380, 236);
            this.tsc_BodyContainer.TabIndex = 0;
            this.tsc_BodyContainer.Text = "ToolStripContainer2";
            // 
            // tsc_BodyContainer.TopToolStripPanel
            // 
            this.tsc_BodyContainer.TopToolStripPanel.Controls.Add(this.ts_TextButtons);
            this.tsc_BodyContainer.TopToolStripPanel.Enabled = false;
            this.tsc_BodyContainer.TopToolStripPanelVisible = false;
            // 
            // txt_Body
            // 
            this.txt_Body.AcceptsReturn = true;
            this.txt_Body.AcceptsTab = true;
            this.txt_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Body.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Body.Location = new System.Drawing.Point(0, 0);
            this.txt_Body.Margin = new System.Windows.Forms.Padding(25, 26, 25, 26);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(380, 236);
            this.txt_Body.TabIndex = 0;
            this.txt_Body.Text = "Email Body...";
            // 
            // rtb_Body
            // 

            this.rtb_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Body.Location = new System.Drawing.Point(0, 0);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.Size = new System.Drawing.Size(380, 236);
            this.rtb_Body.TabIndex = 1;
            this.rtb_Body.TabStop = false;
            this.rtb_Body.Text = "";
            this.rtb_Body.GotFocus += new System.EventHandler(this.TextGotFocus);
            this.rtb_Body.LostFocus += new System.EventHandler(this.TextLostFocus);
            // 
            // ts_TextButtons
            // 
            this.ts_TextButtons.AutoSize = false;
            this.ts_TextButtons.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_TextButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_TextButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Bold,
            this.btn_Underline,
            this.btn_Italics,
            this.ToolStripSeparator1,
            this.btn_ChangeFont,
            this.toolStripSeparator2});
            this.ts_TextButtons.Location = new System.Drawing.Point(6, 0);
            this.ts_TextButtons.Name = "ts_TextButtons";
            this.ts_TextButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_TextButtons.Size = new System.Drawing.Size(132, 24);
            this.ts_TextButtons.TabIndex = 0;
            // 
            // btn_Bold
            // 
            this.btn_Bold.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bold.CheckOnClick = true;
            this.btn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Bold.Image = global::SPPBC.M3Tools.My.Resources.Resources.BoldOption;
            this.btn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(23, 21);
            this.btn_Bold.Text = "Bold";
            this.btn_Bold.Click += new System.EventHandler(this.BoldText);
            // 
            // btn_Underline
            // 
            this.btn_Underline.CheckOnClick = true;
            this.btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Underline.Image = global::SPPBC.M3Tools.My.Resources.Resources.UnderlineOption;
            this.btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(23, 21);
            this.btn_Underline.Text = "Underline";
            this.btn_Underline.Click += new System.EventHandler(this.UnderlineText);
            // 
            // btn_Italics
            // 
            this.btn_Italics.CheckOnClick = true;
            this.btn_Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italics.Image = global::SPPBC.M3Tools.My.Resources.Resources.ItalicOption;
            this.btn_Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italics.Name = "btn_Italics";
            this.btn_Italics.Size = new System.Drawing.Size(23, 21);
            this.btn_Italics.Text = "Italics";
            this.btn_Italics.Click += new System.EventHandler(this.ItalicizeText);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // btn_ChangeFont
            // 
            this.btn_ChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ChangeFont.Image = global::SPPBC.M3Tools.My.Resources.Resources.FontOption;
            this.btn_ChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ChangeFont.Name = "btn_ChangeFont";
            this.btn_ChangeFont.Size = new System.Drawing.Size(23, 21);
            this.btn_ChangeFont.Text = "Change Font";
            this.btn_ChangeFont.Click += new System.EventHandler(this.ChangeFont);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // fd_Font
            // 
            this.fd_Font.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Bold
            // 
            this.Bold.Name = "Bold";
            this.Bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.Bold.Size = new System.Drawing.Size(43, 22);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.BoldShortcut);
            // 
            // Underline
            // 
            this.Underline.Name = "Underline";
            this.Underline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.Underline.Size = new System.Drawing.Size(70, 22);
            this.Underline.Text = "Underline";
            this.Underline.Click += new System.EventHandler(this.UnderlineText);
            // 
            // Italics
            // 
            this.Italics.Name = "Italics";
            this.Italics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Italics.Size = new System.Drawing.Size(49, 22);
            this.Italics.Text = "Italics";
            this.Italics.Click += new System.EventHandler(this.ItalicizeText);
            // 
            // ShortcutKeyStrip
            // 
            this.ShortcutKeyStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ShortcutKeyStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ShortcutKeyStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Underline,
            this.Italics});
            this.ShortcutKeyStrip.Location = new System.Drawing.Point(200, 3);
            this.ShortcutKeyStrip.Name = "ShortcutKeyStrip";
            this.ShortcutKeyStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.ShortcutKeyStrip.Size = new System.Drawing.Size(167, 24);
            this.ShortcutKeyStrip.TabIndex = 1;
            this.ShortcutKeyStrip.Text = "MenuStrip1";
            this.ShortcutKeyStrip.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Enabled = false;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(380, 212);
            // 
            // CustomEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.sc_CustomComp);
            this.Controls.Add(this.ShortcutKeyStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "CustomEmail";
            this.Size = new System.Drawing.Size(400, 300);
            this.Load += new System.EventHandler(this.Loading);
            this.sc_CustomComp.Panel1.ResumeLayout(false);
            this.sc_CustomComp.Panel1.PerformLayout();
            this.sc_CustomComp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_CustomComp)).EndInit();
            this.sc_CustomComp.ResumeLayout(false);
            this.tsc_BodyContainer.ContentPanel.ResumeLayout(false);
            this.tsc_BodyContainer.ContentPanel.PerformLayout();
            this.tsc_BodyContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsc_BodyContainer.ResumeLayout(false);
            this.tsc_BodyContainer.PerformLayout();
            this.ts_TextButtons.ResumeLayout(false);
            this.ts_TextButtons.PerformLayout();
            this.ShortcutKeyStrip.ResumeLayout(false);
            this.ShortcutKeyStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		internal System.Windows.Forms.TextBox txt_Subject;
		internal System.Windows.Forms.SplitContainer sc_CustomComp;
		internal System.Windows.Forms.ToolStripContainer tsc_BodyContainer;
		internal System.Windows.Forms.TextBox txt_Body;
		internal System.Windows.Forms.RichTextBox rtb_Body;
		internal System.Windows.Forms.ToolStrip ts_TextButtons;
		internal System.Windows.Forms.ToolStripButton btn_Bold;
		internal System.Windows.Forms.ToolStripButton btn_Underline;
		internal System.Windows.Forms.ToolStripButton btn_Italics;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripButton btn_ChangeFont;
		internal System.Windows.Forms.FontDialog fd_Font;
		internal System.Windows.Forms.ToolStripMenuItem Bold;
		internal System.Windows.Forms.ToolStripMenuItem Underline;
		internal System.Windows.Forms.ToolStripMenuItem Italics;
		internal System.Windows.Forms.MenuStrip ShortcutKeyStrip;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
