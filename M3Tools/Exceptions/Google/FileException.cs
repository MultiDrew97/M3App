using System;

namespace SPPBC.M3Tools.Exceptions
{
	/// <summary>
	/// An exception related to file operations
	/// </summary>
    [Serializable]
    public class FileException : Exception
    {
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public FileException() : base()
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
        public FileException(string message) : base(message)
        {
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public FileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
