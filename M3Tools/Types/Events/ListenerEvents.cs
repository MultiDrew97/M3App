
namespace SPPBC.M3Tools.Events.Listeners
{
    public delegate void ListenerEventHandler(object sender, ListenerEventArgs e);

    public class ListenerEventArgs : BaseArgs
    {

        public Types.Listener Listener { get; set; }

        public ListenerEventArgs(Types.Listener listener, EventType eventType = default)
        {
            Listener = listener;
            EventType = eventType;
        }
    }
}