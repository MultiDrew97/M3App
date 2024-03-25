using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class CustomerBasedDialogs
    {
        public DialogResult AddCustomer()
        {
            return new Dialogs.AddCustomerDialog().ShowDialog();
        }

        public DialogResult EditCustomer(Types.Customer customer)
        {
            return new Dialogs.EditCustomerDialog() { Customer = customer }.ShowDialog();
        }
    }
}