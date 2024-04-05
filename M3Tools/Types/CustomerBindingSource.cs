using System.Collections.Generic;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class CustomerBindingSource : BindingSource<Types.Customer>
    {
		private readonly Types.CustomerCollection _customers;

		/// <inheritdoc/>
		public CustomerBindingSource() 
		{
			_customers = new Types.CustomerCollection();
			DataSource = _customers;
		}

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		public override Types.DBEntryCollection<Types.Customer> DataSource
		{
			get
			{
				return _customers;
			}
			protected set
			{
				_customers.Clear();
				_customers.AddRange(value);
			}
		}

		/// <inheritdoc/>
		public override string Filter
		{ 
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
