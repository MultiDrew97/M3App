using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class StateSelectorField : System.Windows.Forms.UserControl
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
            Label1 = new System.Windows.Forms.Label();
            cbx_States = new System.Windows.Forms.ComboBox();
            cbx_States.TextChanged += new EventHandler(cbx_States_TextChanged);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            TableLayoutPanel1.Controls.Add(Label1, 0, 0);
            TableLayoutPanel1.Controls.Add(cbx_States, 0, 1);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            TableLayoutPanel1.Size = new System.Drawing.Size(104, 50);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Dock = System.Windows.Forms.DockStyle.Left;
            Label1.Location = new System.Drawing.Point(8, 5);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(32, 13);
            Label1.TabIndex = 0;
            Label1.Text = "State";
            // 
            // cbx_States
            // 
            cbx_States.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbx_States.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbx_States.Dock = System.Windows.Forms.DockStyle.Fill;
            cbx_States.FormattingEnabled = true;
            cbx_States.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            cbx_States.Location = new System.Drawing.Point(8, 21);
            cbx_States.Name = "cbx_States";
            cbx_States.Size = new System.Drawing.Size(88, 21);
            cbx_States.TabIndex = 1;
            // 
            // StateSelectorField
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(100, 50);
            Name = "StateSelectorField";
            Size = new System.Drawing.Size(104, 50);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbx_States;
    }
}