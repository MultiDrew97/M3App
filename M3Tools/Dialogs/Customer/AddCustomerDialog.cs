using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;
using SPPBC.M3Tools.Types;

// TODO: Cleanup this dialog box
namespace SPPBC.M3Tools.Dialogs
{
    public partial class AddCustomerDialog
    {
        public event CustomerEventHandler CustomerAdded;
        private event EventHandler PageChangedEvent;

        private string CustomerName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        private string FirstName
        {
            get
            {
                return gi_FirstName.Text;
            }
        }

        private string LastName
        {
            get
            {
                return gi_LastName.Text;
            }
        }

        private Address Address
        {
            get
            {
                return af_Address.Address;
            }
        }

        private string Phone
        {
            get
            {
                return pn_PhoneNumber.Text;
            }
        }

        private string Email
        {
            get
            {
                return gi_EmailAddress.Text;
            }
        }

        public Customer Customer
        {
            get
            {
                return new Customer(-1, FirstName, LastName, Address, Email, Phone);
            }
        }

        private bool ValidName
        {
            get
            {
                return ValidFirstName & ValidLastName;
            }
        }

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
                if (string.IsNullOrWhiteSpace(Email) || !Regex.IsMatch(Email, My.Resources.Resources.EmailRegex2))
                {
                    ep_InputError.SetError(gi_EmailAddress, "No valid email address provided");
                    return false;
                }

                return true;
            }
        }

        private bool ValidCustomer
        {
            get
            {
                return ValidName && ValidEmail && af_Address.IsValidAddress && pn_PhoneNumber.ValidPhone;
            }
        }

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
                        var res = MessageBox.Show("Are you sure you want to cancel customer creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                        PageChangedEvent?.Invoke(this, e);
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
                            MessageBox.Show("There were errors in your customer submission. Please try again.", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        PageChangedEvent?.Invoke(this, e);
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