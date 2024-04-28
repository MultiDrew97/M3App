using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class EditOrderDialog : System.Windows.Forms.Form
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
			components = new System.ComponentModel.Container();
			TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			OK_Button = new System.Windows.Forms.Button();
			OK_Button.Click += new EventHandler(Finished);
			Cancel_Button = new System.Windows.Forms.Button();
			Cancel_Button.Click += new EventHandler(Cancel);
			bw_LoadOrder = new System.ComponentModel.BackgroundWorker();
			bw_LoadOrder.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadOrder);
			bw_LoadOrder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(OrderLoaded);
			gi_CustomerName = new GenericInputPair();
			qnc_Quantity = new QuantityNudCtrl();
			qnc_Quantity.QuantityChanged += new QuantityNudCtrl.QuantityChangedEventHandler(QuantityUpdated);
			pcb_Items = new ProductsComboBox();
			pcb_Items.LoadBegin += new ProductsComboBox.LoadBeginEventHandler(ItemsLoadBegin);
			pcb_Items.LoadEnd += new ProductsComboBox.LoadEndEventHandler(ItemsLoadEnd);
			pcb_Items.SelectedItemChanged += new ProductsComboBox.SelectedItemChangedEventHandler(SelectedItemChanged);
			db_Orders = new Database.OrdersDatabase(components);
			TableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// TableLayoutPanel1
			// 
			TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			TableLayoutPanel1.ColumnCount = 2;
			TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
			TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
			TableLayoutPanel1.Controls.Add(OK_Button, 1, 0);
			TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
			TableLayoutPanel1.Location = new System.Drawing.Point(199, 187);
			TableLayoutPanel1.Name = "TableLayoutPanel1";
			TableLayoutPanel1.RowCount = 1;
			TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
			TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
			TableLayoutPanel1.TabIndex = 0;
			// 
			// OK_Button
			// 
			OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			OK_Button.Location = new System.Drawing.Point(76, 3);
			OK_Button.Name = "OK_Button";
			OK_Button.Size = new System.Drawing.Size(67, 23);
			OK_Button.TabIndex = 0;
			OK_Button.Text = "OK";
			// 
			// Cancel_Button
			// 
			Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Cancel_Button.Location = new System.Drawing.Point(3, 3);
			Cancel_Button.Name = "Cancel_Button";
			Cancel_Button.Size = new System.Drawing.Size(67, 23);
			Cancel_Button.TabIndex = 1;
			Cancel_Button.Text = "Cancel";
			// 
			// bw_LoadOrder
			// 
			// 
			// gi_CustomerName
			// 
			gi_CustomerName.AutoSize = true;
			gi_CustomerName.Label = "Customer Name";
			gi_CustomerName.Location = new System.Drawing.Point(24, 25);
			gi_CustomerName.Mask = "";
			gi_CustomerName.Name = "gi_CustomerName";
			gi_CustomerName.Placeholder = null;
			gi_CustomerName.ReadOnly = true;
			gi_CustomerName.Size = new System.Drawing.Size(308, 46);
			gi_CustomerName.TabIndex = 5;
			gi_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// qnc_Quantity
			// 
			qnc_Quantity.Location = new System.Drawing.Point(128, 125);
			qnc_Quantity.MaximumSize = new System.Drawing.Size(0, 42);
			qnc_Quantity.MinimumSize = new System.Drawing.Size(100, 42);
			qnc_Quantity.Name = "qnc_Quantity";
			qnc_Quantity.Quantity = 0;
			qnc_Quantity.Size = new System.Drawing.Size(100, 42);
			qnc_Quantity.TabIndex = 4;
			// 
			// pcb_Items
			// 
			pcb_Items.AutoSize = true;
			pcb_Items.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			pcb_Items.Location = new System.Drawing.Point(78, 77);
			pcb_Items.MaximumSize = new System.Drawing.Size(0, 42);
			pcb_Items.MinimumSize = new System.Drawing.Size(200, 42);
			pcb_Items.Name = "pcb_Items";
			pcb_Items.SelectedIndex = -1;
			pcb_Items.SelectedValue = null;
			pcb_Items.Size = new System.Drawing.Size(200, 42);
			pcb_Items.TabIndex = 3;
			// 
			// EditOrderDialog
			// 
			AcceptButton = OK_Button;
			AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			CancelButton = Cancel_Button;
			ClientSize = new System.Drawing.Size(357, 228);
			Controls.Add(gi_CustomerName);
			Controls.Add(qnc_Quantity);
			Controls.Add(pcb_Items);
			Controls.Add(TableLayoutPanel1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "EditOrderDialog";
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Update Order";
			TableLayoutPanel1.ResumeLayout(false);
			Load += new EventHandler(DialogLoading);
			ResumeLayout(false);
			PerformLayout();

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.ComponentModel.BackgroundWorker bw_LoadOrder;
		internal Database.OrdersDatabase db_Orders;
		internal ProductsComboBox pcb_Items;
		internal QuantityNudCtrl qnc_Quantity;
		internal GenericInputPair gi_CustomerName;
	}
}
