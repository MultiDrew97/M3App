using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to Authorization issues
	/// </summary>
    public class AuthorizationException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
        public AuthorizationException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public AuthorizationException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public AuthorizationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
