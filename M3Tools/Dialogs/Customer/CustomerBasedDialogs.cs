using System.Windows.Forms;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// A component that houses all customer based dialogs forms
	/// </summary>
    public partial class CustomerBasedDialogs
    {
		/// <summary>
		/// Open a dialog box for adding a customer
		/// </summary>
		/// <returns></returns>
        public DialogResult AddCustomer()
        {
            return new Dialogs.AddCustomerDialog().ShowDialog();
        }

		/// <summary>
		/// Open a dialog box for editing a customer
		/// </summary>
		/// <param name="customer">The customer to edit</param>
		/// <returns></returns>
        public DialogResult EditCustomer(Types.Customer customer)
        {
            return new Dialogs.EditCustomerDialog(customer).ShowDialog();
        }
    }
}
