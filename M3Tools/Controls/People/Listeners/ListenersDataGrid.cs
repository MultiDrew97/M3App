using System;
using System.Collections;
using System.ComponentModel;
using SPPBC.M3Tools.Events;
using SPPBC.M3Tools.Events.Listeners;

namespace SPPBC.M3Tools.Data
{

    public partial class ListenersDataGrid
    {
		/// <summary>
		/// An event fired when a listener is added
		/// </summary>
		public event ListenerEventHandler AddListener;

		/// <summary>
		/// An event fired when a listener is updated
		/// </summary>
        public event ListenerEventHandler UpdateListener;

		/// <summary>
		/// An event fired when a listener is removed
		/// </summary>
        public event ListenerEventHandler RemoveListener;

		/// <summary>
		/// 
		/// </summary>
        public delegate void RefreshDisplayEventHandler();

		/// <summary>
		/// The complete list of listeners being shown
		/// </summary>
        public IList Listeners
        {
            get
            {
                return base.Rows;
            }
        }

		/// <summary>
		/// The data source used for the control
		/// </summary>
        [Description("Data Source to use for data grid.")]
		public new object DataSource
		{
			get
			{
				if (DesignMode)
				{
					return typeof(ListenerBindingSource);
				}

				return (ListenerBindingSource)base.DataSource;
			}
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
        public ListenersDataGrid()
        {
            InitializeComponent();

			AddEntry += new DataEventHandler<Types.Listener>(ParseEvents);
			UpdateEntry += new DataEventHandler<Types.Listener>(ParseEvents);
			RemoveEntry += new DataEventHandler<Types.Listener>(ParseEvents);
		}

		private void ParseEvents(object sender, DataEventArgs<Types.Listener> e)
		{
			Console.WriteLine("Parsing DataGrid Event");
			Console.WriteLine("Sender: {0}\nEvent Type: {1}\nValue: {2}", sender, e.EventType, e.Value);
			switch (e.EventType)
			{
				case EventType.Added: { AddListener?.Invoke(sender, e); break; }
				case EventType.Removed: { RemoveListener?.Invoke(sender, e); break; }
				case EventType.Updated: { UpdateListener?.Invoke(sender, e); break; }
				default: { throw new ArgumentException($"'{e.EventType}' is not a valid EventType value"); }
			}
		}		
	}
}
