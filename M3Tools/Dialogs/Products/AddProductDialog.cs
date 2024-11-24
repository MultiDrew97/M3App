using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
	public partial class AddProductDialog
	{
		// Public Event ItemAdded As InventoryEventHandler
		private event EventHandler PageChangedEvent;

		private string ItemName => gi_Name.Text;

		private int Stock => nud_Stock.Quantity;
		private decimal Price => pi_Price.Price;
		private bool Available => Price > 0m | chk_Available.Checked;

		private bool ValidProduct => true;

		public Types.Product Product => new(-1, ItemName, Stock, Price, Available);

		public AddProductDialog()
		{
			InitializeComponent();

			PageChangedEvent += new EventHandler(PageChanged);
		}

		private void PreviousStep(object sender, EventArgs e)
		{
			switch (tc_Creation.SelectedIndex)
			{
				case var @case when @case == tp_Basics.TabIndex:
				{
					DialogResult res = MessageBox.Show("Are you sure you want to cancel product creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (!(res == DialogResult.Yes))
					{
						return;
					}

					DialogResult = DialogResult.Cancel;
					Close();
					break;
				}

				default:
				{
					tc_Creation.SelectedIndex -= 1;
					PageChangedEvent?.Invoke(this, e);
					break;
				}
			}
		}

		private void NextStep(object sender, EventArgs e)
		{
			switch (tc_Creation.SelectedIndex)
			{
				case var @case when @case == tp_Summary.TabIndex:
				{
					if (!ValidProduct)
					{
						_ = MessageBox.Show("There were errors in your product submission. Please try again.", "Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// RaiseEvent ItemAdded(Me, New InventoryEventArgs(Product))

					DialogResult = DialogResult.OK;
					Close();
					break;
				}

				default:
				{
					tc_Creation.SelectedIndex += 1;
					PageChangedEvent?.Invoke(this, e);
					break;
				}
			}
		}

		private void PageChanged(object sender, EventArgs e)
		{
			btn_Cancel.Text = tc_Creation.SelectedIndex <= tp_Basics.TabIndex ? "Cancel" : "Back";
			btn_Create.Text = tc_Creation.SelectedIndex >= tp_Summary.TabIndex ? "Create" : "Next";
			sc_Summary.Display = tc_Creation.SelectedIndex == tp_Summary.TabIndex ? Product : null;
		}

		private void QuantityNudCtrl1_Load(object sender, EventArgs e)
		{

		}
	}
}
