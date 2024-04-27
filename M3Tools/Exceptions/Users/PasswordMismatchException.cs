using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to password matching errors
	/// </summary>
    [Serializable]
    public class PasswordMismatchException : PasswordException
    {

		/// <summary>
		/// 
		/// </summary>
        public PasswordMismatchException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public PasswordMismatchException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public PasswordMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
