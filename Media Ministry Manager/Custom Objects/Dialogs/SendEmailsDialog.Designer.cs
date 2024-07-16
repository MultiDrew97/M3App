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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tc_EmailTypes = new System.Windows.Forms.TabControl();
            this.tp_GDrive = new System.Windows.Forms.TabPage();
            this.tp_LocalFiles = new System.Windows.Forms.TabPage();
            this.bw_GatherFiles = new System.ComponentModel.BackgroundWorker();
            this.bw_PrepEmails = new System.ComponentModel.BackgroundWorker();
            this.bw_GatherReceipients = new System.ComponentModel.BackgroundWorker();
            this.bw_SendEmails = new System.ComponentModel.BackgroundWorker();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ss_StatusBar = new System.Windows.Forms.StatusStrip();
            this.tsl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsp_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.gdt_Files = new SPPBC.M3Tools.DriveTree();
            this.fu_Receipts = new SPPBC.M3Tools.FileUpload();
            this.gmt_Gmail = new SPPBC.M3Tools.GTools.GmailTool(this.components);
            this.dbListeners = new SPPBC.M3Tools.Database.ListenerDatabase(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.tc_EmailTypes.SuspendLayout();
            this.tp_GDrive.SuspendLayout();
            this.tp_LocalFiles.SuspendLayout();
            this.ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.ss_StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Send, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(253, 323);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Send.Location = new System.Drawing.Point(76, 3);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(67, 23);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.Click += new System.EventHandler(this.BeginSending);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // tc_EmailTypes
            // 
            this.tc_EmailTypes.Controls.Add(this.tp_GDrive);
            this.tc_EmailTypes.Controls.Add(this.tp_LocalFiles);
            this.tc_EmailTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_EmailTypes.Location = new System.Drawing.Point(0, 0);
            this.tc_EmailTypes.Name = "tc_EmailTypes";
            this.tc_EmailTypes.SelectedIndex = 0;
            this.tc_EmailTypes.Size = new System.Drawing.Size(411, 298);
            this.tc_EmailTypes.TabIndex = 0;
            // 
            // tp_GDrive
            // 
            this.tp_GDrive.Controls.Add(this.gdt_Files);
            this.tp_GDrive.Location = new System.Drawing.Point(4, 22);
            this.tp_GDrive.Name = "tp_GDrive";
            this.tp_GDrive.Size = new System.Drawing.Size(403, 272);
            this.tp_GDrive.TabIndex = 0;
            this.tp_GDrive.Text = "Google Drive";
            this.tp_GDrive.UseVisualStyleBackColor = true;
            // 
            // tp_LocalFiles
            // 
            this.tp_LocalFiles.Controls.Add(this.fu_Receipts);
            this.tp_LocalFiles.Location = new System.Drawing.Point(4, 22);
            this.tp_LocalFiles.Name = "tp_LocalFiles";
            this.tp_LocalFiles.Size = new System.Drawing.Size(99, 62);
            this.tp_LocalFiles.TabIndex = 0;
            this.tp_LocalFiles.Text = "Local Files";
            this.tp_LocalFiles.UseVisualStyleBackColor = true;
            // 
            // bw_GatherFiles
            // 
            this.bw_GatherFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GatherFiles);
            this.bw_GatherFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FilesGathered);
            // 
            // bw_PrepEmails
            // 
            this.bw_PrepEmails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PrepEmails);
            this.bw_PrepEmails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EmailsPrepped);
            // 
            // bw_GatherReceipients
            // 
            this.bw_GatherReceipients.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GatherReceipients);
            this.bw_GatherReceipients.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ReceipientsGathered);
            // 
            // bw_SendEmails
            // 
            this.bw_SendEmails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendEmails);
            this.bw_SendEmails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EmailsDone);
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.BottomToolStripPanel
            // 
            this.ToolStripContainer1.BottomToolStripPanel.Controls.Add(this.ss_StatusBar);
            // 
            // ToolStripContainer1.ContentPanel
            // 
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.tc_EmailTypes);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(411, 298);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolStripContainer1.LeftToolStripPanelVisible = false;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.RightToolStripPanelVisible = false;
            this.ToolStripContainer1.Size = new System.Drawing.Size(411, 320);
            this.ToolStripContainer1.TabIndex = 1;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            this.ToolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // ss_StatusBar
            // 
            this.ss_StatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.ss_StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Status,
            this.tsp_Progress});
            this.ss_StatusBar.Location = new System.Drawing.Point(0, 0);
            this.ss_StatusBar.Name = "ss_StatusBar";
            this.ss_StatusBar.Size = new System.Drawing.Size(411, 22);
            this.ss_StatusBar.SizingGrip = false;
            this.ss_StatusBar.TabIndex = 0;
            // 
            // tsl_Status
            // 
            this.tsl_Status.Name = "tsl_Status";
            this.tsl_Status.Size = new System.Drawing.Size(294, 17);
            this.tsl_Status.Spring = true;
            this.tsl_Status.Text = "Select the files to attach...";
            this.tsl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsp_Progress
            // 
            this.tsp_Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsp_Progress.Name = "tsp_Progress";
            this.tsp_Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // gdt_Files
            // 
            this.gdt_Files.DataBindings.Add(new System.Windows.Forms.Binding("Username", global::M3App.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gdt_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdt_Files.Location = new System.Drawing.Point(0, 0);
            this.gdt_Files.Name = "gdt_Files";
            this.gdt_Files.Size = new System.Drawing.Size(403, 272);
            this.gdt_Files.TabIndex = 4;
            this.gdt_Files.Username = global::M3App.Properties.Settings.Default.Username;
            // 
            // fu_Receipts
            // 
            this.fu_Receipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fu_Receipts.Location = new System.Drawing.Point(0, 0);
            this.fu_Receipts.Name = "fu_Receipts";
            this.fu_Receipts.Size = new System.Drawing.Size(99, 62);
            this.fu_Receipts.TabIndex = 1;
            // 
            // gmt_Gmail
            // 
            this.gmt_Gmail.Username = global::M3App.Properties.Settings.Default.Username;
            // 
            // dbListeners
            // 
            this.dbListeners.BaseUrl = global::M3App.Properties.Settings.Default.BaseUrl;
            this.dbListeners.Password = global::M3App.Properties.Settings.Default.ApiPassword;
            this.dbListeners.Username = global::M3App.Properties.Settings.Default.ApiUsername;
            // 
            // SendEmailsDialog
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(411, 364);
            this.Controls.Add(this.ToolStripContainer1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendEmailsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Email";
            this.Load += new System.EventHandler(this.Loading);
            this.Shown += new System.EventHandler(this.Reload);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.tc_EmailTypes.ResumeLayout(false);
            this.tp_GDrive.ResumeLayout(false);
            this.tp_LocalFiles.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            this.ss_StatusBar.ResumeLayout(false);
            this.ss_StatusBar.PerformLayout();
            this.ResumeLayout(false);

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
        internal SPPBC.M3Tools.Database.ListenerDatabase dbListeners;
    }
}
