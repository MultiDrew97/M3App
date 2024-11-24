using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddProductDialog : System.Windows.Forms.Form
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
            btn_Create = new System.Windows.Forms.Button();
            btn_Create.Click += new EventHandler(NextStep);
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(PreviousStep);
            tc_Creation = new System.Windows.Forms.TabControl();
            tc_Creation.SelectedIndexChanged += new EventHandler(PageChanged);
            tp_Basics = new System.Windows.Forms.TabPage();
            pi_Price = new PriceInput();
            gi_Name = new GenericInputPair();
            nud_Stock = new QuantityNudCtrl();
            nud_Stock.Load += new EventHandler(QuantityNudCtrl1_Load);
            chk_Available = new System.Windows.Forms.CheckBox();
            tp_Description = new System.Windows.Forms.TabPage();
            rtb_Description = new System.Windows.Forms.RichTextBox();
            tp_Summary = new System.Windows.Forms.TabPage();
            sc_Summary = new SummaryCtrl();
            hp_Info = new System.Windows.Forms.HelpProvider();
            TableLayoutPanel1.SuspendLayout();
            tc_Creation.SuspendLayout();
            tp_Basics.SuspendLayout();
            tp_Description.SuspendLayout();
            tp_Summary.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(210, 302);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Create
            // 
            btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Create.Location = new System.Drawing.Point(76, 3);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(67, 23);
            btn_Create.TabIndex = 1;
            btn_Create.Text = "Next";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            // 
            // tc_Creation
            // 
            tc_Creation.Controls.Add(tp_Basics);
            tc_Creation.Controls.Add(tp_Description);
            tc_Creation.Controls.Add(tp_Summary);
            tc_Creation.Dock = System.Windows.Forms.DockStyle.Top;
            tc_Creation.Location = new System.Drawing.Point(0, 0);
            tc_Creation.Name = "tc_Creation";
            tc_Creation.SelectedIndex = 0;
            tc_Creation.Size = new System.Drawing.Size(368, 271);
            tc_Creation.TabIndex = 0;
            // 
            // tp_Basics
            // 
            tp_Basics.Controls.Add(pi_Price);
            tp_Basics.Controls.Add(gi_Name);
            tp_Basics.Controls.Add(nud_Stock);
            tp_Basics.Controls.Add(chk_Available);
            tp_Basics.Location = new System.Drawing.Point(4, 22);
            tp_Basics.Name = "tp_Basics";
            tp_Basics.Padding = new System.Windows.Forms.Padding(3);
            tp_Basics.Size = new System.Drawing.Size(360, 245);
            tp_Basics.TabIndex = 0;
            tp_Basics.Text = "Basics";
            tp_Basics.UseVisualStyleBackColor = true;
            // 
            // pi_Price
            // 
            pi_Price.AutoSize = true;
            pi_Price.Location = new System.Drawing.Point(100, 130);
            pi_Price.MaximumSize = new System.Drawing.Size(0, 45);
            pi_Price.MinimumSize = new System.Drawing.Size(150, 45);
            pi_Price.Name = "pi_Price";
            pi_Price.Price = new decimal(new int[] { 0, 0, 0, 131072 });
            pi_Price.Size = new System.Drawing.Size(150, 45);
            pi_Price.TabIndex = 2;
            // 
            // gi_Name
            // 
            gi_Name.AutoSize = true;
            gi_Name.Label = "Name";
            gi_Name.Location = new System.Drawing.Point(30, 21);
            gi_Name.Mask = "";
            gi_Name.MaximumSize = new System.Drawing.Size(0, 45);
            gi_Name.MinimumSize = new System.Drawing.Size(300, 45);
            gi_Name.Name = "gi_Name";
            gi_Name.Placeholder = "Product Name";
            gi_Name.Size = new System.Drawing.Size(300, 45);
            gi_Name.TabIndex = 0;
            gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nud_Stock
            // 
            nud_Stock.Label = "Stock";
            nud_Stock.Location = new System.Drawing.Point(130, 82);
            nud_Stock.MaximumSize = new System.Drawing.Size(0, 42);
            nud_Stock.MinimumSize = new System.Drawing.Size(100, 42);
            nud_Stock.Name = "nud_Stock";
            nud_Stock.Size = new System.Drawing.Size(100, 42);
            nud_Stock.TabIndex = 1;
            // 
            // chk_Available
            // 
            chk_Available.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            chk_Available.AutoSize = true;
            hp_Info.SetHelpKeyword(chk_Available, "availability");
            hp_Info.SetHelpString(chk_Available, "Whether the new item will be available upon creation");
            chk_Available.Location = new System.Drawing.Point(143, 201);
            chk_Available.Name = "chk_Available";
            hp_Info.SetShowHelp(chk_Available, true);
            chk_Available.Size = new System.Drawing.Size(75, 17);
            chk_Available.TabIndex = 3;
            chk_Available.Text = "Available?";
            chk_Available.UseVisualStyleBackColor = true;
            // 
            // tp_Description
            // 
            tp_Description.Controls.Add(rtb_Description);
            tp_Description.Location = new System.Drawing.Point(4, 22);
            tp_Description.Name = "tp_Description";
            tp_Description.Padding = new System.Windows.Forms.Padding(3);
            tp_Description.Size = new System.Drawing.Size(360, 245);
            tp_Description.TabIndex = 1;
            tp_Description.Text = "Product Description";
            tp_Description.UseVisualStyleBackColor = true;
            // 
            // rtb_Description
            // 
            rtb_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            rtb_Description.Location = new System.Drawing.Point(3, 3);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.Size = new System.Drawing.Size(354, 239);
            rtb_Description.TabIndex = 0;
            rtb_Description.Text = "";
            // 
            // tp_Summary
            // 
            tp_Summary.Controls.Add(sc_Summary);
            tp_Summary.Location = new System.Drawing.Point(4, 22);
            tp_Summary.Name = "tp_Summary";
            tp_Summary.Padding = new System.Windows.Forms.Padding(3);
            tp_Summary.Size = new System.Drawing.Size(360, 245);
            tp_Summary.TabIndex = 2;
            tp_Summary.Text = "Summary";
            tp_Summary.UseVisualStyleBackColor = true;
            // 
            // sc_Summary
            // 
            sc_Summary.Display = null;
            sc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            sc_Summary.Location = new System.Drawing.Point(3, 3);
            sc_Summary.Name = "sc_Summary";
            sc_Summary.Size = new System.Drawing.Size(354, 239);
            sc_Summary.TabIndex = 0;
            // 
            // AddProductDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(368, 343);
            Controls.Add(tc_Creation);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Product";
            TableLayoutPanel1.ResumeLayout(false);
            tc_Creation.ResumeLayout(false);
            tp_Basics.ResumeLayout(false);
            tp_Basics.PerformLayout();
            tp_Description.ResumeLayout(false);
            tp_Summary.ResumeLayout(false);
            ResumeLayout(false);

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Create;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.TabControl tc_Creation;
        internal System.Windows.Forms.TabPage tp_Basics;
        internal System.Windows.Forms.TabPage tp_Description;
        internal System.Windows.Forms.TabPage tp_Summary;
        internal SummaryCtrl sc_Summary;
        internal System.Windows.Forms.RichTextBox rtb_Description;
        internal System.Windows.Forms.CheckBox chk_Available;
        internal System.Windows.Forms.HelpProvider hp_Info;
        internal QuantityNudCtrl nud_Stock;
        internal GenericInputPair gi_Name;
        internal PriceInput pi_Price;
    }
}
