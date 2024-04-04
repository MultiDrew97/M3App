using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SettingsForm : Form
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
                    cts.Dispose();
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            btn_Save = new Button();
            btn_Save.Click += new EventHandler(Btn_Save_Click);
            btn_Default = new Button();
            btn_Default.Click += new EventHandler(Btn_Default_Click);
            tc_Settings = new TabControl();
            tp_Fonts = new TabPage();
            lbl_Bold = new Label();
            btn_ChangeFont = new Button();
            btn_ChangeFont.Click += new EventHandler(Btn_SelectFont_Click);
            lbl_CurrentFont = new Label();
            lbl_FontSize = new Label();
            tp_LinkedAccounts = new TabPage();
            lbl_CurrentGmail = new Label();
            lbl_CurrentDrive = new Label();
            btn_Gmail = new Button();
            btn_Gmail.Click += new EventHandler(Btn_Gmail_Click);
            btn_GoogleDrive = new Button();
            btn_GoogleDrive.Click += new EventHandler(Btn_GoogleDrive_Click);
            fd_FontSelector = new FontDialog();
            bw_Settings = new System.ComponentModel.BackgroundWorker();
            bw_Settings.DoWork += new System.ComponentModel.DoWorkEventHandler(Bw_Settings_DoWork);
            bw_Service = new System.ComponentModel.BackgroundWorker();
            bw_Service.DoWork += new System.ComponentModel.DoWorkEventHandler(Bw_Service_DoWork);
            bw_CheckServices = new System.ComponentModel.BackgroundWorker();
            bw_CheckServices.DoWork += new System.ComponentModel.DoWorkEventHandler(Bw_CheckServices_DoWork);
            tc_Settings.SuspendLayout();
            tp_Fonts.SuspendLayout();
            tp_LinkedAccounts.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.AutoSize = true;
            btn_Save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Save.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Save.Location = new Point(325, 382);
            btn_Save.Margin = new Padding(6);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(72, 36);
            btn_Save.TabIndex = 0;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Default
            // 
            btn_Default.AutoSize = true;
            btn_Default.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Default.DialogResult = DialogResult.Cancel;
            btn_Default.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Default.Location = new Point(39, 382);
            btn_Default.Margin = new Padding(6);
            btn_Default.Name = "btn_Default";
            btn_Default.Size = new Size(208, 36);
            btn_Default.TabIndex = 1;
            btn_Default.Text = "Restore to Defaults";
            btn_Default.UseVisualStyleBackColor = true;
            // 
            // tc_Settings
            // 
            tc_Settings.Controls.Add(tp_Fonts);
            tc_Settings.Controls.Add(tp_LinkedAccounts);
            tc_Settings.Dock = DockStyle.Top;
            tc_Settings.HotTrack = true;
            tc_Settings.Location = new Point(0, 0);
            tc_Settings.Name = "tc_Settings";
            tc_Settings.SelectedIndex = 0;
            tc_Settings.Size = new Size(484, 330);
            tc_Settings.TabIndex = 2;
            // 
            // tp_Fonts
            // 
            tp_Fonts.BackColor = Color.Transparent;
            tp_Fonts.Controls.Add(lbl_Bold);
            tp_Fonts.Controls.Add(btn_ChangeFont);
            tp_Fonts.Controls.Add(lbl_CurrentFont);
            tp_Fonts.Controls.Add(lbl_FontSize);
            tp_Fonts.Location = new Point(4, 34);
            tp_Fonts.Name = "tp_Fonts";
            tp_Fonts.Padding = new Padding(3);
            tp_Fonts.Size = new Size(476, 292);
            tp_Fonts.TabIndex = 0;
            tp_Fonts.Text = "Font Selection";
            // 
            // lbl_Bold
            // 
            lbl_Bold.AutoSize = true;
            lbl_Bold.Location = new Point(316, 131);
            lbl_Bold.Name = "lbl_Bold";
            lbl_Bold.Size = new Size(92, 26);
            lbl_Bold.TabIndex = 5;
            lbl_Bold.Text = "Bolded?";
            // 
            // btn_ChangeFont
            // 
            btn_ChangeFont.Anchor = AnchorStyles.Right;
            btn_ChangeFont.AutoSize = true;
            btn_ChangeFont.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ChangeFont.Location = new Point(122, 225);
            btn_ChangeFont.Margin = new Padding(0);
            btn_ChangeFont.Name = "btn_ChangeFont";
            btn_ChangeFont.Size = new Size(232, 36);
            btn_ChangeFont.TabIndex = 4;
            btn_ChangeFont.Text = "Change Font Settings";
            btn_ChangeFont.TextAlign = ContentAlignment.TopCenter;
            btn_ChangeFont.UseVisualStyleBackColor = true;
            // 
            // lbl_CurrentFont
            // 
            lbl_CurrentFont.AutoSize = true;
            lbl_CurrentFont.Location = new Point(69, 42);
            lbl_CurrentFont.Name = "lbl_CurrentFont";
            lbl_CurrentFont.Size = new Size(61, 26);
            lbl_CurrentFont.TabIndex = 2;
            lbl_CurrentFont.Text = "Font:";
            // 
            // lbl_FontSize
            // 
            lbl_FontSize.AutoSize = true;
            lbl_FontSize.Location = new Point(69, 131);
            lbl_FontSize.Name = "lbl_FontSize";
            lbl_FontSize.Size = new Size(110, 26);
            lbl_FontSize.TabIndex = 1;
            lbl_FontSize.Text = "Font Size:";
            // 
            // tp_LinkedAccounts
            // 
            tp_LinkedAccounts.BackColor = Color.Transparent;
            tp_LinkedAccounts.Controls.Add(lbl_CurrentGmail);
            tp_LinkedAccounts.Controls.Add(lbl_CurrentDrive);
            tp_LinkedAccounts.Controls.Add(btn_Gmail);
            tp_LinkedAccounts.Controls.Add(btn_GoogleDrive);
            tp_LinkedAccounts.Location = new Point(4, 34);
            tp_LinkedAccounts.Name = "tp_LinkedAccounts";
            tp_LinkedAccounts.Padding = new Padding(3);
            tp_LinkedAccounts.Size = new Size(476, 292);
            tp_LinkedAccounts.TabIndex = 1;
            tp_LinkedAccounts.Text = "Linked Accounts";
            // 
            // lbl_CurrentGmail
            // 
            lbl_CurrentGmail.AutoSize = true;
            lbl_CurrentGmail.Location = new Point(36, 198);
            lbl_CurrentGmail.Name = "lbl_CurrentGmail";
            lbl_CurrentGmail.Size = new Size(142, 26);
            lbl_CurrentGmail.TabIndex = 3;
            lbl_CurrentGmail.Text = "Current User:";
            // 
            // lbl_CurrentDrive
            // 
            lbl_CurrentDrive.AutoSize = true;
            lbl_CurrentDrive.Location = new Point(31, 32);
            lbl_CurrentDrive.Name = "lbl_CurrentDrive";
            lbl_CurrentDrive.Size = new Size(142, 26);
            lbl_CurrentDrive.TabIndex = 2;
            lbl_CurrentDrive.Text = "Current User:";
            // 
            // btn_Gmail
            // 
            btn_Gmail.AutoSize = true;
            btn_Gmail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Gmail.Location = new Point(36, 227);
            btn_Gmail.Name = "btn_Gmail";
            btn_Gmail.Size = new Size(126, 36);
            btn_Gmail.TabIndex = 1;
            btn_Gmail.Text = "Link Gmail";
            btn_Gmail.UseVisualStyleBackColor = true;
            // 
            // btn_GoogleDrive
            // 
            btn_GoogleDrive.AutoSize = true;
            btn_GoogleDrive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_GoogleDrive.Location = new Point(36, 75);
            btn_GoogleDrive.Name = "btn_GoogleDrive";
            btn_GoogleDrive.Size = new Size(195, 36);
            btn_GoogleDrive.TabIndex = 0;
            btn_GoogleDrive.Text = "Link Google Drive";
            btn_GoogleDrive.UseVisualStyleBackColor = true;
            // 
            // fd_FontSelector
            // 
            fd_FontSelector.AllowVerticalFonts = false;
            fd_FontSelector.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            fd_FontSelector.FontMustExist = true;
            fd_FontSelector.MaxSize = 24;
            fd_FontSelector.MinSize = 12;
            fd_FontSelector.ScriptsOnly = true;
            // 
            // bw_Settings
            // 
            // 
            // bw_Service
            // 
            bw_Service.WorkerSupportsCancellation = true;
            // 
            // bw_CheckServices
            // 
            // 
            // SettingsForm
            // 
            AcceptButton = btn_Save;
            AutoScaleDimensions = new SizeF(12.0f, 25.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(tc_Settings);
            Controls.Add(btn_Default);
            Controls.Add(btn_Save);
            Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MaximumSize = new Size(800, 800);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Ministry Manager";
            tc_Settings.ResumeLayout(false);
            tp_Fonts.ResumeLayout(false);
            tp_Fonts.PerformLayout();
            tp_LinkedAccounts.ResumeLayout(false);
            tp_LinkedAccounts.PerformLayout();
            Load += new EventHandler(Frm_Settings_Load);
            Closed += new EventHandler(Frm_Settings_Closed);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btn_Save;
        internal Button btn_Default;
        internal TabControl tc_Settings;
        internal TabPage tp_Fonts;
        internal TabPage tp_LinkedAccounts;
        internal FontDialog fd_FontSelector;
        internal Button btn_ChangeFont;
        internal Label lbl_CurrentFont;
        internal Label lbl_FontSize;
        internal System.ComponentModel.BackgroundWorker bw_Settings;
        internal Button btn_Gmail;
        internal Button btn_GoogleDrive;
        internal Label lbl_CurrentDrive;
        internal Label lbl_CurrentGmail;
        internal System.ComponentModel.BackgroundWorker bw_Service;
        internal System.ComponentModel.BackgroundWorker bw_CheckServices;
        internal Label lbl_Bold;
    }
}