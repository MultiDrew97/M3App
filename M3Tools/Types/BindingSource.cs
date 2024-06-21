using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom binding source to be used with the M3 Application
	/// </summary>
	/// <typeparam name="T">Data type for the data being used for binding</typeparam>
	public partial class BindingSource<T> //where T : Types.IDbEntry
	{
		/// <summary>
		/// The binding source supports filtering
		/// </summary>
		public readonly new bool SupportsFiltering = true;

		/// <summary>
		/// List of customers in the binding source
		/// </summary>
		[Browsable(false)]
		public new IList<T> List
		{
			get => ((Types.DbEntryCollection<T>)DataSource).Items;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		protected new Types.DbEntryCollection<T> DataSource
		{
			get => (Types.DbEntryCollection<T>)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public override string Filter
		{
			// TODO: Ensure filtering text follows this format $"([FirstName] like '%{value}%') OR ([LastName] like '%${value}%') OR ([Email] like '%{value}%')";
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
