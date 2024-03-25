using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddCustomerDialog : System.Windows.Forms.Form
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
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(PreviousStep);
            btn_Create = new System.Windows.Forms.Button();
            btn_Create.Click += new EventHandler(NextStep);
            ep_InputError = new System.Windows.Forms.ErrorProvider(components);
            StatusStrip1 = new System.Windows.Forms.StatusStrip();
            tss_Feedback = new System.Windows.Forms.ToolStripStatusLabel();
            tc_Creation = new System.Windows.Forms.TabControl();
            tc_Creation.SelectedIndexChanged += new EventHandler(PageChanged);
            tp_Basics = new System.Windows.Forms.TabPage();
            tp_Address = new System.Windows.Forms.TabPage();
            tp_Summary = new System.Windows.Forms.TabPage();
            gi_FirstName = new GenericInputPair();
            gi_LastName = new GenericInputPair();
            pn_PhoneNumber = new PhoneNumberField();
            gi_EmailAddress = new GenericInputPair();
            af_Address = new AddressField();
            sc_Summary = new SummaryCtrl();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_InputError).BeginInit();
            StatusStrip1.SuspendLayout();
            tc_Creation.SuspendLayout();
            tp_Basics.SuspendLayout();
            tp_Address.SuspendLayout();
            tp_Summary.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(291, 310);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(292, 56);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.Location = new System.Drawing.Point(6, 6);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(134, 44);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            // 
            // btn_Create
            // 
            btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Create.Location = new System.Drawing.Point(152, 6);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(134, 44);
            btn_Create.TabIndex = 1;
            btn_Create.Text = "Next";
            // 
            // ep_InputError
            // 
            ep_InputError.ContainerControl = this;
            // 
            // StatusStrip1
            // 
            StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tss_Feedback });
            StatusStrip1.Location = new System.Drawing.Point(0, 382);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new System.Drawing.Size(595, 22);
            StatusStrip1.TabIndex = 6;
            StatusStrip1.Text = "StatusStrip1";
            // 
            // tss_Feedback
            // 
            tss_Feedback.Name = "tss_Feedback";
            tss_Feedback.Size = new System.Drawing.Size(271, 17);
            tss_Feedback.Text = "Please enter the infomation for the new customer.";
            // 
            // tc_Creation
            // 
            tc_Creation.Controls.Add(tp_Basics);
            tc_Creation.Controls.Add(tp_Address);
            tc_Creation.Controls.Add(tp_Summary);
            tc_Creation.Dock = System.Windows.Forms.DockStyle.Top;
            tc_Creation.Location = new System.Drawing.Point(0, 0);
            tc_Creation.Multiline = true;
            tc_Creation.Name = "tc_Creation";
            tc_Creation.SelectedIndex = 0;
            tc_Creation.Size = new System.Drawing.Size(595, 304);
            tc_Creation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tc_Creation.TabIndex = 7;
            // 
            // tp_Basic
            // 
            tp_Basics.BackColor = System.Drawing.Color.LightGray;
            tp_Basics.Controls.Add(gi_FirstName);
            tp_Basics.Controls.Add(gi_LastName);
            tp_Basics.Controls.Add(pn_PhoneNumber);
            tp_Basics.Controls.Add(gi_EmailAddress);
            tp_Basics.Location = new System.Drawing.Point(4, 22);
            tp_Basics.Name = "tp_Basic";
            tp_Basics.Padding = new System.Windows.Forms.Padding(3);
            tp_Basics.Size = new System.Drawing.Size(587, 278);
            tp_Basics.TabIndex = 0;
            tp_Basics.Text = "Basics";
            // 
            // tp_Address
            // 
            tp_Address.Controls.Add(af_Address);
            tp_Address.Location = new System.Drawing.Point(4, 22);
            tp_Address.Name = "tp_Address";
            tp_Address.Padding = new System.Windows.Forms.Padding(3);
            tp_Address.Size = new System.Drawing.Size(587, 278);
            tp_Address.TabIndex = 1;
            tp_Address.Text = "Address";
            tp_Address.UseVisualStyleBackColor = true;
            // 
            // tp_Summary
            // 
            tp_Summary.Controls.Add(sc_Summary);
            tp_Summary.Location = new System.Drawing.Point(4, 22);
            tp_Summary.Name = "tp_Summary";
            tp_Summary.Padding = new System.Windows.Forms.Padding(3);
            tp_Summary.Size = new System.Drawing.Size(587, 278);
            tp_Summary.TabIndex = 2;
            tp_Summary.Text = "Summary";
            tp_Summary.UseVisualStyleBackColor = true;
            // 
            // gi_FirstName
            // 
            gi_FirstName.AutoSize = true;
            gi_FirstName.Label = "* First Name";
            gi_FirstName.Location = new System.Drawing.Point(43, 79);
            gi_FirstName.Margin = new System.Windows.Forms.Padding(6);
            gi_FirstName.Mask = "";
            gi_FirstName.Name = "gi_FirstName";
            gi_FirstName.Placeholder = null;
            gi_FirstName.Size = new System.Drawing.Size(244, 62);
            gi_FirstName.TabIndex = 1;
            gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_LastName
            // 
            gi_LastName.AutoSize = true;
            gi_LastName.Label = "* Last Name";
            gi_LastName.Location = new System.Drawing.Point(299, 79);
            gi_LastName.Margin = new System.Windows.Forms.Padding(6);
            gi_LastName.Mask = "";
            gi_LastName.Name = "gi_LastName";
            gi_LastName.Placeholder = null;
            gi_LastName.Size = new System.Drawing.Size(244, 62);
            gi_LastName.TabIndex = 2;
            gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pn_PhoneNumber
            // 
            pn_PhoneNumber.AutoSize = true;
            pn_PhoneNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pn_PhoneNumber.Location = new System.Drawing.Point(43, 153);
            pn_PhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            pn_PhoneNumber.MaximumSize = new System.Drawing.Size(0, 50);
            pn_PhoneNumber.MinimumSize = new System.Drawing.Size(100, 50);
            pn_PhoneNumber.Name = "pn_PhoneNumber";
            pn_PhoneNumber.Size = new System.Drawing.Size(100, 50);
            pn_PhoneNumber.TabIndex = 3;
            // 
            // gi_EmailAddress
            // 
            gi_EmailAddress.AutoSize = true;
            gi_EmailAddress.Label = "Email Address";
            gi_EmailAddress.Location = new System.Drawing.Point(285, 153);
            gi_EmailAddress.Margin = new System.Windows.Forms.Padding(6);
            gi_EmailAddress.Mask = "";
            gi_EmailAddress.Name = "gi_EmailAddress";
            gi_EmailAddress.Placeholder = null;
            gi_EmailAddress.Size = new System.Drawing.Size(258, 40);
            gi_EmailAddress.TabIndex = 4;
            gi_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // af_Address
            // 
            af_Address.Address = null;
            af_Address.AutoSize = true;
            af_Address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            af_Address.BackColor = System.Drawing.Color.LightGray;
            af_Address.City = "";
            af_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            af_Address.Location = new System.Drawing.Point(3, 3);
            af_Address.Margin = new System.Windows.Forms.Padding(6);
            af_Address.MinimumSize = new System.Drawing.Size(500, 100);
            af_Address.Name = "af_Address";
            af_Address.Size = new System.Drawing.Size(581, 272);
            af_Address.State = "";
            af_Address.Street = "";
            af_Address.TabIndex = 5;
            af_Address.ZipCode = "";
            // 
            // sc_Summary
            // 
            sc_Summary.Display = null;
            sc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            sc_Summary.Location = new System.Drawing.Point(3, 3);
            sc_Summary.Name = "sc_Summary";
            sc_Summary.Size = new System.Drawing.Size(581, 272);
            sc_Summary.TabIndex = 0;
            // 
            // AddCustomerDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(595, 404);
            Controls.Add(tc_Creation);
            Controls.Add(StatusStrip1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCustomerDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Customer";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ep_InputError).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            tc_Creation.ResumeLayout(false);
            tp_Basics.ResumeLayout(false);
            tp_Basics.PerformLayout();
            tp_Address.ResumeLayout(false);
            tp_Address.PerformLayout();
            tp_Summary.ResumeLayout(false);
            PageChangedEvent += new EventHandler(PageChanged);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.Button btn_Create;
        internal System.Windows.Forms.ErrorProvider ep_InputError;
        internal AddressField af_Address;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tss_Feedback;
        internal System.Windows.Forms.TabControl tc_Creation;
        internal System.Windows.Forms.TabPage tp_Basics;
        internal GenericInputPair gi_FirstName;
        internal GenericInputPair gi_LastName;
        internal PhoneNumberField pn_PhoneNumber;
        internal GenericInputPair gi_EmailAddress;
        internal System.Windows.Forms.TabPage tp_Address;
        internal System.Windows.Forms.TabPage tp_Summary;
        internal SummaryCtrl sc_Summary;
    }
}