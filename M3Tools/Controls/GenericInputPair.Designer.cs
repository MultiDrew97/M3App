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
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lbl_InputLabel = new System.Windows.Forms.Label();
            txt_Input = new System.Windows.Forms.MaskedTextBox();
            txt_Input.TextChanged += new EventHandler(InputTextChanged);
            txt_Input.GotFocus += new EventHandler(InputGotFocus);
            txt_Input.LostFocus += new EventHandler(InputLostFocus);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(lbl_InputLabel, 0, 0);
            TableLayoutPanel1.Controls.Add(txt_Input, 0, 1);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(300, 45);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_InputLabel
            // 
            lbl_InputLabel.AutoSize = true;
            lbl_InputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_InputLabel.Location = new System.Drawing.Point(3, 0);
            lbl_InputLabel.Name = "lbl_InputLabel";
            lbl_InputLabel.Size = new System.Drawing.Size(294, 22);
            lbl_InputLabel.TabIndex = 0;
            lbl_InputLabel.Text = "Label1";
            lbl_InputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Input
            // 
            txt_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Input.Location = new System.Drawing.Point(3, 25);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new System.Drawing.Size(294, 20);
            txt_Input.TabIndex = 1;
            // 
            // GenericInputPair
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MaximumSize = new System.Drawing.Size(0, 45);
            MinimumSize = new System.Drawing.Size(300, 45);
            Name = "GenericInputPair";
            Size = new System.Drawing.Size(300, 45);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Load += new EventHandler(Loading);
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label lbl_InputLabel;
        internal System.Windows.Forms.MaskedTextBox txt_Input;
    }
}