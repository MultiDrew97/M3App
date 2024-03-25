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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            if_Address1 = new GenericInputPair();
            if_City = new GenericInputPair();
            ssf_State = new StateSelectorField();
            if_Address2 = new GenericInputPair();
            if_ZipCode = new GenericInputPair();
            ep_InvalidAddress = new System.Windows.Forms.ErrorProvider(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_InvalidAddress).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0f));
            TableLayoutPanel1.Controls.Add(if_Address1, 0, 0);
            TableLayoutPanel1.Controls.Add(if_City, 0, 1);
            TableLayoutPanel1.Controls.Add(ssf_State, 1, 1);
            TableLayoutPanel1.Controls.Add(if_Address2, 2, 0);
            TableLayoutPanel1.Controls.Add(if_ZipCode, 2, 1);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0f));
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(650, 125);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // if_Address1
            // 
            if_Address1.AutoSize = true;
            if_Address1.Dock = System.Windows.Forms.DockStyle.Fill;
            if_Address1.Label = "Address 1";
            if_Address1.Location = new System.Drawing.Point(6, 6);
            if_Address1.Margin = new System.Windows.Forms.Padding(6);
            if_Address1.Mask = "";
            if_Address1.Name = "if_Address1";
            if_Address1.Placeholder = "Address 1";
            if_Address1.Size = new System.Drawing.Size(248, 49);
            if_Address1.TabIndex = 0;
            if_Address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // if_City
            // 
            if_City.AutoSize = true;
            if_City.Dock = System.Windows.Forms.DockStyle.Fill;
            if_City.Label = "City";
            if_City.Location = new System.Drawing.Point(6, 67);
            if_City.Margin = new System.Windows.Forms.Padding(6);
            if_City.Mask = "";
            if_City.Name = "if_City";
            if_City.Placeholder = "City";
            if_City.Size = new System.Drawing.Size(248, 52);
            if_City.TabIndex = 2;
            if_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ssf_State
            // 
            ssf_State.AutoSize = true;
            ssf_State.Dock = System.Windows.Forms.DockStyle.Fill;
            ssf_State.Location = new System.Drawing.Point(266, 67);
            ssf_State.Margin = new System.Windows.Forms.Padding(6);
            ssf_State.Name = "ssf_State";
            ssf_State.Size = new System.Drawing.Size(118, 52);
            ssf_State.StateCode = "";
            ssf_State.TabIndex = 3;
            // 
            // if_Address2
            // 
            if_Address2.AutoSize = true;
            if_Address2.Dock = System.Windows.Forms.DockStyle.Fill;
            if_Address2.Label = "Address 2";
            if_Address2.Location = new System.Drawing.Point(396, 6);
            if_Address2.Margin = new System.Windows.Forms.Padding(6);
            if_Address2.Mask = "";
            if_Address2.Name = "if_Address2";
            if_Address2.Placeholder = "Address 2";
            if_Address2.Size = new System.Drawing.Size(248, 49);
            if_Address2.TabIndex = 1;
            if_Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // if_ZipCode
            // 
            if_ZipCode.AutoSize = true;
            if_ZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            if_ZipCode.Label = "Zip Code";
            if_ZipCode.Location = new System.Drawing.Point(396, 67);
            if_ZipCode.Margin = new System.Windows.Forms.Padding(6);
            if_ZipCode.Mask = "99999";
            if_ZipCode.Name = "if_ZipCode";
            if_ZipCode.Placeholder = "00000";
            if_ZipCode.Size = new System.Drawing.Size(248, 52);
            if_ZipCode.TabIndex = 4;
            if_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ep_InvalidAddress
            // 
            ep_InvalidAddress.ContainerControl = this;
            // 
            // AddressField
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(650, 125);
            Name = "AddressField";
            Size = new System.Drawing.Size(650, 125);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_InvalidAddress).EndInit();
            ResumeLayout(false);

        }

        internal GenericInputPair if_Address1;
        internal GenericInputPair if_Address2;
        internal GenericInputPair if_City;
        internal GenericInputPair if_ZipCode;
        internal StateSelectorField ssf_State;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.ErrorProvider ep_InvalidAddress;
    }
}