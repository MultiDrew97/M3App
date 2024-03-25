
namespace SPPBC.M3Tools.Events.Inventory
{
    public delegate void InventoryEventHandler(object sender, InventoryEventArgs e);

    public class InventoryEventArgs : BaseArgs
    {

        public Types.Product Product { get; set; }

        public InventoryEventArgs(Types.Product product, EventType eventType = default)
        {
            Product = product;
            EventType = eventType;
        }
    }
}