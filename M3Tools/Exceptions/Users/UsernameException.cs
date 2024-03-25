using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class UsernameException : UserException
    {

        public UsernameException() : base()
        {
        }

        public UsernameException(string message) : base(message)
        {
        }

        public UsernameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}