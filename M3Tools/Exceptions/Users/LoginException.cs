using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to login errors
	/// </summary>
    [Serializable]
    public class LoginException : UserException
    {

		/// <summary>
		/// 
		/// </summary>
        public LoginException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public LoginException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
