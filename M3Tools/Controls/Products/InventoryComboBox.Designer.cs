using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class InventoryComboBox : System.Windows.Forms.UserControl
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
            this.cbx_Items = new System.Windows.Forms.ComboBox();
            this.bsInventory = new SPPBC.M3Tools.Data.InventoryBindingSource();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.cbx_Items, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.lbl_Items, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(200, 42);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // cbx_Items
            // 
            this.cbx_Items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Items.DataSource = this.bsInventory;
            this.cbx_Items.DisplayMember = "Name";
            this.cbx_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Items.FormattingEnabled = true;
            this.cbx_Items.Location = new System.Drawing.Point(3, 16);
            this.cbx_Items.Name = "cbx_Items";
            this.cbx_Items.Size = new System.Drawing.Size(194, 21);
            this.cbx_Items.TabIndex = 2;
            this.cbx_Items.ValueMember = "Id";
            // 
            // bsInventory
            // 
            this.bsInventory.DataSource = typeof(SPPBC.M3Tools.Types.InventoryCollection);
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Items.Location = new System.Drawing.Point(3, 0);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(194, 13);
            this.lbl_Items.TabIndex = 0;
            this.lbl_Items.Text = "Inventory";
            // 
            // InventoryComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(0, 42);
            this.MinimumSize = new System.Drawing.Size(200, 42);
            this.Name = "InventoryComboBox";
            this.Size = new System.Drawing.Size(200, 42);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).EndInit();
            this.ResumeLayout(false);

		}

		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Label lbl_Items;
		internal System.Windows.Forms.ComboBox cbx_Items;
		private Data.InventoryBindingSource bsInventory;
	}
}
