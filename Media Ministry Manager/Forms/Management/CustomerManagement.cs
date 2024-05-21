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

			ts_Tools.ToggleButton(new[] { SPPBC.M3Tools.ToolButtons.EMAIL, SPPBC.M3Tools.ToolButtons.IMPORT });
			mms_Main.ToggleViewItem(SPPBC.M3Tools.MenuItemsCategories.CUSTOMERS);

			mms_Main.AddCustomer += new CustomerEventHandler(AddCustomer);

			cdg_Customers.Reload += new EventHandler(Reload);
			cdg_Customers.AddCustomer += new CustomerEventHandler(AddCustomer);
			cdg_Customers.UpdateCustomer += new CustomerEventHandler(UpdateCustomer);
			cdg_Customers.RemoveCustomer += new CustomerEventHandler(RemoveCustomer);

			ts_Tools.FilterChanged += new EventHandler<string>(FilterChanged);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void Reload(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			bsCustomers.Clear();
			foreach (var customer in dbCustomers.GetCustomers())
				bsCustomers.Add(customer);
			ts_Tools.Count = string.Format(My.Resources.Resources.CountTemplate, cdg_Customers.Customers.Count);
			// FIXME: Determine how to no longer need this like before to have the DataGridView actually show the new data
			bsCustomers.ResetBindings(false);
			UseWaitCursor = false;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void DisplayClosing(object sender, CancelEventArgs e)
		{
			// TODO: Find easier way
			Console.WriteLine(sender);
			if (sender is SPPBC.M3Tools.MainMenuStrip)
			{
				return;
			}

			My.MyProject.Forms.MainForm.Show();
		}

		private void UpdateCustomer(object sender, CustomerEventArgs e)
		{
			UseWaitCursor = true;

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

		private void AddCustomer(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			using var @add = new SPPBC.M3Tools.Dialogs.AddCustomerDialog();

			if (add.ShowDialog() != DialogResult.OK)
			{
				UseWaitCursor = false;
				return;
			}

			/*dbCustomers.AddCustomer(add.Customer);*/
			MessageBox.Show($"Successfully created customer", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		private void RemoveCustomer(object sender, CustomerEventArgs e)
		{
			UseWaitCursor = true;
			dbCustomers.RemoveCustomer(e.Value.Id);
			MessageBox.Show($"Successfully removed customer", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Reload(sender, e);
		}

		private void FilterChanged(object sender, string filter)
		{
			bsCustomers.Filter = filter;
		}
	}
}
