using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;
using SPPBC.M3Tools.Types;

// TODO: Cleanup this dialog box
namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// The dialog responsible to retrieving new customer info
	/// </summary>
	public partial class AddCustomerDialog
	{
		/// <summary>
		/// The event that occurs when a user is created
		/// </summary>
		public event CustomerEventHandler CustomerAdded;

		private string FirstName => gi_FirstName.Text;

		private string LastName => gi_LastName.Text;

		private Address Address => af_Address.Address;

		private string Phone => pn_PhoneNumber.Text;

		private string Email => gi_EmailAddress.Text;

		/// <summary>
		/// The customer being created
		/// </summary>
		public Customer Customer => new(-1, FirstName, LastName, Address, Phone, Email);

		private bool ValidName => ValidFirstName & ValidLastName;

		private bool ValidFirstName
		{
			get
			{
				if (string.IsNullOrWhiteSpace(FirstName))
				{
					ep_InputError.SetError(gi_FirstName, "A first name is required");
					return false;
				}

				return true;
			}
		}

		private bool ValidLastName
		{
			get
			{
				if (string.IsNullOrWhiteSpace(LastName))
				{
					ep_InputError.SetError(gi_LastName, "A last name is required");
					return false;
				}

				return true;
			}
		}

		private bool ValidEmail
		{
			get
			{
				if (string.IsNullOrWhiteSpace(Email) || !Regex.IsMatch(Email, Properties.Resources.EmailRegex2))
				{
					ep_InputError.SetError(gi_EmailAddress, "No valid email address provided");
					return false;
				}

				return true;
			}
		}

		private bool ValidCustomer => ValidName && ValidEmail && af_Address.IsValidAddress && pn_PhoneNumber.ValidPhone;

		/// <summary>
		/// 
		/// </summary>
		public AddCustomerDialog()
		{
			InitializeComponent();
		}

		private void PreviousStep(object sender, EventArgs e)
		{
			switch (tc_Creation.SelectedIndex)
			{
				case var @case when @case == tp_Basics.TabIndex:
					{
						DialogResult res = MessageBox.Show("Are you sure you want to cancel customer creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (!(res == DialogResult.Yes))
						{
							return;
						}

						DialogResult = DialogResult.Cancel;
						Close();
						break;
					}

				default:
					{
						tc_Creation.SelectedIndex -= 1;
						break;
					}
			}
		}

		private void NextStep(object sender, EventArgs e)
		{
			switch (tc_Creation.SelectedIndex)
			{
				case var @case when @case == tp_Summary.TabIndex:
					{
						if (!ValidCustomer)
						{
							_ = MessageBox.Show("There were errors in your customer submission. Please try again.", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						CustomerAdded?.Invoke(this, new CustomerEventArgs(Customer, M3Tools.Events.EventType.Added));

						DialogResult = DialogResult.OK;
						Close();
						break;
					}

				default:
					{
						tc_Creation.SelectedIndex += 1;
						break;
					}
			}
		}

		private void PageChanged(object sender, EventArgs e)
		{
			btn_Cancel.Text = tc_Creation.SelectedIndex <= tp_Basics.TabIndex ? "Cancel" : "Back";
			btn_Create.Text = tc_Creation.SelectedIndex >= tp_Summary.TabIndex ? "Create" : "Next";
			sc_Summary.Display = tc_Creation.SelectedIndex == tp_Summary.TabIndex ? Customer : null;
		}
	}
}
