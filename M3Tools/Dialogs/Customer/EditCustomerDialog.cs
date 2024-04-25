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
        // Private _newInfo As Types.Customer

        private event CustomerChangedEventHandler CustomerChanged;

        private delegate void CustomerChangedEventHandler();

		/// <summary>
		/// The customer being edited
		/// </summary>
        public Types.Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
                CustomerChanged?.Invoke();
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

		/// <summary>
		/// The customer's first name
		/// </summary>
        public string FirstName
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

		/// <summary>
		/// The customer's last name
		/// </summary>
        public string LastName
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

		/// <summary>
		/// The customer's phone number
		/// </summary>
        public string Phone
        {
            get
            {
                return PhoneNumberField1.Text;
            }
            set
            {
                PhoneNumberField1.Text = value;
            }
        }

		/// <summary>
		/// The email of the customer
		/// </summary>
        public string Email
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

		/// <summary>
		/// The address of the customer
		/// </summary>
        public Types.Address Address
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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public EditCustomerDialog()
        {
            InitializeComponent();
        }

        private void FinishDialog(object sender, EventArgs e)
        {
            if (!ValidChangesDetected())
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

        private void CustomerUpdated()
        {
            // _newInfo = Customer.Clone()
            FirstName = Customer.FirstName;
            LastName = Customer.LastName;
            Address = Customer.Address;
            Phone = Customer.Phone;
            Email = Customer.Email;
            Text = string.Format(Text, Customer.Name);
        }

        private bool ValidChangesDetected()
        {
            bool validFirstName = !string.IsNullOrEmpty(FirstName);
            if ((FirstName ?? "") != (Customer.FirstName ?? "") && validFirstName)
            {
                return true;
            }

            if ((LastName ?? "") != (Customer.LastName ?? "") && validFirstName)
            {
                return true;
            }

            if ((Email ?? "") != (Customer.Email ?? "") && (string.IsNullOrWhiteSpace(Email) || Regex.IsMatch(Email, My.Resources.Resources.EmailRegex2)))
            {
                return true;
            }

            if (Address != Customer.Address && af_Address.IsValidAddress)
            {
                return true;
            }

            return false;
        }

        // Private Sub CustomersLoaded(sender As Object, e As RunWorkerCompletedEventArgs)
        // If e.Cancelled Then
        // Dim answer = MessageBox.Show("Unable to retrieve customer. Would you Like to try again?", "Customer Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        // If answer = DialogResult.Yes Then
        // While bw_LoadCustomer.IsBusy
        // Console.WriteLine("LoadCustomers Background worker Not finished...")
        // Utils.Wait()
        // End While

        // bw_LoadCustomer.RunWorkerAsync()
        // End If
        // Return
        // End If

        // FirstName = _customer.FirstName
        // LastName = _customer.LastName
        // Phone = _customer.PhoneNumber
        // Email = _customer.Email
        // Address = _customer.Address
        // End Sub

        // Private Sub Reload()
        // bw_LoadCustomer.RunWorkerAsync()
        // End Sub

        private bool CheckChangedValues()
        {
            // TODO: Check to allow empty Nullable fields
            if (!FirstName.Equals(_customer.FirstName) | (!LastName.Equals(_customer.LastName) && IsValidName()))
            {
                return true;
            }

            if (IsValidAddress() && !Address.ToString().Equals(_customer.Address.ToString()))
            {
                return true;
            }

            if (!Email.Equals(_customer.Email) && IsValidEmail())
            {
                return true;
            }

            string phoneStr = string.Join("", Phone.Where((currentChar) => !Regex.IsMatch(Conversions.ToString(currentChar), @"[\s()-]")));
            string currentStr = string.Join("", _customer.Phone.Where((currentChar) => !Regex.IsMatch(Conversions.ToString(currentChar), @"[\s()-]")));

            if (!phoneStr.Equals(currentStr) && IsValidPhone())
            {
                return true;
            }

            return false;
        }

        private bool IsValidName()
        {
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
        }

        private bool IsValidEmail()
        {
            return Regex.IsMatch(Email, My.Resources.Resources.EmailRegex2);
        }

        private bool IsValidPhone()
        {
            return !string.IsNullOrEmpty(Phone) && Regex.IsMatch(Phone, @"\(\d{3}\)\s\d{3}-\d{4}");
        }

        private bool IsValidAddress()
        {
            return af_Address.IsValidAddress;
        }
    }
}
