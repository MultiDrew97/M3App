using System;

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
			ListChanged += (sender, e) =>
			{
				foreach (Types.Customer item in List ?? [])
				{
					Console.WriteLine(item);
				}
			};

			DataSource = new Types.CustomerCollection();
		}

		/// <summary>
		/// 
		/// </summary>
		public new System.Collections.Generic.IList<Types.Customer> List => (DataSource as Types.CustomerCollection)?.Items;

		///// <summary>
		///// 
		///// </summary>
		//[Browsable(false)]
		//public new object DataSource
		//{
		//	get => DesignMode ? typeof(Types.CustomerCollection) : base.DataSource;
		//	set => base.DataSource = value;
		//}

		/// <inheritdoc />
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = value;//string.IsNullOrEmpty(value) ? value : string.Format(CustomerFilter, value);
		}
	}
}
