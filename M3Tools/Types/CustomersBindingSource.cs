using System.Collections.Generic;

namespace SPPBC.M3Tools.Types
{
    public class CustomersBindingSource : System.Windows.Forms.BindingSource
    {

        private CustomersCollection _customers = new CustomersCollection();

        public new bool SupportsFiltering { get; private set; } = true;

        public new CustomersCollection DataSource
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        public new IList<Customer> List
        {
            get
            {
                return _customers.Items;
            }
        }

        // Shadows ReadOnly Property DataSource As CustomersCollection
        // Get
        // If DesignMode Then
        // Return New CustomersCollection From {
        // New Customer()
        // }
        // End If

        // Return _customers
        // End Get
        // End Property

        // Sub New()
        // 'MyBase.New(New CustomersCollection(), String.Empty)
        // MyBase.New()
        // DataSource = _customers
        // ResetBindings(False)
        // End Sub

        public new string Filter
        {
            get
            {
                return base.Filter;
            }
            set
            {
                // If Not String.IsNullOrEmpty(value) Then
                // value = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
                // End If

                base.Filter = value;
                _customers.Filter = value;
            }
        }
    }
}