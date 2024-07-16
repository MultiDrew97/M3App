using System;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An address used for people
	/// </summary>
    public class Address
    {

		/// <summary>
		/// 
		/// </summary>
		[System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("street")]
        public string Street { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string City { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; }


		/// <summary>
		/// 
		/// </summary>
        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }

		/// <summary>
		/// Returns an empty address object
		/// </summary>
        public static Address None
        {
            get
            {
                return new Address();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <param name="state"></param>
		/// <param name="zipCode"></param>
		[System.Text.Json.Serialization.JsonConstructor]
        public Address(string street = null, string city = null, string state = null, string zipCode = null)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }


		/// <summary>
		/// Parses the information for an address from an address string
		/// </summary>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <param name="state"></param>
		/// <param name="zipCode"></param>
		/// <returns>The parsed out address object based on the string</returns>
		/// <exception cref="ArgumentException"></exception>
		public static Address Parse(string street, string city, string state, string zipCode)
        {
            if (!(!string.IsNullOrEmpty(street) || !string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(state) || !string.IsNullOrEmpty(zipCode)))
            {
                return null;
            }

            return Parse(string.Join(My.Settings.Default.ObjectDelimiter, new[] { street, city, state, zipCode }));
        }

        private static Address Parse(string addrStr)
        {
            string[] addrParts = addrStr.Split(char.Parse(My.Settings.Default.ObjectDelimiter));

            if (addrParts.Count() < 4)
            {
                throw new ArgumentException($"Unable to parse an address from '{addrStr}'");
            }

            return new Address(addrParts[0], addrParts[1], addrParts[2], addrParts[3]);
        }

		/// <summary>
		/// Gives the address in a string
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return string.Join(My.Settings.Default.ObjectDelimiter, Street, City, State, ZipCode);
        }

		/// <summary>
		/// Returns the address with formatting
		/// </summary>
		/// <returns></returns>
        public string Display()
        {
            // If there was not an address supplied, it doesn't apply the formating
            return string.IsNullOrEmpty(Street) | string.IsNullOrEmpty(City) | string.IsNullOrEmpty(State) | string.IsNullOrEmpty(ZipCode) ? "" : $"{string.Join(Constants.vbCrLf, Street.Split(',').Where((currentString) => !string.IsNullOrWhiteSpace(currentString)))}{Constants.vbCrLf}{City}, {State} {ZipCode}";
        }

		/// <summary>
		/// Determines if an address is the same
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return this == obj as Address;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// Determines if 2 addresses are the same
		/// </summary>
		/// <param name="left">The left hand side address</param>
		/// <param name="right">The right hand side address</param>
		/// <returns>True if the addresses are the same, otherwise False</returns>
		public static bool operator ==(Address left, Address right)
        {
            if (left is null & right is not null ||
				left is not null & right is null ||
				left.Street != right.Street ||
				left.City != right.City ||
				left.State != right.State ||
				left.ZipCode != right.ZipCode)
            {
                return false;
            }

            return true;
        }

		/// <summary>
		/// Determines if 2 address are not the same
		/// </summary>
		/// <param name="left">The left hand side address</param>
		/// <param name="right">The right hand side address</param>
		/// <returns>True if the addresses are different, otherwise False</returns>
        public static bool operator !=(Address left, Address right)
        {
            return !(left == right);
        }
    }
}
