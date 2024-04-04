using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Events
{
	//public delegate void RemoveEventHandler(object sender, BulkActionEventArgs e);
	//public delegate void AddEventHandler(object sender, BulkActionEventArgs e);
	//public delegate void EditEventHandler(object sender, BulkActionEventArgs e);
	/// <summary>
	/// The base event handler for data events
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void DataEventHandler<T>(object sender, DataEventArgs<T> e) where T : Types.IDbEntry;

	/// <summary>
	/// The argument values for the event that occured
	/// </summary>
	/// <typeparam name="T">The type of the data being modified</typeparam>
	public abstract class DataEventArgs<T> : BaseArgs where T : Types.IDbEntry
	{
		/// <summary>
		/// The row of the data being modified
		/// </summary>
		protected DataGridViewRow Row { get; }

		/// <summary>
		/// The value of the data being modified
		/// </summary>
		public abstract T Value { get; protected set; }

		/// <summary>
		/// Create a new event arguments value
		/// </summary>
		/// <param name="value">The value being modified</param>
		/// <param name="type">The type of event occuring</param>
		public DataEventArgs(T value, EventType type = EventType.None)
		{
			Value = value;
			EventType = type;
		}

		public static DataEventArgs<T> Parse(T value)
		{
			Console.WriteLine(value.GetType());
			return null;
		}
	}

	/// <summary>
	/// Base class for all event args
	/// </summary>
	public abstract class BaseArgs
    {
		/// <summary>
		/// The type of even that occured
		/// </summary>
		public EventType EventType { get; protected set; }
	}

    //public class BulkActionEventArgs : BaseArgs
    //{

    //    public IList List { get; set; }

    //    public BulkActionEventArgs(IList list, EventType eventType = EventType.None)
    //    {
    //        List = list;
    //        EventType = eventType;
    //    }
    //}

    public enum EventType
    {
        None,
        Added,
        Deleted,
        Updated
    }
}
