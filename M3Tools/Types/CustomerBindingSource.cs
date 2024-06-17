using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class CustomerBindingSource : BindingSource<Types.Customer>
    {
		private readonly Types.CustomerCollection _customers = new();

		/// <summary>
		/// 
		/// </summary>
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
		public new object DataSource {
			get => DesignMode ? typeof(Types.CustomerCollection) : (Types.CustomerCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => _customers?.Filter;
			set => _customers.Filter = value;
		}

	}
}
