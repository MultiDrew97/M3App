using System;
using Microsoft.VisualBasic;
using SPPBC.M3Tools.Types.Extensions;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Class containing customer data
	/// </summary>
    public class Customer : Person
    {
        // Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
        private string __phone;

		/// <summary>
		/// An empty instance of a customer
		/// </summary>
		public new static Customer None => new();

		/// <inheritdoc />
		[System.Text.Json.Serialization.JsonPropertyName("customerID")]
		public override int Id
		{
			get => base.Id;
			set => base.Id = value;
		}

		/// <summary>
		/// The customers phone number
		/// </summary>
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

		/// <summary>
		/// The shipping address of the customer
		/// </summary>
        [System.ComponentModel.Category("Contact")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public Address Address { get; set; }

		/// <summary>
		/// The date the user was added to the database
		/// </summary>
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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public Customer() : this(-1)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="address"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="joined"></param>
        public Customer(int customerID, string firstName = "John", string lastName = "Doe", Address address = null, string email = "johndoe@domain.ext", string phoneNumber = "1234567890", string joined = null) : this(customerID, $"{firstName} {lastName}", address, phoneNumber, email, string.IsNullOrWhiteSpace(joined) ? default : DateTime.Parse(joined))
        {
        }

        private Customer(int customerID, string name, Address address, string phone, string email, DateTime @join) : base(customerID, name, email)
        {
            Phone = phone;
            Address = address ?? Address.None;
            Joined = join;
        }

		/// <summary>
		/// Returns the customer in a string format
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
			// Name (Email)
			// Street
			// City, ST ZipCode
			// Phone Number
			return string.Join(My.Settings.Default.ObjectDelimiter, Id, Name, Email, Address.ToString(), Phone, Joined);
        }

		/// <summary>
		/// Returns the info for the custoemr in a human readable format
		/// </summary>
		/// <returns></returns>
        public string Display()
        {
            // ID) Name (Email)
            // Street
            // City, ST ZipCode
            // Phone Number
            return $"{Id}) {Name} (e: {Email} p: {Phone}){Constants.vbCrLf}{Constants.vbCrLf}{Address.Display()}{Constants.vbCrLf}";
        }

		/// <summary>
		/// Determine if a customer object is equal to another
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(Customer left, Customer right)
		{
			if ((left is null && right is not null) || (right is null && left is not null)) return false;
			if (left.FirstName != right.FirstName) return false;
			if (left.LastName != right.LastName) return false;
			if (left.Address != right.Address) return false;
			if (left.Email != right.Email) return false;
			if (left.Phone != right.Phone) return false;
			if (left.Joined != right.Joined) return false;

			return true;
		}

		/// <summary>
		/// Determine if a customer object is not equal to another
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(Customer left, Customer right)
		{
			return !(left == right);
		}
    }
}
