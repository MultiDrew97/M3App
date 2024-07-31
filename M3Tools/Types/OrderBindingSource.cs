using System.ComponentModel;

using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// 
	/// </summary>
	public partial class OrderBindingSource
	{
		private readonly string OrderFilter = "[CustomerName] LIKE '%{0}%' OR [ItemName] LIKE '%{0}%'";

		/// <summary>
		/// 
		/// </summary>
		public OrderBindingSource() : base() => DataSource = new OrderCollection();

		/// <summary>
		/// 
		/// </summary>
		[Category("Data")]
		public new object DataSource
		{
			get => DesignMode ? typeof(OrderCollection) : (OrderCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = string.IsNullOrEmpty(value) ? value : string.Format(OrderFilter, value);
		}
	}
}
