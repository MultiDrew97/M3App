using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomEmailDialog : System.Windows.Forms.Form
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Done = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ce_Email = new SPPBC.M3Tools.CustomEmail();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Done, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(287, 319);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Done
            // 
            this.btn_Done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Done.Location = new System.Drawing.Point(76, 3);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(67, 23);
            this.btn_Done.TabIndex = 1;
            this.btn_Done.Text = "Done";
            this.btn_Done.Click += new System.EventHandler(this.FinishedCustom);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(3, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.CancelCustom);
            // 
            // ce_Email
            // 
            this.ce_Email.AutoSize = true;
            this.ce_Email.Location = new System.Drawing.Point(0, 0);
            this.ce_Email.Margin = new System.Windows.Forms.Padding(6);
            this.ce_Email.MaximumSize = new System.Drawing.Size(600, 500);
            this.ce_Email.MinimumSize = new System.Drawing.Size(400, 300);
            this.ce_Email.Name = "ce_Email";
            this.ce_Email.Size = new System.Drawing.Size(445, 300);
            this.ce_Email.Subject = "Subject...";
            this.ce_Email.TabIndex = 0;
            // 
            // CustomEmailDialog
            // 
            this.AcceptButton = this.btn_Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.Controls.Add(this.ce_Email);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomEmailDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Email";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Done;
        internal System.Windows.Forms.Button Cancel_Button;
		internal CustomEmail ce_Email;
	}
}
