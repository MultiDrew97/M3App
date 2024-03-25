using System;
using Microsoft.VisualBasic;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
    public class Customer : Person
    {
        // Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
        private string __phone;

        [System.ComponentModel.Browsable(false)]
        [System.Text.Json.Serialization.JsonPropertyName("customerID")]
        public override int Id { get; set; }

        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string Phone
        {
            get
            {
                return __phone;
            }
            set
            {
                __phone = value.FormatPhone();
            }
        }

        [System.ComponentModel.Category("Contact")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public Address Address { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.Text.Json.Serialization.JsonPropertyName("joined")]
        public DateTime Joined { get; set; }
		// Get
		// If __joined.Year < 1950 OrElse IsNothing(__joined) Then
		// Return Nothing
		// End If

		// Return __joined
		// End Get
		// Set(value As Date)
		// If value.Year < 1950 Then
		// __joined = Nothing
		// End If
		// End Set
		// End Property

		public static Customer None { get; } = new Customer();

        public Customer() : this(-1)
        {
        }

        public Customer(int customerID, string firstName = "John", string lastName = "Doe", Address address = null, string email = "johndoe@domain.ext", string phoneNumber = "1234567890", string joined = null) : this(customerID, $"{firstName} {lastName}", address, phoneNumber, email, string.IsNullOrWhiteSpace(joined) ? default : DateTime.Parse(joined))
        {
        }

        private Customer(int id, string name, Address address, string phone, string email, DateTime @join) : base(id, name, email)
        {
            Phone = phone;
            Address = address ?? Address.None;
            Joined = join;
        }

        public override string ToString()
        {
            // Name (Email)
            // Street
            // City, ST ZipCode
            // Phone Number
            return $@"{Name} ({Email}){Constants.vbCrLf}
					{Address}{Constants.vbCrLf}
					{Phone}";
        }

        public string Display()
        {
            // ID) Name (Email)
            // Street
            // City, ST ZipCode
            // Phone Number
            return $"{Id}) {Name} (e: {Email} p: {Phone}){Constants.vbCrLf}{Constants.vbCrLf}{Address.Display()}{Constants.vbCrLf}";
        }
    }
}
