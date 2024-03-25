using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class FileException : Exception
    {

        public FileException() : base()
        {
        }

        public FileException(string message) : base(message)
        {
        }

        public FileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}