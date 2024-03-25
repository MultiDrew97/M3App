using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MediaMinistry
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FileLocationField : UserControl
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
            SplitContainer1 = new SplitContainer();
            txtFileLocation = new TextBox();
            btnBrowse = new Button();
            btnBrowse.Click += new EventHandler(BtnBrowse_Click);
            ofdFileSelection = new OpenFileDialog();
            ofdFileSelection.FileOk += new System.ComponentModel.CancelEventHandler(OfdFileSelection_FileOk);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = DockStyle.Fill;
            SplitContainer1.Location = new Point(0, 0);
            SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(txtFileLocation);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(btnBrowse);
            SplitContainer1.Size = new Size(566, 32);
            SplitContainer1.SplitterDistance = 521;
            SplitContainer1.TabIndex = 0;
            // 
            // txtFileLocation
            // 
            txtFileLocation.Dock = DockStyle.Fill;
            txtFileLocation.Location = new Point(0, 0);
            txtFileLocation.Name = "txtFileLocation";
            txtFileLocation.ReadOnly = true;
            txtFileLocation.Size = new Size(521, 31);
            txtFileLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Location = new Point(0, 0);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(41, 32);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // ofdFileSelection
            // 
            ofdFileSelection.Title = "Media Ministry Manager";
            // 
            // FileLocationField
            // 
            Controls.Add(SplitContainer1);
            Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold);
            Name = "FileLocationField";
            Size = new Size(566, 32);
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel1.PerformLayout();
            SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            Load += new EventHandler(FileLocationField_Load);
            ResumeLayout(false);

        }

        internal SplitContainer SplitContainer1;
        internal TextBox txtFileLocation;
        internal Button btnBrowse;
        internal OpenFileDialog ofdFileSelection;
    }
}