using System;
using System.Collections;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	public partial class OrderDataGrid
	{
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
		/// 
		/// </summary>
		public new object DataSource
		{
			get => DesignMode ? typeof(OrderBindingSource) : (OrderBindingSource)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// The list of orders currently in the data grid
		/// </summary>
		[Browsable(false)]
		public Types.OrderCollection Orders
		{
			get => Types.OrderCollection.Cast(base.Rows);
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

			AddEntry += (sender, e) => AddOrder?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateOrder?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveOrder?.Invoke(sender, new(e.Value, e.EventType));
		}
	}
}
