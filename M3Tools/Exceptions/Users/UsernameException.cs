using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to username operations
	/// </summary>
	[Serializable]
	public class UsernameException : UserException
	{

		/// <summary>
		/// 
		/// </summary>
		public UsernameException() : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UsernameException(string message) : base(message)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public UsernameException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
