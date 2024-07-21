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
		public Listener(int listenerID, string fName = "New", string lName = "Listener", string email = "NewListener@domain.tst") : this(listenerID, $"{fName} {lName}", email)
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
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(Listener left, Listener right)
		{
			if ((left is null && right is not null) || (right is null && left is not null))
			{
				return false;
			}

			if (left.Name != right.Name)
			{
				return false;
			}

			return left.Email == right.Email;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(Listener left, Listener right)
		{
			return !(left == right);
		}
	}
}
