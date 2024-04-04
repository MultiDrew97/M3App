using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

	public partial class DisplayOrdersCtrl
	{
		// TODO: Implement a way to change between current and completed orders
		// TODO: Make an event for when the count is updated
		// TODO: Convert DataGridView to TreeView so that orders for the same person can be grouped together
		// TODO: Instead of TreeView, use something in the containing ToolStripContainer
		private event ShowCompletedChangedEventHandler ShowCompletedChanged;

		private delegate void ShowCompletedChangedEventHandler();
		public event DataChangedEventHandler DataChanged;

		public delegate void DataChangedEventHandler();

		// Private ReadOnly _orders As New Types.DBEntryCollection(Of Types.Order)
		private bool _showCompleted = false;
		private bool Confirmed = false;

		public bool ShowCompleted
		{
			get
			{
				return _showCompleted;
			}
			set
			{
				_showCompleted = value;
				ShowCompletedChanged?.Invoke();
			}
		}

		public string Filter
		{
			get
			{
				return bsOrders.Filter;
			}
			set
			{
				bsOrders.Filter = value;
			}
		}

		public DisplayOrdersCtrl()
		{
			InitializeComponent();
		}

		// Property DataSource As BindingSource
		// Get
		// Return odg_Orders.DataSource
		// End Get
		// Set(value As BindingSource)
		// odg_Orders.DataSource = value
		// End Set
		// End Property

		public void FulfilOrder()
		{
			int orderID;

			if (dgv_Orders.SelectedRows.Count > 0 | dgv_Orders.SelectedCells.Count > 0)
			{
				foreach (DataGridViewRow row in dgv_Orders.SelectedRows)
				{
					orderID = Conversions.ToInteger(((DataRowView)row.DataBoundItem)["OrderID"]);
					db_Orders.CompleteOrder(orderID);
					dgv_Orders.Rows.RemoveAt(row.Index);
				}
			}
			else
			{
				MessageBox.Show("You must select at least 1 order to fulfill it.", "Select an Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ToggleCompleted()
		{
			if (!ShowCompleted)
			{
				return;
			}

			Filter = !ShowCompleted ? "[CompletedDate] IS NULL" : "";
		}

		private void LoadOrders(object sender, DoWorkEventArgs e)
		{
			try
			{
				// TODO: Figure out how to sort the table to sort by order date
				// DdataSource.Clear()
				foreach (var order in db_Orders.GetOrders())
				{
					// DataSource.Add(order)
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				e.Cancel = true;
				return;
			}
		}

		private void ControlLoaded(object sender, EventArgs e)
		{

		}

		public void Reload()
		{
			UseWaitCursor = true;
			bw_LoadOrders.RunWorkerAsync();
		}

		private void OrdersLoaded()
		{
			UseWaitCursor = false;
			// TODO: Play around with this to make sure it works
			ShowCompleted = false;
			DataChanged?.Invoke();
			dgv_Orders.Refresh();
		}

		private void CellClicked(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			// ToolButtonsClicked(e.ColumnIndex, DataSource(e.RowIndex).Id)
		}

		private void UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			Confirmed = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

			if (!Confirmed | dgv_Orders.SelectedRows.Count < 1)
			{
				e.Cancel = true;
				return;
			}

			ClearSelectedRows();
			e.Row.Selected = true;
			RemoveSelectedRows();
		}
		private void RemoveRowByToolStrip(object sender, EventArgs e)
		{
			Confirmed = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

			if (!Confirmed || dgv_Orders.SelectedRows.Count < 1)
			{
				return;
			}

			RemoveSelectedRows();

			// TODO: Open a dialog for bulk deletion
			// Using bulk As New BulkDeletionDialog(dgv_CustomerTable)
			// bulk.ShowDialog()
			// End Using
		}

		private void ClearSelectedRows()
		{
			foreach (DataGridViewRow row in dgv_Orders.SelectedRows)
				row.Selected = false;
		}

		private void RemoveSelectedRows()
		{
			int id;
			int failed = 0;
			int total = dgv_Orders.SelectedRows.Count;

			foreach (DataGridViewRow row in dgv_Orders.SelectedRows)
			{
				try
				{
					id = (int)row.Cells["CustomerID"].Value;
					db_Orders.CancelOrder(id);
				}
				catch
				{
					failed += 1;
				}
			}

			if (failed > 0)
			{
				MessageBox.Show($"Failed to remove {failed} customer{(failed > 1 ? "s" : "")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (total - failed > 0)
			{
				MessageBox.Show($"Successfully removed {total - failed} customer{(total - failed > 1 ? "s" : "")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ToolButtonsClicked(int colIndex, int orderID)
		{
			switch (colIndex)
			{
				case var @case when @case == btn_Complete.Index:
					{
						break;
					}
				// Complete Order
				// db_Orders.CompleteOrder(orderID)
				case var case1 when case1 == btn_Cancel.Index:
					{
						break;
					}
				// Cancel Order
				// db_Orders.CancelOrder(orderID)
				case var case2 when case2 == btn_Edit.Index:
					{
						// Edit Order
						using var edit = new EditOrderDialog(orderID);
						if (edit.ShowDialog(this) == DialogResult.OK)
						{
							Reload();
						}

						break;
					}
			}
		}

		private void ShowCompletedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowCompleted = true;
		}

		private void PlaceOrder(object sender, EventArgs e)
		{
			using var placeOrder = new PlaceOrderDialog();

			if (placeOrder.ShowDialog() == DialogResult.Yes)
			{
				Reload();
			}
		}

		private void OrdersLoaded(object sender, RunWorkerCompletedEventArgs e) => OrdersLoaded();
		private void Reload(object sender, EventArgs e) => Reload();
	}
}
