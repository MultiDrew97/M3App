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
        internal Label lbl_Version;
        internal Label lbl_Copyright;
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
            this.spsh_SplashScreen = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.spsh_SplashScreen.SuspendLayout();
            this.DetailsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spsh_SplashScreen
            // 
            this.spsh_SplashScreen.BackgroundImage = global::M3App.Properties.Resources.Banner;
            this.spsh_SplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spsh_SplashScreen.ColumnCount = 2;
            this.spsh_SplashScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.spsh_SplashScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.spsh_SplashScreen.Controls.Add(this.DetailsLayoutPanel, 1, 1);
            this.spsh_SplashScreen.Controls.Add(this.lbl_Version, 0, 1);
            this.spsh_SplashScreen.Controls.Add(this.ApplicationTitle, 0, 0);
            this.spsh_SplashScreen.Controls.Add(this.progressBar1, 1, 0);
            this.spsh_SplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spsh_SplashScreen.Location = new System.Drawing.Point(0, 0);
            this.spsh_SplashScreen.Name = "spsh_SplashScreen";
            this.spsh_SplashScreen.RowCount = 2;
            this.spsh_SplashScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.spsh_SplashScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.spsh_SplashScreen.Size = new System.Drawing.Size(496, 303);
            this.spsh_SplashScreen.TabIndex = 0;
            this.spsh_SplashScreen.UseWaitCursor = true;
            // 
            // DetailsLayoutPanel
            // 
            this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLayoutPanel.ColumnCount = 1;
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.DetailsLayoutPanel.Controls.Add(this.lbl_Copyright, 0, 1);
            this.DetailsLayoutPanel.Location = new System.Drawing.Point(246, 221);
            this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DetailsLayoutPanel.Size = new System.Drawing.Size(247, 79);
            this.DetailsLayoutPanel.TabIndex = 1;
            this.DetailsLayoutPanel.UseWaitCursor = true;
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyright.Location = new System.Drawing.Point(3, 0);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(241, 79);
            this.lbl_Copyright.TabIndex = 2;
            this.lbl_Copyright.Text = "Copyright";
            this.lbl_Copyright.UseWaitCursor = true;
            // 
            // lbl_Version
            // 
            this.lbl_Version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.Location = new System.Drawing.Point(3, 218);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(237, 85);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "Version";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Version.UseWaitCursor = true;
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.Location = new System.Drawing.Point(3, 3);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(237, 212);
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ApplicationTitle.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(246, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.UseWaitCursor = true;
            // 
            // MediaMinistrySplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 303);
            this.ControlBox = false;
            this.Controls.Add(this.spsh_SplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaMinistrySplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SplashLoading);
            this.spsh_SplashScreen.ResumeLayout(false);
            this.DetailsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		private ProgressBar progressBar1;
	}
}
