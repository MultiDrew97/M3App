using System.Linq;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class Person : DbEntry
	{
		private readonly MimeKit.MailboxAddress __email;

		/// <summary>
		/// The person's first name
		/// </summary>
		[System.ComponentModel.Category("Basics")]
		[Newtonsoft.Json.JsonProperty("firstName")]
		public string FirstName { get; set; }

		/// <summary>
		/// The person's last name
		/// </summary>
		[System.ComponentModel.Category("Basics")]
		[Newtonsoft.Json.JsonProperty("lastName")]
		public string LastName { get; set; }

		/// <summary>
		/// The person's email address
		/// </summary>
		[System.ComponentModel.Category("Contact")]
		[Newtonsoft.Json.JsonProperty("email")]
		public string Email
		{
			get;// => string.IsNullOrWhiteSpace(__email.Address) ? null : __email.Address;
			set;// => __email = new MimeKit.MailboxAddress(Name, value);
		}

		/// <summary>
		/// The person's whole name
		/// </summary>
		// [ComponentModel.Browsable(False)]
		[Newtonsoft.Json.JsonProperty("name")]
		public string Name
		{
			get => string.Join(" ", FirstName, LastName).Trim();
			set => ParseName(value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="email"></param>
		[Newtonsoft.Json.JsonConstructor]
		protected Person(int id = -1, string name = "New Person", string email = null) : base(id)
		{
			ParseName(name);
			Email = (email ?? string.Empty).Trim();
		}

		private void ParseName(string name)
		{
			// TODO: Look into better parsing name data
			string[] parts = (name ?? string.Empty).Trim().Split(' ');
			FirstName = parts[0];

			// MAYBE: Convert to netcore instead of .NET Framework to use this
			//			LastName = string.Join(" ", parts[1..]);
			//LastName = string.Join(" ", parts[1..]);
			LastName = parts.Length > 1 ? string.Join(" ", parts.Skip(1)) : null;
		}
	}
}
