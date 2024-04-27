using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to a users role
	/// </summary>
    [Serializable]
    public class RoleException : UserException
    {

		/// <summary>
		/// 
		/// </summary>
        public RoleException() : base()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
        public RoleException(string message) : base(message)
        {
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public RoleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
