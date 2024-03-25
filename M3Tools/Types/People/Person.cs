
namespace SPPBC.M3Tools.Types
{
    public abstract class Person : DbEntry
    {
        private MimeKit.MailboxAddress __email;

        [System.ComponentModel.Category("Basics")]
        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [System.ComponentModel.Category("Basics")]
        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [System.ComponentModel.Category("Contact")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email
        {
            get
            {
                return string.IsNullOrWhiteSpace(__email.Address) ? null : __email.Address;
            }
            set
            {
                __email = new MimeKit.MailboxAddress(Name, value ?? "");
            }
        }

        // <ComponentModel.Browsable(False)>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name
        {
            get
            {
                return string.Join(" ", FirstName, LastName).Trim();
            }
            set
            {
                ParseName(value);
            }
        }

        protected internal Person(int id = -1, string name = "John Doe", string email = "JohnDoe@domain.ext") : base(id)
        {
            ParseName(name);
            Email = (email ?? string.Empty).Trim();
        }

        private void ParseName(string name)
        {
            // TODO: Look into better parsing name data
            string[] parts = name.Trim().Split(' ');
            FirstName = parts[0];

            try
            {
                LastName = parts[1];
            }
            catch
            {
                LastName = null;
            }
        }

        public static bool operator ==(Person ls, Person rs)
        {
            return ls.Id == rs.Id & ls.Name.Equals(rs.Name) & ls.Email.Equals(rs.Email);
        }

        public static bool operator !=(Person ls, Person rs)
        {
            return !(ls == rs);
        }
    }
}