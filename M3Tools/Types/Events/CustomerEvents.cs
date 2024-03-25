
namespace SPPBC.M3Tools.Events.Customers
{
    public delegate void CustomerEventHandler(object sender, CustomerEventArgs e);
    // Public Delegate Sub EditCustomerEventHandler(sender As Object, e As CustomerEventArgs)

    public class CustomerEventArgs : BaseArgs
    {

        public Types.Customer Customer { get; set; }

        public CustomerEventArgs(Types.Customer customer, EventType eventType = default)
        {
            Customer = customer;
            EventType = eventType;
        }
    }
}