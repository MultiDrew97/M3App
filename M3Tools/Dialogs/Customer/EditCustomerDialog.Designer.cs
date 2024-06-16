using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditCustomerDialog : System.Windows.Forms.Form
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
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.af_Address = new SPPBC.M3Tools.AddressField();
            this.gi_Email = new SPPBC.M3Tools.GenericInputPair();
            this.pf_Phone = new SPPBC.M3Tools.PhoneNumberField();
            this.gi_LastName = new SPPBC.M3Tools.GenericInputPair();
            this.gi_FirstName = new SPPBC.M3Tools.GenericInputPair();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(592, 388);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 5;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(76, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.FinishDialog);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Location = new System.Drawing.Point(3, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.CancelDialog);
            // 
            // af_Address
            // 
            this.af_Address.Address = null;
            this.af_Address.AutoSize = true;
            this.af_Address.City = "";
            this.af_Address.Location = new System.Drawing.Point(22, 171);
            this.af_Address.MinimumSize = new System.Drawing.Size(700, 200);
            this.af_Address.Name = "af_Address";
            this.af_Address.Size = new System.Drawing.Size(700, 200);
            this.af_Address.State = "";
            this.af_Address.Street = "";
            this.af_Address.TabIndex = 4;
            this.af_Address.ZipCode = "";
            // 
            // gi_Email
            // 
            this.gi_Email.AutoSize = true;
            this.gi_Email.Label = "Email";
            this.gi_Email.Location = new System.Drawing.Point(385, 109);
            this.gi_Email.Mask = "";
            this.gi_Email.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_Email.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_Email.Name = "gi_Email";
            this.gi_Email.Placeholder = null;
            this.gi_Email.Size = new System.Drawing.Size(225, 45);
            this.gi_Email.TabIndex = 3;
            this.gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pf_Phone
            // 
            this.pf_Phone.AutoSize = true;
            this.pf_Phone.Location = new System.Drawing.Point(140, 109);
            this.pf_Phone.MaximumSize = new System.Drawing.Size(0, 50);
            this.pf_Phone.MinimumSize = new System.Drawing.Size(100, 50);
            this.pf_Phone.Name = "pf_Phone";
            this.pf_Phone.PhoneNumber = "";
            this.pf_Phone.Size = new System.Drawing.Size(100, 50);
            this.pf_Phone.TabIndex = 2;
            // 
            // gi_LastName
            // 
            this.gi_LastName.AutoSize = true;
            this.gi_LastName.Label = "Last Name";
            this.gi_LastName.Location = new System.Drawing.Point(385, 57);
            this.gi_LastName.Mask = "";
            this.gi_LastName.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_LastName.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_LastName.Name = "gi_LastName";
            this.gi_LastName.Placeholder = null;
            this.gi_LastName.Size = new System.Drawing.Size(225, 45);
            this.gi_LastName.TabIndex = 1;
            this.gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_FirstName
            // 
            this.gi_FirstName.AutoSize = true;
            this.gi_FirstName.Label = "First Name";
            this.gi_FirstName.Location = new System.Drawing.Point(140, 57);
            this.gi_FirstName.Mask = "";
            this.gi_FirstName.MaximumSize = new System.Drawing.Size(225, 45);
            this.gi_FirstName.MinimumSize = new System.Drawing.Size(150, 45);
            this.gi_FirstName.Name = "gi_FirstName";
            this.gi_FirstName.Placeholder = null;
            this.gi_FirstName.Size = new System.Drawing.Size(225, 45);
            this.gi_FirstName.TabIndex = 0;
            this.gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EditCustomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 429);
            this.Controls.Add(this.af_Address);
            this.Controls.Add(this.gi_Email);
            this.Controls.Add(this.pf_Phone);
            this.Controls.Add(this.gi_LastName);
            this.Controls.Add(this.gi_FirstName);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomerDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit {0}";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal GenericInputPair gi_FirstName;
        internal GenericInputPair gi_LastName;
        internal PhoneNumberField pf_Phone;
        internal GenericInputPair gi_Email;
        internal AddressField af_Address;
    }
}
