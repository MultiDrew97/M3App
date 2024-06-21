using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Binding source made for managing customer info
	/// </summary>
    public class ListenerBindingSource : BindingSource<Types.Listener>
    {
		private readonly string ListenerFilter = "[Name] LIKE '%{0}%'";
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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			get => base.Filter;
			set => base.Filter = string.IsNullOrEmpty(value) ? value : string.Format(ListenerFilter, value);
		}

	}
}
