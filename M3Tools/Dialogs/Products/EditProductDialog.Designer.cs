using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class EditProductDialog : System.Windows.Forms.Form
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pi_Price = new SPPBC.M3Tools.PriceInput();
            this.gi_Name = new SPPBC.M3Tools.GenericInputPair();
            this.qn_Stock = new SPPBC.M3Tools.QuantityNudCtrl();
            this.chk_Available = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.btn_Done, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(197, 232);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 4;
            // 
            // btn_Done
            // 
            this.btn_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Done.Location = new System.Drawing.Point(76, 3);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(67, 23);
            this.btn_Done.TabIndex = 0;
            this.btn_Done.Text = "Done";
            this.btn_Done.Click += new System.EventHandler(this.FinishDialog);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.CancelDialog);
            // 
            // pi_Price
            // 
            this.pi_Price.AutoSize = true;
            this.pi_Price.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pi_Price.Location = new System.Drawing.Point(102, 136);
            this.pi_Price.MaximumSize = new System.Drawing.Size(150, 45);
            this.pi_Price.MinimumSize = new System.Drawing.Size(150, 45);
            this.pi_Price.Name = "pi_Price";
            this.pi_Price.Price = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.pi_Price.Size = new System.Drawing.Size(150, 45);
            this.pi_Price.TabIndex = 2;
            // 
            // gi_Name
            // 
            this.gi_Name.AutoSize = true;
            this.gi_Name.Label = "Name";
            this.gi_Name.Location = new System.Drawing.Point(27, 21);
            this.gi_Name.Mask = "";
            this.gi_Name.MaximumSize = new System.Drawing.Size(0, 45);
            this.gi_Name.MinimumSize = new System.Drawing.Size(300, 45);
            this.gi_Name.Name = "gi_Name";
            this.gi_Name.Placeholder = "Product Name";
            this.gi_Name.Size = new System.Drawing.Size(300, 45);
            this.gi_Name.TabIndex = 0;
            this.gi_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // qn_Stock
            // 
            this.qn_Stock.Label = "Stock";
            this.qn_Stock.Location = new System.Drawing.Point(127, 80);
            this.qn_Stock.MaximumSize = new System.Drawing.Size(0, 42);
            this.qn_Stock.MaximumValue = 100;
            this.qn_Stock.MinimumSize = new System.Drawing.Size(100, 42);
            this.qn_Stock.Name = "qn_Stock";
            this.qn_Stock.Size = new System.Drawing.Size(100, 42);
            this.qn_Stock.TabIndex = 1;
            // 
            // chk_Available
            // 
            this.chk_Available.AutoSize = true;
            this.chk_Available.Location = new System.Drawing.Point(140, 195);
            this.chk_Available.Name = "chk_Available";
            this.chk_Available.Size = new System.Drawing.Size(75, 17);
            this.chk_Available.TabIndex = 3;
            this.chk_Available.Text = "Available?";
            this.chk_Available.UseVisualStyleBackColor = true;
            // 
            // EditProductDialog
            // 
            this.AcceptButton = this.btn_Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(355, 273);
            this.Controls.Add(this.pi_Price);
            this.Controls.Add(this.gi_Name);
            this.Controls.Add(this.qn_Stock);
            this.Controls.Add(this.chk_Available);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit {0}";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button btn_Done;
		internal System.Windows.Forms.Button btn_Cancel;
		internal PriceInput pi_Price;
		internal GenericInputPair gi_Name;
		internal QuantityNudCtrl qn_Stock;
		internal System.Windows.Forms.CheckBox chk_Available;
	}
}
