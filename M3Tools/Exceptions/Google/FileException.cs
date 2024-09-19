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

	[Serializable]
	public class FileExistsException : FileException
	{
		public FileExistsException() : base() { }

		public FileExistsException(string message) : base(message) { }

		public FileExistsException(string message, Exception innerException) : base(message, innerException) { }
	}

	[Serializable]
	public class FileNotFoundException : FileException
	{
		public FileNotFoundException() : base() { }

		public FileNotFoundException(string message) : base(message) { }

		public FileNotFoundException(string message, Exception innerException) : base(message, innerException) { }
	}
}
