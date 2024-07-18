using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	public partial class OrderBindingSource
	{
		private readonly string OrderFilter = "[CustomerName] LIKE '%{0}%' OR [ItemName] LIKE '%{0}%'";

		/// <summary>
		/// 
		/// </summary>
		public OrderBindingSource() : base()
		{
			DataSource = new Types.OrderCollection();
		}

		/// <summary>
		/// 
		/// </summary>
		[Category("Data")]
		public new object DataSource
		{
			get => DesignMode ? typeof(Types.OrderCollection) : (Types.OrderCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public new string Filter
		{
			get => base.Filter;
			set => base.Filter = string.IsNullOrEmpty(value) ? value : string.Format(OrderFilter, value);
		}
	}
}
