using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class CreationException : DatabaseException
    {

        public CreationException() : base()
        {
        }

        public CreationException(string message) : base(message)
        {
        }

        public CreationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}