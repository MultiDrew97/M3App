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
		[Browsable(false)]
        public Types.ListenerCollection Listeners
        {
			get => Types.ListenerCollection.Cast(base.Rows);
        }

		/// <summary>
		/// 
		/// </summary>
		public new object DataSource
		{
			get => DesignMode ? typeof(ListenerBindingSource) : (ListenerBindingSource)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public Types.ListenerCollection SelectedListeners
		{
			get => Types.ListenerCollection.Cast(base.SelectedRows);
		}

		/// <summary>
		/// 
		/// </summary>
		public ListenersDataGrid() : base()
        {
            InitializeComponent();

			AddEntry += (sender, e) => AddListener?.Invoke(sender, new(e.Value, e.EventType));
			UpdateEntry += (sender, e) => UpdateListener?.Invoke(sender, new(e.Value, e.EventType));
			RemoveEntry += (sender, e) => RemoveListener?.Invoke(sender, new(e.Value, e.EventType));
		}	
	}
}
