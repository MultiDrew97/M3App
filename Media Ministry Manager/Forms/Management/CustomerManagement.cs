using System;
using System.Windows.Forms;

using SPPBC.M3Tools.Events.Customers;

namespace M3App
{

	/// <summary>
	/// Form for managing  customers
	/// </summary>
	public partial class CustomerManagement
	{
		//private readonly CustomerCollection _original;

		/// <summary>
		/// 
		/// </summary>
		public CustomerManagement() : base()
		{
			InitializeComponent();

			cdg_Customers.Reload += new EventHandler(Reload);
			cdg_Customers.AddCustomer += new CustomerEventHandler(Add);
			cdg_Customers.UpdateCustomer += new CustomerEventHandler(Update);
			cdg_Customers.RemoveCustomer += new CustomerEventHandler(Remove);

			cdg_Customers.Reload += (sender, e) => _original = dbCustomers.GetCustomers();

			_original = dbCustomers.GetCustomers();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			cdg_Customers.Customers = SPPBC.M3Tools.Types.CustomerCollection.Cast(_original.Items);
			ts_Tools.Count = string.Format(Properties.Resources.COUNT_TEMPLATE, cdg_Customers.Customers.Count);
			UseWaitCursor = false;
		}

		/// <summary>
		/// Add a new customer to the database from the tool strip
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Add(object sender, EventArgs e)
		{
			using SPPBC.M3Tools.Dialogs.AddCustomerDialog @add = new();

			if (add.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			_ = dbCustomers.AddCustomer(add.Customer);
			_ = MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Customer> e)
		{
			using SPPBC.M3Tools.Dialogs.EditCustomerDialog @edit = new(e.Value);

			if (edit.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			_ = dbCustomers.UpdateCustomer(edit.Customer);
			_ = MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Customer> e)
		{
			_ = dbCustomers.RemoveCustomer(e.Value.Id);
			_ = MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			_original.Filter = filter;
			cdg_Customers.Customers = SPPBC.M3Tools.Types.CustomerCollection.Cast(_original.Items);
		}
	}
}
