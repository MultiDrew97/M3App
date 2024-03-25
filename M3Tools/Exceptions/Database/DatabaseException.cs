using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class DatabaseException : Exception
    {

        public DatabaseException() : base()
        {
        }

        public DatabaseException(string message) : base(message)
        {
        }

        public DatabaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}