using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MediaMinistrySplash : Form
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
        internal Label ApplicationTitle;
        internal Label Version;
        internal Label Copyright;
        internal TableLayoutPanel spsh_SplashScreen;
        internal TableLayoutPanel DetailsLayoutPanel;

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            spsh_SplashScreen = new TableLayoutPanel();
            DetailsLayoutPanel = new TableLayoutPanel();
            Copyright = new Label();
            Version = new Label();
            ApplicationTitle = new Label();
            spsh_SplashScreen.SuspendLayout();
            DetailsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // spsh_SplashScreen
            // 
            spsh_SplashScreen.BackgroundImage = My.Resources.Resources.BannerImage;
            spsh_SplashScreen.BackgroundImageLayout = ImageLayout.Stretch;
            spsh_SplashScreen.ColumnCount = 2;
            spsh_SplashScreen.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243.0f));
            spsh_SplashScreen.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253.0f));
            spsh_SplashScreen.Controls.Add(DetailsLayoutPanel, 1, 1);
            spsh_SplashScreen.Controls.Add(Version, 0, 1);
            spsh_SplashScreen.Controls.Add(ApplicationTitle, 1, 0);
            spsh_SplashScreen.Dock = DockStyle.Fill;
            spsh_SplashScreen.Location = new Point(0, 0);
            spsh_SplashScreen.Name = "spsh_SplashScreen";
            spsh_SplashScreen.RowCount = 2;
            spsh_SplashScreen.RowStyles.Add(new RowStyle(SizeType.Absolute, 218.0f));
            spsh_SplashScreen.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            spsh_SplashScreen.Size = new Size(496, 303);
            spsh_SplashScreen.TabIndex = 0;
            // 
            // DetailsLayoutPanel
            // 
            DetailsLayoutPanel.Anchor = AnchorStyles.None;
            DetailsLayoutPanel.BackColor = Color.Transparent;
            DetailsLayoutPanel.ColumnCount = 1;
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247.0f));
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142.0f));
            DetailsLayoutPanel.Controls.Add(Copyright, 0, 1);
            DetailsLayoutPanel.Location = new Point(246, 221);
            DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0f));
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0f));
            DetailsLayoutPanel.Size = new Size(247, 79);
            DetailsLayoutPanel.TabIndex = 1;
            // 
            // Copyright
            // 
            Copyright.Anchor = AnchorStyles.None;
            Copyright.BackColor = Color.Transparent;
            Copyright.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copyright.Location = new Point(3, 39);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(241, 40);
            Copyright.TabIndex = 2;
            Copyright.Text = "Copyright";
            // 
            // Version
            // 
            Version.Anchor = AnchorStyles.None;
            Version.BackColor = Color.Transparent;
            Version.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Version.Location = new Point(3, 250);
            Version.Name = "Version";
            Version.Size = new Size(237, 20);
            Version.TabIndex = 1;
            Version.Text = "Version {0}.{1:0}.{2}";
            Version.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApplicationTitle
            // 
            ApplicationTitle.Anchor = AnchorStyles.None;
            ApplicationTitle.BackColor = Color.Transparent;
            ApplicationTitle.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationTitle.Location = new Point(246, 3);
            ApplicationTitle.Name = "ApplicationTitle";
            ApplicationTitle.Size = new Size(247, 212);
            ApplicationTitle.TabIndex = 0;
            ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MediaMinistrySplash
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 303);
            ControlBox = false;
            Controls.Add(spsh_SplashScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MediaMinistrySplash";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            spsh_SplashScreen.ResumeLayout(false);
            DetailsLayoutPanel.ResumeLayout(false);
            Load += new EventHandler(SplashLoading);
            ResumeLayout(false);

        }
    }
}