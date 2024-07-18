using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	public partial class OrderDataGrid
	{
		// Columns for the data grid
		private readonly DataGridViewTextBoxColumn dgc_CustomerName;
		private readonly DataGridViewTextBoxColumn dgc_ItemName;
		private readonly DataGridViewTextBoxColumn dgc_OrderTotal;
		private readonly DataGridViewTextBoxColumn dgc_OrderDate;
		private readonly DataGridViewTextBoxColumn dgc_CompletedDate;

		/// <summary>
		/// Event that occurs when a order is being added to the database
		/// </summary>
		public event Events.Orders.OrderEventHandler AddOrder;

		/// <summary>
		/// Event that occurs when a order is being removed from the database
		/// </summary>
		public event Events.Orders.OrderEventHandler RemoveOrder;

		/// <summary>
		/// Event that occurs when a order is being updated in the database
		/// </summary>
		public event Events.Orders.OrderEventHandler UpdateOrder;

		/// <summary>
		/// The list of orders currently in the data grid
		/// </summary>
		[Browsable(false)]
		public Types.OrderCollection Orders
		{
			get => Types.OrderCollection.Cast(bsOrders.List);
			set
			{
				if (DesignMode) return;
				bsOrders.DataSource = value;
			}
		}

		/// <summary>
		/// The filter to place on the data in the grid
		/// </summary>
		public string Filter
		{
			get => bsOrders.Filter;
			set => bsOrders.Filter = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public new Types.OrderCollection SelectedRows
		{
			get => Types.OrderCollection.Cast(base.SelectedRows);
		}

		/// <summary>
		/// 
		/// </summary>
		public OrderDataGrid() : base()
		{
			InitializeComponent();

			dgc_CustomerName = new DataGridViewTextBoxColumn();
			dgc_ItemName = new DataGridViewTextBoxColumn();
			dgc_OrderTotal = new DataGridViewTextBoxColumn();
			dgc_OrderDate = new DataGridViewTextBoxColumn();
			dgc_CompletedDate = new DataGridViewTextBoxColumn();

			LoadColumns();

			AddEntry += (sender, e) => AddOrder?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateOrder?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveOrder?.Invoke(sender, new(e.Value, e.EventType));
		}

		/// <summary>
		/// 
		/// </summary>
		protected new void LoadColumns()
		{
			base.LoadColumns();

			dgc_ID.HeaderText = "OrderID";

			// 
			// dgc_CustomerName
			// 
			dgc_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dgc_CustomerName.FillWeight = 25F;
			dgc_CustomerName.HeaderText = "Customer";
			dgc_CustomerName.MinimumWidth = 10;
			dgc_CustomerName.Name = "dgc_CustomerName";
			dgc_CustomerName.ReadOnly = true;
			// 
			// dgc_ItemName
			// 
			dgc_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_ItemName.FillWeight = 25F;
			dgc_ItemName.HeaderText = "Item";
			dgc_ItemName.MinimumWidth = 10;
			dgc_ItemName.Name = "dgc_ItemName";
			dgc_ItemName.ReadOnly = true;
			// 
			// dgc_OrderTotal
			// 
			dgc_OrderTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_OrderTotal.DataPropertyName = "Total";
			dgc_OrderTotal.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "C2", NullValue = "0" };
			dgc_OrderTotal.FillWeight = 25F;
			dgc_OrderTotal.HeaderText = "Total";
			dgc_OrderTotal.MinimumWidth = 50;
			dgc_OrderTotal.Name = "dgc_OrderTotal";
			dgc_OrderTotal.ReadOnly = true;
			// 
			// dgc_OrderDate
			// 
			dgc_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_OrderDate.DataPropertyName = "OrderDate";
			dgc_OrderDate.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" };
			dgc_OrderDate.FillWeight = 25F;
			dgc_OrderDate.HeaderText = "Ordered";
			dgc_OrderDate.MinimumWidth = 10;
			dgc_OrderDate.Name = "dgc_OrderDate";
			dgc_OrderDate.ReadOnly = true;
			// 
			// dgc_CompletedDate
			// 
			dgc_CompletedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dgc_CompletedDate.DataPropertyName = "CompletedDate";
			dgc_CompletedDate.DefaultCellStyle = new() { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "d", NullValue = "N/A" };
			dgc_CompletedDate.FillWeight = 25F;
			dgc_CompletedDate.HeaderText = "Completed";
			dgc_CompletedDate.MinimumWidth = 10;
			dgc_CompletedDate.Name = "dgc_CompletedDate";
			dgc_CompletedDate.ReadOnly = true;

			Columns.AddRange(new DataGridViewColumn[] {
			dgc_Selection,
			dgc_ID,
			dgc_CustomerName,
			dgc_ItemName,
			dgc_OrderTotal,
			dgc_OrderDate,
			dgc_CompletedDate,
			dgc_Edit,
			dgc_Remove});
		}
	}
}
