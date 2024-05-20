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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.ep_InputError = new System.Windows.Forms.ErrorProvider(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_Feedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.tc_Creation = new System.Windows.Forms.TabControl();
            this.tp_Basics = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gi_FirstName = new SPPBC.M3Tools.GenericInputPair();
            this.gi_LastName = new SPPBC.M3Tools.GenericInputPair();
            this.pn_PhoneNumber = new SPPBC.M3Tools.PhoneNumberField();
            this.gi_EmailAddress = new SPPBC.M3Tools.GenericInputPair();
            this.tp_Address = new System.Windows.Forms.TabPage();
            this.af_Address = new SPPBC.M3Tools.AddressField();
            this.tp_Summary = new System.Windows.Forms.TabPage();
            this.sc_Summary = new SPPBC.M3Tools.SummaryCtrl();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_InputError)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.tc_Creation.SuspendLayout();
            this.tp_Basics.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tp_Address.SuspendLayout();
            this.tp_Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Create, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(423, 314);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(292, 56);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(134, 44);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.PreviousStep);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Create.Location = new System.Drawing.Point(152, 6);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(134, 44);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "Next";
            this.btn_Create.Click += new System.EventHandler(this.NextStep);
            // 
            // ep_InputError
            // 
            this.ep_InputError.ContainerControl = this;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Feedback});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 386);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(727, 22);
            this.StatusStrip1.TabIndex = 6;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // tss_Feedback
            // 
            this.tss_Feedback.Name = "tss_Feedback";
            this.tss_Feedback.Size = new System.Drawing.Size(271, 17);
            this.tss_Feedback.Text = "Please enter the infomation for the new customer.";
            // 
            // tc_Creation
            // 
            this.tc_Creation.Controls.Add(this.tp_Basics);
            this.tc_Creation.Controls.Add(this.tp_Address);
            this.tc_Creation.Controls.Add(this.tp_Summary);
            this.tc_Creation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_Creation.Location = new System.Drawing.Point(0, 0);
            this.tc_Creation.Multiline = true;
            this.tc_Creation.Name = "tc_Creation";
            this.tc_Creation.SelectedIndex = 0;
            this.tc_Creation.Size = new System.Drawing.Size(727, 304);
            this.tc_Creation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Creation.TabIndex = 7;
            this.tc_Creation.SelectedIndexChanged += new System.EventHandler(this.PageChanged);
            // 
            // tp_Basics
            // 
            this.tp_Basics.BackColor = System.Drawing.Color.LightGray;
            this.tp_Basics.Controls.Add(this.flowLayoutPanel1);
            this.tp_Basics.Location = new System.Drawing.Point(4, 22);
            this.tp_Basics.Name = "tp_Basics";
            this.tp_Basics.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Basics.Size = new System.Drawing.Size(719, 278);
            this.tp_Basics.TabIndex = 0;
            this.tp_Basics.Text = "Basics";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gi_FirstName);
            this.flowLayoutPanel1.Controls.Add(this.gi_LastName);
            this.flowLayoutPanel1.Controls.Add(this.pn_PhoneNumber);
            this.flowLayoutPanel1.Controls.Add(this.gi_EmailAddress);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 272);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // gi_FirstName
            // 
            this.gi_FirstName.AutoSize = true;
            this.gi_FirstName.Label = "* First Name";
            this.gi_FirstName.Location = new System.Drawing.Point(50, 10);
            this.gi_FirstName.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.gi_FirstName.Mask = "";
            this.gi_FirstName.MaximumSize = new System.Drawing.Size(0, 45);
            this.gi_FirstName.MinimumSize = new System.Drawing.Size(300, 45);
            this.gi_FirstName.Name = "gi_FirstName";
            this.gi_FirstName.Placeholder = null;
            this.gi_FirstName.Size = new System.Drawing.Size(300, 45);
            this.gi_FirstName.TabIndex = 1;
            this.gi_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gi_LastName
            // 
            this.gi_LastName.AutoSize = true;
            this.gi_LastName.Label = "* Last Name";
            this.gi_LastName.Location = new System.Drawing.Point(370, 10);
            this.gi_LastName.Margin = new System.Windows.Forms.Padding(10);
            this.gi_LastName.Mask = "";
            this.gi_LastName.MaximumSize = new System.Drawing.Size(0, 45);
            this.gi_LastName.MinimumSize = new System.Drawing.Size(300, 45);
            this.gi_LastName.Name = "gi_LastName";
            this.gi_LastName.Placeholder = null;
            this.gi_LastName.Size = new System.Drawing.Size(300, 45);
            this.gi_LastName.TabIndex = 2;
            this.gi_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pn_PhoneNumber
            // 
            this.pn_PhoneNumber.AutoSize = true;
            this.pn_PhoneNumber.Location = new System.Drawing.Point(160, 115);
            this.pn_PhoneNumber.Margin = new System.Windows.Forms.Padding(160, 50, 50, 50);
            this.pn_PhoneNumber.MaximumSize = new System.Drawing.Size(225, 45);
            this.pn_PhoneNumber.MinimumSize = new System.Drawing.Size(100, 50);
            this.pn_PhoneNumber.Name = "pn_PhoneNumber";
            this.pn_PhoneNumber.PhoneNumber = "";
            this.pn_PhoneNumber.Size = new System.Drawing.Size(100, 50);
            this.pn_PhoneNumber.TabIndex = 3;
            // 
            // gi_EmailAddress
            // 
            this.gi_EmailAddress.AutoSize = true;
            this.gi_EmailAddress.Label = "Email Address";
            this.gi_EmailAddress.Location = new System.Drawing.Point(360, 115);
            this.gi_EmailAddress.Margin = new System.Windows.Forms.Padding(50);
            this.gi_EmailAddress.Mask = "";
            this.gi_EmailAddress.MaximumSize = new System.Drawing.Size(0, 45);
            this.gi_EmailAddress.MinimumSize = new System.Drawing.Size(300, 45);
            this.gi_EmailAddress.Name = "gi_EmailAddress";
            this.gi_EmailAddress.Placeholder = null;
            this.gi_EmailAddress.Size = new System.Drawing.Size(300, 45);
            this.gi_EmailAddress.TabIndex = 4;
            this.gi_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tp_Address
            // 
            this.tp_Address.Controls.Add(this.af_Address);
            this.tp_Address.Location = new System.Drawing.Point(4, 22);
            this.tp_Address.Name = "tp_Address";
            this.tp_Address.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Address.Size = new System.Drawing.Size(719, 278);
            this.tp_Address.TabIndex = 1;
            this.tp_Address.Text = "Address";
            this.tp_Address.UseVisualStyleBackColor = true;
            // 
            // af_Address
            // 
            this.af_Address.Address = null;
            this.af_Address.AutoSize = true;
            this.af_Address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.af_Address.BackColor = System.Drawing.Color.LightGray;
            this.af_Address.City = "";
            this.af_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.af_Address.Location = new System.Drawing.Point(3, 3);
            this.af_Address.Margin = new System.Windows.Forms.Padding(6);
            this.af_Address.MinimumSize = new System.Drawing.Size(650, 125);
            this.af_Address.Name = "af_Address";
            this.af_Address.Size = new System.Drawing.Size(713, 272);
            this.af_Address.State = "";
            this.af_Address.Street = "";
            this.af_Address.TabIndex = 5;
            this.af_Address.ZipCode = "";
            // 
            // tp_Summary
            // 
            this.tp_Summary.Controls.Add(this.sc_Summary);
            this.tp_Summary.Location = new System.Drawing.Point(4, 22);
            this.tp_Summary.Name = "tp_Summary";
            this.tp_Summary.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Summary.Size = new System.Drawing.Size(719, 278);
            this.tp_Summary.TabIndex = 2;
            this.tp_Summary.Text = "Summary";
            this.tp_Summary.UseVisualStyleBackColor = true;
            // 
            // sc_Summary
            // 
            this.sc_Summary.Display = null;
            this.sc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_Summary.Location = new System.Drawing.Point(3, 3);
            this.sc_Summary.Name = "sc_Summary";
            this.sc_Summary.Size = new System.Drawing.Size(713, 272);
            this.sc_Summary.TabIndex = 0;
            // 
            // AddCustomerDialog
            // 
            this.AcceptButton = this.btn_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(727, 408);
            this.Controls.Add(this.tc_Creation);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep_InputError)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.tc_Creation.ResumeLayout(false);
            this.tp_Basics.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tp_Address.ResumeLayout(false);
            this.tp_Address.PerformLayout();
            this.tp_Summary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal GenericInputPair gi_EmailAddress;
        internal System.Windows.Forms.TabPage tp_Address;
        internal System.Windows.Forms.TabPage tp_Summary;
        internal SummaryCtrl sc_Summary;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private PhoneNumberField pn_PhoneNumber;
	}
}
