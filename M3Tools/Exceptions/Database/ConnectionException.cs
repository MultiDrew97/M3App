using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class ConnectionException : DatabaseException
    {

        public ConnectionException() : base()
        {
        }

        public ConnectionException(string message) : base(message)
        {
        }

        public ConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}