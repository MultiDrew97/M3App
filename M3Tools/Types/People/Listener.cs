using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools.Types
{
    public class Listener : Person
    {

		[System.Text.Json.Serialization.JsonPropertyName("listenerID")]
		public override int Id => base.Id;

		public static new Listener None => new();

        public Listener() : this(-1)
        {
        }

        public Listener(int listenerID, string fName = "Test", string lName = "Listener", string email = "TestListener@domain.tst") : this(listenerID, $"{fName} {lName}", email)
        {
        }

        public Listener(int listenerID, string name, string email) : base(listenerID, name, email)
        {
        }

        public override string ToString()
        {
            return $"{Id}) {Name} <{Email}>";
        }

        public static Listener Parse(object[] arr)
        {
            return new Listener(Conversions.ToInteger(arr[0]), Conversions.ToString(arr[1]), Conversions.ToString(arr[2]));
        }

        public Listener Clone()
        {
            return new Listener(Id, Name, Email);
        }
    }
}
