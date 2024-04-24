using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressField : System.Windows.Forms.UserControl
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
            this.components = new System.ComponentModel.Container();
            this.ep_InvalidAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.if_Address1 = new SPPBC.M3Tools.GenericInputPair();
            this.if_Address2 = new SPPBC.M3Tools.GenericInputPair();
            this.if_City = new SPPBC.M3Tools.GenericInputPair();
            this.ssf_State = new SPPBC.M3Tools.StateSelectorField();
            this.if_ZipCode = new SPPBC.M3Tools.GenericInputPair();
            ((System.ComponentModel.ISupportInitialize)(this.ep_InvalidAddress)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep_InvalidAddress
            // 
            this.ep_InvalidAddress.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.if_Address1);
            this.flowLayoutPanel1.Controls.Add(this.if_Address2);
            this.flowLayoutPanel1.Controls.Add(this.if_City);
            this.flowLayoutPanel1.Controls.Add(this.ssf_State);
            this.flowLayoutPanel1.Controls.Add(this.if_ZipCode);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 198);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // if_Address1
            // 
            this.if_Address1.AutoSize = true;
            this.if_Address1.Label = "Address 1";
            this.if_Address1.Location = new System.Drawing.Point(25, 25);
            this.if_Address1.Margin = new System.Windows.Forms.Padding(25);
            this.if_Address1.Mask = "";
            this.if_Address1.MinimumSize = new System.Drawing.Size(300, 45);
            this.if_Address1.Name = "if_Address1";
            this.if_Address1.Placeholder = "Address 1";
            this.if_Address1.Size = new System.Drawing.Size(300, 45);
            this.if_Address1.TabIndex = 0;
            this.if_Address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // if_Address2
            // 
            this.if_Address2.AutoSize = true;
            this.if_Address2.Cursor = System.Windows.Forms.Cursors.Default;
            this.if_Address2.Label = "Address 2";
            this.if_Address2.Location = new System.Drawing.Point(375, 25);
            this.if_Address2.Margin = new System.Windows.Forms.Padding(25);
            this.if_Address2.Mask = "";
            this.if_Address2.MinimumSize = new System.Drawing.Size(300, 45);
            this.if_Address2.Name = "if_Address2";
            this.if_Address2.Placeholder = "Address 2";
            this.if_Address2.Size = new System.Drawing.Size(300, 45);
            this.if_Address2.TabIndex = 1;
            this.if_Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // if_City
            // 
            this.if_City.AutoSize = true;
            this.if_City.Label = "City";
            this.if_City.Location = new System.Drawing.Point(25, 120);
            this.if_City.Margin = new System.Windows.Forms.Padding(25);
            this.if_City.Mask = "";
            this.if_City.MinimumSize = new System.Drawing.Size(300, 45);
            this.if_City.Name = "if_City";
            this.if_City.Placeholder = "City";
            this.if_City.Size = new System.Drawing.Size(300, 45);
            this.if_City.TabIndex = 2;
            this.if_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ssf_State
            // 
            this.ssf_State.AutoSize = true;
            this.ssf_State.Location = new System.Drawing.Point(370, 120);
            this.ssf_State.Margin = new System.Windows.Forms.Padding(20, 25, 20, 20);
            this.ssf_State.MinimumSize = new System.Drawing.Size(100, 50);
            this.ssf_State.Name = "ssf_State";
            this.ssf_State.Size = new System.Drawing.Size(100, 50);
            this.ssf_State.StateCode = "";
            this.ssf_State.TabIndex = 3;
            // 
            // if_ZipCode
            // 
            this.if_ZipCode.AutoSize = true;
            this.if_ZipCode.Label = "Zip Code";
            this.if_ZipCode.Location = new System.Drawing.Point(515, 120);
            this.if_ZipCode.Margin = new System.Windows.Forms.Padding(25);
            this.if_ZipCode.Mask = "99999";
            this.if_ZipCode.MinimumSize = new System.Drawing.Size(150, 45);
            this.if_ZipCode.Name = "if_ZipCode";
            this.if_ZipCode.Placeholder = "00000";
            this.if_ZipCode.Size = new System.Drawing.Size(150, 45);
            this.if_ZipCode.TabIndex = 4;
            this.if_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(650, 125);
            this.Name = "AddressField";
            this.Size = new System.Drawing.Size(706, 198);
            ((System.ComponentModel.ISupportInitialize)(this.ep_InvalidAddress)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal GenericInputPair if_Address1;
        internal GenericInputPair if_Address2;
        internal GenericInputPair if_City;
        internal GenericInputPair if_ZipCode;
        internal StateSelectorField ssf_State;
        internal System.Windows.Forms.ErrorProvider ep_InvalidAddress;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
