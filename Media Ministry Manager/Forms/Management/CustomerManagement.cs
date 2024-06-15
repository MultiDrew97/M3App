using System;
using System.ComponentModel;
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
		/// <inheritdoc/>
		/// </summary>
		public CustomerManagement() : base()
		{
			InitializeComponent();

			// TODO: Figure out if I can place button toggles in the base class and automate the hiding
			ts_Tools.ToggleButton(new[] { SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT });
			mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.CUSTOMERS);

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
			// TODO: Figure out if wait cursor management can be automated in the base class as well
			UseWaitCursor = true;
			bsCustomers.Clear();
			foreach (var customer in dbCustomers.GetCustomers())
				bsCustomers.Add(customer);
			// FIXME: Determine how to no longer need this like before to have the DataGridView actually show the new data
			bsCustomers.ResetBindings(false);
			ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, cdg_Customers.Customers.Count);
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
