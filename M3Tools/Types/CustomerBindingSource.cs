using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class CustomerBindingSource : BindingSource<Types.Customer>
    {
		private readonly string CustomerFilter = "[Name] LIKE '%{0}%'";

		/// <summary>
		/// 
		/// </summary>
		public CustomerBindingSource() : base()
		{
			DataSource = new();
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public new Types.CustomerCollection DataSource
		{
			get => (Types.CustomerCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = string.IsNullOrEmpty(value) ? value : string.Format(CustomerFilter, value);
		}
	}
}
