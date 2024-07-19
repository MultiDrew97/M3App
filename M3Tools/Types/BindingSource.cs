using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Custom binding source to be used with the M3 Application
	/// </summary>
	/// <typeparam name="T">Data type for the data being used for binding</typeparam>
	public partial class BindingSource<T> where T : Types.IDbEntry
	{
		/// <summary>
		/// The binding source supports filtering
		/// </summary>
		public readonly new bool SupportsFiltering = true;

		///// <summary>
		///// List of customers in the binding source
		///// </summary>
		//[EditorBrowsable(EditorBrowsableState.Advanced)]
		//public new IList List
		//{
		//	get => base.List;
		//}

		/// <summary>
		/// The datasource being used for the binding source
		/// </summary>
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof(IListSource))]
		// MAYBE: Look into using the TypeDescriptionProviderAttribute and similar to make dev potentially easier
		protected new object DataSource
		{
			get => DesignMode ? typeof(Types.DbEntryCollection<T>) : (Types.DbEntryCollection<T>)base.DataSource;
			set => base.DataSource = value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listAccessors"></param>
		/// <returns></returns>
		public override PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			var properties = TypeDescriptor.GetProperties(typeof(T));
			var newProperties = new List<PropertyDescriptor>();

			foreach (PropertyDescriptor pd in properties)
			{
				if (pd.PropertyType.GetProperties().Length > 0)
				{
					newProperties.AddRange(CreateNestedProperties(pd));
				}
				newProperties.Add(pd);
			}

			return new PropertyDescriptorCollection(newProperties.ToArray());
		}

		private IEnumerable<PropertyDescriptor> CreateNestedProperties(PropertyDescriptor parent)
		{
			foreach (PropertyInfo pi in parent.PropertyType.GetProperties())
			{
				yield return new NestedPropertyDescriptor(parent, pi);
			}
		}
	}

	class NestedPropertyDescriptor : PropertyDescriptor
	{
		private readonly PropertyDescriptor _parent;
		private readonly PropertyInfo _info;

		public override bool IsReadOnly => true;

		public override Type ComponentType => _parent.ComponentType;

		public override Type PropertyType => _info.PropertyType;

		public NestedPropertyDescriptor(PropertyDescriptor parent, PropertyInfo propertyInfo) : base(parent.Name + "." + propertyInfo.Name, null)
		{
			_parent = parent;
			_info = propertyInfo;
		}

		public override bool CanResetValue(object component) => false;

		public override object GetValue(object component) => _info.GetValue(_parent.GetValue(component), null);

		public override void ResetValue(object component) { }

		public override void SetValue(object component, object value) { }

		public override bool ShouldSerializeValue(object component) => true;
	}
}
