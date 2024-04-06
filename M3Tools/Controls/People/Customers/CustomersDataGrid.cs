using System;
using System.Collections;
using System.ComponentModel;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Data
{

    // TODO: Remove old dgc for remove and edit if customs continue to work out. keep until proven
	/// <summary>
	/// Custom data grid to use for displaying customer information
	/// </summary>
    public partial class CustomerDataGrid : DataGrid<Types.Customer>
    {

		/// <summary>
		/// Event that occurs when a customer is added to the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler AddCustomer;

		/// <summary>
		/// Event that occurs when a customer is removed from the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler RemoveCustomer;

		/// <summary>
		/// Event that occurs when a customer is updated in the database
		/// </summary>
		public event Events.Customers.CustomerEventHandler UpdateCustomer;

		public override BindingSource<Customer> DataSource { get => bsCustomers; set => bsCustomers = (CustomerBindingSource)value; }

		[Browsable(false)]
        public IList Customers
        {
            get
            {
                return base.Rows;
            }
        }  

        [DefaultValue(false)]
        public bool AllowAdding
        {
            get
            {
                return AllowUserToAddRows;
            }
            set
            {
                AllowUserToAddRows = value;
            }
        }

		public CustomerDataGrid()
		{
			this.cms_Tools.RefreshView += Refresh;
			LoadColumns();

			AddEntry += ParseEvents;
			UpdateEntry += ParseEvents;
			RemoveEntry += ParseEvents;
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Customer> e)
		{
			Console.WriteLine("Parsing DataGrid Event");
			Console.WriteLine("Sender: {0}\nEvent Type: {1}\nValue: {2}", sender, e.EventType, e.Value);
			switch (e.EventType)
			{
				case EventType.Added: { AddCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break; }
				case EventType.Deleted: { UpdateCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break;  }
				case EventType.Updated: { RemoveCustomer?.Invoke(sender, (Events.Customers.CustomerEventArgs)e); break; }
				default: { throw new ArgumentException($"'{e.EventType}' is not a valid EventType value"); }
			}
		}

		private void LoadColumns()
		{
			Columns.Insert(1, this.dgc_CustomerID);
			Columns.Insert(2, this.dgc_Name);
			Columns.Insert(3, this.dgc_Address);
			Columns.Insert(4, this.dgc_Phone);
			Columns.Insert(5, this.dgc_Email);
			Columns.Insert(6, this.dgc_Join);
		}
	}
}
