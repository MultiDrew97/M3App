using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditListenerDialog : System.Windows.Forms.Form
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gi_Email = new SPPBC.M3Tools.GenericInputPair();
            this.gi_Name = new SPPBC.M3Tools.GenericInputPair();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Save, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(100, 158);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Location = new System.Drawing.Point(76, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(67, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "OK";
            this.btn_Save.Click += new System.EventHandler(this.FinishDialog);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.CancelDialog);
            // 
            // gi_Email
            // 
            this.gi_Email.AutoSize = true;
            this.gi_Email.Label = "Email Address";
            this.gi_Email.Location = new System.Drawing.Point(17, 79);
            this.gi_Email.Mask = "";
            this.gi_Email.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_Email.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_Email.Name = "gi_Email";
            this.gi_Email.Placeholder = "Email";
            this.gi_Email.Size = new System.Drawing.Size(225, 45);
            this.gi_Email.TabIndex = 1;
            this.gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_Name
            // 
            this.gi_Name.AutoSize = true;
            this.gi_Name.Label = "Name";
            this.gi_Name.Location = new System.Drawing.Point(17, 18);
            this.gi_Name.Mask = "";
            this.gi_Name.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_Name.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_Name.Name = "gi_Name";
            this.gi_Name.Placeholder = "Name";
            this.gi_Name.Size = new System.Drawing.Size(225, 45);
            this.gi_Name.TabIndex = 0;
            this.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EditListenerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 199);
            this.Controls.Add(this.gi_Email);
            this.Controls.Add(this.gi_Name);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditListenerDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit {0}";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Save;
        internal System.Windows.Forms.Button btn_Cancel;
        internal GenericInputPair gi_Name;
        internal GenericInputPair gi_Email;
    }
}
