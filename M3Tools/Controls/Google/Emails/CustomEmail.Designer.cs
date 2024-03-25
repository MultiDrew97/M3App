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
            tsc_BodyContainer = new System.Windows.Forms.ToolStripContainer();
            txt_Body = new System.Windows.Forms.TextBox();
            txt_Body.GotFocus += new EventHandler(TextGotFocus);
            txt_Body.LostFocus += new EventHandler(TextLostFocus);
            rtb_Body = new System.Windows.Forms.RichTextBox();
            ts_TextButtons = new System.Windows.Forms.ToolStrip();
            btn_Bold = new System.Windows.Forms.ToolStripButton();
            btn_Bold.Click += new EventHandler(BoldText);
            btn_Underline = new System.Windows.Forms.ToolStripButton();
            btn_Underline.Click += new EventHandler(UnderlineText);
            btn_Italics = new System.Windows.Forms.ToolStripButton();
            btn_Italics.Click += new EventHandler(ItalicizeText);
            ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btn_ChangeFont = new System.Windows.Forms.ToolStripButton();
            btn_ChangeFont.Click += new EventHandler(ChangeFont);
            ShortcutKeyStrip = new System.Windows.Forms.MenuStrip();
            Bold = new System.Windows.Forms.ToolStripMenuItem();
            Bold.Click += new EventHandler(BoldText);
            Bold.Click += new EventHandler(BoldShortcut);
            Underline = new System.Windows.Forms.ToolStripMenuItem();
            Underline.Click += new EventHandler(BoldShortcut);
            Underline.Click += new EventHandler(UnderlineText);
            Italics = new System.Windows.Forms.ToolStripMenuItem();
            Italics.Click += new EventHandler(BoldShortcut);
            Italics.Click += new EventHandler(ItalicizeText);
            fd_Font = new System.Windows.Forms.FontDialog();
            sc_CustomComp = new System.Windows.Forms.SplitContainer();
            txt_Subject = new System.Windows.Forms.TextBox();
            txt_Subject.GotFocus += new EventHandler(TextGotFocus);
            txt_Subject.LostFocus += new EventHandler(TextLostFocus);
            tsc_BodyContainer.ContentPanel.SuspendLayout();
            tsc_BodyContainer.TopToolStripPanel.SuspendLayout();
            tsc_BodyContainer.SuspendLayout();
            ts_TextButtons.SuspendLayout();
            ShortcutKeyStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc_CustomComp).BeginInit();
            sc_CustomComp.Panel1.SuspendLayout();
            sc_CustomComp.Panel2.SuspendLayout();
            sc_CustomComp.SuspendLayout();
            SuspendLayout();
            // 
            // tsc_BodyContainer
            // 
            tsc_BodyContainer.BottomToolStripPanelVisible = false;
            // 
            // tsc_BodyContainer.ContentPanel
            // 
            tsc_BodyContainer.ContentPanel.Controls.Add(txt_Body);
            tsc_BodyContainer.ContentPanel.Controls.Add(rtb_Body);
            tsc_BodyContainer.ContentPanel.Size = new System.Drawing.Size(380, 236);
            tsc_BodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            tsc_BodyContainer.LeftToolStripPanelVisible = false;
            tsc_BodyContainer.Location = new System.Drawing.Point(10, 10);
            tsc_BodyContainer.Name = "tsc_BodyContainer";
            tsc_BodyContainer.RightToolStripPanelVisible = false;
            tsc_BodyContainer.Size = new System.Drawing.Size(380, 236);
            tsc_BodyContainer.TabIndex = 0;
            tsc_BodyContainer.Text = "ToolStripContainer2";
            // 
            // tsc_BodyContainer.TopToolStripPanel
            // 
            tsc_BodyContainer.TopToolStripPanel.Controls.Add(ts_TextButtons);
            tsc_BodyContainer.TopToolStripPanel.Enabled = false;
            tsc_BodyContainer.TopToolStripPanelVisible = false;
            // 
            // txt_Body
            // 
            txt_Body.AcceptsReturn = true;
            txt_Body.AcceptsTab = true;
            txt_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Body.ForeColor = System.Drawing.SystemColors.ControlDark;
            txt_Body.Location = new System.Drawing.Point(0, 0);
            txt_Body.Margin = new System.Windows.Forms.Padding(25, 26, 25, 26);
            txt_Body.Multiline = true;
            txt_Body.Name = "txt_Body";
            txt_Body.Size = new System.Drawing.Size(380, 236);
            txt_Body.TabIndex = 0;
            txt_Body.Text = "Email Body...";
            // 
            // rtb_Body
            // 
            rtb_Body.Location = new System.Drawing.Point(96, 3);
            rtb_Body.Name = "rtb_Body";
            rtb_Body.Size = new System.Drawing.Size(281, 251);
            rtb_Body.TabIndex = 1;
            rtb_Body.TabStop = false;
            rtb_Body.Text = "";
            // 
            // ts_TextButtons
            // 
            ts_TextButtons.AutoSize = false;
            ts_TextButtons.Dock = System.Windows.Forms.DockStyle.None;
            ts_TextButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts_TextButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_Bold, btn_Underline, btn_Italics, ToolStripSeparator1, btn_ChangeFont });
            ts_TextButtons.Location = new System.Drawing.Point(6, 0);
            ts_TextButtons.Name = "ts_TextButtons";
            ts_TextButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            ts_TextButtons.Size = new System.Drawing.Size(132, 24);
            ts_TextButtons.TabIndex = 0;
            // 
            // btn_Bold
            // 
            btn_Bold.BackColor = System.Drawing.Color.Transparent;
            btn_Bold.CheckOnClick = true;
            btn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_Bold.Image = My.Resources.Resources.BoldOption;
            btn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_Bold.Name = "btn_Bold";
            btn_Bold.Size = new System.Drawing.Size(23, 21);
            btn_Bold.Text = "Bold";
            // 
            // btn_Underline
            // 
            btn_Underline.CheckOnClick = true;
            btn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_Underline.Image = My.Resources.Resources.UnderlineOption;
            btn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_Underline.Name = "btn_Underline";
            btn_Underline.Size = new System.Drawing.Size(23, 21);
            btn_Underline.Text = "Underline";
            // 
            // btn_Italics
            // 
            btn_Italics.CheckOnClick = true;
            btn_Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_Italics.Image = My.Resources.Resources.ItalicOption;
            btn_Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_Italics.Name = "btn_Italics";
            btn_Italics.Size = new System.Drawing.Size(23, 21);
            btn_Italics.Text = "Italics";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // btn_ChangeFont
            // 
            btn_ChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_ChangeFont.Image = My.Resources.Resources.FontOption;
            btn_ChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_ChangeFont.Name = "btn_ChangeFont";
            btn_ChangeFont.Size = new System.Drawing.Size(23, 21);
            btn_ChangeFont.Text = "Change Font";
            // 
            // ShortcutKeyStrip
            // 
            ShortcutKeyStrip.Dock = System.Windows.Forms.DockStyle.None;
            ShortcutKeyStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            ShortcutKeyStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Bold, Underline, Italics });
            ShortcutKeyStrip.Location = new System.Drawing.Point(200, 3);
            ShortcutKeyStrip.Name = "ShortcutKeyStrip";
            ShortcutKeyStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            ShortcutKeyStrip.Size = new System.Drawing.Size(167, 24);
            ShortcutKeyStrip.TabIndex = 1;
            ShortcutKeyStrip.Text = "MenuStrip1";
            ShortcutKeyStrip.Visible = false;
            // 
            // Bold
            // 
            Bold.Name = "Bold";
            Bold.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
            Bold.Size = new System.Drawing.Size(43, 22);
            Bold.Text = "Bold";
            // 
            // Underline
            // 
            Underline.Name = "Underline";
            Underline.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U;
            Underline.Size = new System.Drawing.Size(70, 22);
            Underline.Text = "Underline";
            // 
            // Italics
            // 
            Italics.Name = "Italics";
            Italics.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I;
            Italics.Size = new System.Drawing.Size(49, 22);
            Italics.Text = "Italics";
            // 
            // fd_Font
            // 
            fd_Font.Font = new System.Drawing.Font("Calibri", 12.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            // 
            // sc_CustomComp
            // 
            sc_CustomComp.Dock = System.Windows.Forms.DockStyle.Fill;
            sc_CustomComp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            sc_CustomComp.IsSplitterFixed = true;
            sc_CustomComp.Location = new System.Drawing.Point(0, 0);
            sc_CustomComp.Name = "sc_CustomComp";
            sc_CustomComp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_CustomComp.Panel1
            // 
            sc_CustomComp.Panel1.Controls.Add(txt_Subject);
            sc_CustomComp.Panel1.Padding = new System.Windows.Forms.Padding(10);
            sc_CustomComp.Panel1MinSize = 40;
            // 
            // sc_CustomComp.Panel2
            // 
            sc_CustomComp.Panel2.Controls.Add(tsc_BodyContainer);
            sc_CustomComp.Panel2.Padding = new System.Windows.Forms.Padding(10);
            sc_CustomComp.Size = new System.Drawing.Size(400, 300);
            sc_CustomComp.SplitterDistance = 40;
            sc_CustomComp.SplitterIncrement = 5;
            sc_CustomComp.TabIndex = 0;
            sc_CustomComp.TabStop = false;
            // 
            // txt_Subject
            // 
            txt_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Subject.ForeColor = System.Drawing.SystemColors.ControlDark;
            txt_Subject.Location = new System.Drawing.Point(10, 10);
            txt_Subject.Name = "txt_Subject";
            txt_Subject.Size = new System.Drawing.Size(380, 20);
            txt_Subject.TabIndex = 0;
            txt_Subject.Text = "Subject...";
            // 
            // CustomEmail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(sc_CustomComp);
            Controls.Add(ShortcutKeyStrip);
            Margin = new System.Windows.Forms.Padding(0);
            MaximumSize = new System.Drawing.Size(400, 300);
            MinimumSize = new System.Drawing.Size(400, 300);
            Name = "CustomEmail";
            Size = new System.Drawing.Size(400, 300);
            tsc_BodyContainer.ContentPanel.ResumeLayout(false);
            tsc_BodyContainer.ContentPanel.PerformLayout();
            tsc_BodyContainer.TopToolStripPanel.ResumeLayout(false);
            tsc_BodyContainer.ResumeLayout(false);
            tsc_BodyContainer.PerformLayout();
            ts_TextButtons.ResumeLayout(false);
            ts_TextButtons.PerformLayout();
            ShortcutKeyStrip.ResumeLayout(false);
            ShortcutKeyStrip.PerformLayout();
            sc_CustomComp.Panel1.ResumeLayout(false);
            sc_CustomComp.Panel1.PerformLayout();
            sc_CustomComp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_CustomComp).EndInit();
            sc_CustomComp.ResumeLayout(false);
            Load += new EventHandler(Loading);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.ToolStripContainer tsc_BodyContainer;
        internal System.Windows.Forms.FontDialog fd_Font;
        internal System.Windows.Forms.ToolStrip ts_TextButtons;
        internal System.Windows.Forms.ToolStripButton btn_Bold;
        internal System.Windows.Forms.ToolStripButton btn_Underline;
        internal System.Windows.Forms.ToolStripButton btn_Italics;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btn_ChangeFont;
        internal System.Windows.Forms.MenuStrip ShortcutKeyStrip;
        internal System.Windows.Forms.ToolStripMenuItem Bold;
        internal System.Windows.Forms.ToolStripMenuItem Underline;
        internal System.Windows.Forms.ToolStripMenuItem Italics;
        internal System.Windows.Forms.TextBox txt_Body;
        internal System.Windows.Forms.SplitContainer sc_CustomComp;
        internal System.Windows.Forms.RichTextBox rtb_Body;
        internal System.Windows.Forms.TextBox txt_Subject;
    }
}