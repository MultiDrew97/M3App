using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools;
using SPPBC.M3Tools.Database;

namespace M3App
{

    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SendEmailsDialog : Form
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
            btn_Send = new Button();
            btn_Send.Click += new EventHandler(BeginSending);
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            tc_EmailTypes = new TabControl();
            tp_GDrive = new TabPage();
            gdt_Files = new DriveTree();
            tp_LocalFiles = new TabPage();
            fu_Receipts = new FileUpload();
            bw_GatherFiles = new System.ComponentModel.BackgroundWorker();
            bw_GatherFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(GatherFiles);
            bw_GatherFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(FilesGathered);
            bw_PrepEmails = new System.ComponentModel.BackgroundWorker();
            bw_PrepEmails.DoWork += new System.ComponentModel.DoWorkEventHandler(PrepEmails);
            bw_PrepEmails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(EmailsPrepped);
            bw_GatherReceipients = new System.ComponentModel.BackgroundWorker();
            bw_GatherReceipients.DoWork += new System.ComponentModel.DoWorkEventHandler(GatherReceipients);
            bw_GatherReceipients.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(ReceipientsGathered);
            bw_SendEmails = new System.ComponentModel.BackgroundWorker();
            bw_SendEmails.DoWork += new System.ComponentModel.DoWorkEventHandler(SendEmails);
            bw_SendEmails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(EmailsDone);
            ToolStripContainer1 = new ToolStripContainer();
            ss_StatusBar = new StatusStrip();
            tsl_Status = new ToolStripStatusLabel();
            tsp_Progress = new ToolStripProgressBar();
            gmt_Gmail = new SPPBC.M3Tools.GTools.GmailTool(components);
            rsd_Selection = new RecipientSelectionDialog(components);
            dbListeners = new ListenerDatabase(components);
            TableLayoutPanel1.SuspendLayout();
            tc_EmailTypes.SuspendLayout();
            tp_GDrive.SuspendLayout();
            tp_LocalFiles.SuspendLayout();
            ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
            ToolStripContainer1.ContentPanel.SuspendLayout();
            ToolStripContainer1.SuspendLayout();
            ss_StatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Send, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new Point(253, 323);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Send
            // 
            btn_Send.Anchor = AnchorStyles.None;
            btn_Send.Location = new Point(76, 3);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(67, 23);
            btn_Send.TabIndex = 0;
            btn_Send.Text = "Send";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.None;
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // tc_EmailTypes
            // 
            tc_EmailTypes.Controls.Add(tp_GDrive);
            tc_EmailTypes.Controls.Add(tp_LocalFiles);
            tc_EmailTypes.Dock = DockStyle.Fill;
            tc_EmailTypes.Location = new Point(0, 0);
            tc_EmailTypes.Name = "tc_EmailTypes";
            tc_EmailTypes.SelectedIndex = 0;
            tc_EmailTypes.Size = new Size(411, 298);
            tc_EmailTypes.TabIndex = 0;
            // 
            // tp_GDrive
            // 
            tp_GDrive.Controls.Add(gdt_Files);
            tp_GDrive.Location = new Point(4, 22);
            tp_GDrive.Name = "tp_GDrive";
            tp_GDrive.Size = new Size(403, 272);
            tp_GDrive.TabIndex = 0;
            tp_GDrive.Text = "Google Drive";
            tp_GDrive.UseVisualStyleBackColor = true;
            // 
            // gdt_Files
            // 
            gdt_Files.DataBindings.Add(new Binding("Username", global::M3App.My.Settings.Default, "Username", true, DataSourceUpdateMode.OnPropertyChanged));
            gdt_Files.Dock = DockStyle.Fill;
            gdt_Files.Location = new Point(0, 0);
            gdt_Files.Name = "gdt_Files";
            gdt_Files.Size = new Size(403, 272);
            gdt_Files.TabIndex = 4;
            gdt_Files.Username = global::M3App.My.Settings.Default.Username;
            // 
            // tp_LocalFiles
            // 
            tp_LocalFiles.Controls.Add(fu_Receipts);
            tp_LocalFiles.Location = new Point(4, 22);
            tp_LocalFiles.Name = "tp_LocalFiles";
            tp_LocalFiles.Size = new Size(403, 272);
            tp_LocalFiles.TabIndex = 0;
            tp_LocalFiles.Text = "Local Files";
            tp_LocalFiles.UseVisualStyleBackColor = true;
            // 
            // fu_Receipts
            // 
            fu_Receipts.Dock = DockStyle.Fill;
            fu_Receipts.Location = new Point(0, 0);
            fu_Receipts.Name = "fu_Receipts";
            fu_Receipts.Size = new Size(403, 272);
            fu_Receipts.TabIndex = 1;
            // 
            // bw_GatherFiles
            // 
            // 
            // bw_PrepEmails
            // 
            // 
            // bw_GatherReceipients
            // 
            // 
            // bw_SendEmails
            // 
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.BottomToolStripPanel
            // 
            ToolStripContainer1.BottomToolStripPanel.Controls.Add(ss_StatusBar);
            // 
            // ToolStripContainer1.ContentPanel
            // 
            ToolStripContainer1.ContentPanel.Controls.Add(tc_EmailTypes);
            ToolStripContainer1.ContentPanel.Size = new Size(411, 298);
            ToolStripContainer1.Dock = DockStyle.Top;
            ToolStripContainer1.LeftToolStripPanelVisible = false;
            ToolStripContainer1.Location = new Point(0, 0);
            ToolStripContainer1.Name = "ToolStripContainer1";
            ToolStripContainer1.RightToolStripPanelVisible = false;
            ToolStripContainer1.Size = new Size(411, 320);
            ToolStripContainer1.TabIndex = 1;
            ToolStripContainer1.Text = "ToolStripContainer1";
            ToolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // ss_StatusBar
            // 
            ss_StatusBar.Dock = DockStyle.None;
            ss_StatusBar.Items.AddRange(new ToolStripItem[] { tsl_Status, tsp_Progress });
            ss_StatusBar.Location = new Point(0, 0);
            ss_StatusBar.Name = "ss_StatusBar";
            ss_StatusBar.Size = new Size(411, 22);
            ss_StatusBar.TabIndex = 0;
            // 
            // tsl_Status
            // 
            tsl_Status.Name = "tsl_Status";
            tsl_Status.Size = new Size(141, 17);
            tsl_Status.Text = "Select the files to attach...";
            // 
            // tsp_Progress
            // 
            tsp_Progress.Alignment = ToolStripItemAlignment.Right;
            tsp_Progress.Name = "tsp_Progress";
            tsp_Progress.Size = new Size(100, 16);
            // 
            // gmt_Gmail
            // 
            gmt_Gmail.Username = global::M3App.My.Settings.Default.Username;
            // 
            // dbListeners
            // 
            dbListeners.BaseUrl = global::M3App.My.Settings.Default.BaseUrl;
            dbListeners.Password = global::M3App.My.Settings.Default.ApiPassword;
            dbListeners.Username = global::M3App.My.Settings.Default.ApiUsername;
            // 
            // SendEmailsDialog
            // 
            AcceptButton = btn_Send;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(411, 364);
            Controls.Add(ToolStripContainer1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SendEmailsDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Email";
            TableLayoutPanel1.ResumeLayout(false);
            tc_EmailTypes.ResumeLayout(false);
            tp_GDrive.ResumeLayout(false);
            tp_LocalFiles.ResumeLayout(false);
            ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            ToolStripContainer1.BottomToolStripPanel.PerformLayout();
            ToolStripContainer1.ContentPanel.ResumeLayout(false);
            ToolStripContainer1.ResumeLayout(false);
            ToolStripContainer1.PerformLayout();
            ss_StatusBar.ResumeLayout(false);
            ss_StatusBar.PerformLayout();
            Load += new EventHandler(Loading);
            Shown += new EventHandler(Reload);
            EmailsCancelled += new EmailsCancelledEventHandler(Cancelled);
            EmailsSending += new EmailsSendingEventHandler(Sending);
            EmailsSent += new EmailsSentEventHandler(Sent);
            ProgressReset += new ProgressResetEventHandler(ResetProgress);
            ProgressMade += new ProgressMadeEventHandler(UpdateProgress);
            ResumeLayout(false);

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button btn_Send;
        internal Button btn_Cancel;
        internal SPPBC.M3Tools.GTools.GmailTool gmt_Gmail;
        internal DriveTree gdt_Files;
        internal TabControl tc_EmailTypes;
        internal TabPage tp_GDrive;
        internal TabPage tp_LocalFiles;
        internal System.ComponentModel.BackgroundWorker bw_GatherFiles;
        internal System.ComponentModel.BackgroundWorker bw_PrepEmails;
        internal System.ComponentModel.BackgroundWorker bw_GatherReceipients;
        internal System.ComponentModel.BackgroundWorker bw_SendEmails;
        internal ToolStripContainer ToolStripContainer1;
        internal StatusStrip ss_StatusBar;
        internal ToolStripStatusLabel tsl_Status;
        internal ToolStripProgressBar tsp_Progress;
        internal FileUpload fu_Receipts;
        internal RecipientSelectionDialog rsd_Selection;
        internal SPPBC.M3Tools.Database.ListenerDatabase dbListeners;
    }
}
