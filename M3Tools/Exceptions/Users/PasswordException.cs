using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to password errors
	/// </summary>
    [Serializable]
    public class PasswordException : UserException
    {

		/// <summary>
		/// 
		/// </summary>
        public PasswordException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public PasswordException(string message) : base(message)
        {
        }

        /// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public PasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
