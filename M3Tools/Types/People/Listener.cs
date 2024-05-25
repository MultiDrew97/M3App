using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An email listener that recieves the email ministry emails
	/// </summary>
    public class Listener : Person
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[System.Text.Json.Serialization.JsonPropertyName("listenerID")]
		public override int Id
		{
			get => base.Id;
			set => base.Id = value;
		}

		/// <summary>
		/// An empty instance of the Listener class
		/// </summary>
		public static new Listener None => new();

		/// <summary>
		/// 
		/// </summary>
        public Listener() : this(-1)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="fName"></param>
		/// <param name="lName"></param>
		/// <param name="email"></param>
        public Listener(int listenerID, string fName = "Test", string lName = "Listener", string email = "TestListener@domain.tst") : this(listenerID, $"{fName} {lName}", email)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listenerID"></param>
		/// <param name="name"></param>
		/// <param name="email"></param>
        public Listener(int listenerID, string name, string email) : base(listenerID, name, email)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return $"{Id}) {Name} <{Email}>";
        }

		/// <summary>
		/// Parses a listener from an array of parameters
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
        public static Listener Parse(object[] arr)
        {
            return new Listener(Conversions.ToInteger(arr[0]), Conversions.ToString(arr[1]), Conversions.ToString(arr[2]));
        }

		/// <summary>
		/// Clones the current instance of a listener and returns it
		/// </summary>
		/// <returns>A copy of the current instance</returns>
        public Listener Clone()
        {
			// TODO: Verify this works
			return base.MemberwiseClone() as Listener;
            //return new Listener(Id, Name, Email);
        }
    }
}
