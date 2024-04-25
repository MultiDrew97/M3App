using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// The exception associated with a database connection issue
	/// </summary>
    [Serializable]
    public class ConnectionException : DatabaseException
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public ConnectionException() : base()
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
        public ConnectionException(string message) : base(message)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public ConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
