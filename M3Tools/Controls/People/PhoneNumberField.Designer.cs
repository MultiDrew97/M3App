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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.ep_InvalidPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_InvalidPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.txt_PhoneNumber, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.lbl_PhoneNumber, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(100, 45);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.AllowPromptAsInput = false;
            this.txt_PhoneNumber.BeepOnError = true;
            this.txt_PhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(3, 23);
            this.txt_PhoneNumber.Mask = "(999) 000-0000";
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(94, 20);
            this.txt_PhoneNumber.TabIndex = 1;
            this.txt_PhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(3, 0);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(94, 20);
            this.lbl_PhoneNumber.TabIndex = 0;
            this.lbl_PhoneNumber.Text = "Phone Number";
            this.lbl_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ep_InvalidPhone
            // 
            this.ep_InvalidPhone.ContainerControl = this;
            // 
            // PhoneNumberField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(150, 45);
            this.MinimumSize = new System.Drawing.Size(100, 45);
            this.Name = "PhoneNumberField";
            this.Size = new System.Drawing.Size(100, 45);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_InvalidPhone)).EndInit();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.MaskedTextBox txt_PhoneNumber;
        internal System.Windows.Forms.Label lbl_PhoneNumber;
        internal System.Windows.Forms.ErrorProvider ep_InvalidPhone;
    }
}
