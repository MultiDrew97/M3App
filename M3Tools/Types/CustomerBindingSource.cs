using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class CustomerBindingSource : BindingSource<Types.Customer>
    {
		private readonly Types.CustomerCollection _customers;

		/// <inheritdoc/>
		public CustomerBindingSource() : base()
		{
			_customers = new Types.CustomerCollection();
			DataSource = _customers;
		}

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		public new Types.CustomerCollection DataSource { get => (Types.CustomerCollection)base.DataSource; set => base.DataSource = value; }

		public override string Filter
		{
			get => _customers?.Filter;
			set => _customers.Filter = value;
		}

	}
}
