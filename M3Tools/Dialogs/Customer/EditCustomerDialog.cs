using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools.Dialogs
{
	public partial class EditCustomerDialog
	{
		private Types.Customer _customer;

		protected event EventHandler CustomerChanged;


		/// <summary>
		/// The customer being edited
		/// </summary>
		public Types.Customer Customer
		{
			get
			{
				return _customer;
			}
			private set
			{
				_customer = value;
				CustomerChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		/// <summary>
		/// The new info for the customer
		/// </summary>
		public Types.Customer NewInfo
		{
			get
			{
				return new Types.Customer(Customer.Id, FirstName, LastName, Address, Email, Phone);
			}
		}

		private string FirstName
		{
			get
			{
				return gi_FirstName.Text;
			}
			set
			{
				gi_FirstName.Text = value;
			}
		}

		private string LastName
		{
			get
			{
				return gi_LastName.Text;
			}
			set
			{
				gi_LastName.Text = value;
			}
		}

		private string Phone
		{
			get
			{
				return pf_Phone.PhoneNumber;
			}
			set
			{
				pf_Phone.PhoneNumber = value;
			}
		}

		private string Email
		{
			get
			{
				return gi_Email.Text;
			}
			set
			{
				gi_Email.Text = value;
			}
		}

		private Types.Address Address
		{
			get
			{
				return af_Address.Address;
			}
			set
			{
				af_Address.Address = value;
			}
		}

		public EditCustomerDialog(Types.Customer customer) : this()
		{
			this.Customer = (Types.Customer)customer.Clone();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        protected EditCustomerDialog()
        {
            InitializeComponent();
			CustomerChanged += new EventHandler(CustomerUpdated);
		}

        private void FinishDialog(object sender, EventArgs e)
        {
            if (Customer == NewInfo)
            {
                MessageBox.Show("There were errors in your edits. Please review And try again.", "Editting Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelDialog(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CustomerUpdated(object sender, EventArgs e)
        {
            FirstName = Customer.FirstName;
            LastName = Customer.LastName;
            Address = Customer.Address;
            Phone = Customer.Phone;
            Email = Customer.Email;
            Text = string.Format(Text, Customer.Name);
        }
    }
}
