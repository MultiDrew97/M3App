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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            OK_Button = new System.Windows.Forms.Button();
            OK_Button.Click += new EventHandler(FinishDialog);
            Cancel_Button = new System.Windows.Forms.Button();
            Cancel_Button.Click += new EventHandler(CancelDialog);
            af_Address = new AddressField();
            gi_Email = new GenericInputPair();
            PhoneNumberField1 = new PhoneNumberField();
            gi_LastName = new GenericInputPair();
            gi_FirstName = new GenericInputPair();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 1, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(387, 274);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 5;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            OK_Button.Location = new System.Drawing.Point(76, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new System.Drawing.Size(67, 23);
            OK_Button.TabIndex = 1;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            Cancel_Button.Location = new System.Drawing.Point(3, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new System.Drawing.Size(67, 23);
            Cancel_Button.TabIndex = 0;
            Cancel_Button.Text = "Cancel";
            // 
            // af_Address
            // 
            af_Address.Address = null;
            af_Address.AutoSize = true;
            af_Address.City = "";
            af_Address.Location = new System.Drawing.Point(12, 138);
            af_Address.MinimumSize = new System.Drawing.Size(500, 100);
            af_Address.Name = "af_Address";
            af_Address.Size = new System.Drawing.Size(518, 100);
            af_Address.State = "";
            af_Address.Street = "";
            af_Address.TabIndex = 4;
            af_Address.ZipCode = "";
            // 
            // gi_Email
            // 
            gi_Email.AutoSize = true;
            gi_Email.Label = "Email";
            gi_Email.Location = new System.Drawing.Point(257, 64);
            gi_Email.Mask = "";
            gi_Email.Name = "gi_Email";
            gi_Email.Placeholder = null;
            gi_Email.Size = new System.Drawing.Size(273, 46);
            gi_Email.TabIndex = 3;
            gi_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PhoneNumberField1
            // 
            PhoneNumberField1.AutoSize = true;
            PhoneNumberField1.Location = new System.Drawing.Point(12, 64);
            PhoneNumberField1.MaximumSize = new System.Drawing.Size(0, 50);
            PhoneNumberField1.MinimumSize = new System.Drawing.Size(100, 50);
            PhoneNumberField1.Name = "PhoneNumberField1";
            PhoneNumberField1.Size = new System.Drawing.Size(100, 50);
            PhoneNumberField1.TabIndex = 2;
            // 
            // gi_LastName
            // 
            gi_LastName.AutoSize = true;
            gi_LastName.Label = "Last Name";
            gi_LastName.Location = new System.Drawing.Point(257, 12);
            gi_LastName.Mask = "";
            gi_LastName.Name = "gi_LastName";
            gi_LastName.Placeholder = null;
            gi_LastName.Size = new System.Drawing.Size(276, 46);
            gi_LastName.TabIndex = 1;
            gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_FirstName
            // 
            gi_FirstName.AutoSize = true;
            gi_FirstName.Label = "First Name";
            gi_FirstName.Location = new System.Drawing.Point(12, 12);
            gi_FirstName.Mask = "";
            gi_FirstName.Name = "gi_FirstName";
            gi_FirstName.Placeholder = null;
            gi_FirstName.Size = new System.Drawing.Size(229, 46);
            gi_FirstName.TabIndex = 0;
            gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EditCustomerDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(545, 315);
            Controls.Add(af_Address);
            Controls.Add(gi_Email);
            Controls.Add(PhoneNumberField1);
            Controls.Add(gi_LastName);
            Controls.Add(gi_FirstName);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCustomerDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit {0}";
            TableLayoutPanel1.ResumeLayout(false);
            CustomerChanged += new CustomerChangedEventHandler(CustomerUpdated);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal GenericInputPair gi_FirstName;
        internal GenericInputPair gi_LastName;
        internal PhoneNumberField PhoneNumberField1;
        internal GenericInputPair gi_Email;
        internal AddressField af_Address;
    }
}