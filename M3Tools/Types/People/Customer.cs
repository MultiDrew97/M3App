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
		public static new Customer None => new();

		/// <summary>
		/// 
		/// </summary>
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
			get => __phone;
			set => __phone = value.FormatPhone();
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
		[System.Text.Json.Serialization.JsonPropertyName("joined")]
		public DateTime Joined { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Customer() : this(-1)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerID"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="address"></param>
		/// <param name="email"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="joined"></param>
		public Customer(int customerID, string firstName = "New", string lastName = "Customer", Address address = null, string phoneNumber = "1234567890", string email = "johndoe@domain.ext", string joined = null) : this(customerID, $"{firstName} {lastName}", address, phoneNumber, email, string.IsNullOrWhiteSpace(joined) ? default : DateTime.Parse(joined))
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
			// Id,Name,Email,Address,Phone,Joined
			return string.Join(Properties.Settings.Default.ObjectDelimiter, Id, Name, Email, Address.ToString(), Phone, Joined);
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
			return !(left is null ^ right is null) && left.FirstName == right.FirstName && left.LastName == right.LastName && left.Address == right.Address
			&& left.Email == right.Email && left.Phone == right.Phone && left.Joined == right.Joined;
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
