using System.Collections;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{

	// TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
	public partial class CustomerDataGrid
	{
		/*private readonly System.Collections.Generic.Dictionary<string, Tuple<string, int>> columns = new() {
			{ "ID", new("CustomerID", 1) },
			{ "Name", new("Name", 2) },
			{ "Address", new("Address", 3) },
			{ "Phone", new("Phone", 4)},
			{ "Email", new("Email", 5) },
			{ "Join", new("Join", 6) }
		};*/
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
		public IList Customers
		{
			get
			{
				return base.Rows;
			}
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
