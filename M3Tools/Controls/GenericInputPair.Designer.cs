using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class GenericInputPair : System.Windows.Forms.UserControl
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_InputLabel = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.MaskedTextBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.lbl_InputLabel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.txt_Input, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(225, 45);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_InputLabel
            // 
            this.lbl_InputLabel.AutoSize = true;
            this.lbl_InputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_InputLabel.Location = new System.Drawing.Point(3, 0);
            this.lbl_InputLabel.Name = "lbl_InputLabel";
            this.lbl_InputLabel.Size = new System.Drawing.Size(219, 22);
            this.lbl_InputLabel.TabIndex = 0;
            this.lbl_InputLabel.Text = "Label1";
            this.lbl_InputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Input
            // 
            this.txt_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Input.Location = new System.Drawing.Point(3, 25);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(219, 20);
            this.txt_Input.TabIndex = 1;
            this.txt_Input.TextChanged += new System.EventHandler(this.InputTextChanged);
            this.txt_Input.GotFocus += new System.EventHandler(this.InputGotFocus);
            this.txt_Input.LostFocus += new System.EventHandler(this.InputLostFocus);
            // 
            // GenericInputPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(225, 45);
            this.MinimumSize = new System.Drawing.Size(150, 45);
            this.Name = "GenericInputPair";
            this.Size = new System.Drawing.Size(225, 45);
            this.Load += new System.EventHandler(this.Loading);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label lbl_InputLabel;
        internal System.Windows.Forms.MaskedTextBox txt_Input;
    }
}