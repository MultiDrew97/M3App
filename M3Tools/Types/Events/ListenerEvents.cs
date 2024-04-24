
namespace SPPBC.M3Tools.Events.Listeners
{
    public delegate void ListenerEventHandler(object sender, ListenerEventArgs e);

    public class ListenerEventArgs : DataEventArgs<Types.Listener>
    {

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public override Types.Listener Value { get; protected set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="listener"></param>
		/// <param name="eventType"></param>
        public ListenerEventArgs(Types.Listener listener, EventType eventType = default) : base(listener, eventType)
        {
        }
    }
}
