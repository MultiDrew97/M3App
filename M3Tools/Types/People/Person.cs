namespace SPPBC.M3Tools.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Person : DbEntry
    {
        private MimeKit.MailboxAddress __email;

        /// <summary>
        /// The person's first name
        /// </summary>
        [System.ComponentModel.Category("Basics")]
        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The person's last name
        /// </summary>
        [System.ComponentModel.Category("Basics")]
        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The person's email address
        /// </summary>
        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email
        {
            get => string.IsNullOrWhiteSpace(__email.Address) ? null : __email.Address;
            set => __email = new MimeKit.MailboxAddress(Name, value ?? "");
        }

        /// <summary>
        /// The person's whole name
        /// </summary>
        // [ComponentModel.Browsable(False)]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
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

            try
            {
                LastName = string.Join(" ", parts[1..]);
            }
            catch
            {
                LastName = null;
            }
        }

        //      public static bool operator ==(Person ls, Person rs)
        //      {
        //          return ls.Id == rs.Id & ls.Name.Equals(rs.Name) & ls.Email.Equals(rs.Email);
        //      }

        //      public static bool operator !=(Person ls, Person rs)
        //      {
        //          return !(ls == rs);
        //      }

        //public override bool Equals(object obj)
        //{
        //	try
        //	{
        //		return (this.GetHashCode() == ((Person)obj).GetHashCode());
        //	}
        //	catch
        //	{
        //		return base.Equals(obj);
        //	}
        //}

        //public override int GetHashCode()
        //{
        //	return Utils.ValidID(this.Id) ? this.Id : base.GetHashCode();
        //}
    }
}
