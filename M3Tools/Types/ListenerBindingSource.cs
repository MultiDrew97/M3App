using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class ListenerBindingSource : BindingSource<Types.Listener>
    {
		private readonly Types.ListenerCollection _listeners = new();

		/// <inheritdoc/>
		public ListenerBindingSource() : base()
		{
			_listeners = new Types.ListenerCollection();
			DataSource = _listeners;
		}

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		public new object DataSource { 
			get => DesignMode ? typeof(Types.ListenerCollection) : (Types.ListenerCollection)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => _listeners?.Filter;
			set => _listeners.Filter = value;
		}

	}
}
