using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PhoneNumberField : System.Windows.Forms.UserControl
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
            txt_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            lbl_PhoneNumber = new System.Windows.Forms.Label();
            ep_InvalidPhone = new System.Windows.Forms.ErrorProvider(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_InvalidPhone).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            TableLayoutPanel1.Controls.Add(txt_PhoneNumber, 0, 1);
            TableLayoutPanel1.Controls.Add(lbl_PhoneNumber, 0, 0);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(100, 50);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.AllowPromptAsInput = false;
            txt_PhoneNumber.BeepOnError = true;
            txt_PhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            txt_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_PhoneNumber.Location = new System.Drawing.Point(3, 23);
            txt_PhoneNumber.Mask = "(999) 000-0000";
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new System.Drawing.Size(94, 20);
            txt_PhoneNumber.TabIndex = 1;
            txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txt_PhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            lbl_PhoneNumber.Location = new System.Drawing.Point(3, 0);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.Size = new System.Drawing.Size(78, 20);
            lbl_PhoneNumber.TabIndex = 0;
            lbl_PhoneNumber.Text = "Phone Number";
            // 
            // ep_InvalidPhone
            // 
            ep_InvalidPhone.ContainerControl = this;
            // 
            // PhoneNumberField
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MaximumSize = new System.Drawing.Size(0, 50);
            MinimumSize = new System.Drawing.Size(100, 50);
            Name = "PhoneNumberField";
            Size = new System.Drawing.Size(100, 50);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_InvalidPhone).EndInit();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.MaskedTextBox txt_PhoneNumber;
        internal System.Windows.Forms.Label lbl_PhoneNumber;
        internal System.Windows.Forms.ErrorProvider ep_InvalidPhone;
    }
}