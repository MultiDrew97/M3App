
namespace SPPBC.M3Tools.Types
{
    public class CustomersCollection : DBEntryCollection<Customer>
    {

        public override bool ApplyFilter(Customer customer, int index)
        {
            // TODO: Do I want to allow for nothing values?
            if (customer is null)
            {
                return false;
            }

            return customer.Name.Contains(Filter) || customer.Email.Contains(Filter) || customer.Phone.Contains(Filter);
        }
    }
}