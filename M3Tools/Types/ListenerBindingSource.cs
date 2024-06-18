using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class ListenerBindingSource : BindingSource<Types.Listener>
    {
		/// <inheritdoc/>
		public ListenerBindingSource() : base()
		{
			DataSource = new();
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Browsable(false)]
		public new Types.ListenerCollection DataSource
        {
            get => (Types.ListenerCollection)base.DataSource;
			set => base.DataSource = value;
        }

	}
}
