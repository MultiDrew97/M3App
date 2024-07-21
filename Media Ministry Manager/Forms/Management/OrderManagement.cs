
using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Orders;

namespace M3App
{
	// TODO: Mimic CustomerManagement
	/// <summary>
	/// 
	/// </summary>
	public partial class OrderManagement
	{
		/// <summary>
		/// 
		/// </summary>
		public OrderManagement() : base()
		{
			InitializeComponent();

			odg_Orders.Reload += new EventHandler(Reload);
			odg_Orders.AddOrder += new OrderEventHandler(Add);
			odg_Orders.UpdateOrder += new OrderEventHandler(Update);
			odg_Orders.RemoveOrder += new OrderEventHandler(Remove);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			odg_Orders.Orders = dbOrders.GetOrders();
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, odg_Orders.Orders.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// Add a new Order to the database from the tool strip
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
			//using var @add = new SPPBC.M3Tools.Dialogs.AddOrderDialog();

			//if (add.ShowDialog() != DialogResult.OK)
			//{
			//	UseWaitCursor = false;
			//	return;
			//}

			//dbOrders.AddOrder(add.Order);
			//MessageBox.Show($"Successfully created order", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Order> e)
		{
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
			//using var @edit = new SPPBC.M3Tools.Dialogs.EditOrderDialog(e.Value);

			//if (edit.ShowDialog() != DialogResult.OK)
			//{
			//	UseWaitCursor = false;
			//	return;
			//}

			//dbOrders.UpdateOrder(edit.Order);
			//MessageBox.Show($"Successfully updated order", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Order> e)
		{
			_ = MessageBox.Show(Properties.Resources.UNDER_CONSTRUCTION_MESSAGE, Properties.Resources.UNDER_CONSTRUCTION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
			//dbOrders.RemoveOrder(e.Value.Id);
			_ = MessageBox.Show($"Successfully removed order", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			odg_Orders.Filter = filter;
		}
	}
}
