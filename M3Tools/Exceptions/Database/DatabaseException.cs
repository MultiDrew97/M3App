using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception that occurs when a database related error occurs
	/// </summary>
    [Serializable]
    public class DatabaseException : Exception
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public DatabaseException() : base()
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
        public DatabaseException(string message) : base(message)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public DatabaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
