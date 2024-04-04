﻿using System.Collections.Generic;

namespace SPPBC.M3Tools.Data
{
    public class CustomersBindingSource : BindingSource<Types.Customer>
    {
		private Types.CustomerCollection _customers;

		public CustomersBindingSource() 
		{
			_customers = new Types.CustomerCollection();
			DataSource = _customers;
		}

		/// <summary>
		/// List of customers in the binding source
		/// </summary>
        public new IList<Types.Customer> List
        {
            get
            {
                return DataSource.Items;
            }
        }

		/// <summary>
		/// The data source for the binding source to bind from
		/// </summary>
		public new Types.CustomerCollection DataSource
		{
			get
			{
				return (Types.CustomerCollection)base.DataSource;
			}
			private set
			{
				base.DataSource = value;
			}
		}

		public override string Filter
		{ 
			get => base.Filter;
			set => base.Filter = value;
		}
	}
}
