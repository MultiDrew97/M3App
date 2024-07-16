using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CustomerManagement
	{
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
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			bsCustomers.DataSource = dbCustomers.GetCustomers();
			bsCustomers.ResetBindings(false);
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
			using var @add = new SPPBC.M3Tools.Dialogs.AddCustomerDialog();

			if (add.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			dbCustomers.AddCustomer(add.Customer);
			MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Update(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Customer> e)
		{
			using var @edit = new SPPBC.M3Tools.Dialogs.EditCustomerDialog(e.Value);

			if (edit.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}


			dbCustomers.UpdateCustomer(edit.Customer);
			MessageBox.Show($"Successfully updated customer", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Remove(object sender, SPPBC.M3Tools.Events.DataEventArgs<SPPBC.M3Tools.Types.Customer> e)
		{
			dbCustomers.RemoveCustomer(e.Value.Id);
			MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="filter"></param>
		protected override void FilterChanged(object sender, string filter)
		{
			bsCustomers.Filter = filter;
		}
	}
}
