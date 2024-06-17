using System.Collections;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
	public partial class CustomerDataGrid
	{
		/// <summary>
		/// Event that occurs when a customer is being added to the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler AddCustomer;

		/// <summary>
		/// Event that occurs when a customer is being removed from the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler RemoveCustomer;

		/// <summary>
		/// Event that occurs when a customer is being updated in the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler UpdateCustomer;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public new object DataSource
		{
			get => DesignMode ? typeof(CustomerBindingSource) : (CustomerBindingSource)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// The list of customers currently in the data grid
		/// </summary>
		[Browsable(false)]
		public Types.CustomerCollection Customers
		{
			get => Types.CustomerCollection.Cast(base.Rows);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.CustomerCollection SelectedRows
		{
			get => Types.CustomerCollection.Cast(base.SelectedRows);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public CustomerDataGrid() : base()
		{
			InitializeComponent();

			AddEntry += (sender, e) => AddCustomer?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateCustomer?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveCustomer?.Invoke(sender, new(e.Value, e.EventType));
		}
	}

}
