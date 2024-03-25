using System;
using System.Collections;

namespace SPPBC.M3Tools.Events
{
    public delegate void RemoveEventHandler(object sender, BulkActionEventArgs e);
    public delegate void AddEventHandler(object sender, BulkActionEventArgs e);
    public delegate void EditEventHandler(object sender, BulkActionEventArgs e);

    public abstract class BaseArgs : EventArgs
    {
        public EventType EventType { get; set; }
    }

    public class BulkActionEventArgs : BaseArgs
    {

        public IList List { get; set; }

        public BulkActionEventArgs(IList list, EventType eventType = EventType.None)
        {
            List = list;
            EventType = eventType;
        }
    }

    public enum EventType
    {
        None,
        Added,
        Deleted,
        Updated
    }
}