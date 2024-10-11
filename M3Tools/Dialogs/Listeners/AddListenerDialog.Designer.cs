using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddListenerDialog : System.Windows.Forms.Form
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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btn_Create = new System.Windows.Forms.Button();
            btn_Create.Click += new EventHandler(AddListener);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(Cancel);
            gi_Name = new GenericInputPair();
            gi_Email = new GenericInputPair();
            dbListeners = new API.ListenerDatabase(components);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(174, 149);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Create
            // 
            btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Create.Location = new System.Drawing.Point(76, 3);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(67, 23);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "OK";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // gi_Name
            // 
            gi_Name.AutoSize = true;
            gi_Name.Label = "Name";
            gi_Name.Location = new System.Drawing.Point(12, 35);
            gi_Name.Mask = "";
            gi_Name.Name = "gi_Name";
            gi_Name.Placeholder = "John Doe";
            gi_Name.Size = new System.Drawing.Size(308, 46);
            gi_Name.TabIndex = 1;
            gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_Email
            // 
            gi_Email.AutoSize = true;
            gi_Email.Label = "Email Address";
            gi_Email.Location = new System.Drawing.Point(12, 87);
            gi_Email.Mask = "";
            gi_Email.Name = "gi_Email";
            gi_Email.Placeholder = "johndoe@domain.ext";
            gi_Email.Size = new System.Drawing.Size(308, 46);
            gi_Email.TabIndex = 2;
            gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dbListeners
            // 
            // 
            // AddListenerDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(332, 190);
            Controls.Add(gi_Email);
            Controls.Add(gi_Name);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddListenerDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Listener";
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Create;
        internal System.Windows.Forms.Button btn_Cancel;
        internal GenericInputPair gi_Name;
        internal GenericInputPair gi_Email;
        internal API.ListenerDatabase dbListeners;
    }
}