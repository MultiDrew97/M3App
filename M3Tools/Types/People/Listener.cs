﻿namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// An email listener that receives the email ministry emails
	/// </summary>
	[Newtonsoft.Json.JsonObject]
	public class Listener : Person
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		[Newtonsoft.Json.JsonProperty("listenerID")]
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
		[Newtonsoft.Json.JsonConstructor]
		public Listener(int listenerID, string fName = "New", string lName = "Listener", string email = default) : this(listenerID, $"{fName} {lName}", email)
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
		public override string ToString() => $"{Id}) {Name} <{Email}>";

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(Listener left, Listener right) => !(left is null ^ right is null) && left.Id == right.Id && left.Name == right.Name && left.Email == right.Email;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(Listener left, Listener right) => !(left == right);

		/// <inheritdoc/>
		public override bool Equals(object obj) => this == (obj as Listener);

		/// <inheritdoc/>
		public override int GetHashCode() => base.GetHashCode();
	}
}
