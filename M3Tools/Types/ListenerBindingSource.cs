using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
	public class ListenerBindingSource : BindingSource<Types.Listener>
	{
		private readonly string ListenerFilter = "[Name] LIKE '%{0}%'";

		/// <summary>
		/// 
		/// </summary>
		public ListenerBindingSource() : base()
		{
			DataSource = new Types.ListenerCollection();
		}

		/// <summary>
		/// 
		/// </summary>
		[Category("Data")]
		public new object DataSource
		{
			get => DesignMode ? typeof(Types.ListenerCollection) : (Types.ListenerCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = string.IsNullOrEmpty(value) ? value : string.Format(ListenerFilter, value);
		}

	}
}
